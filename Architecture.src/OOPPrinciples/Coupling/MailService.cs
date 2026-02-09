namespace Architecture.src.OOPPrinciples.Coupling
{
    public class MailService : INotificationService
    {
        public void SendEmail()
        {
            Console.WriteLine("email is sent");
        }

        public void sendNotification(string message)
        {
            Console.WriteLine("send email: " + message);
        }
    }
}
