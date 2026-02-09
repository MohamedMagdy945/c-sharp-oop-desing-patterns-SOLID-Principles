namespace Architecture.src.OOPPrinciples.Abstraction
{
    public class BadEmailService
    {
        public void SendEmail()
        {
            Console.WriteLine("sending email...");
        }
        public void Connect()
        {
            Console.WriteLine("connecting to email server...");
        }
        public void Autheticate()
        {
            Console.WriteLine("Authenticating...");
        }
        public void Disconnect()
        {
            Console.WriteLine("connecting to email server...");
        }
    }
}
