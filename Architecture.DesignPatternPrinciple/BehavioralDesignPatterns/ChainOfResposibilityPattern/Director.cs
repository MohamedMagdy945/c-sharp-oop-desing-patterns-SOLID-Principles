using Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.ChainOfResposibilityPattern;

public class Director : Handler
{
    public override void Handle(int amount)
    {
        if (amount <= 5000)
            Console.WriteLine("Director approved");
        else
            _next?.Handle(amount);
    }
}
