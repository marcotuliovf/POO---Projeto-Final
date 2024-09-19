using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace wfaEmprestimoLivros
{
    internal class Aluno
    {
        string name;
        string matricula;
        string cpf;

        public Aluno()
        {
        }

        public Aluno(string _name, string _matricula, string _cpf)
        {
            name = _name;
            matricula = _matricula;
            cpf = _cpf;
        }

        public string Name { get =>  name; set => name = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Cpf { get => cpf; set => cpf = value; }

    }
}
