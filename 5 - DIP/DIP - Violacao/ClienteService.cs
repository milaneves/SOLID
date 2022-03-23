
namespace SOLID._5___DIP.DIP___Violacao
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            return "Cliente Cadastrado com sucesso";
        }
    }
}
