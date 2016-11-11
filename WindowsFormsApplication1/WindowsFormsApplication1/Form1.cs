using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string theText = textBox.Text;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox2.Text;
            webBrowser2.Navigate(url);
        }

        private void webBrowser2_DocumentCompleted(object sender,
           WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string theText = textBox.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = textBox3.Text;
            webBrowser3.Navigate(url);
        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed)
            {
                splitContainer1.Panel2Collapsed = false;
            }
            else
            {
                splitContainer1.Panel2Collapsed = true;
            }
        }
       

    }
}
