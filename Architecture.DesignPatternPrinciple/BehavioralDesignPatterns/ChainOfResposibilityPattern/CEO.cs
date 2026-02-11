namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.ChainOfResposibilityPattern
{
    public class CEO : Handler
    {
        public override void Handle(int amount)
        {
            Console.WriteLine("CEO approved");
        }
    }

}
