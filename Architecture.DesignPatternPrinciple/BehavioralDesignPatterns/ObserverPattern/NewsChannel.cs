namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.ObserverPattern
{
    public class NewsChannel : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _news ;
        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);   
        }
        public void Unsubscribe(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void PublishNews(string newNews)
        {
            _news = newNews;
            Notify();
        }
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_news);
            }
        }
    }
}
