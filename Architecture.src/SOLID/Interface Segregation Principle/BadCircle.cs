namespace Architecture.src.SOLID.Interface_Segregation_Principle
{
    public class BadCircle : IShape3D
    {
        public int Raduis {  get; set; }
        public double Area()
        {
            return Math.PI * Math.Pow(Raduis, 2);
        }
        // bad way
        public double Volume()
        {
            throw new NotImplementedException();
        }
    }
}
