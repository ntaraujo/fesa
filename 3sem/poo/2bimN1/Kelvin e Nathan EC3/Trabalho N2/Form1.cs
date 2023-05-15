using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_N2.Classes;
using Trabalho_N2.Interfaces;

namespace Trabalho_N2
{
    public partial class Form1 : Form
    {
        private List<Veiculos.Veiculo> veiculos = new List<Veiculos.Veiculo>();
        private List<Marca> marcas = new List<Marca>();
        private List<Modelo> modelos = new List<Modelo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Instanciar automaticamente ao menos uma instância de cada veículo
            veiculos.Add(new Aviao());
            veiculos.Add(new AviaoDeGuerra());
            veiculos.Add(new Caminhao());
            veiculos.Add(new Carro());
            veiculos.Add(new Navio());
            veiculos.Add(new NavioDeGuerra());
            veiculos.Add(new Onibus());
            veiculos.Add(new Trem());
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Salvar os cadastros dos veículos, marcas e modelos no tipo JSON (sem usar bibliotecas externas)
            string jsonVeiculos = "[";
            foreach (var veiculo in veiculos)
            {
                jsonVeiculos += "{";
                jsonVeiculos += "\"Identificacao\":\"" + veiculo.Identificacao + "\",";
                jsonVeiculos += "\"Modelo\":{";
                jsonVeiculos += "\"Codigo\":" + veiculo.Modelo.Codigo + ",";
                jsonVeiculos += "\"Descricao\":\"" + veiculo.Modelo.Descricao + "\",";
                jsonVeiculos += "\"Marca\":{";
                jsonVeiculos += "\"Codigo\":" + veiculo.Modelo.Marca.Codigo + ",";
                jsonVeiculos += "\"Descricao\":\"" + veiculo.Modelo.Marca.Descricao + "\"";
                jsonVeiculos += "}";
                jsonVeiculos += "}";
                jsonVeiculos += "},";
            }
            jsonVeiculos = jsonVeiculos.TrimEnd(',') + "]";

            string jsonMarcas = "[";
            foreach (var marca in marcas)
            {
                jsonMarcas += "{";
                jsonMarcas += "\"Codigo\":" + marca.Codigo + ",";
                jsonMarcas += "\"Descricao\":\"" + marca.Descricao + "\"";
                jsonMarcas += "},";
            }
            jsonMarcas = jsonMarcas.TrimEnd(',') + "]";

            string jsonModelos = "[";
            foreach (var modelo in modelos)
            {
                jsonModelos += "{";
                jsonModelos += "\"Codigo\":" + modelo.Codigo + ",";
                jsonModelos += "\"Descricao\":\"" + modelo.Descricao + "\",";
                jsonModelos += "\"Marca\":{";
                jsonModelos += "\"Codigo\":" + modelo.Marca.Codigo + ",";
                jsonModelos += "\"Descricao\":\"" + modelo.Marca.Descricao + "\"";
                jsonModelos += "}";
                jsonModelos += "},";
            }
            jsonModelos = jsonModelos.TrimEnd(',') + "]";
        }

        private void btnLigaDesligaLimpador_Click(object sender, EventArgs e)
        {
            // Acione o limpador de todos os veículos
            foreach (var veiculo in veiculos.OfType<Fechados>())
            {
                veiculo.LigaDesligaLimpador(veiculo.Identificacao, true);
            }
        }

        private void btnAtracar_Click(object sender, EventArgs e)
        {
            // Atraque todos os navios
            foreach (var navio in veiculos.OfType<Maritimos>())
            {
                navio.Atracar(navio.Identificacao);
            }
        }

        private void btnAtaque_Click(object sender, EventArgs e)
        {
            // Ataque com todos os veículos
            foreach (var ataque in veiculos.OfType<Ataque>())
            {
                ataque.Ataque(ataque.Identificacao);
            }
        }

        private void btnEmpinar_Click(object sender, EventArgs e)
        {
            // Empine todos os veículos
            foreach (var aereo in veiculos.OfType<Aereo>())
            {
                aereo.Arremeter();
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            // Exibir todos os veículos
            string mensagem = "Veículos: \n";
            foreach (var veiculo in veiculos)
            {
                mensagem += veiculo.Identificacao + " - " + veiculo.Modelo.Descricao + "\n";
            }
            MessageBox.Show(mensagem);
        }
    }
}
