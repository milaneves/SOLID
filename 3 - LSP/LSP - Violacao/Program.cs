using SOLID._3___LSP.LSP___Violacao;
using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Transporte bicicleta = new Bicicleta();
            bicicleta.LigarMotor();
        }
    }
}
