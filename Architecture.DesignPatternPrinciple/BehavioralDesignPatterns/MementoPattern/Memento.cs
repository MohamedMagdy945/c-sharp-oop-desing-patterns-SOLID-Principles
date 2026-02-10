namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.MementoPattern
{
    // Memento
    public class Memento
    {
        public string Content { get; private set; }
        public DateTime Date { get; private set; }
        public Memento(string content)
        {
            Content = content;
            Date = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{Content} - {Date}";
        }
    }
}
