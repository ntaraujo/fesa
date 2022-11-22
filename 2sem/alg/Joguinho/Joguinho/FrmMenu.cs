using System;
using System.Windows.Forms;

namespace Joguinho
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmClass().Show();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmJogo().Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
