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
    public partial class FrmCheckedListBox : Form
    {
        public FrmCheckedListBox()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            string saida = "";

            foreach (string item in chlFrutas.CheckedItems)
            {
                saida += item + "\n";
            }

            MessageBox.Show(saida, "Frutas Preferidas");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
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

            chlFrutas.Items.Clear();

            var result = MessageBox.Show("Manter a lista original?",
                                         "Lista Original",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                chlFrutas.Items.AddRange(frutas.ToArray());
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtAdicionar.Text.Trim() != "")
            {
                chlFrutas.Items.Add(txtAdicionar.Text, false);
                txtAdicionar.Text = "";
                btnExibir.Focus();
            }
        }
    }
}
