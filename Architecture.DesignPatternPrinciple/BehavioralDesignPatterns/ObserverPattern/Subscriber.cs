using System;

namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.ObserverPattern
{
    public class Subscriber : IObserver
    {
        private string _name;
        public Subscriber(string name)
        {
            _name = name;
        }

        void IObserver.Update(string message)
        {
            Console.WriteLine($"{_name} received: {message}");
        }
    }
}
