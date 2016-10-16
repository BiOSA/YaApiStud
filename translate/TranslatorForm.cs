using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;
using YandexLinguistics.NET;

namespace translate
{
    public partial class Form1 : Form
    {
        string ApiKey = "trnsl.1.1.20161008T083156Z.705f8e455aa7faa0.ddcd649ebb087c923ecc078fb69f6cdc56be59d2";
        Translator Trans;
        public Form1()
        {
            InitializeComponent();
            Trans = new Translator(ApiKey);
           
        }

        public void button1_Click(object sender, EventArgs e)
        {
            LangPair LP = new LangPair(Lang.En, Lang.Ru);
            textBox2.Text = "";
            textBox2.Text = Trans.Translate(textBox1.Text, LP).Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }
    }
}
