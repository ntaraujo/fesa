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
    internal class AviaoDeGuerra : Veiculo, Ataque, Aereo
    {
        public void Arremeter()
        {
            MessageBox.Show("Veículo arremeteu.");
        }

        public void Ataque(string Identificacao)
        {
            string mensagem = "Veículo " + Identificacao + " atacou.";
            MessageBox.Show(mensagem);
        }

        public void Decolar()
        {
            MessageBox.Show("Veículo decolou.");
        }

        public void Ejetar()
        {
            MessageBox.Show("Piloto Ejetado");
        }

        public void Pousar()
        {
            MessageBox.Show("Veículo pousou.");
        }
    }
}
