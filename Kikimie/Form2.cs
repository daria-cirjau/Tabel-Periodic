using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelulPeriodic

{
    public partial class Form2 : Form
    {
        string pageurl;
        public Form2(string url)
        {
            pageurl = url;
            InitializeComponent();
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(pageurl);
        }
    }
}
