namespace Architecture.src.OOPPrinciples.Abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {
            Connect();
            Autheticate();
            Console.WriteLine("sending email...");
            Disconnect();
        }
        private void Connect()
        {
            Console.WriteLine("connecting to email server...");
        }
        private void Autheticate()
        {
            Console.WriteLine("Authenticating...");
        }
        private void Disconnect()
        {
            Console.WriteLine("connecting to email server...");
        }
    }
}
