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
    public partial class frmYouLost : Form
    {
        public frmYouLost()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmYouLost_Closed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["FrmJogo"].Show();
        }
    }
}
