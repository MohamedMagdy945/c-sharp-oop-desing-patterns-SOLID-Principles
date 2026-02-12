namespace Architecture.DesignPatternPrinciple.CreationalDesignPatterns.BuilderPattern
{
    public class Juice
    {
        public string Size;
        public bool Sugar;
        public bool Ice;
        public bool Milk;

        public void Show()
        {
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Sugar: {Sugar}");
            Console.WriteLine($"Ice: {Ice}");
            Console.WriteLine($"Milk: {Milk}");
        }
    }
}
