using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MessengerActivityMonitor
{
	static class Program
	{
        public const string AppName = "Messenger Activity Monitor";
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            //try
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            //}
            //catch (Exception ex)
            //{
            //    var result = MessageBox.Show($"{AppName} has crashed because of {ex.Message}. \nWould you like to copy the crash report?", AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            //    if (result == DialogResult.Yes)
            //    {
            //        Clipboard.SetText($"{AppName} Crash Report: \n{ex.ToString()}");
            //        MessageBox.Show("The crash report has been copied. You can sent this report to Craftplacer over the MessengerGeek forum.", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
		}
	}
}
