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
    public partial class FrmDateTimePicker2 : Form
    {
        public FrmDateTimePicker2()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            txtData.Text = dtpData.Text;
            txtDia.Text = dtpData.Value.Day.ToString();
            txtMes.Text = dtpData.Value.Month.ToString();
            txtAno.Text = dtpData.Value.Year.ToString();
        }

        private void btnDefinir_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int ano = int.Parse(txtAno.Text);
            DateTime date = new DateTime(ano, mes, dia);
            dtpData.Value = date;
            txtData.Text = dtpData.Text;
        }

        private void btnHoje_Click(object sender, EventArgs e)
        {
            dtpData.Value = DateTime.Now;
            txtData.Text = dtpData.Text;
            txtDia.Text = dtpData.Value.Day.ToString();
            txtMes.Text = dtpData.Value.Month.ToString();
            txtAno.Text = dtpData.Value.Year.ToString();
        }

        private void FrmDateTimePicker_Load(object sender, EventArgs e)
        {
            dtpData.Format = DateTimePickerFormat.Custom;
            dtpData.CustomFormat = "'São Bernardo do Campo', dddd, dd 'de' MMM 'de' yyyy";
        }
    }
}
