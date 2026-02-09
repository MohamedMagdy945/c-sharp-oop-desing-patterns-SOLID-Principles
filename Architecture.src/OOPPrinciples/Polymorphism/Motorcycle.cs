namespace Architecture.src.OOPPrinciples.Polymorphism
{
    public class Motorcycle : Transport
    {
        public override void Start()
        {
            Console.WriteLine("motorcycle is starting...");
        }
        public override void Stop()
        {
            Console.WriteLine("motorcycle is stopping...");
        }
    }
}
