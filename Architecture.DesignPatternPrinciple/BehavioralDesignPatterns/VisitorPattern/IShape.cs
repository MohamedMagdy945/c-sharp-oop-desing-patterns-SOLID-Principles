namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.VisitorPattern
{
    public interface IShape
    {
        void Accept(IVisitor visitor) ;
    }
}
