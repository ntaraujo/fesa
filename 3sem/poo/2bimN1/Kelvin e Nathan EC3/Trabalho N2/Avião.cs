using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_N2
{
    public partial class Avião : Form
    {
        public Avião()
        {
            InitializeComponent();
        }

        private void Avião_Load(object sender, EventArgs e)
        {

        }
        //variáveis necessárias

        /*Aviao aviao = new Aviao();
        aviao.Identificacao = "AV001";
        aviao.Modelo = new Modelo("Boeing", "737");
        aviao.VelocidadeAtual = 0;
        aviao.Peso = 50000.0f;
        aviao.CapacidadeDePassageiros = 150;*/

        //métodos necessários

        /*// Métodos da classe Veiculos
public virtual void Acelera(string Identificacao, int velocidade)
{
    string mensagem = "Veículo " + Identificacao + " foi acelerado em " + velocidade + " km/h.";
    MessageBox.Show(mensagem);
    VelocidadeAtual -= velocidade;
}

public virtual void Desacelera(string Identificacao, int velocidade)
{
    if (VelocidadeAtual > 0)
    {
        string mensagem = "Veículo " + Identificacao + " foi desacelerado em " + velocidade + " km/h.";
        MessageBox.Show(mensagem);
        VelocidadeAtual-= velocidade;
    }
}

// Métodos da classe Aviao
public void Arremeter()
{
    MessageBox.Show("O veículo arremeteu");
}

public void Decolar()
{
    MessageBox.Show("O veículo decolou");
}

public void LigaDesligaLimpador(string Identificacao, bool ligado)
{
    string mensagem = "Limpador do veículo " + Identificacao;
    if (ligado)
    {
        mensagem += " ligado.";
    }
    else
    {
        mensagem += " desligado.";
    }
    MessageBox.Show(mensagem);
}

public void Pousar()
{
    MessageBox.Show("Veículo pousou.");
}
*/

    }
}
