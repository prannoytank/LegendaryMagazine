using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroUiTest
{
    public partial class web : MetroForm
    {
        private string nav;
        private string title="WEB";
        public web(string navVal,string titless)
        {
            InitializeComponent();
            nav = navVal;
            this.title = titless;
        }

        private void web_Load(object sender, EventArgs e)
        {
            this.Text = title;
            webBrowser1.Navigate(nav);
            toolStripTextBox1.Text = nav;
            webBrowser1.ScriptErrorsSuppressed = true;
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                toolStripProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);
                toolStripProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
