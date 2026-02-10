namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.TemplatePattern
{
    public class Tea : Beverage
    {
        protected override void AddExtras()
        {
            Console.WriteLine("Add tea");
        }

        protected override void AddMainIngredient()
        {
            Console.WriteLine("Add sugar and mint");
        }
    }
}
