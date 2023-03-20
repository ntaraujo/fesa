using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    class Game
    {
        private int código;
        private string nome;
        private string categoria;
        private DateTime data_de_lançamento;

        public int GetCode() => código;
        public void SetCode(int código)
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
        public string GetName() => nome;
        public void SetName(string nome) 
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Name não pode estar vazio");
            }
            else
            {
                this.nome = nome;
            }
        }
        public string GetCategory() => categoria;
        public void SetCategory(string categoria)
        {
            if (string.IsNullOrEmpty(categoria))
            {
                throw new Exception("Category não pode estar vazia");
            }
            else
            {
                this.categoria = categoria;
            }
        }
        public DateTime GetReleaseDate() => data_de_lançamento;
        public void SetReleaseDate(DateTime data)
        {
            this.data_de_lançamento = data;
        }
    }
}
