using Pessoal.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoal.Repositorios.SqlServer
{
    public class TarefaRepositorio
    {
        private string _stringConexao =
            ConfigurationManager.ConnectionStrings["pessoalConnectionString"].ConnectionString;

        public int Inserir(Tarefa tarefa)
        {
            using (var conexao = new SqlConnection(_stringConexao))
            {
                conexao.Open();

                using (var comando = new SqlCommand("TarefaInserir", conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    return (int)comando.ExecuteScalar();
                }

                //conexao.Close();
            }

        }
    }
}
