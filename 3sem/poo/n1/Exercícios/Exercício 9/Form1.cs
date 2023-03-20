using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_9
{
    public partial class Form1 : Form
    {


        bool código = false, nome = false, RG = false, salário = false;
        int i = 0;
        Funcionários f = new Funcionários();
        List<Funcionários> funcionarios = new List<Funcionários>(10);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCódigo_Click(object sender, EventArgs e)
        {
            try
            {
                f.Id = Convert.ToInt32(txtCodigo.Text);
                btnName.Enabled = true;
            }
            catch (Exception errorr)
            {
                MessageBox.Show(errorr.Message);
            }
        }

        private void btnName_Click(object sender, EventArgs e)
        {

            try
            {
                f.Name = txtName.Text;
                btnRG.Enabled = true;
            }
            catch (Exception errorr)
            {
                MessageBox.Show(errorr.Message);
            }
        }

        private void btnRG_Click(object sender, EventArgs e)
        {

            try
            {
                f.Rg = txtRG.Text;
                btnSalário.Enabled = true;
            }
            catch (Exception errorr)
            {
                MessageBox.Show(errorr.Message);
            }
        }

        private void btnSalário_Click(object sender, EventArgs e)
        {

            try
            {
                f.Salario = Convert.ToDouble(txtSalario.Text);
                btnExibir.Enabled = true;
            }
            catch (Exception errorr)
            {
                MessageBox.Show(errorr.Message);
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {
                funcionarios.Add(f);
                lblExibir.Text += "ID: " + funcionarios[i].Id + "\n" +
                "NOME: " + funcionarios[i].Name + "\n" +
                "RG: " + funcionarios[i].Rg + "\n" +
                "Salário: " + funcionarios[i].Salario + "\n";

                i++;
            }
            btnName.Enabled = false;
            btnRG.Enabled = false;
            btnSalário.Enabled = false;
            btnExibir.Enabled = false;
        }
    }
}
