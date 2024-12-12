using System.Data.SqlClient;

namespace GastosPessoais.Data_Base
{
    public class Conexao
    {



        // String de conexão com o banco de dados
        private readonly string connectionString =
        "Data Source=DESKTOP-A7R1DL8\\SQLEXPRESS;Initial Catalog=gastos_pessoais;Persist Security Info=True;User ID=sa;Password=123leo;TrustServerCertificate=True";

        // Método para obter a conexão
        public SqlConnection AbrirConexao()
        {
            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();

            return conexao;
        }

    }


}


