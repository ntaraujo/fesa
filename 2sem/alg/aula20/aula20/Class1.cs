using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    enum Genero
    {
        Romance = 0
    }

    class Filme
    {
        private string titulo;
        private string duracao;
        private int faixaEtaria;
        private Genero genero;
        private string diretor;

        public string getTitulo()
        {
            return this.titulo;
        }
        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }
    }
}
