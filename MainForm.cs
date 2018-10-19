using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MessengerDotNet;
using Microsoft.VisualBasic;

namespace MessengerActivityMonitor
{
	public partial class MainForm : Form
	{
        private const string StartupRegistryPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

		public MainForm() => InitializeComponent();

		#region Methods

		private void UpdateTimer_Tick(object sender, EventArgs e)
		{
			var dict = GetDictionary();
			Process process = FindSuitableProcess(dict);
			if (process != null)
			{
				string processName = process.ProcessName.ToLower();
				string text = "";

				text = ProcessText(dict[processName], process);

				if (text != null)
				{
                    MessengerActivity.SetActivity((MessengerActivityType)GetActivityIconFromKey(processName), text.ToString());
				}
			}
		}

		public int GetActivityIconFromKey(string key)
		{
			foreach (ListViewItem item in listView.Items)
			{
				if (item.Text == key)
				{
					return item.ImageIndex;
				}
			}
			return 0;
		}

		public Process FindSuitableProcess(Dictionary<string, string> dict)
		{
			int id;
			GetWindowThreadProcessId(GetForegroundWindow(), out id);
			var p = Process.GetProcessById(id);
			if (dict.ContainsKey(p.ProcessName.ToLower()))
			{
				return p;
			}
			else
			{
				foreach (var item in dict.Keys)
				{
					var p2 = Process.GetProcessesByName(item);
					if (p2.Length != 0 && !string.IsNullOrWhiteSpace(p2[0].MainWindowTitle))
					{
						return p2[0];
					}
				}
			}
			return null;
		}

		public string ProcessText(string value, Process p)
		{
			if (value == "{noop}")
			{
				return null;
			}
			else if (value.Contains("{auto}"))
			{
				return value.Replace("{auto}", p.MainWindowTitle);
			}
			else
			{
				return value;
			}
		}

		public Dictionary<string, string> GetDictionary()
		{
			var dict = new Dictionary<string, string>();
			foreach (ListViewItem item in listView.Items)
			{
				if (item.SubItems.Count > 1)
				{
					dict.Add(item.Text.ToLower(), item.SubItems[1].Text);
				}
			}
			return dict;
		}

		#endregion Methods

		#region Other Control Events

		private void UpdateIntervalNumericUpDown_ValueChanged(object sender, EventArgs e) => updateTimer.Interval = (int)updateIntervalNumericUpDown.Value * 1000;

		private void AddButton_Click(object sender, EventArgs e)
        {
			var dialog = new AddItemForm();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var item = new ListViewItem(dialog.ProcessName);
				if (dialog.NoOperation)
				{
					item.SubItems.Add("{noop}");
				}
				else
				{
					item.SubItems.Add(dialog.PersonalMessge);
					item.ImageIndex = (int)dialog.ActivityType;
				}
				listView.Items.Add(item);
			}
           
        }

        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();

        private void listView1_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && listView.SelectedItems.Count != 0)
			{
				ManageItemContextMenuStrip.Show(PointToScreen(e.Location));
			}
		}

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                NotifyIcon.Visible = true;
            }
        }

        #endregion Other Control Events

        #region Menu Item Events

        private void RemoveMenuItem_Click(object sender, EventArgs e) => listView.Items.Remove(listView.SelectedItems[0]);

		private void IconMusicMenuItem_Click(object sender, EventArgs e) => listView.SelectedItems[0].ImageIndex = 0;

		private void IconGamesMenuItem_Click(object sender, EventArgs e) => listView.SelectedItems[0].ImageIndex = 1;

		private void IconOfficeMenuItem_Click(object sender, EventArgs e) => listView.SelectedItems[0].ImageIndex = 2;

		#endregion Menu Item Events

		#region DLL Imports

		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll")]
		private static extern int GetWindowThreadProcessId(IntPtr handle, out int pid);





        #endregion DLL Imports

        private void MainForm_Shown(object sender, EventArgs e)
        {
			this.WindowState = FormWindowState.Minimized;
            NotifyIcon.ShowBalloonTip(1000, Program.AppName + " is running", "You can open it by double-clicking the icon in the tray area.", ToolTipIcon.Info);
        }

        private void StartupCheckBox_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(StartupRegistryPath, true);
            if (startupCheckBox.Checked)
            {
                key.SetValue(Program.AppName, Application.ExecutablePath);
            }
            else
            {
                key.DeleteValue(Program.AppName, false);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            startupCheckBox.Checked = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(StartupRegistryPath, false).GetValue("Messenger Rich Presence", null) != null;
            
            if (Properties.Settings.Default.ActivitySettings != null)
            {
                this.listView.Items.Clear();
                this.listView.Items.AddRange(Properties.Settings.Default.ActivitySettings);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                ListViewItem[] items = new ListViewItem[listView.Items.Count];
                listView.Items.CopyTo(items, 0);
                Properties.Settings.Default.ActivitySettings = items;
                Properties.Settings.Default.Save();
            }
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}