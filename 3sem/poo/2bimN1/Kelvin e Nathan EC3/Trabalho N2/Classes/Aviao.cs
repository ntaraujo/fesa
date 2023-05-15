using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_N2.Interfaces;

namespace Trabalho_N2.Classes
{
    internal class Aviao : Veículos, Interfaces.Aereo, Fechados
    {
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
    }
}
