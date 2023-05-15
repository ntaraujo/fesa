using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_N2.Interfaces;

namespace Trabalho_N2.Classes
{
    internal class NavioDeGuerra : Veículos, Maritimos, Ataque
    {
        public void Ataque(string Identificacao)
        {
            string mensagem = "Veículo " + Identificacao + " atacou.";
            MessageBox.Show(mensagem);
        }

        public void Atracar(string Identificacao)
        {
            string mensagem = "Veículo " + Identificacao + " atracado.";
            MessageBox.Show(mensagem);
        }
    }
}
