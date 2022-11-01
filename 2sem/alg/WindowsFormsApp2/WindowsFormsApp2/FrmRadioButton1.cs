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
    public partial class FrmRadioButton : Form
    {
        public FrmRadioButton()
        {
            InitializeComponent();
        }

        private void rbtOutra_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtOutra.Checked)
            {
                txtOutraFruta.Visible = true;
                txtOutraFruta.Focus();
            } else
            {
                txtOutraFruta.Text = "";
                txtOutraFruta.Visible = false;
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            string saida = "";

            if (rbtBanana.Checked)
            {
                saida = rbtBanana.Text;
            }
            if (rbtMaca.Checked)
            {
                saida = rbtMaca.Text;
            }
            if (rbtLaranja.Checked)
            {
                saida = rbtLaranja.Text;
            }
            if (rbtMamao.Checked)
            {
                saida = rbtMamao.Text;
            }
            if (rbtManga.Checked)
            {
                saida = rbtManga.Text;
            }
            if (rbtAcai.Checked)
            {
                saida = rbtAcai.Text;
            }
            if (rbtMelancia.Checked)
            {
                saida = rbtMelancia.Text;
            }
            if (rbtTangerina.Checked)
            {
                saida = rbtTangerina.Text;
            }
            if (rbtAbacaxi.Checked)
            {
                saida = rbtAbacaxi.Text;
            }
            if (rbtUva.Checked)
            {
                saida = rbtUva.Text;
            }

            if (rbtOutra.Checked && txtOutraFruta.Text.Trim() != "")
            {
                saida = txtOutraFruta.Text;
            }

            if (saida != "")
            {
                MessageBox.Show(saida, "Fruta Preferida");
            }
        }
    }
}
