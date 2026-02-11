namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.ChainOfResposibilityPattern
{
    public class Manager : Handler
    {
        public override void Handle(int amount)
        {
            if(amount <= 1000)
                Console.WriteLine("Manager approved");
            else
                _next?.Handle(amount);
            
        }
    }
}
