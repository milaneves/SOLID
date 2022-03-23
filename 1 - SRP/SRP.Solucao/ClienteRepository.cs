
using System.Data;
using System.Data.SqlClient;


namespace SOLID._1___SRP.SRP.Solucao
{
    public class ClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE(NOME, EMAIL CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @datacadastro)";

                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("cpf", CPF);
                cmd.Parameters.AddWithValue("datacadastro", DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
