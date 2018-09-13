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
		private const string _defaultFile = "leltar.ejk";
		private XmlDocument _document;
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
			Settings.Load();

			// Instantiate sub-forms
			_aboutForm = new AboutForm();
			_editForm = new EditForm(this);
			_settingsForm = new SettingsForm(this);
			_changeForm = new ChangeQuantityForm();

			_ids = new HashSet<string>();

			InitializeComponent();

			// Load settings
			Size = Settings.Default.WindowSize;
			WindowState = Settings.Default.Maximized ? FormWindowState.Maximized : FormWindowState.Normal;
		}

		#region Methods
		// Set _changed and form title
		public void SetChanged(bool changed)
		{
			_changed = changed;
			Text = $"{(_changed ? "* " : "")}Leltár - {(string.IsNullOrWhiteSpace(Settings.Default.FilePath) ? "Üres dokumentum" : Settings.Default.FilePath)}";
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
		private void DisplayEntry(XmlElement e)
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
					_document.DocumentElement.RemoveChild(_selected);
					_selected = null;
					PopulateList();
				}
			}
		}

		// Load XML doc
		private void LoadFile()
		{
			_document = new XmlDocument();
			_document.Load(Settings.Default.FilePath);
			SetChanged(false);
			PopulateList();
		}

		// Make backups
		private void MakeBackup()
		{

		}

		// Save XML doc
		private void SaveFile()
		{
			try
			{
				// Backup
				if (Settings.Default.BackupCount > 0)
				{
					if (Settings.Default.BackupPathSelect)
					{
						// Backup in the selected directory
					}
				}

				// Save
				_document.Save(Settings.Default.FilePath);
				SetChanged(false);
			}
			catch (Exception ex)
			{
				if (ex is System.Security.SecurityException)
					MessageBox.Show($"A {Settings.Default.FilePath} helyen lévő fájlt nem lehetett elmenteni:\nA felhasználónak nincs írási engedélye.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else if (ex is DriveNotFoundException)
					MessageBox.Show($"A {Settings.Default.FilePath} helyen lévő fájlt nem lehetett elmenteni:\nA(z) {Path.GetPathRoot(Settings.Default.FilePath)} jelű eszköz nem található.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show($"A {Settings.Default.FilePath} helyen lévő fájlt nem lehetett elmenteni:\n{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Save XML doc as copy
		private void ExportFile(string path)
		{
			try
			{
				// Save
				_document.Save(path);
			}
			catch (Exception ex)
			{
				if (ex is System.Security.SecurityException || ex is UnauthorizedAccessException)
					MessageBox.Show($"A {Settings.Default.FilePath} helyen lévő fájlt nem lehetett elmenteni:\nA felhasználónak nincs írási engedélye.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else if (ex is DriveNotFoundException)
					MessageBox.Show($"A {Settings.Default.FilePath} helyen lévő fájlt nem lehetett elmenteni:\nA(z) {Path.GetPathRoot(Settings.Default.FilePath)} jelű eszköz nem található.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show($"A {Settings.Default.FilePath} helyen lévő fájlt nem lehetett elmenteni:\n{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Import XML doc
		private void ImportFile(string path)
		{
			try
			{
				_document = new XmlDocument();
				_document.Load(path);
				SetChanged(true);
				PopulateList();
			}
			catch (Exception ex)
			{

			}
		}

		// Read, filter and display XmlElements
		private void PopulateList()
		{
			_ids.Clear();
			mainList.Items.Clear();
			mainList.SelectedIndices.Clear();
			foreach (XmlElement n in _document.DocumentElement.ChildNodes.OfType<XmlElement>())
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
						SetChanged(true);
					}

					if (_ids.Contains(code))
					{
						if (MessageBox.Show($"A lista már tartalmaz egy elemet a \"{code}\" azonosítóval. Kitöröljem az új bejegyzést?", "Ütközés", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							_document.DocumentElement.RemoveChild(n);
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
			if (string.IsNullOrEmpty(Settings.Default.LastDir))
				Settings.Default.LastDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

			if (Settings.Default.StartupLoad == 1 && !string.IsNullOrWhiteSpace(Settings.Default.FilePath))
			{
				try
				{
					LoadFile();
				}
				catch (Exception ex)
				{
					if (ex is DriveNotFoundException)
						MessageBox.Show($"A {Settings.Default.FilePath} helyen lévő fájlt nem lehetett megnyitni:\nA(z) {Path.GetPathRoot(Settings.Default.FilePath)} jelű eszköz nem található.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					else if (ex is FileNotFoundException || ex is DirectoryNotFoundException)
						MessageBox.Show($"A {Settings.Default.FilePath} helyen lévő fájlt nem lehetett megnyitni:\nA fájl vagy mappa nem létezik.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					else if (ex is System.Security.SecurityException || ex is UnauthorizedAccessException)
						MessageBox.Show($"A {Settings.Default.FilePath} helyen lévő fájlt nem lehetett megnyitni:\nA felhasználónak nincsen olvasási engedélye.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

					Settings.Default.FilePath = "";
					_document = new XmlDocument();
					_document.AppendChild(_document.CreateXmlDeclaration("1.0", "utf-8", null));
					_document.AppendChild(_document.CreateElement("Inventory"));
					PopulateList();
				}
			}
			else if (Settings.Default.StartupLoad == 2)
			{
				try
				{
					Settings.Default.FilePath = _defaultFile;
					LoadFile();
				}
				catch (Exception ex)
				{
					if (ex is DriveNotFoundException)
						MessageBox.Show($"A {Settings.Default.FilePath} helyen lévő fájlt nem lehetett megnyitni:\nA(z) {Path.GetPathRoot(Settings.Default.FilePath)} jelű eszköz nem található.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					else if (ex is FileNotFoundException || ex is DirectoryNotFoundException)
					{
						Settings.Default.FilePath = "";
						_document = new XmlDocument();
						_document.AppendChild(_document.CreateXmlDeclaration("1.0", "utf-8", null));
						_document.AppendChild(_document.CreateElement("Inventory"));
						PopulateList();
					}
					else if (ex is System.Security.SecurityException || ex is UnauthorizedAccessException)
						MessageBox.Show($"A {Settings.Default.FilePath} helyen lévő fájlt nem lehetett megnyitni:\nA felhasználónak nincsen olvasási engedélye.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				Settings.Default.FilePath = "";
				_document = new XmlDocument();
				_document.AppendChild(_document.CreateXmlDeclaration("1.0", "utf-8", null));
				_document.AppendChild(_document.CreateElement("Inventory"));
				PopulateList();
			}
			//SetChanged(false);
			_selected = null;
			SetActive(false);
		}

		// Search
		private void searchButton_Click(object sender, EventArgs e)
		{
			PopulateList();
		}

		// Select item
		private void mainList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.Item != null)
			{
				_selected = _document.DocumentElement.ChildNodes.OfType<XmlElement>().Single(n => n["ID"].InnerText == e.Item.Text);
				DisplayEntry(_selected);
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
				DialogResult res = MessageBox.Show("A dokumentumban nem mentett változtatások vannak. Mentsem?", "Dokumentum mentése", MessageBoxButtons.YesNoCancel);
				if (res == DialogResult.Yes)
					saveToolStripMenuItem_Click(sender, e);
				else if (res == DialogResult.Cancel)
					return;
			}
			Settings.Default.FilePath = "";
			_document = new XmlDocument();
			_document.AppendChild(_document.CreateXmlDeclaration("1.0", "utf-8", null));
			_document.AppendChild(_document.CreateElement("Inventory"));
			SetChanged(false);
			_selected = null;
			SetActive(false);
			PopulateList();
		}

		// Open document
		private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_changed)
			{
				DialogResult res = MessageBox.Show("A dokumentumban nem mentett változtatások vannak. Mentsem?", "Dokumentum mentése", MessageBoxButtons.YesNoCancel);
				if (res == DialogResult.Yes)
					saveToolStripMenuItem_Click(sender, e);
				else if (res == DialogResult.Cancel)
					return;
			}
			OpenFileDialog d = new OpenFileDialog()
			{
				InitialDirectory = Settings.Default.LastDir,
				Multiselect = false,
				Filter = "EJK dokumentum|*.ejk|XML dokumentum|*.xml|Minden fájl|*.*",
				Title = "Megnyitás"
			};
			if (d.ShowDialog() == DialogResult.OK)
			{
				Settings.Default.FilePath = d.FileName;
				Settings.Default.LastDir = Path.GetDirectoryName(d.FileName);
				try
				{
					LoadFile();
				}
				catch (Exception ex)
				{
					if (ex is DriveNotFoundException)
						MessageBox.Show($"A {Settings.Default.FilePath} helyen lévő fájlt nem lehetett megnyitni:\nA(z) {Path.GetPathRoot(Settings.Default.FilePath)} jelű eszköz nem található.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					else if (ex is FileNotFoundException || ex is DirectoryNotFoundException)
						MessageBox.Show($"A {Settings.Default.FilePath} helyen lévő fájlt nem lehetett megnyitni:\nA fájl vagy mappa nem létezik.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					else if (ex is System.Security.SecurityException || ex is UnauthorizedAccessException)
						MessageBox.Show($"A {Settings.Default.FilePath} helyen lévő fájlt nem lehetett megnyitni:\nA felhasználónak nincsen olvasási engedélye.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				_selected = null;
				SetActive(false);
			}
			d.Dispose();
		}

		// Save document
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(Settings.Default.FilePath))
			{
				saveAsToolStripMenuItem_Click(sender, e);
			}
			else
			{
				SaveFile();
			}
		}

		// Save document as
		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog d = new SaveFileDialog()
			{
				InitialDirectory = Path.GetDirectoryName(Settings.Default.LastDir),
				Filter = "EJK dokumentum|*.ejk|XML dokumentum|*.xml|Minden fájl|*.*",
				DefaultExt = "ejk",
				Title = "Mentés másként"
			};
			if (d.ShowDialog() == DialogResult.OK)
			{
				Settings.Default.FilePath = d.FileName;
				Settings.Default.LastDir = Path.GetDirectoryName(d.FileName);
				SaveFile();
			}
		}

		// Export document
		private void saveCopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog d = new SaveFileDialog()
			{
				InitialDirectory = Path.GetDirectoryName(Settings.Default.LastDir),
				Filter = "EJK dokumentum|*.ejk|XML dokumentum|*.xml|Minden fájl|*.*",
				DefaultExt = "ejk",
				Title = "Másolat mentése"
			};
			if (d.ShowDialog() == DialogResult.OK)
			{
				ExportFile(d.FileName);
			}
		}

		// Import document
		private void importToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Ez a művelet a teljes dokumentumot felülírja. Biztos?", "Importálás megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
				return;
			OpenFileDialog d = new OpenFileDialog()
			{
				InitialDirectory = Path.GetDirectoryName(Settings.Default.LastDir),
				Filter = "EJK dokumentum|*.ejk|XML dokumentum|*.xml|Minden fájl|*.*",
				DefaultExt = "ejk",
				Title = "Dokumentum importálása",
				Multiselect = false
			};
			if (d.ShowDialog() == DialogResult.OK)
			{
				try
				{
					ImportFile(d.FileName);
				}
				catch (Exception ex)
				{
					if (ex is DriveNotFoundException)
						MessageBox.Show($"A {Settings.Default.FilePath} helyen lévő fájlt nem lehetett megnyitni:\nA(z) {Path.GetPathRoot(Settings.Default.FilePath)} jelű eszköz nem található.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					else if (ex is FileNotFoundException || ex is DirectoryNotFoundException)
						MessageBox.Show($"A {Settings.Default.FilePath} helyen lévő fájlt nem lehetett megnyitni:\nA fájl vagy mappa nem létezik.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					else if (ex is System.Security.SecurityException || ex is UnauthorizedAccessException)
						MessageBox.Show($"A {Settings.Default.FilePath} helyen lévő fájlt nem lehetett megnyitni:\nA felhasználónak nincsen olvasási engedélye.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
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
				DialogResult res = MessageBox.Show("A dokumentumban nem mentett változtatások vannak. Mentsem?", "Dokumentum mentése", MessageBoxButtons.YesNoCancel);
				if (res == DialogResult.Yes)
					saveToolStripMenuItem_Click(sender, e);
				else if (res == DialogResult.Cancel)
				{
					e.Cancel = true;
					return;
				}
			}
			Settings.Default.WindowSize = Size;
			Settings.Default.Maximized = WindowState == FormWindowState.Maximized;
			Settings.Save();
		}

		// New book
		private void newBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_editForm.ShowDialog(_document) == DialogResult.OK)
			{
				_document.DocumentElement.AppendChild(_editForm.Element);
				SetChanged(true);
				PopulateList();
				mainList.SelectedIndices.Add(mainList.Items.Count - 1);
				mainList.EnsureVisible(mainList.SelectedIndices[0]);
			}
		}

		// Edit book
		private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_editForm.ShowDialog(_selected);
			DisplayEntry(_selected);
		}

		// Borrow book
		private void borrowButton_Click(object sender, EventArgs e)
		{
			if (_selected == null)
				return;
			if (_changeForm.ShowDialog(_selected, ChangeQuantityForm.OpenMode.Borrow) == DialogResult.OK)
				SetChanged(true);
			DisplayEntry(_selected);
		}

		// Return book
		private void returnButton_Click(object sender, EventArgs e)
		{
			if (_selected == null)
				return;
			if (_changeForm.ShowDialog(_selected, ChangeQuantityForm.OpenMode.Return) == DialogResult.OK)
				SetChanged(true);
			DisplayEntry(_selected);
		}

		// Add books
		private void addButton_Click(object sender, EventArgs e)
		{
			if (_changeForm.ShowDialog(_selected, ChangeQuantityForm.OpenMode.Add) == DialogResult.OK)
				SetChanged(true);
			DisplayEntry(_selected);
		}

		// Delete book
		private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show($"A kiválasztott bejegyzés véglegesen törölve lesz:\n\n{_selected["Title"].InnerText}\n{_selected["ID"].InnerText}", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				int index = mainList.SelectedIndices[0];
				_document.DocumentElement.RemoveChild(_selected);
				PopulateList();
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
				Settings.Save();
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

		// Check for updated version
		private void updateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Updater.DisplayVersion(Updater.GetGitHubVersion());
		}
		#endregion
	}
}