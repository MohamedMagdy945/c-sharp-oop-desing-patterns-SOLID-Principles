namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.CompositPattern
{
    public class FileSystem : FileSystemItem
    {
        public FileSystem(string name) : base(name)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }
    }
}
