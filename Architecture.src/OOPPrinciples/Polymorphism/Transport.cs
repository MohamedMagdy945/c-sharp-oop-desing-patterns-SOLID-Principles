namespace Architecture.src.OOPPrinciples.Polymorphism
{
    public class Transport
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public virtual void Start()
        {
            Console.WriteLine("vechile is starting...");
        }
        public virtual void Stop()
        {
            Console.WriteLine("vechile is stopping...");
        }
    }
}
