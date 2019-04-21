using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.IO;
using System.Media;

namespace Base64Tool
{
    public partial class History : MaterialForm
    {
       
        public History()
        {
            InitializeComponent();
            string[] hString = File.ReadAllLines("history.txt");
            for (int i = 0; i < hString.Length; i++)
            {
                listBox1.Items.Add(hString[i]);
            }
            var h = "";
        }
        private void History_Load(object sender, EventArgs e)
        {
            
        }

        private void MaterialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && !String.IsNullOrWhiteSpace(listBox1.SelectedItem.ToString()))
            {
                Clipboard.SetText(listBox1.SelectedItem.ToString());
                SystemSounds.Beep.Play();
                MessageBox.Show("Item Copied to clipboard!");
            }
        }

        private void ClearHistory_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> list = new List<string>();
            File.WriteAllLines("history.txt", list.ToArray());
        }

        private void GetTitle_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (Base64C.IsValidUri(listBox1.SelectedItem.ToString()))
                {
                    WebClient x = new WebClient();
                    string source = x.DownloadString(listBox1.SelectedItem.ToString());
                    string title = Regex.Match(source, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>",
                        RegexOptions.IgnoreCase).Groups["Title"].Value;
                    MessageBox.Show(title);
                }
                else
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("That is not a valid url!");
                }
            }
        }
    }
}
