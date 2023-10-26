using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoClass
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public bool Emprestado { get; private set; }

        public Livro(string titulo, string autor, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            Emprestado = false;
        }

        public void Emprestar()
        {
            Emprestado = true;
        }

        public void Devolver()
        {
            Emprestado = false;
        }
    }
}