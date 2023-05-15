using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_N2.Interfaces;
using static Trabalho_N2.Classes.Veículos;


namespace Trabalho_N2.Classes
{
    internal class Caminhao : Veiculo, Pesados
    {
        public double PesoCarregado { get; set; }
        public double CapacidadeMaxima { get; set; }
        public int QuantidadeEixos { get; set; }

        public void Carregar(double peso)
        {
            if (PesoCarregado + peso > CapacidadeMaxima)
            {
                throw new Exception("Capacidade máxima de carga excedida.");
            }
            PesoCarregado += peso;
        }

        public void Descarregar(double peso)
        {
            PesoCarregado -= peso;
        }

        public override void Acelera(string Identificacao, int velocidade)
        {
            if (VelocidadeAtual < 0 || VelocidadeAtual >= 120)
            {
                throw new Exception("A velocidade está fora do limite permitido.");
            }
            if (PesoCarregado > CapacidadeMaxima)
            {
                throw new Exception("Capacidade máxima de carga excedida.");
            }
            VelocidadeAtual++;
        }

        public override void Desacelera(string Identificacao, int velocidade)
        {
            if (VelocidadeAtual <= 0)
            {
                throw new Exception("O veículo já está parado.");
            }
            VelocidadeAtual--;
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

        public void pagarPedagio()
        {
            throw new NotImplementedException();
        }
    }
}
