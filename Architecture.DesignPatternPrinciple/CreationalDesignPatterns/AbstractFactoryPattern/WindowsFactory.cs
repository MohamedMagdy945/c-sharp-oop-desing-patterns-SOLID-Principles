namespace Architecture.DesignPatternPrinciple.CreationalDesignPatterns.AbstractFactoryPattern
{
    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ITextbox CreateTextbox() => new WindowsTextbox();
    }
}
