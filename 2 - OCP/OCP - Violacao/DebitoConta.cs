namespace SOLID._2___OCP.OCP___Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta,TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Corrente)
            {
                //Debita conta corrente
            }

            if (tipoConta == TipoConta.Poupanca)
            {
                //Valida Aniversario da Conta
                //Debita Conta Poupança
            }
        }
    }
}
