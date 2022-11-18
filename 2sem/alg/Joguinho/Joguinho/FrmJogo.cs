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
        private int points = 0;

        public FrmJogo()
        {
            InitializeComponent();

            FormClosed += FrmJogo_Closed;
            button1.MouseDown += new System.Windows.Forms.MouseEventHandler(button1_Down);
            button1.MouseUp += new System.Windows.Forms.MouseEventHandler(button1_Up);
            button2.MouseDown += new System.Windows.Forms.MouseEventHandler(button2_Down);
            button2.MouseUp += new System.Windows.Forms.MouseEventHandler(button2_Up);
            button3.MouseDown += new System.Windows.Forms.MouseEventHandler(button3_Down);
            button3.MouseUp += new System.Windows.Forms.MouseEventHandler(button3_Up);
            button4.MouseDown += new System.Windows.Forms.MouseEventHandler(button4_Down);
            button4.MouseUp += new System.Windows.Forms.MouseEventHandler(button4_Up);

        }

        private void button1_Down(object sender, EventArgs e)
        {
            buttons[0].BackColor = colors[0];
        }
        private void button1_Up(object sender, EventArgs e)
        {
            buttons[0].BackColor = defaultColors[0];
        }
        private void button2_Down(object sender, EventArgs e)
        {
            buttons[1].BackColor = colors[1];
        }
        private void button2_Up(object sender, EventArgs e)
        {
            buttons[1].BackColor = defaultColors[1];
        }
        private void button3_Down(object sender, EventArgs e)
        {
            buttons[2].BackColor = colors[2];
        }
        private void button3_Up(object sender, EventArgs e)
        {
            buttons[2].BackColor = defaultColors[2];
        }
        private void button4_Down(object sender, EventArgs e)
        {
            buttons[3].BackColor = colors[3];
        }
        private void button4_Up(object sender, EventArgs e)
        {
            buttons[3].BackColor = defaultColors[3];
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
            if (lost)
            {
                new frmYouLost().Show();
            }
            else
            {
                Application.OpenForms["FrmMenu"].Show();
            }
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
                points += 10;
                label1.Text = $"{points} - round: {numSequence - 1}";
            }
            else
            {
                lost = true;
                this.Close();
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
