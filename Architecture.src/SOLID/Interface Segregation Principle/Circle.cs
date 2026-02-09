namespace Architecture.src.SOLID.Interface_Segregation_Principle
{
    public class Circle : IShape2D
    {
        public int Raduis { get; set; }
        public double Area()
        {
            return Math.PI * Math.Pow(Raduis, 2);
        }

    }
}
