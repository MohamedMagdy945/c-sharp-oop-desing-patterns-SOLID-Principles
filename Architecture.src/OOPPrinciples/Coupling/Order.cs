namespace Architecture.src.OOPPrinciples.Coupling
{
    public class Order
    {
        private readonly INotificationService notificationService;
        public Order() { }  
        public Order(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }
        public void BadPlaceOrder()
        {
            // tightly coupled bad way
            MailService mailSerivce = new MailService();
            mailSerivce.SendEmail();
            Console.WriteLine("order is placed");
        }
        public void PlaceOrder()
        {
            notificationService.sendNotification("order placed successfully");
        }
    }
}
