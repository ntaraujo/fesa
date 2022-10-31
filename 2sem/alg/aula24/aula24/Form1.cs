using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exemplo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("1");
        }

        private void exemplo1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("2");
        }
    }
}
