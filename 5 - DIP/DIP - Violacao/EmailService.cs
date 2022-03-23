
namespace SOLID._5___DIP.DIP___Violacao
{
    public class EmailServices
    {
        public static bool IsValid(string email)
        {
            return email.Contains("@");
        }
    }
}
