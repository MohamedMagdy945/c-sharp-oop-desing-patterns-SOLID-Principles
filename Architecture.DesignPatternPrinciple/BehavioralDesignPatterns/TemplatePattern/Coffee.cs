
namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.TemplatePattern
{
    public class Coffee : Beverage
    {
        protected override void AddMainIngredient()
        {
            Console.WriteLine("Add coffee");
        }
        protected override void AddExtras()
        {
            Console.WriteLine("Add milk and sugar");
        }
    }
}
