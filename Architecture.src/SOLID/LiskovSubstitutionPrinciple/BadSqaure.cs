
namespace Architecture.src.SOLID.LiskovSubstitutionPrinciple
{
    public class BadSqaure : Rectangle
    {
        // unexpected behaviour
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }
    }
}
