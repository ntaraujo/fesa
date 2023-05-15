using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_N2.Interfaces;

namespace Trabalho_N2.Classes
{
    internal class Navio : Veículos, Maritimos
    {
        public void Atracar(string Identificacao)
        {
            string mensagem = "Veículo " + Identificacao + " atracado.";
            MessageBox.Show(mensagem);
        }
    }
}
