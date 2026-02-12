namespace Architecture.DesignPatternPrinciple.CreationalDesignPatterns.AbstractFactoryPattern
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render Mac Button");
        }
    }
}
