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
    public partial class FrmCombobox : Form
    {
        public FrmCombobox()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cboFrutas.Text, "Fruta Preferida");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> frutas = new List<string>();
            frutas.Add("banana");
            frutas.Add("maçã");
            frutas.Add("laranja");
            frutas.Add("mamão");
            frutas.Add("manga");
            frutas.Add("açaí");
            frutas.Add("melancia");
            frutas.Add("tangerina");
            frutas.Add("abacaxi");
            frutas.Add("uva");

            cboFrutas.Items.Clear();
            cboFrutas.Text = "";
            txtFrutaPreferida.Text = "";
            var result = MessageBox.Show("Manter a lista original?",
                                         "Lista Original",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                cboFrutas.Items.AddRange(frutas.ToArray());
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            cboFrutas.Items.Add(txtFrutaPreferida.Text);
        }

        private void cboFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFrutaPreferida.Text = cboFrutas.Text;
        }

        private void txtFrutaPreferida_MouseClick(object sender, MouseEventArgs e)
        {
            txtFrutaPreferida.Text = "";
        }
    }
}
