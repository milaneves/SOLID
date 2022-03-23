using System;
using SOLID._5___DIP.DIP___Solucao.Interfaces;

namespace SOLID._5___DIP.DIP___Solucao
{
    public class Cliente
    {
        private readonly ICPFServices _cpfServices;

        public Cliente( ICPFServices cpfServices)
        {
            _cpfServices = cpfServices;

        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}