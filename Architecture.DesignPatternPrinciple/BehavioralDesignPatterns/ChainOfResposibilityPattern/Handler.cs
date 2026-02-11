namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.ChainOfResposibilityPattern
{
    public abstract class Handler 
    {
        protected Handler _next;
        public Handler SetNext(Handler next)
        {
            _next = next;
            return next;
        }
        public abstract void Handle(int amount);
    }
}
