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
    public partial class FrmJogo : Form
    {
        public FrmJogo()
        {
            InitializeComponent();

            FormClosed += FrmJogo_Closed;
            
        }

        private void FrmJogo_Load(object sender, EventArgs e)
        {

        }

        private void FrmJogo_Closed(object sender, FormClosedEventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
        }
    }
}
