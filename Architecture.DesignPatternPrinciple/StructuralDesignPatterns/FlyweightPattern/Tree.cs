namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.FlyweightPattern
{
    public class Tree
    {
        private int x;
        private int y;
        private TreeType type;
        public Tree(int x, int y, TreeType type)
        {
            this.x = x;
            this.y = y;
            this.type = type;
        }
        public void Display()
        {
            Console.WriteLine($"Tree {type.Name} at ({x},{y}) with color {type.Color} and texture {type.Texture}");
        }
    }
}
