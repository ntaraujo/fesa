using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            FrmClass frmClass = new FrmClass();
            frmClass.Show();
            this.Hide();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            FrmJogo frmJogo = new FrmJogo();
            frmJogo.Show();
            this.Hide();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
