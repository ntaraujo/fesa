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
    public partial class FrmCheckbox2 : Form
    {

        private List<CheckBox> frutas = new List<CheckBox>();

        public FrmCheckbox2()
        {
            InitializeComponent();
            frutas.Add(chkBanana2);
            frutas.Add(chkMaca2);
            frutas.Add(chkLaranja2);
            frutas.Add(chkMamao2);
            frutas.Add(chkManga2);
            frutas.Add(chkAcai2);
            frutas.Add(chkMelancia2);
            frutas.Add(chkTangerina2);
            frutas.Add(chkAbacaxi2);
            frutas.Add(chkUva2);            
        }

        private void chkOutraFruta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOutraFruta2.Checked)
            {
                txtOutraFruta2.Visible = true;
                txtOutraFruta2.Focus();
            }
            else
            {
                txtOutraFruta2.Visible=false;
                txtOutraFruta2.Text = null;  
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string saida = "";


            foreach (CheckBox fruta in frutas)
            {
                if (fruta.Checked)
                {
                    saida += fruta.Text + "\n";
                }
            }
            if (chkOutraFruta2.Checked)
            {
                saida += txtOutraFruta2.Text;
            }
            MessageBox.Show(saida, "Frutas preferidas");
        }
    }
}
