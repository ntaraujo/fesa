using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    internal class Jogo
    {
        private int _codigo;
        private string _nome;
        private string _categoria;
        private DateTime _data_de_lancamento;

        public int codigo{
            get {
                return _codigo;
            }
            set {
                if (value <= 0)
                {
                    throw new Exception("deve ser > 0");
                }
                else
                {
                    _codigo = value;
                }
            }
        }
        public string nome{
            get {
                return _nome;
            }
            set {
                if (value.Trim().Length == 0)
                {
                    throw new Exception("obrigatório");
                }
                else
                {
                    _nome = value;
                }
            }
        }

        private List<string> _categorias_permitidas = new List<string>() {"ação", "luta", "tiro", "Esportes" };
        public string categoria{
            get {
                return _categoria;
            }
            set {
                if (!_categorias_permitidas.Contains(value))
                {
                    throw new Exception("válido apenas “ação”  “luta” “tiro” e “Esportes”");
                }
                else
                {
                    _categoria = value;
                }
            }
        }
        public DateTime data_de_lancamento { 
            get {
                return _data_de_lancamento;
            }
            set
            {
                if (value >= DateTime.Now)
                {
                    throw new Exception("deve ser  inferior à data atual");
                }
                else
                {
                    _data_de_lancamento = value;
                }
            }
        }
    }
}
