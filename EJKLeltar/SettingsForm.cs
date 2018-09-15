using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJKLeltar
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void SettingsForm_Load(object sender, EventArgs e)
		{
			//if (Settings.Default.OpenLast)
			//	openLastStartupCheck.Checked = true;
			//else
			//	newOnStartupCheck.Checked = true;

			switch (Settings.Default.StartupLoad)
			{
				case 1:
					openLastStartupCheck.Checked = true;
					break;
				case 2:
					defaultOnStartupCheck.Checked = true;
					break;
				default:
					newOnStartupCheck.Checked = true;
					break;
			}

			if (Settings.Default.BackupPathSelect)
				backupSelectDirCheck.Checked = true;
			else
				backupSameDirCheck.Checked = true;

			backupPathText.Text = Settings.Default.BackupPath;
			backupNumber.Value = Settings.Default.BackupCount;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			//Settings.Default.OpenLast = openLastStartupCheck.Checked;
			Settings.Default.StartupLoad = defaultOnStartupCheck.Checked ? 2 : (openLastStartupCheck.Checked ? 1 : 0);
			Settings.Default.BackupPathSelect = backupSelectDirCheck.Checked;
			Settings.Default.BackupPath = backupSelectDirCheck.Checked ? backupPathText.Text : string.Empty;
			Settings.Default.BackupCount = (int)backupNumber.Value;

			Settings.Save();
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
