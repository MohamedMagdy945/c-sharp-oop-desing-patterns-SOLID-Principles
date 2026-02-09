namespace Architecture.src.SOLID.OpenClosedPrinciple
{
    public class BadShapeType
    {
        public ShapeType Type { get; set; }
        public double Redius { get; set; }
        public double Length {  get; set; }
        public double Width { get; set; }
        public double CalculateArea()
        {
            switch(Type)
            {
                case ShapeType.Circle:
                    return Math.PI * Math.Pow(Redius, 2);
                case ShapeType.Rectangle:
                    return Length * Width ;
                default:
                    throw new InvalidOperationException("Unsupported shape type");
            }
        }
    }
}
