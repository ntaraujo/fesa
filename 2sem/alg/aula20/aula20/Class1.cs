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
    
    class Ator
    {
        private string nome;

        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
    }

    class Filme
    {
        private string titulo;
        private string duracao;
        private int faixaEtaria;
        private Genero genero;
        private string diretor;
        private List<Ator> atores = new List<Ator>();

        public string getTitulo()
        {
            return this.titulo;
        }
        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public void setAtores(List<Ator> atores)
        {
            this.atores = atores;
        }

        public void addAtor(Ator ator)
        {
            this.atores.Add(ator);
        }

        public List<Ator> getAtores()
        {
            return this.atores;
        }
    }
}
