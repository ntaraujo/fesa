using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_N2.Classes
{
    internal class Veículos
    {
        public class Veiculo
        {
            public string Identificacao { get; set; }
            public Modelo Modelo { get; set; }
            public int VelocidadeAtual { get; set; }
            public float Peso { get; set; }
            public int CapacidadeDePassageiros { get; set; }

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
        }

    }
}
