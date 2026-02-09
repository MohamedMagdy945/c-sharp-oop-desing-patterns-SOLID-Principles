namespace Architecture.src.SOLID.LiskovSubstitutionPrinciple
{
    public class Rectangle : Shape
    {
        public virtual int  Width { get; set; } 
        public virtual int Height { get; set; }
        public override int Area => Width * Height ;
    }
}
