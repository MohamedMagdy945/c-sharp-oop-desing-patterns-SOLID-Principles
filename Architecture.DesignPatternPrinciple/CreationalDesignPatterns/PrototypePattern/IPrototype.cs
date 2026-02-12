namespace Architecture.DesignPatternPrinciple.CreationalDesignPatterns.PrototypePattern
{
    internal interface IPrototype<T>
    {
        T Clone();
    }
}
