namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.AdapterPattern
{
    public class PaymentAdapter : IPayment
    {
        private OldPaymentSystem _oldSystem;
        public PaymentAdapter(OldPaymentSystem oldSystem)
        {
            _oldSystem = oldSystem;
        }

        public void Pay(double amount)
        {
            _oldSystem.MakePayment(amount);
        }
    }
}
