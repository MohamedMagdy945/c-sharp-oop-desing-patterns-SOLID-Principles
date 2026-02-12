namespace Architecture.DesignPatternPrinciple.CreationalDesignPatterns.AbstractFactoryPattern
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render Windows Button");
        }
    }
}
