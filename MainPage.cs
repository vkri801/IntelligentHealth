using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Intelligent_Health
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("http://nanostring-public-share.s3-website-us-west-2.amazonaws.com/GeoScriptHub/KidneyDataset/Kidney_Sample_Annotations.txt");
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadToEnd();

            richTextBox1.Text = content;
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
