using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FrmLinkLabel : Form
    {
        public FrmLinkLabel()
        {
            InitializeComponent();
            //TIOBE - REMOTERS - REMOTAR - W3SCHOOLS
            lblDiversos.Links.Add(0, 5, "https://www.tiobe.com/tiobe-index/");
            lblDiversos.Links.Add(8, 8, "https://remoters.net/jobs/software-development/");
            lblDiversos.Links.Add(19, 7, "https://remotar.com.br/job-type/vaga-internacional/");
            lblDiversos.Links.Add(29, 9, "https://www.w3schools.com/");

            lblDiversos.Links[2].Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtConteudo.Text);
        }

        private void lklFesa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://faculdadesalvadorarena.org.br/");
            LinkLabel linkLabel = (LinkLabel) sender;
            linkLabel.LinkVisited = true;

        }

        private void lklCalculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void lklPaint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com/custom?q=" + txtConteudo.Text);
        }

        private void lblDiversos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }
    }
}
