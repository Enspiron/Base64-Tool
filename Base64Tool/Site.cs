using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using System.Windows.Forms.VisualStyles;

namespace Base64Tool
{
    public partial class Site : MaterialForm
    {
        //public Uri url;
        public Site(string title, string newT)
        {
            InitializeComponent();
            this.Text = title;
            Uri url = new Uri($"{newT}", UriKind.Absolute);
            webBrowser1.Url = url;
        }

        private void Site_Load(object sender, EventArgs e)
        {
        }
    }
}
