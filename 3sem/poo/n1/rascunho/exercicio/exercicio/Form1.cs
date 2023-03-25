using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio
{
    public partial class Form1 : Form
    {
        private List<Jogo> jogos = new List<Jogo>();

        public Form1()
        {
            InitializeComponent();
            cbCategoria.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jogos.Count >= 10)
            {
                MessageBox.Show("Não é possível cadastrar mais jogos.");
                return;
            }

            Jogo jogo = new Jogo();

            int codigo;
            if (!int.TryParse(txtCodigo.Text, out codigo) || codigo <= 0)
            {
                MessageBox.Show("Código inválido.");
                return;
            }
            jogo.Codigo = codigo;

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório.");
                return;
            }
            jogo.Nome = txtNome.Text;

            string categoria = cbCategoria.SelectedItem.ToString();
            if (categoria != "Ação" && categoria != "Luta" && categoria != "Tiro" && categoria != "Esportes")
            {
                MessageBox.Show("Categoria inválida.");
                return;
            }
            jogo.Categoria = categoria;

            DateTime dataLancamento;
            if (!DateTime.TryParse(dtpDataLancamento.Text, out dataLancamento) || dataLancamento > DateTime.Now)
            {
                MessageBox.Show("Data de lançamento inválida.");
                return;
            }
            jogo.DataLancamento = dataLancamento;

            jogos.Add(jogo);

            MessageBox.Show("Jogo cadastrado com sucesso.");

            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            cbCategoria.SelectedIndex = 0;
            dtpDataLancamento.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dados = "";
            foreach (Jogo jogo in jogos)
            {
                dados += $"Código: {jogo.Codigo}\nNome: {jogo.Nome}\nCategoria: {jogo.Categoria}\nData de Lançamento: {jogo.DataLancamento}\n\n";
            }

            MessageBox.Show(dados);
        }
    }

    public class Jogo
    {
        private int codigo;
        private string nome;
        private string categoria;
        private DateTime dataLancamento;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value > 0 ? value : 0; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = !string.IsNullOrWhiteSpace(value) ? value : ""; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value == "Ação" || value == "Luta" || value == "Tiro" || value == "Esportes" ? value : ""; }
        }

        public DateTime DataLancamento
        {
            get { return dataLancamento; }
            set { dataLancamento = value < DateTime.Now ? value : DateTime.Now; }
        }
    }
}
