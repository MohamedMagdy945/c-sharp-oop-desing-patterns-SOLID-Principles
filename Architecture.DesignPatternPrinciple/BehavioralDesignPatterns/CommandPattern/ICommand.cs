namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.CommandPattern
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
