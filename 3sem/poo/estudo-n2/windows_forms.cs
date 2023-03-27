public partial class Form1 : Form
{

    public Form1
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Botão clicado!");
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        label1.Text = "Texto digitado: " + textBox1.Text;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        this.BackColor = Color.Red;
        this.Width = 800;
        button1.Enabled = false;
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        MessageBox.Show("Fechando o formulário...");
    }
}