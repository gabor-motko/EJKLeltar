using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;

namespace EJKLeltar
{
	public partial class EditForm : Form
	{
		public enum OpenMode { New, Edit }
		public OpenMode Mode { get; private set; }
		public XmlElement Element { get; set; }
		private XmlDocument _doc;

		private MainForm _main;

		public EditForm(MainForm main)
		{
			_main = main;
			InitializeComponent();
		}

		public DialogResult ShowDialog(XmlElement element)
		{
			Element = element;
			_doc = element.OwnerDocument;
			Mode = OpenMode.Edit;

			subjectDrop.Items.Clear();

			Text = "Szerkesztés";

			idText.Text = Element["ID"].InnerText;
			titleText.Text = Element["Title"].InnerText;
			subjectDrop.Text = Element["Subject"].InnerText;
			countNumber.Value = int.Parse(Element["Count"].InnerText, NumberStyles.Integer, NumberFormatInfo.InvariantInfo);
			outNumber.Value = int.Parse(Element["Out"].InnerText, NumberStyles.Integer, NumberFormatInfo.InvariantInfo);
			commentText.Text = Element["Comment"].InnerText;

			return ShowDialog();
		}

		public DialogResult ShowDialog(XmlDocument doc)
		{
			_doc = doc;
			Element = doc.CreateElement("Book");
			Mode = OpenMode.New;
			Text = "Új könyv";

			idText.Text = "";
			subjectDrop.Text = "";
			titleText.Text = "";
			countNumber.Value = 0;
			outNumber.Value = 0;
			commentText.Text = "";

			return ShowDialog();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			// Negative quantity
			if (outNumber.Value > countNumber.Value)
			{
				MessageBox.Show("A kikölcsönzött könyvek száma nem lehet nagyobb a teljes darabszámnál.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			// Empty ID or title
			if(string.IsNullOrWhiteSpace(titleText.Text) || string.IsNullOrWhiteSpace(idText.Text))
			{
				MessageBox.Show("A könyv címe nem lehet üres.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (Mode == OpenMode.New)
			{
				if (_doc.DocumentElement.ChildNodes.OfType<XmlElement>().Any(n => n["ID"].InnerText == idText.Text))
				{
					if (MessageBox.Show("A megadott azonosító már létezik. Felülírjam?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
					{
						Element = _doc.DocumentElement.ChildNodes.OfType<XmlElement>().Single(n => n["ID"].InnerText == idText.Text);
						Element["Title"].InnerText = titleText.Text;
						Element["Subject"].InnerText = subjectDrop.Text;
						Element["Count"].InnerText = countNumber.Value.ToString("0", NumberFormatInfo.InvariantInfo);
						Element["Out"].InnerText = countNumber.Value.ToString("0", NumberFormatInfo.InvariantInfo);
						Element["Comment"].InnerText = commentText.Text.Replace('\n', '|').Replace("\r", "");
					}
					else
					{
						return;
					}
				}
				else
				{
					Element = _doc.CreateElement("Book");
					XmlElement id = _doc.CreateElement("ID");
					XmlElement title = _doc.CreateElement("Title");
					XmlElement subject = _doc.CreateElement("Subject");
					XmlElement count = _doc.CreateElement("Count");
					XmlElement outCount = _doc.CreateElement("Out");
					XmlElement comment = _doc.CreateElement("Comment");

					id.AppendChild(_doc.CreateTextNode(idText.Text));
					title.AppendChild(_doc.CreateTextNode(titleText.Text));
					subject.AppendChild(_doc.CreateTextNode(subjectDrop.Text));
					count.AppendChild(_doc.CreateTextNode(countNumber.Value.ToString("0", NumberFormatInfo.InvariantInfo)));
					outCount.AppendChild(_doc.CreateTextNode(outNumber.Value.ToString("0", NumberFormatInfo.InvariantInfo)));
					comment.AppendChild(_doc.CreateTextNode(commentText.Text.Replace('\n', '|').Replace("\r", "")));

					Element.AppendChild(id);
					Element.AppendChild(title);
					Element.AppendChild(subject);
					Element.AppendChild(count);
					Element.AppendChild(outCount);
					Element.AppendChild(comment);
				}
			}
			else
			{
				Element["ID"].InnerText = idText.Text;
				Element["Title"].InnerText = titleText.Text;
				Element["Subject"].InnerText = subjectDrop.Text;
				Element["Count"].InnerText = countNumber.Value.ToString("0", NumberFormatInfo.InvariantInfo);
				Element["Out"].InnerText = outNumber.Value.ToString("0", NumberFormatInfo.InvariantInfo);
				Element["Comment"].InnerText = commentText.Text.Replace('\n', '|').Replace("\r", "");
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
