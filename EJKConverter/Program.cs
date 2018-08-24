using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace EJKConverter
{
	class Program
	{
		static void Main(string[] args)
		{
			// Documents
			XmlDocument doc = new XmlDocument();
			XmlDocument newdoc = new XmlDocument();
			XmlElement root;
			newdoc.AppendChild(newdoc.CreateXmlDeclaration("1.0", "utf-8", null));
			newdoc.AppendChild(root = newdoc.CreateElement("Inventory"));

			// Source file
			try
			{
				doc.Load(args[0]);
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.ToString());
				Console.ReadKey();
				return;
			}

			// Destination file
			string dest = string.IsNullOrWhiteSpace(args[1]) ? args[0] : args[1];

			// Process
			foreach (XmlElement e in doc.DocumentElement.ChildNodes)
			{
				XmlElement book = newdoc.CreateElement("Book");
				// Title
				XmlElement name = newdoc.CreateElement("Title");
				name.AppendChild(newdoc.CreateTextNode(e["title"].InnerText));
				book.AppendChild(name);

				// ID
				XmlElement id = newdoc.CreateElement("ID");
				id.AppendChild(newdoc.CreateTextNode(e.GetAttribute("id")));
				book.AppendChild(id);

				// Counts
				int i = int.Parse(e.GetAttribute("instorage"));
				int o = int.Parse(e.GetAttribute("borrowed"));
				int c = i + o;

				XmlElement count = newdoc.CreateElement("Count");
				count.AppendChild(newdoc.CreateTextNode(c.ToString()));
				book.AppendChild(count);

				XmlElement outcount = newdoc.CreateElement("Out");
				outcount.AppendChild(newdoc.CreateTextNode(o.ToString()));
				book.AppendChild(outcount);

				// Subject
				XmlElement subject = newdoc.CreateElement("Subject");
				subject.AppendChild(newdoc.CreateTextNode("-"));
				book.AppendChild(subject);

				// Comment
				string note = e["note"].InnerText.Trim().Replace("|", Environment.NewLine);
				XmlElement comment = newdoc.CreateElement("Comment");
				comment.AppendChild(newdoc.CreateTextNode(note.Replace('\n', '|').Replace("\r", "").Trim()));
				book.AppendChild(comment);

				root.AppendChild(book);
			}

			// Save
			newdoc.Save(dest);
		}
	}
}
