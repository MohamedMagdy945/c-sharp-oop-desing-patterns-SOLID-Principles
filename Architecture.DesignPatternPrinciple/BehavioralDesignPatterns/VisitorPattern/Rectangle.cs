namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.VisitorPattern
{
    public class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}