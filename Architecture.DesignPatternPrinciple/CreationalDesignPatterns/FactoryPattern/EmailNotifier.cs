namespace Architecture.DesignPatternPrinciple.CreationalDesignPatterns.FactoryPattern
{
    public class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }
}
