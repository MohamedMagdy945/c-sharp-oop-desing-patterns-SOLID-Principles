namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.StatePattern
{
    internal class VibrateState : IPhoneState
    {
        public void ChangeMode(Phone phone)
        {
            Console.WriteLine("Vibrate -> Normal");
            phone.State = new NormalState();
        }
    }
}