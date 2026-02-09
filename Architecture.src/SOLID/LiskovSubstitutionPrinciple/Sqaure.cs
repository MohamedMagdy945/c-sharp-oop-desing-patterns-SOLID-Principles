namespace Architecture.src.SOLID.LiskovSubstitutionPrinciple
{
    public class Sqaure : Shape
    {
        public int Length { get; set; }
        public override int Area => Length * Length;
    }
}
