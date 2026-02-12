namespace Architecture.DesignPatternPrinciple.CreationalDesignPatterns.FactoryPattern
{
    public class SMSNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }

}
