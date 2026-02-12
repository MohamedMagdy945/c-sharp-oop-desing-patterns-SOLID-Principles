namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.ProxyPattern
{
    public class RealImage : IImage
    {
        private string fileName;
        public RealImage(string fileName)
        {
            this.fileName = fileName;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading {fileName} from disk...");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying {fileName}");
        }
    }
}
