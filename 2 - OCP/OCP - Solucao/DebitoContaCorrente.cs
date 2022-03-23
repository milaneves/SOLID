

namespace SOLID._2___OCP.OCP___Solucao
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            //Debita Conta corrente
            return NumeroTransacao;
        }
    }
}
