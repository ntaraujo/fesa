using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício3
{
    public partial class Form1 : Form
    {
        bool código = false, nome = false, RG = false, salário = false;
        int i = 0;
        
        Funcionários f = new Funcionários();
        List<Funcionários> funcionarios = new List<Funcionários>();
        private void btnCódigo_Click(object sender, EventArgs e)
        {
            try
            {
                f.setId(Convert.ToInt32(txtCodigo.Text));
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
                f.setNome(txtNome.Text);
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
                f.setRg(txtRG.Text);
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
                f.setSalario(Convert.ToDouble(txtSalario.Text));
                btnExibir.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void lblExibir_Click(object sender, EventArgs e)
        {

        }

        private void lblSalario_Click(object sender, EventArgs e)
        {

        }

        private void lblRG_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            funcionarios.Add(f);
            lblExibir.Text += "ID: " + funcionarios[i].getId() + "\n" +
            "NOME: " + funcionarios[i].getNome() + "\n" +
            "RG: " + funcionarios[i].getRg() + "\n" +
            "Salário: " + funcionarios[i].getSalário() + "\n";
            i++;
            btnNome.Enabled = false;
            btnRG.Enabled = false;
            btnSalário.Enabled = false;
            btnExibir.Enabled = false;


        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



    }
}
