using System;
using System.Windows.Forms;


namespace Joguinho
{
    public partial class FrmYouLost : Form
    {
        private int points;

        public FrmYouLost(int points, int rounds)
        {
            InitializeComponent();

            FormClosed += frmYouLost_Closed;
            txtNome.KeyUp += txtName_KeyUp;
            lblYouLost.Text = $"cor errada huashausha\nvocê fez {points} pontos em {rounds} rounds";
            this.points = points;   
        }

        private void frmYouLost_Closed(object sender, FormClosedEventArgs e)
        {
            new FrmJogo().Show();
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                new SavingPoints(txtNome.Text, points);
                e.Handled = true;
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            new SavingPoints(txtNome.Text, points);
            this.Close();
        }
    }
}
