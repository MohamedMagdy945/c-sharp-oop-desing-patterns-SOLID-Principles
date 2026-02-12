namespace Architecture.DesignPatternPrinciple.CreationalDesignPatterns.AbstractFactoryPattern
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ITextbox CreateTextbox();
    }
}
