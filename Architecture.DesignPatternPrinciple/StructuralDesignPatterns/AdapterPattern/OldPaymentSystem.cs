namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.AdapterPattern
{
    public class OldPaymentSystem
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine("Payment done : " + amount);
        }
    }
}
