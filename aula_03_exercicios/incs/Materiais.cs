using System;

namespace aula_03_exercicios
{
    public class Materiais
    {
        public Materiais(int codigo, string assunto, string titulo)
        {
            this.codigo = codigo;
            this.assunto = assunto;
            this.titulo = titulo;
        }
        public int codigo { get; private set; }
        public string assunto { get; private set; }
        public string titulo { get; private set; }

        public class Livros
        {
            public Livros(string editora, string edicao, string ISBN, string autor)
            {
                this.editora = editora;
                this.edicao = edicao;
                this.ISBN = ISBN;
                this.autor = autor;
            }

            public string editora { get; private set; }
            public string edicao { get; private set; }
            public string ISBN { get; private set; }
            public string autor { get; private set; }
        }

        public class Revistas
        {
            public Revistas(string colecao, string editora)
            {
                this.colecao = colecao;
                this.editora = editora;
            }
            
            public string colecao { get; private set; }
            public string editora { get; private set; }

            internal class Artigos
            {
                public Artigos(string autor, string tituloArtigo)
                {
                    this.autor = autor;
                    this.tituloArtigo = tituloArtigo;
                }

                public string autor { get; private set; }
                public string tituloArtigo { get; private set; }
            }
        }
    }
}