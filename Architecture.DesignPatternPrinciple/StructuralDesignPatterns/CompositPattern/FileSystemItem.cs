namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.CompositPattern
{
    public abstract class FileSystemItem
    {
        public string Name { get; set; }
        public FileSystemItem(string name)
        {
            this.Name = name; 
        }
        public abstract void Display(int depth);
    }
}
