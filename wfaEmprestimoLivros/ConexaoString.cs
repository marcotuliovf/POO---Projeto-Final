using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaEmprestimoLivros
{
    internal class ConexaoString
    {
        string serverName = "localhost";
        string port = "5432";
        string userName = "postgres";
        string password = "410311";
        string dataBaseName = "EmprestimoLivros";

        public string ConnString()
        {
            var connString = "server=" + serverName + ";port = " + port + ";username = " + userName +
                ";password = " + password + ";Database = " + dataBaseName + ";";

            return connString;
        }
    }
}
