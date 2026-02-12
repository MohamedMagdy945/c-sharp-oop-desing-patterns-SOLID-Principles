namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.DecoratorPattern
{
    public class PlainPizza : Pizza
    {
        public override double GetCost() => 10;
        public override string GetDescription() => "Plain Pizza";
    }
}
