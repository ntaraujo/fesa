namespace Trabalho_N2.Interfaces
{
    internal interface Aereo
    {
        void Pousar();
        void Arremeter();
        void Decolar();
    }
    internal interface Ataque
    {
        void Ataque(string Identificação);
    }
    internal interface Fechados 
    {
        void LigaDesligaLimpador(string Identificacao, bool ligado) ;
    }
    internal interface Maritimos
    {
        void Atracar(string Identificacao);
    }
    internal interface Pesados : Fechados, Rodoviarios
    {
        int QuantidadeEixos { get; set; }
    }
    internal interface Rodoviarios 
    {
        void pagarPedagio();
    }
}

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
    internal class AviaoDeGuerra : Ataque, Aereo
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
    internal class Carro : Veiculo, Fechados, Rodoviarios
    {
        public int QuantidadePortas { get; set; }
        public bool VeiculoOficial { get; set; }

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
    internal class Marca
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
    }
    internal class Modelo
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public Marca Marca { get; set; }
    }
    internal class Navio : Veículos, Maritimos
    {
        public void Atracar(string Identificacao)
        {
            string mensagem = "Veículo " + Identificacao + " atracado.";
            MessageBox.Show(mensagem);
        }
    }
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
    internal class Onibus : Veiculo, Pesados
    {
        public bool Leito { get; set; }
        public int QuantidadeEixos { get; set; }

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
    internal class Trem : Veículos, Fechados
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