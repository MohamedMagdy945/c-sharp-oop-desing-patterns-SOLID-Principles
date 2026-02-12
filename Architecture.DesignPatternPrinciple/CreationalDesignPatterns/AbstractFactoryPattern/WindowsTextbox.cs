namespace Architecture.DesignPatternPrinciple.CreationalDesignPatterns.AbstractFactoryPattern
{
    internal class WindowsTextbox : ITextbox
    {
        public void Render()
        {
            Console.WriteLine("Render Windows Textbox");
        }
    }
}
