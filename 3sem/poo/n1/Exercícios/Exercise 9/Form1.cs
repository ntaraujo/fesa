using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_9
{
    public partial class Form1 : Form
    {


        bool code = false, name = false, Rg = false, salary = false;
        int i = 0;
        Workers f = new Workers();
        List<Workers> workers = new List<Workers>(10);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            try
            {
                f.Id = Convert.ToInt32(txtCode.Text);
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
                f.Name = txtName.Text;
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
                f.Rg = txtRg.Text;
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
                f.Salary = Convert.ToDouble(txtSalary.Text);
                btnShow.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {
                workers.Add(f);
                lblShow.Text += "Id: " + workers[i].Id + "\n" +
                "Name: " + workers[i].Name + "\n" +
                "Rg: " + workers[i].Rg + "\n" +
                "Salary: " + workers[i].Salary + "\n";

                i++;
            }
            btnName.Enabled = false;
            btnRg.Enabled = false;
            btnSalary.Enabled = false;
            btnShow.Enabled = false;
        }
    }
}
