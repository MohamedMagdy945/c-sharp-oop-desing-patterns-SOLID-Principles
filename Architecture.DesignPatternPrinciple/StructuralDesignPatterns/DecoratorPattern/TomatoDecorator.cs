namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.DecoratorPattern
{
    public class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(Pizza pizza) : base(pizza) { }
        public override double GetCost() => pizza.GetCost() + 2;
        public override string GetDescription() => pizza.GetDescription() + ", Tomato";
    }
}
