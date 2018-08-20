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
		private MainForm _main;
		public SettingsForm(MainForm main)
		{
			_main = main;
			InitializeComponent();
		}

		private void SettingsForm_Load(object sender, EventArgs e)
		{
			if(Properties.Settings.Default.OpenLast)
			{
				openLastStartupCheck.Checked = true;
			}
			else
			{
				newOnStartupCheck.Checked = true;
			}
		}
	}
}
