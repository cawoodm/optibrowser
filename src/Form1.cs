using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using Microsoft.Win32;
using System.IO;

namespace OptiBrowser {

    public partial class Form1 : Form {

        private string URL;
        private string DefaultBrowser;

        public Form1() {

            InitializeComponent();

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
                URL = args[1];
            else {
                MessageBox.Show("No URL specified in startup parameters, defaulting to google.com!");
                URL = "http://google.com";
            }

            tslabelURL.Text = URL;
            tslabelURL.Tag = URL;

            DefaultBrowser = getDefaultBrowser();
            DefaultBrowser = "nix";
            if (DefaultBrowser.ToLower().Contains("chrome"))
                btnChrome.Focus();
            else if (DefaultBrowser.ToLower().Contains("firefox"))
                btnFF.Focus();
            else if (DefaultBrowser.ToLower().Contains("iexplore"))
                btnIE.Focus();
            else
                DefaultBrowser = "X";

        }

        private void button1_Click(object sender, EventArgs e) {
            Process p = new Process();
            p.StartInfo.FileName = "iexplore.exe";
            p.StartInfo.Arguments = URL;
            p.Start();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) {
            Process.Start("firefox.exe", URL);
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e) {
            Process.Start("chrome.exe", URL);
            Application.Exit();
        }

        private string getDefaultBrowser() {
            string browser = string.Empty;
            RegistryKey key = null;
            try {
                key = Registry.ClassesRoot.OpenSubKey(@"HTTP\shell\open\command", false);
                // Trim off quotes
                browser = key.GetValue(null).ToString().ToLower().Replace("\"", "");
                if (!browser.EndsWith("exe")) {
                    // Get rid of everything after the ".exe"
                    browser = browser.Substring(0, browser.LastIndexOf(".exe") + 4);
                }
            } finally {
                if (key != null) key.Close();
            }
            return browser;
        }

        private void tslabelURL_Click(object sender, EventArgs e) {
            // Start default browser if URL is clicked
            Process.Start(tslabelURL.Tag.ToString());
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
            // Start default browser if Enter is pressed and no default is known
            if (e.KeyChar == (char)13 && DefaultBrowser == "X") {
                Process.Start(tslabelURL.Tag.ToString());
                Application.Exit();
            }
        }
    }
}
