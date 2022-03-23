 
namespace SOLID._1___SRP.SRP.Solucao
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
