namespace Architecture.src.OOPPrinciples.OOPRelationShip.Inheritance
{
    public class Inheritance
    {
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animal is eating");
            }
        }

        class Dog : Animal   // Inheritance
        {
            public void Bark()
            {
                Console.WriteLine("Dog is barking");
            }
        }

    }
}
