namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.StatePattern
{
    public class SilentState : IPhoneState
    {
        public void ChangeMode(Phone phone)
        {
            Console.WriteLine("Silent -> Vibrate");
            phone.State = new VibrateState();
        }
    }
}
