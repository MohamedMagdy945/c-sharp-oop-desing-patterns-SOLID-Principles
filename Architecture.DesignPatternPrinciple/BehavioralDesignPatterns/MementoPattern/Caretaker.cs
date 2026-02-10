namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.MementoPattern
{
    public class Caretaker
    {
        private List<Memento>  _history = new List<Memento>();
        public void AddMemento(Memento memento) => _history.Add(memento);
        public Memento GetMemento(int index) => _history[index];

        public void ShowHistory()
        {
            Console.WriteLine("History :");
            foreach(var memento in _history)
            {
                Console.WriteLine(memento);
            }
        }

    }
}
