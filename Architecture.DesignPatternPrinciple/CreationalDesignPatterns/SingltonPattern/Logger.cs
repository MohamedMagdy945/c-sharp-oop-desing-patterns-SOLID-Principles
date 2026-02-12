namespace Architecture.DesignPatternPrinciple.CreationalDesignPatterns.SingltonPattern
{
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _instanceLock = new object();
        private Logger() { }
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Logger();
                        }
                    }
                }
                return _instance;
            }
        }
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}
