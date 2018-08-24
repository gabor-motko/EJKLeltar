using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EJKLeltar
{
	public partial class ChangeQuantityForm : Form
	{
		public enum OpenMode { Borrow, Return, Add }
		public OpenMode Mode;
		public XmlElement Element;

		private int _count;
		private int _out;
		private int _in;

		public ChangeQuantityForm()
		{
			InitializeComponent();
		}

		public DialogResult ShowDialog(XmlElement e, OpenMode mode)
		{
			changeNumber.Value = 0;
			Mode = mode;
			Element = e;
			titleText.Text = e["Title"].InnerText;
			_count = int.Parse(e["Count"].InnerText, System.Globalization.NumberStyles.Integer, System.Globalization.NumberFormatInfo.InvariantInfo);
			_out = int.Parse(e["Out"].InnerText, System.Globalization.NumberStyles.Integer, System.Globalization.NumberFormatInfo.InvariantInfo);
			_in = _count - _out;
			switch (mode)
			{
				case OpenMode.Borrow:
					Text = "Kikölcsönzés";
					changeNumber.Maximum = _in;
					changeNumber.Minimum = 0;
					availableLabel.Text = $"{_in} darab raktáron";
					break;
				case OpenMode.Return:
					Text = "Visszavétel";
					changeNumber.Maximum = _out;
					changeNumber.Minimum = 0;
					availableLabel.Text = $"{_out} darab kikölcsönözve";
					break;
				case OpenMode.Add:
					Text = "Leltárba vétel";
					changeNumber.Maximum = 10000;
					changeNumber.Minimum = -_in;
					availableLabel.Text = $"{_count} darab a leltárban";
					break;
				default:
					break;
			}
			return ShowDialog();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			switch (Mode)
			{
				case OpenMode.Borrow:
					Element["Out"].InnerText = (_out + (int)changeNumber.Value).ToString();
					break;
				case OpenMode.Return:
					Element["Out"].InnerText = (_out - (int)changeNumber.Value).ToString();
					break;
				case OpenMode.Add:
					Element["Count"].InnerText = (_count + (int)changeNumber.Value).ToString();
					break;
				default:
					break;
			}
			DialogResult = DialogResult.OK;
			Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void ChangeQuantityForm_Shown(object sender, EventArgs e)
		{
			changeNumber.Focus();
		}
	}
}
