namespace Architecture.DesignPatternPrinciple.CreationalDesignPatterns.FactoryPattern
{
    public class PushNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Push notification sent: {message}");
        }
    }
}
