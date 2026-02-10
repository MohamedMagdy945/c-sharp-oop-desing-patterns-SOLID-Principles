namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.StrategyPattern
{
    public class VisaPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Paid {amount} with Visa");
        }
    }
}
