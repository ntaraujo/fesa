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
    public partial class FrmRadioButton2 : Form
    {
        List<RadioButton> frutas = new List<RadioButton>();
        List<RadioButton> bebidas = new List<RadioButton>();

        public FrmRadioButton2()
        {
            InitializeComponent();
            
            frutas.Add(rbtBanana);
            frutas.Add(rbtBanana);
            frutas.Add(rbtBanana);
            frutas.Add(rbtMaca);
            frutas.Add(rbtLaranja);
            frutas.Add(rbtMamao);
            frutas.Add(rbtManga);
            frutas.Add(rbtAcai);
            frutas.Add(rbtMelancia);
            frutas.Add(rbtTangerina);
            frutas.Add(rbtAbacaxi);
            frutas.Add(rbtUva);

            bebidas.Add(rbtAgua);
            bebidas.Add(rbtAguaAromatizada);
            bebidas.Add(rbtCafe);
            bebidas.Add(rbtCha);
            bebidas.Add(rbtSuco);
            bebidas.Add(rbtBatida);
            bebidas.Add(rbtAguaCoco);
            bebidas.Add(rbtSmoothies);
            bebidas.Add(rbtCaldoCana);
            bebidas.Add(rbtLimonada);
        }

        private void rbtOutraFruta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtOutraFruta.Checked)
            {
                txtOutraFruta.Visible = true;
                txtOutraFruta.Focus();
            } else
            {
                txtOutraFruta.Visible = false;
                txtOutraFruta.Text = "";
            }
        }

        private void rbtOutraBebida_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtOutraBebida.Checked)
            {
                txtOutraBebida.Visible = true;
                txtOutraFruta.Focus();
            }
            else
            {
                txtOutraBebida.Visible = false;
                txtOutraBebida.Text = "";
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            string saida = "";
            foreach (RadioButton fruta in frutas)
            {
                if (fruta.Checked)
                {
                    saida = "fruta: " + fruta.Text + "\n";
                }
            }

            if (rbtOutraFruta.Checked && txtOutraFruta.Text.Trim() != "")
            {
                saida = "fruta: " + txtOutraFruta.Text.Trim() + "\n";
            }

            foreach (RadioButton bebida in bebidas)
            {
                if (bebida.Checked)
                {
                    saida += "bebida: " + bebida.Text;
                }
            }

            if (rbtOutraBebida.Checked && txtOutraFruta.Text.Trim() != "")
            {
                saida = "bebida: " + txtOutraBebida.Text.Trim();
            }

            if (saida != "")
            {
                MessageBox.Show(saida, "Fruta e Bebida Preferidas");
            }
        }
    }
 }
