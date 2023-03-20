using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_4
{
    public partial class Form1 : Form
    {

        bool código = false, nome = false, RG = false, salário = false;
        int i = 0;
        Funcionários f = new Funcionários();
        List<Funcionários> funcionarios = new List<Funcionários>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCódigo_Click(object sender, EventArgs e)
        {
            try
            {
                f.Id = Convert.ToInt32(txtCodigo.Text);
                btnNome.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            try
            {
                f.Nome = txtNome.Text;
                btnRG.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnRG_Click(object sender, EventArgs e)
        {
            try
            {
                f.Rg = txtRG.Text;
                btnSalário.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnSalário_Click(object sender, EventArgs e)
        {
            try
            {
                f.Salario = Convert.ToDouble(txtSalario.Text);
                btnExibir.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            funcionarios.Add(f);
            lblExibir.Text += "ID: " + funcionarios[i].Id + "\n" +
            "NOME: " + funcionarios[i].Nome + "\n" +
            "RG: " + funcionarios[i].Rg + "\n" +
            "Salário: " + funcionarios[i].Salario + "\n";
            i++;
            btnNome.Enabled = false;
            btnRG.Enabled = false;
            btnSalário.Enabled = false;
            btnExibir.Enabled = false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
