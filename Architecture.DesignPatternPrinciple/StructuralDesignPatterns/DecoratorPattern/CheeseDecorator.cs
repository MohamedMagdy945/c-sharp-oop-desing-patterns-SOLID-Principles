namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.DecoratorPattern
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(Pizza pizza) : base(pizza) { }
        public override double GetCost() => pizza.GetCost() + 3;
        public override string GetDescription() => pizza.GetDescription() + ", Cheese";
    }
}
