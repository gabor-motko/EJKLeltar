using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
			// TODO: don't do this.
			Default.StartupLoad = 2;
			SettingsData.Serialize(Default, Path);
		}

		public class SettingsData
		{
			// File
			public string FilePath;
			public string LastDir;
			public int StartupLoad;

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
				catch (Exception ex)
				{
					System.Windows.Forms.MessageBox.Show(ex.ToString());
				}
				return new SettingsData();
			}
		}
	}

	public static class Updater
	{
		private const string _githubApiUrl = "https://api.github.com/repos/gabor-motko/ejkleltar/releases/latest";
		private static readonly Regex _versionRegex = new Regex("\"tag_name\"[\\s:]*\"([\\d.]*)\"");

		// Compare semantic version strings with the Major.Minor.Hotfix schema
		private static int CompareSemvers(string a, string b)
		{
			try
			{
				string[] splitA = a.Split('.');
				string[] splitB = b.Split('.');
				int result;
				if ((result = string.Compare(splitA[0], splitB[0])) != 0)
					return result;
				if ((result = string.Compare(splitA[1], splitB[1])) != 0)
					return result;
				if ((result = string.Compare(splitA[2], splitB[2])) != 0)
					return result;
				return 0;
			}
			catch
			{
				return -1;
			}
		}

		// Get the latest version from GitHub
		public static string GetGitHubVersion()
		{
			string ver = "1.0.0";

			using (WebClient client = new WebClient())
			{
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				client.Headers.Add(HttpRequestHeader.UserAgent, "EJKLeltar");
				try
				{
					string data = client.DownloadString(_githubApiUrl);
					ver = _versionRegex.Match(data).Value;
				}
				catch(Exception ex)
				{
					//MessageBox.Show(ex.ToString());
				}
			}

			return ver;
		}

		public static void DisplayVersion(string latest)
		{
			string current = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
			string result = CompareSemvers(current, latest) < 0 ? "Új frissítés elérhető." : "Nincs új frissítés.";
			MessageBox.Show($"Jelenlegi verzió: {current}\nLegújabb verzió: {latest}\n\n{result}");
		}
	}
}
