using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._1___SRP.SRP.Solucao
{
    public class CPFServices
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}
