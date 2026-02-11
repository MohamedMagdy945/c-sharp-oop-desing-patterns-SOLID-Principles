namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.CompositPattern
{
    public class FolderSystem : FileSystemItem
    {
        private List<FileSystemItem> _children = new List<FileSystemItem>();
        public FolderSystem(string name) : base(name)
        {
        }
        public void Add(FileSystemItem item)
        {
            _children.Add(item);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
            foreach(var child in _children)
            {
                child.Display(depth + 2);
            }
        }
    }
}
