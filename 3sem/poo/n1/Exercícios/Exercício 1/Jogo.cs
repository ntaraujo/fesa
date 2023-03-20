using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Game
    {
        private int code;
        private string name;
        private string categoria;
        private DateTime data_de_lançamento;

        public int GetCode() => code;
        public void SetCode(int code)
        {
            if (code <= 0)
            {
                throw new Exception("Code não pode ser menor que 0 (zero)");
            }
            else
            {
                this.code = code;
            }
        }
        public string GetName() => name;
        public void SetName(string name) 
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name não pode estar vazio");
            }
            else
            {
                this.name = name;
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
