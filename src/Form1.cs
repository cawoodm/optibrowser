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
        private string Arg1;
        private string OriginalBrowser;
        private string EXEPath;

        public Form1() {

            InitializeComponent();

            EXEPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + Path.DirectorySeparatorChar;

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1) {
                URL = args[1];
                if (args.Length > 2) {
                    Arg1 = args[2];
                    if (Arg1 == "OBDEFAULT") {
                        doDefault(URL);
                        Application.Exit();
                    }
                }
            } else {
                MessageBox.Show("No URL specified in startup parameters, defaulting to google.com!");
                URL = "http://google.com";
            }

            tslabelURL.Text = URL;
            tslabelURL.Tag = URL;

            OriginalBrowser = getOriginalBrowser();

            string SystemBrowser = getSystemBrowser();
            if (!SystemBrowser.ToLower().Contains("optibrowser")) {
                MessageBox.Show("OptiBrowser is not configured as your default browser!");
            } else {
                if (OriginalBrowser == "" && !SystemBrowser.ToLower().Contains("optibrowser")) SaveToFile("default.browser.txt", SystemBrowser);
            }
            
            if (OriginalBrowser.ToLower().Contains("chrome"))
                btnChrome.Focus();
            else if (OriginalBrowser.ToLower().Contains("firefox"))
                btnFF.Focus();
            else if (OriginalBrowser.ToLower().Contains("iexplore"))
                btnIE.Focus();
            //else OriginalBrowser = "X";

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

        private void doDefault(string url) {
            if (OriginalBrowser == "") {
                MessageBox.Show("No default browser defined in the file default.browser.txt!");
                SaveToFile(EXEPath + "default.browser.txt", "");
                Process.Start(EXEPath + "default.browser.txt");
                return;
            }
            Process.Start(OriginalBrowser, URL);
            Application.Exit();
        }

        private string getOriginalBrowser() {
            return LoadFromFile(EXEPath + "default.browser.txt");
        }

        private string getSystemBrowser() {
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
            doDefault(tslabelURL.Tag.ToString());
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
            // Start default browser if Enter is pressed and no default is known
            if (e.KeyChar == (char)13 && OriginalBrowser == "X") {
                doDefault(tslabelURL.Tag.ToString());
            }
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e) {
            //MessageBox.Show("Help!");
            using (About box = new About()) {
                box.ShowDialog(this);
            }
        }

        private string LoadFromFile(string Filename) {
            try {
                StreamReader Reader = new StreamReader(Filename);
                string s = Reader.ReadToEnd();
                Reader.Close();
                return s;
            } catch (Exception e) {
                return "";
            }
        }

        private void SaveToFile(string filename, string data) {
            StreamWriter Writer = new StreamWriter(filename);
            Writer.Write(data);
            Writer.Close();
        }

    }
}
