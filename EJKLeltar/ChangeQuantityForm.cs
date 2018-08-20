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
		public ChangeQuantityForm()
		{
			InitializeComponent();
		}

		public void ShowDialog(XmlElement e, OpenMode mode)
		{
			Mode = mode;
			Element = e;
			switch (mode)
			{
				case OpenMode.Borrow:
					int d = int.Parse(e["Count"].InnerText, System.Globalization.NumberStyles.Integer, System.Globalization.NumberFormatInfo.InvariantInfo) - int.Parse(e["Out"].InnerText, System.Globalization.NumberStyles.Integer, System.Globalization.NumberFormatInfo.InvariantInfo);
					changeNumber.Maximum = d;
					availableLabel.Text = $"{d} raktáron";
					break;
				case OpenMode.Return:
					changeNumber.Maximum = int.Parse(e["Out"].InnerText, System.Globalization.NumberStyles.Integer, System.Globalization.NumberFormatInfo.InvariantInfo);
					break;
				case OpenMode.Add:
					break;
				default:
					break;
			}
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			switch (Mode)
			{
				case OpenMode.Borrow:
					break;
				case OpenMode.Return:
					break;
				case OpenMode.Add:
					break;
				default:
					break;
			}
		}
	}
}
