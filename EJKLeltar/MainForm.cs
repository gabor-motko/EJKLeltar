using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace EJKLeltar
{
	public partial class MainForm : Form
	{
		// Data
		public XmlDocument Document;

		private bool _changed = false;
		private XmlElement _selected;

		// Sub-forms
		private AboutForm _aboutForm;
		private EditForm _editForm;
		private SettingsForm _settingsForm;

		public MainForm()
		{
			// Instantiate sub-forms
			_aboutForm = new AboutForm();
			_editForm = new EditForm(this);
			_settingsForm = new SettingsForm(this);


			InitializeComponent();
		}

		// Set _changed and form title
		public void SetChanged(bool changed)
		{
			_changed = changed;
			Text = $"Leltár {(_changed ? "* " : "")} - {Properties.Settings.Default.FilePath}";
		}

		// Display book data
		private void _displayEntry(XmlElement e)
		{
			if (e != null)
			{
				titleText.Text = e["Title"].InnerText;
				idText.Text = e["ID"].InnerText;
				int count = int.Parse(e["Count"].InnerText);
				int outCount = int.Parse(e["Out"].InnerText);
				int inCount = count - outCount;

				inText.Text = inCount.ToString();
				outText.Text = outCount.ToString();
				totalText.Text = count.ToString();
				commentText.Text = e["Comment"].InnerText.Replace('|', '\n');
			}
			else
			{
				titleText.Text = "Cím";
				idText.Text = "Azonosító";
				inText.Text = "";
				outText.Text = "";
				totalText.Text = "";
				commentText.Text = "Megjegyzés";
			}
		}

		// Load XML doc
		private void _loadFile()
		{
			try
			{
				Document.Load(Properties.Settings.Default.FilePath);
				SetChanged(false);
				_populateList();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Save XML doc
		private void _saveFile()
		{
			try
			{
				Document.Save(Properties.Settings.Default.FilePath);
				SetChanged(false);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Read, filter and display XmlElements
		private void _populateList()
		{
			mainList.Items.Clear();
			mainList.SelectedIndices.Clear();
			foreach(XmlElement n in Document.DocumentElement.ChildNodes.OfType<XmlElement>())
			{
				string code = n["ID"].InnerText;
				string title = n["Title"].InnerText; 

				if(string.IsNullOrEmpty(searchText.Text) || (code.ToLowerInvariant().Contains(searchText.Text.ToLowerInvariant()) || title.ToLowerInvariant().Contains(searchText.Text.ToLowerInvariant())))
				{
					ListViewItem item = new ListViewItem(code);
					item.SubItems.Add(new ListViewItem.ListViewSubItem(item, title));
					mainList.Items.Add(item);
				}
			}
			mainList.SelectedIndices.Clear();
		}

		// Form loads
		private void MainForm_Load(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(Properties.Settings.Default.LastDir))
				Properties.Settings.Default.LastDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

			if (Properties.Settings.Default.OpenLast)
			{
				_loadFile();
			}
			else
			{
				Document = new XmlDocument();
				Document.AppendChild(Document.CreateXmlDeclaration("1.0", "utf-8", null));
				Document.AppendChild(Document.CreateElement("Inventory"));
				_populateList();
			}
		}

		// Search
		private void searchButton_Click(object sender, EventArgs e)
		{
			_populateList();
		}

		// Select item
		private void mainList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.Item != null)
			{
				_selected = Document.DocumentElement.ChildNodes.OfType<XmlElement>().Single(n => n["ID"].InnerText == e.Item.Text);
				_displayEntry(_selected);
			}
		}

		// Click on list
		private void mainList_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if (mainList.FocusedItem.Bounds.Contains(e.Location))
				{
					mainListContextMenu.Show(Cursor.Position);
				}
			}
		}

		// New document
		private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.FilePath = string.Empty;
			Document = new XmlDocument();
			Document.AppendChild(Document.CreateElement("Inventory"));
			_populateList();
		}

		// Open document
		private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(_changed)
			{
				DialogResult res = MessageBox.Show("save?", "save?", MessageBoxButtons.YesNoCancel);
				if (res == DialogResult.Yes)
					saveToolStripMenuItem_Click(sender, e);
				else if (res == DialogResult.Cancel)
					return;
			}
			OpenFileDialog d = new OpenFileDialog()
			{
				InitialDirectory = Properties.Settings.Default.LastDir,
				Multiselect = false,
				Filter = "XML fájl|*.xml|Minden fájl|*.*",
				Title = "Megnyitás"
			};
			if (d.ShowDialog() == DialogResult.OK)
			{
				Properties.Settings.Default.FilePath = d.FileName;
				Properties.Settings.Default.LastDir = Path.GetDirectoryName(d.FileName);
				_loadFile();
			}
			d.Dispose();
		}

		// Save document
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(Properties.Settings.Default.FilePath))
			{
				saveAsToolStripMenuItem_Click(sender, e);
			}
			else
			{
				_saveFile();
			}
		}

		// Save document as
		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog d = new SaveFileDialog()
			{
				InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.FilePath),
				Filter = "XML fájl|*.xml|Minden fájl|*.*",
				DefaultExt = "xml",
				Title = "Mentés másként"
			};
			if(d.ShowDialog() == DialogResult.OK)
			{
				Properties.Settings.Default.FilePath = d.FileName;
				Properties.Settings.Default.LastDir = Path.GetDirectoryName(d.FileName);
				_saveFile();
			}
		}

		// Exit
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		// Closing
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_changed)
			{
				DialogResult res = MessageBox.Show("save?", "save?", MessageBoxButtons.YesNoCancel);
				if (res == DialogResult.Yes)
					saveToolStripMenuItem_Click(sender, e);
				else if (res == DialogResult.Cancel)
				{
					e.Cancel = true;
					return;
				}
			}
			Properties.Settings.Default.Save();
		}

		// New book
		private void newBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(_editForm.ShowDialog(Document) == DialogResult.OK)
			{
				Document.DocumentElement.AppendChild(_editForm.Element);
				SetChanged(true);
				_populateList();
				mainList.SelectedIndices.Add(mainList.Items.Count - 1);
			}
		}

		// Edit book
		private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_editForm.ShowDialog(_selected);
			_displayEntry(_selected);
		}

		// Borrow book
		private void borrowButton_Click(object sender, EventArgs e)
		{
			titleText.Text = _selected["ID"].InnerText;
			SetChanged(true);
		}

		// Return book
		private void returnButton_Click(object sender, EventArgs e)
		{

		}

		// Delete book
		private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show($"A kiválasztott bejegyzés véglegesen törölve lesz:\n\n{_selected["Title"].InnerText}\n{_selected["ID"].InnerText}", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				Document.DocumentElement.RemoveChild(_selected);
				_populateList();
			}
		}

		// Open settings
		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_settingsForm.ShowDialog() == DialogResult.OK)
			{
				Properties.Settings.Default.Save();
			}
		}

		// Open about
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_aboutForm.ShowDialog();
		}
	}
}
