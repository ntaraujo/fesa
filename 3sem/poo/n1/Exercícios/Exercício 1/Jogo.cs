using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    class Jogo
    {
        private int código;
        private string nome;
        private string categoria;
        private DateTime data_de_lançamento;

        public int GetCódigo() => código;
        public void SetCódigo(int código)
        {
            if (código <= 0)
            {
                throw new Exception("Código não pode ser menor que 0 (zero)");
            }
            else
            {
                this.código = código;
            }
        }
        public string GetNome() => nome;
        public void SetNome(string nome) 
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome não pode estar vazio");
            }
            else
            {
                this.nome = nome;
            }
        }
        public string GetCategoria() => categoria;
        public void SetCategoria(string categoria)
        {
            if (string.IsNullOrEmpty(categoria))
            {
                throw new Exception("Categoria não pode estar vazia");
            }
            else
            {
                this.categoria = categoria;
            }
        }
        public DateTime GetData_de_lançamento() => data_de_lançamento;
        public void SetData_de_lançamento(DateTime data)
        {
            this.data_de_lançamento = data;
        }
    }
}
