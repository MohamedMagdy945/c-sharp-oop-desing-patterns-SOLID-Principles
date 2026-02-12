namespace Architecture.DesignPatternPrinciple.CreationalDesignPatterns.AbstractFactoryPattern
{
    public class MacTextbox : ITextbox
    {
        public void Render()
        {
            Console.WriteLine("Render Mac Textbox");
        }
    }
}
