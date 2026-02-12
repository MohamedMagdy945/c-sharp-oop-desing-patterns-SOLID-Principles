namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.DecoratorPattern
{
    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        public PizzaDecorator(Pizza pizza) { this.pizza = pizza; }
    }
}
