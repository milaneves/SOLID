
using SOLID._5___DIP.DIP___Solucao.Interfaces;

namespace SOLID._5___DIP.DIP___Solucao
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteServices(
            IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            _clienteRepository.AdicionarCliente(cliente);
                    
            return "Cliente cadastrado com sucesso";
        }
    }
}