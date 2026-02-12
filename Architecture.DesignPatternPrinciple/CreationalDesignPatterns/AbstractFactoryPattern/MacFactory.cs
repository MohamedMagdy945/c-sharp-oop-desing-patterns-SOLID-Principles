namespace Architecture.DesignPatternPrinciple.CreationalDesignPatterns.AbstractFactoryPattern
{
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ITextbox CreateTextbox() => new MacTextbox();
    }
}
