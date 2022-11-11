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
    public partial class FrmClass : Form
    {
        public FrmClass()
        {
            InitializeComponent();

            FormClosed += FrmClass_Closed;
        }

        private void FrmClass_Closed(object sender, FormClosedEventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
        }
    }
}
