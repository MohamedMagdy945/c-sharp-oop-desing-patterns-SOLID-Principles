namespace Architecture.src.OOPPrinciples.Composition
{
    public class Motorcar
    {
        private Engine engine { get; set; }
        private Wheels wheels { get; set; }
        private Chassis chassis { get; set; }
        private Seats seats { get; set; }
        public void MoveCar()
        {
            engine.Start();
            wheels.Rotate();
            chassis.Support();
            seats.Sit();
        }
    }
}
