
namespace Architecture.src.OOPPrinciples.Coupling
{
    public class SmsService : INotificationService
    {
        public void sendNotification(string message)
        {
            Console.WriteLine("send sms : " + message);
        }
    }
}
