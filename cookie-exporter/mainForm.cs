using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cookie_exporter
{
    public partial class mainForm : Form
    {
        private IWebDriver _driver;
        public mainForm()
        {
            InitializeComponent();
        }

        #region events
        private void btnStart_Click(object sender, EventArgs e)
        {
            var text = btnStart.Text;
            if (text == "Start") start();
            else stop();
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            export();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            import();
        }
        private void btnDeleteCookies_Click(object sender, EventArgs e)
        {
            delete_all_cookies();
        }
        #endregion

        #region main
        private void start()
        {
            // UI init
            bool is_chrome = radioChrome.Checked;
            btnStart.Text = "Stop";
            groupExport.Enabled = true;
            btnDeleteCookies.Enabled = true;

            // start driver
            if (is_chrome) this._driver = new ChromeDriver();
            else this._driver = new FirefoxDriver();
        }
        private void stop()
        {
            // UI init
            btnStart.Text = "Start";
            groupExport.Enabled = false;
            btnDeleteCookies.Enabled = false;

            // dispose browser (if not null)
            if(this._driver != null)
            {
                try
                {
                    this._driver.Dispose();
                }
                catch { }
            }
        }
        private void export()
        {
            string filename = txtCookies.Text;
            // check if filename was given
            if (string.IsNullOrWhiteSpace(filename))
            {
                MessageBox.Show("Type a filename first");
                return;
            }
            export_cookies(filename);
            MessageBox.Show(string.Format("Cookies exported to {0}", filename));
        }
        private void import()
        {
            string filename = txtImport.Text;
            // check if file was given
            if (string.IsNullOrWhiteSpace(filename))
            {
                MessageBox.Show("Type a filename first");
                return;
            }
            // check if file exists
            if(!File.Exists(filename))
            {
                MessageBox.Show(string.Format("{0} does not exist", filename));
                return;
            }
            int imported = import_cookies(filename);
            MessageBox.Show(string.Format("{0} cookie/s imported", imported));
        }
        private void delete_all_cookies()
        {
            if (this._driver == null) return;
            this._driver.Manage().Cookies.DeleteAllCookies();       // clear all cookies
            MessageBox.Show("Cookies cleared");
        }
        #endregion

        #region cookie handling
        private void export_cookies(string filename)
        {
            // Open streamwriter for writing to file
            using (StreamWriter wr = new StreamWriter(filename))
            {
                foreach (var cookie in this._driver.Manage().Cookies.AllCookies)
                {
                    // create cookie "line" with a custom format (we'll split by this when importing)
                    var c = string.Format("{0};;_^_;;{1};;_^_;;{2};;_^_;;{3};;_^_;;{4};;_^_;;{5}", 
                        cookie.Name, cookie.Value, cookie.Domain, cookie.Path, cookie.Expiry, cookie.IsHttpOnly);
                    wr.WriteLine(c);
                }
            }
        }
        private int import_cookies(string filename)
        {
            int imported = 0;
            string last_domain = "";
            
            // start reading from file
            using (StreamReader wr = new StreamReader(filename))
            {
                string line = "";
                while (wr.Peek() >= 0)
                {
                    // line by line
                    line = wr.ReadLine();
                    
                    // split it by our delimiter
                    var s = line.Split(new string[] { ";;_^_;;" }, StringSplitOptions.None);
                    // if no date given, set it to somewhere in the future
                    if (string.IsNullOrWhiteSpace(s[4])) s[4] = "05/01/2030";    

                    // create cookie from string/s
                    Cookie c = new Cookie(s[0], s[1], s[2], s[3], Convert.ToDateTime(s[4]));
                    
                    // IMPORTANT
                    // ---------
                    // go to domain, if not already there
                    // otherwise, import / adding the cookie will throw an error
                    if (!this._driver.Url.Contains(c.Domain))
                        this._driver.Navigate().GoToUrl(c.Domain.StartsWith("http") ? c.Domain : "http://" + c.Domain);
                    this._driver.Manage().Cookies.AddCookie(c);     // add cookie to browser
                    imported++;                                     // keep a counter
                    last_domain = this._driver.Url;                 // use it to go to it, once all imported, so we're logged in (eventually)
                }
            }
            this._driver.Navigate().GoToUrl(last_domain);       // go to last domain
            return imported;
        }
        #endregion
    }
}
