using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Youtube Thumbnail Stealer
        // I could not find any software on the internet that does this, so i ended up making one. Can be useful.

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            string LOL = textBox1.Text.Substring(32);
            var cli = new WebClient();
            byte[] imgBytes = cli.DownloadData("https://i3.ytimg.com/vi/" + LOL + "/maxresdefault.jpg");
            File.WriteAllBytes(@"thumbnail.jpg", imgBytes);
            string AptitudeRocks = Directory.GetCurrentDirectory();
            MessageBox.Show("Success!\nSaved to: " + AptitudeRocks + "\\maxresdefault.jpg");
            Process.Start("thumbnail.jpg");
            }
            catch
            {
                MessageBox.Show("Failure!\nPlease Insert a Valid Link!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
