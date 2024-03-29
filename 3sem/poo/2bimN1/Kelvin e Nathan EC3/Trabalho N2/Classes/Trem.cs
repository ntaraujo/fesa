﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_N2.Interfaces;
using static Trabalho_N2.Classes.Veículos;

namespace Trabalho_N2.Classes
{
    internal class Trem : Veiculo, Fechados
    {
        public int QuantidadeDeVagoes { get; set; }

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
    }
}
