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
		private HashSet<string> _ids;

		// Sub-forms
		private AboutForm _aboutForm;
		private EditForm _editForm;
		private SettingsForm _settingsForm;
		private ChangeQuantityForm _changeForm;

		public MainForm()
		{
			// Instantiate sub-forms
			_aboutForm = new AboutForm();
			_editForm = new EditForm(this);
			_settingsForm = new SettingsForm(this);
			_changeForm = new ChangeQuantityForm();

			_ids = new HashSet<string>();

			InitializeComponent();

			// Load settings
			Size = Properties.Settings.Default.WindowSize;
			WindowState = Properties.Settings.Default.WindowMaximized ? FormWindowState.Maximized : FormWindowState.Normal;
		}

		#region Methods
		// Set _changed and form title
		public void SetChanged(bool changed)
		{
			_changed = changed;
			Text = $"{(_changed ? "* " : "")}Leltár - {(string.IsNullOrWhiteSpace(Properties.Settings.Default.FilePath) ? "Üres dokumentum" : Properties.Settings.Default.FilePath)}";
		}

		// Enable or disable buttons
		public void SetActive(bool active)
		{
			borrowButton.Enabled = active;
			returnButton.Enabled = active;
			editButton.Enabled = active;
			deleteButton.Enabled = active;
			addButton.Enabled = active;
		}
		
		// Display book data
		private void _displayEntry(XmlElement e)
		{
			try
			{
				if (e != null)
				{
					titleText.Text = e["Title"].InnerText;
					idText.Text = e["ID"].InnerText;
					subjectText.Text = e["Subject"].InnerText;
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
					subjectText.Text = "Szakma";
					inText.Text = "";
					outText.Text = "";
					totalText.Text = "";
					commentText.Text = "Megjegyzés";
				}
			}
			catch (NullReferenceException ex)
			{
				if (MessageBox.Show("A kijelölt bejegyzés egyik mezője hiányzik. Törlöd?", "Hiba", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
				{
					Document.DocumentElement.RemoveChild(_selected);
					_selected = null;
					_populateList();
				}
			}
		}

		// Load XML doc
		private void _loadFile()
		{
			Document = new XmlDocument();
			Document.Load(Properties.Settings.Default.FilePath);
			SetChanged(false);
			_populateList();
		}

		// Make backups
		private void MakeBackup()
		{

		}

		// Save XML doc
		private void _saveFile()
		{
			try
			{
				// Backup
				if(Properties.Settings.Default.BackupCount > 0)
				{
					if(Properties.Settings.Default.BackupPathSelect)
					{
						// Backup in the selected directory
					}
				}

				// Save
				Document.Save(Properties.Settings.Default.FilePath);
				SetChanged(false);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Read, filter and display XmlElements
		private void _populateList()
		{
			_ids.Clear();
			mainList.Items.Clear();
			mainList.SelectedIndices.Clear();
			foreach (XmlElement n in Document.DocumentElement.ChildNodes.OfType<XmlElement>())
			{
				try
				{
					// Get relevant fields
					string code = n["ID"].InnerText.Trim();

					if (string.IsNullOrWhiteSpace(code))
					{
						code = "ÜRES-" + n.GetHashCode();
						n["ID"].InnerText = code;
						MessageBox.Show($"Az egyik bejegyzés azonosítója üres vagy whitespace karakter. Az új azonosító {code}.");
					}

					if (_ids.Contains(code))
					{
						if (MessageBox.Show($"A lista már tartalmaz egy elemet a \"{code}\" azonosítóval. Kitöröljem az új bejegyzést?", "Ütközés", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							Document.DocumentElement.RemoveChild(n);
							continue;
						}
						else
						{
							code = $"{code}-{n.GetHashCode()}";
							n["ID"].InnerText = code;
							MessageBox.Show($"Az új azonosító {code} lesz.");
						}
						SetChanged(true);
					}
					_ids.Add(code);

					string title = n["Title"].InnerText;

					// Add main list items
					if (string.IsNullOrEmpty(searchText.Text) || (code.ToLowerInvariant().Contains(searchText.Text.ToLowerInvariant()) || title.ToLowerInvariant().Contains(searchText.Text.ToLowerInvariant())))
					{
						ListViewItem item = new ListViewItem(code);
						item.SubItems.Add(new ListViewItem.ListViewSubItem(item, title));
						mainList.Items.Add(item);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			mainList.SelectedIndices.Clear();
		}
		#endregion

		#region Event handlers
		// Form loads
		private void MainForm_Load(object sender, EventArgs e)
		{
			SetChanged(false);
			if (string.IsNullOrEmpty(Properties.Settings.Default.LastDir))
				Properties.Settings.Default.LastDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

			if (Properties.Settings.Default.OpenLast && !string.IsNullOrWhiteSpace(Properties.Settings.Default.FilePath))
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
			_selected = null;
			SetActive(false);
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
				SetActive(true);
			}
			else
				SetActive(false);
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
			if (_changed)
			{
				DialogResult res = MessageBox.Show("save?", "save?", MessageBoxButtons.YesNoCancel);
				if (res == DialogResult.Yes)
					saveToolStripMenuItem_Click(sender, e);
				else if (res == DialogResult.Cancel)
					return;
			}
			Properties.Settings.Default.FilePath = "";
			Document = new XmlDocument();
			Document.AppendChild(Document.CreateXmlDeclaration("1.0", "utf-8", null));
			Document.AppendChild(Document.CreateElement("Inventory"));
			SetChanged(false);
			_selected = null;
			SetActive(false);
			_populateList();
		}

		// Open document
		private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_changed)
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
				_selected = null;
				SetActive(false);
			}
			d.Dispose();
		}

		// Save document
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(Properties.Settings.Default.FilePath))
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
				InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.LastDir),
				Filter = "XML fájl|*.xml|Minden fájl|*.*",
				DefaultExt = "xml",
				Title = "Mentés másként"
			};
			if (d.ShowDialog() == DialogResult.OK)
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
			Properties.Settings.Default.WindowSize = Size;
			Properties.Settings.Default.WindowMaximized = WindowState == FormWindowState.Maximized;
			Properties.Settings.Default.Save();
		}

		// New book
		private void newBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_editForm.ShowDialog(Document) == DialogResult.OK)
			{
				Document.DocumentElement.AppendChild(_editForm.Element);
				SetChanged(true);
				_populateList();
				mainList.SelectedIndices.Add(mainList.Items.Count - 1);
				mainList.EnsureVisible(mainList.SelectedIndices[0]);
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
			if (_selected == null)
				return;
			if (_changeForm.ShowDialog(_selected, ChangeQuantityForm.OpenMode.Borrow) == DialogResult.OK)
				SetChanged(true);
			_displayEntry(_selected);
		}

		// Return book
		private void returnButton_Click(object sender, EventArgs e)
		{
			if (_selected == null)
				return;
			if (_changeForm.ShowDialog(_selected, ChangeQuantityForm.OpenMode.Return) == DialogResult.OK)
				SetChanged(true);
			_displayEntry(_selected);
		}

		// Add books
		private void addButton_Click(object sender, EventArgs e)
		{
			if (_changeForm.ShowDialog(_selected, ChangeQuantityForm.OpenMode.Add) == DialogResult.OK)
				SetChanged(true);
			_displayEntry(_selected);
		}

		// Delete book
		private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show($"A kiválasztott bejegyzés véglegesen törölve lesz:\n\n{_selected["Title"].InnerText}\n{_selected["ID"].InnerText}", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				int index = mainList.SelectedIndices[0];
				Document.DocumentElement.RemoveChild(_selected);
				_populateList();
				mainList.Select();
				index = Math.Min(index, mainList.Items.Count - 1);
				mainList.Items[index].Selected = true;
				mainList.EnsureVisible(index);
				SetChanged(true);
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

		// Ctrl + F
		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (!e.Handled)
			{
				if (e.Modifiers == Keys.Control && e.KeyCode == Keys.F)
				{
					searchText.Focus();
				}
			}
		}

		// Search text keypresses
		private void searchText_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Enter:
					searchButton_Click(sender, e);
					break;
				case Keys.Escape:
					searchText.Text = "";
					searchButton_Click(sender, e);
					break;
				default:
					break;
			}
		}
		#endregion
	}
}