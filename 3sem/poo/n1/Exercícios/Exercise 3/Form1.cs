using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        bool code = false, name = false, Rg = false, salary = false;
        int i = 0;
        
        Workers f = new Workers();
        List<Workers> workers = new List<Workers>();
        private void btnCode_Click(object sender, EventArgs e)
        {
            try
            {
                f.setId(Convert.ToInt32(txtCode.Text));
                btnName.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }
        private void btnName_Click(object sender, EventArgs e)
        {
            try
            {
                f.SetName(txtName.Text);
                btnRg.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }
        private void btnRg_Click(object sender, EventArgs e)
        {
           
            try
            {
                f.setRg(txtRg.Text);
                btnSalary.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }
        private void btnSalary_Click(object sender, EventArgs e)
        {
            try
            {
                f.setSalary(Convert.ToDouble(txtSalary.Text));
                btnShow.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void lblShow_Click(object sender, EventArgs e)
        {

        }

        private void lblSalary_Click(object sender, EventArgs e)
        {

        }

        private void lblRg_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblCode_Click(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            workers.Add(f);
            lblShow.Text += "Id: " + workers[i].getId() + "\n" +
            "Name: " + workers[i].GetName() + "\n" +
            "Rg: " + workers[i].getRg() + "\n" +
            "Salary: " + workers[i].getSalary() + "\n";
            i++;
            btnName.Enabled = false;
            btnRg.Enabled = false;
            btnSalary.Enabled = false;
            btnShow.Enabled = false;


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
