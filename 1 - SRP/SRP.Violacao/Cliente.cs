using System;
using System.Data;
using System.Data.SqlClient;

namespace SOLID._1___SRP.SRP.Violacao
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }


        // responsabilidade em adicionar cliente ao banco
        // é de um repositório
        public string AdicionarCliente()
        {
            // 1 - reponsabilidade de validação de email
            if (!Email.Contains("@"))
                return "Cliente com e-mail inválido";

            
            //2 - reponsabilidade de validação de CPF
            if (CPF.Length != 11)
                return "Cliente com CPF inválido";

            //3 - responsabilidade em conectar o banco e inserir cliente no banco de dados
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

            return "Cliente cadastrado com Sucesso!";

          }
    }
}
