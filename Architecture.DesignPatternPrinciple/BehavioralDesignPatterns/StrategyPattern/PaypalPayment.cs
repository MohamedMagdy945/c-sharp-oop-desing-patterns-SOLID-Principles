namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.StrategyPattern
{
    public class PaypalPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Paid {amount} with Paypal");
        }
    }
}
