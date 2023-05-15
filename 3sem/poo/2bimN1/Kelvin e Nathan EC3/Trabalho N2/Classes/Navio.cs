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
    internal class Navio : Veículo, Maritimos
    {
        public void Atracar(string Identificacao)
        {
            string mensagem = "Veículo " + Identificacao + " atracado.";
            MessageBox.Show(mensagem);
        }
    }
}
