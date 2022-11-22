using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joguinho
{
    public partial class FrmClass : Form
    {
        public FrmClass()
        {
            InitializeComponent();

            FormClosed += FrmClass_Closed;
            orderingClassification ordering = new orderingClassification();
            Dictionary<string, double> classDict = ordering.getDict();

            int i = 0;
            foreach (KeyValuePair<string, double> entrada in classDict)
            {
                i++;
                listBox1.Items.Add($"{entrada.Key.Split(':')[1]} - {entrada.Value}");
                if (i == 10) break;
            }
        }

        private void FrmClass_Closed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["FrmMenu"].Show();
        }
    }
}
