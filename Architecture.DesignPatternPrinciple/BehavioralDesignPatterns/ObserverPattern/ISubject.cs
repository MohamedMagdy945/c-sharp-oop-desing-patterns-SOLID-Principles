namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.ObserverPattern
{
    public interface ISubject
    {
        public void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void Notify();
    }
}
