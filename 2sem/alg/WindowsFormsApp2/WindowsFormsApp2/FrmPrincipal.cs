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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void exemplo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCheckbox1 frmCheckbox1 = new FrmCheckbox1();
            frmCheckbox1.ShowDialog();
        }

        private void exemplo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCheckbox2 frmCheckbox2 = new FrmCheckbox2();
            frmCheckbox2.ShowDialog();  

        }

        private void checkdListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCheckedListBox frmCheckedListBox = new FrmCheckedListBox();
            frmCheckedListBox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCombobox frmCombobox = new FrmCombobox();
            frmCombobox.ShowDialog();
        }

        private void exemplo1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRadioButton frmRadioButton1 = new FrmRadioButton();
            frmRadioButton1.ShowDialog();
        }

        private void exemplo2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRadioButton2 frmRadioButton2 = new FrmRadioButton2();
            frmRadioButton2.ShowDialog();
        }

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLinkLabel frmlinkLabel = new FrmLinkLabel();
            frmlinkLabel.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListView frmListView = new FrmListView();
            frmListView.ShowDialog();
        }

        private void exemplo1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmDateTimePicker1 frmDataTimePicker1 = new FrmDateTimePicker1();
            frmDataTimePicker1.ShowDialog();
        }

        private void exemplo2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmDateTimePicker2 frmDataTimePicker2 = new FrmDateTimePicker2();
            frmDataTimePicker2.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListBox frmListBox = new FrmListBox();
            frmListBox.ShowDialog();
        }
    }
}
