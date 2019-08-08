using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShowdeBola.Properties;

namespace ShowdeBola
{
    class Conexao
    {
        public SqlConnection conexao = new SqlConnection();

        public void conectar()
        {
            conexao.ConnectionString = Properties.Settings.Default.ConnectionString;
            conexao.Open();
        }

        public void desconectar()
        {
            conexao.Close();
        }
    }
}
