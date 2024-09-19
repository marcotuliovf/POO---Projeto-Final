using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace wfaEmprestimoLivros
{
    internal class Livro
    {
        string cadastro;
        string titulo;
        string autor;
        string edicao;
        string ano;

        public Livro() 
        { 
        }

        public Livro(string _cadastro, string _titulo, string _autor, string _edicao, string _ano)
        {
            cadastro = _cadastro;
            titulo = _titulo;
            autor = _autor;
            edicao = _edicao;
            ano = _ano;
        }

        public string Cadastro { get => cadastro; set => cadastro = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Edicao { get => edicao; set => edicao = value; }
        public string Ano { get => ano; set => ano = value; }
    }
}
