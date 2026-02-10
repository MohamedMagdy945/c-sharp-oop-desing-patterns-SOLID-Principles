namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.StatePattern
{
    internal class NormalState : IPhoneState
    {
        public void ChangeMode(Phone phone)
        {
            Console.WriteLine("Normal -> Silent");
            phone.State = new SilentState();
        }
    }
}