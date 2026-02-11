namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.VisitorPattern
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}