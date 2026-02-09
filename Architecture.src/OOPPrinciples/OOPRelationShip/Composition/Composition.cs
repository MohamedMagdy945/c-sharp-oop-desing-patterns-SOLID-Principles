namespace Architecture.src.OOPPrinciples.OOPRelationShip.Composition
{
    public class Composition
    {
        class Engine
        {
            public int Power { get; set; }
        }
        class Car
        {
            private Engine engine;

            public Car()
            {
                engine = new Engine(); // Composition
            }
        }

    }
}
