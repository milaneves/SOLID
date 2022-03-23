using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._1___SRP.SRP.Solucao
{
    public class EmailServices
    {
        public static bool IsValid (string email)
        {
            return email.Contains("@");
        }
    }
}
