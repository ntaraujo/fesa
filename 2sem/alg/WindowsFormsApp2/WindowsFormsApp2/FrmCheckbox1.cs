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
    public partial class FrmCheckbox1 : Form
    {
        public FrmCheckbox1()
        {
            InitializeComponent();
            CheckBox c;
        }

        private void chkOutraFruta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOutraFruta.Checked)
            {
                txtOutraFruta.Visible = true;
                txtOutraFruta.Focus();
            }
            else
            {
                txtOutraFruta.Visible=false;
                txtOutraFruta.Text = null;  
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string saida = "";


            if (chkBanana.Checked)
            {
                saida += chkBanana.Text + "\n";
            }
            if (chkMaca.Checked)
            {
                saida += chkMaca.Text + "\n";
            }
            if (chkLaranja.Checked)
            {
                saida += chkLaranja.Text + "\n";
            }
            if (chkMamao.Checked)
            {
                saida += chkMamao.Text + "\n";
            }
            if (chkManga.Checked)
            {
                saida += chkManga.Text + "\n";
            }
            if (chkAcai.Checked)
            {
                saida += chkAcai.Text + "\n";
            }
            if (chkMelancia.Checked)
            {
                saida += chkMelancia.Text + "\n";
            }
            if (chkTangerina.Checked)
            {
                saida += chkTangerina.Text + "\n";
            }
            if (chkAbacaxi.Checked)
            {
                saida += chkAbacaxi.Text + "\n";
            }
            if (chkUva.Checked)
            {
                saida += chkUva.Text + "\n";
            }
            if (chkOutraFruta.Checked)
            {
                saida += txtOutraFruta.Text;
            }
            MessageBox.Show(saida, "Frutas preferidas");
        }
    }
}
