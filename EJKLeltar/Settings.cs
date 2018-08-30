using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Drawing;
using System.Xml.Schema;

namespace EJKLeltar
{
	public class Settings
	{
		public static SettingsData Default { get; private set; }
		public const string Path = "settings.xml";

		public static void Load()
		{
			Default = SettingsData.Deserialize(Path);
		}

		public static void Save()
		{
			SettingsData.Serialize(Default, Path);
		}

		public class SettingsData
		{
			// File
			public string FilePath;
			public string LastDir;
			public bool OpenLast;

			// Window
			public Size WindowSize;
			public bool Maximized;

			// Backups
			public bool BackupPathSelect;
			public string BackupPath;
			public int BackupCount;

			public static void Serialize(SettingsData data, string path)
			{
				try
				{
					XmlSerializer serializer = new XmlSerializer(typeof(SettingsData));
					StreamWriter stream = new StreamWriter(path);
					XmlWriter writer = XmlWriter.Create(stream);
					serializer.Serialize(writer, data);
					writer.Close();
					stream.Close();
				}
				catch (Exception ex)
				{
					if (ex is System.Security.SecurityException)
						System.Windows.Forms.MessageBox.Show("A beállítások mentése sikertelen: hozzáférés megtagadva.", "Hozzáférés megtagadva", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
					else
						System.Windows.Forms.MessageBox.Show("A beállítások mentése sikertelen: " + ex.Message, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
				}
			}

			public static SettingsData Deserialize(string path)
			{
				try
				{
					XmlSerializer serializer = new XmlSerializer(typeof(SettingsData));
					StreamReader stream = new StreamReader(path);
					XmlReader reader = XmlReader.Create(stream);
					SettingsData o = serializer.Deserialize(reader) as SettingsData;
					reader.Close();
					stream.Close();
					return o;
				}
				catch(Exception ex)
				{
					System.Windows.Forms.MessageBox.Show(ex.ToString());
				}
				return new SettingsData();
			}
		}
	}
}
