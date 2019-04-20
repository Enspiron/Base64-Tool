using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Base64Tool
{
    public partial class Main : MaterialForm
    {
        public string web;

        static void AddToHistory(string add)
        {
            List<string> hList = File.ReadAllLines("history.txt").ToList();
            hList.Add(add);
            File.WriteAllLines("history.txt", hList.ToArray());
        }

        public Main()
        {
            InitializeComponent();
            if (!File.Exists("history.txt"))
            {
                File.Create("history.txt");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void V_Click(object sender, EventArgs e)
        {
            NEW.Text = Base64.Decode(OG.Text);
            AddToHistory(NEW.Text);
        }

        private void Encode_Click(object sender, EventArgs e)
        {
            NEW.Text = Base64.Encode(OG.Text);
            AddToHistory(OG.Text);
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            var oldT = NEW.Text;
            var newT = OG.Text;
            NEW.Text = newT;
            OG.Text = oldT;
        }

        private void MaterialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(NEW.Text))
            {
                WebClient x = new WebClient();
                string source = x.DownloadString(NEW.Text);
                string title = Regex.Match(source, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>",
                    RegexOptions.IgnoreCase).Groups["Title"].Value;

                Site site = new Site(title, NEW.Text);
                site.Show();
            }
        }

      

        private void Timer1_Tick(object sender, EventArgs e)
        {
            web = NEW.Text;
        }

        private void MaterialRaisedButton3_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void CopyOutput_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(NEW.Text))
            Clipboard.SetText(NEW.Text);
        }
    }
}
