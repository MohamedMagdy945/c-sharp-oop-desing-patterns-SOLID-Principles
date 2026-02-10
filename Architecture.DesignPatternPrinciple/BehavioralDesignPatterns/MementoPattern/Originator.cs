namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.MementoPattern
{
    public class Originator
    {
        public string Content { get; set; }
        public Memento SaveState()
        {
            return new Memento(Content);
        }
        public void RestorState(Memento memento)
        {
            Content = memento.Content;
        }
    }
}
