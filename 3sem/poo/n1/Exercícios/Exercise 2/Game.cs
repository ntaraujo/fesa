using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Game
    {
        private int code;
        private string name;
        private string categoria;
        private DateTime data_de_lançamento;
        List<string> categorias = new List<string>() { "ação", "luta", "tiro", "esportes" };

        public int GetCode() => code;
        public void SetCode(int code)
        {
            if (code <= 0)
            {
                throw new Exception("Code não pode ser menor ou igual a 0 (zero)");
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
            categoria = categoria.ToLower();
            if (!categorias.Accountins(categoria))
            {
                throw new Exception("Verifique se a categoria existe ou está escrita corretamente");
            }
            else
            {
                this.categoria = categoria;
            }
        }
        public DateTime GetReleaseDate() => data_de_lançamento;
        public void SetReleaseDate(DateTime data)
        {
            if(data <= DateTime.Now) 
            {
                this.data_de_lançamento = data;
            }
            else
            {
                throw new Exception("A data não pode ser menor que a data atual");
            }
        }
        
    }
}
