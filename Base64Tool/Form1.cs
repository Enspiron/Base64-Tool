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
using System.Media;

namespace Base64Tool
{
    public partial class Main : MaterialForm
    {
        //(s.Length % 4 == 0) && Regex.IsMatch(s, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None)
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
            if (!String.IsNullOrWhiteSpace(OG.Text))
            {
                if (Base64C.IsBase64String(OG.Text))
                {
                    NEW.Text = Base64C.Decode(OG.Text);
                    AddToHistory(NEW.Text);
                }
                else
                {
                    MessageBox.Show("That is not a base64 string!");
                }
            }
        }

        private void Encode_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(OG.Text))
            {
                NEW.Text = Base64C.Encode(OG.Text);
                AddToHistory(OG.Text);
            }
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(OG.Text) || !String.IsNullOrWhiteSpace(NEW.Text))
            {
                var oldT = NEW.Text;
                var newT = OG.Text;
                NEW.Text = newT;
                OG.Text = oldT;
            }
        }

        private void MaterialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(NEW.Text))
            {
                if (Base64C.IsValidUri(NEW.Text))
                {
                    if (Base64C.CheckReachableSite(NEW.Text))
                    {
                        WebClient x = new WebClient();
                        string source = x.DownloadString($"{NEW.Text}");
                        string title = Regex.Match(source, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>",
                            RegexOptions.IgnoreCase).Groups["Title"].Value;

                        Site site = new Site(title, NEW.Text);
                        site.Show();
                    }
                    else
                    {
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Site does not exist!");
                    }
                }
                else
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("That is not a valid url!");
                }
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

        private void PDC_Click(object sender, EventArgs e)
        {
            //Paste, Decode, Copy
            if (!String.IsNullOrWhiteSpace(Clipboard.GetText()))
            {
                if (Base64C.IsBase64String(Clipboard.GetText()))
                {
                    OG.Text = Clipboard.GetText();
                    NEW.Text = Base64C.Decode(Clipboard.GetText());
                    Clipboard.SetText(NEW.Text);
                    AddToHistory(NEW.Text);
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("That is not a base64 string!");
                }
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("That is not some text!");
            }
        }

        private void PEC_Click(object sender, EventArgs e)
        {
            //Paste, Encode, Copy
            if (!String.IsNullOrWhiteSpace(Clipboard.GetText()))
            {
                OG.Text = Clipboard.GetText();
                NEW.Text = Base64C.Encode(Clipboard.GetText());
                Clipboard.SetText(NEW.Text);
                AddToHistory(NEW.Text);
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("That is not some text!");
            }
        }

        private void ClearNEW_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(NEW.Text))
            {
                NEW.Clear();
            }
        }

        private void ClearOG_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(OG.Text))
            {
                OG.Clear();
            }
        }
    }
}
