namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.IteratorPattern
{
    public class MyIterator<T>
    {
        private List<T> _items;
        private int _Position = -1 ;
        public MyIterator(List<T> items)
        {
            _items = items;
        }
        public T Current
        {
            get { return _items[_Position]; }
        }

        public bool MoveNext()
        {
            if (_Position < _items.Count - 1)
            {
                _Position++;
                return true;
            }
            return false;
        }
    }
}
