
namespace SOLID._3___LSP.LSP___Violacao
{
    public class Transporte
    {
        public string Nome { get; set; }
        public Motor Motor { get; set; }
        public int Velocidade { get; set; }

        public virtual bool LigarMotor()
        {
            return true;
        }
        
    }
}
