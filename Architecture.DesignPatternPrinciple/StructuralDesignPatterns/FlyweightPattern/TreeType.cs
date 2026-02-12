namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.FlyweightPattern
{
    public class TreeType
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Texture { get; set; }
        public TreeType(string name , string color, string texture)
        {
            Name = name;
            Color = color;
            Texture = texture;
        }
    }
}
