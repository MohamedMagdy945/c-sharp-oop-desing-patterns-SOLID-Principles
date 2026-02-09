namespace Architecture.src.OOPPrinciples.Polymorphism
{
    public class Bus : Transport
    {
        public int NumberOfDoors;
        public override void Start()
        {
            Console.WriteLine("car is starting...");
        }
        public override void Stop()
        {
            Console.WriteLine("car is stopping...");
        }
    }
}
