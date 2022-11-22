using System.Collections.Generic;
using System.Windows.Forms;

namespace Joguinho
{
    public partial class FrmClass : Form
    {
        public FrmClass()
        {
            InitializeComponent();

            FormClosed += FrmClass_Closed;

            int i = 0;
            foreach (KeyValuePair<string, double> entrada in new orderingClassification().dict)
            {
                i++;
                boxTop10.Items.Add($"{entrada.Key.Split(':')[1]} - {entrada.Value}");
                if (i == 10) break;
            }
        }

        private void FrmClass_Closed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["FrmMenu"].Show();
        }
    }
}
