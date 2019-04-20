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
        }

        private void History_Load(object sender, EventArgs e)
        {
            
        }

        private void MaterialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listBox1.SelectedItem.ToString());
        }
    }
}
