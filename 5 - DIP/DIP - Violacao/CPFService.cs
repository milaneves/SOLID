namespace SOLID._5___DIP.DIP___Violacao
{
    public class CPFServices
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}
