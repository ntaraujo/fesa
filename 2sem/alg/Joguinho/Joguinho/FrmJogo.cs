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
    public partial class FrmJogo : Form
    {
        private int timeWaitInit = 0;
        private Button[] buttons = new Button[4];
        private Color[] colors = new Color[4];
        private Color[] defaultColors = new Color[4];
        private Random random = new Random();
        private List<int> systemSequence = new List<int>();
        private List<int> playerSequence = new List<int>();
        private int round = 0;
        private bool lost = false;
        private int numSequence = 2;
        private int indexcheck = 0;

        public FrmJogo()
        {
            InitializeComponent();

            FormClosed += FrmJogo_Closed;
            
        }

        private void FrmJogo_Load(object sender, EventArgs e)
        {
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;

            colors[0] = Color.Red;
            colors[1] = Color.Green;
            colors[2] = Color.Blue;
            colors[3] = Color.Yellow;

            defaultColors[0] = Color.LightSalmon;
            defaultColors[1] = Color.LightGreen;
            defaultColors[2] = Color.LightBlue;
            defaultColors[3] = Color.LightYellow;
        }

        private void FrmJogo_Closed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["FrmMenu"].Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (round == 0)
            {
                systemRound();
            }
        }

        private void systemRound()
        {
            if (this.timeWaitInit < 500)
            {
                this.timeWaitInit += 100;
                defaultColorize();
            }
            else
            {
                this.timeWaitInit = 0;
                randomColorize();
            }
        }

        private void randomColorize()
        {
            int index = random.Next(4);

            buttons[index].BackColor = colors[index];

            systemSequence.Add(index);
            
        }

        private void defaultColorize()
        {
            for (int i = 0; i < 4; i++)
            {
                buttons[i].BackColor = defaultColors[i];
            }

            if (systemSequence.Count == numSequence)
            {
                round = 1;
            }
        }
        private void playerSequenceCheck()
        {

            if (playerSequence[indexcheck] == systemSequence[indexcheck])
            {
                indexcheck++;
                
            }
            else
            {
                frmYouLost frmYouLost = new frmYouLost();
                frmYouLost.Show();
                lost = true;
                this.Hide();
            }

            if (playerSequence.Count == numSequence)
            {
                numSequence++;
                round = 0;
                indexcheck = 0;
                systemSequence.Clear();
                playerSequence.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerSequence.Add(0);
            playerSequenceCheck();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerSequence.Add(1);
            playerSequenceCheck();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerSequence.Add(2);
            playerSequenceCheck();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            playerSequence.Add(3);
            playerSequenceCheck();
        }
    }
}
