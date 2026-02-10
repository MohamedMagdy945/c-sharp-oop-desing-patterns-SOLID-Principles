namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.StrategyPattern
{
    public class PaymentContext
    {
        private IPaymentStrategy _strategy;
        public PaymentContext(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }
        public void Pay(int amount)
        {
            _strategy.Pay(amount); 
        }
    }
}
