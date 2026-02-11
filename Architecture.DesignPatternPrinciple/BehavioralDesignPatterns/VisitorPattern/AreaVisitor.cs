namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.VisitorPattern
{
    internal class AreaVisitor : IVisitor
    {
        public void Visit(Circle circle)
        {
            Console.WriteLine(circle.Radius * circle.Radius * Math.PI);
        }

        public void Visit(Rectangle rectangle)
        {
            Console.WriteLine(rectangle.Width * rectangle.Height);
        }
    }
}
