namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.TemplatePattern
{
    public abstract class Beverage
    {
        public void Prepare()
        {
            BoilWater();
            AddMainIngredient();
            AddExtras();
            Serve();
        }
        protected void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        protected abstract void AddMainIngredient();
        protected abstract void AddExtras();
        protected void Serve()
        {
            {
                Console.WriteLine("Serve the drink");
            }
        }
    }
}
