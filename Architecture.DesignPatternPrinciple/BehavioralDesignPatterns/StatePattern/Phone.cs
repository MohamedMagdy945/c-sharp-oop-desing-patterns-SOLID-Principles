namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.StatePattern
{
    public class Phone
    {
        public IPhoneState State { get; set; }
        public Phone(IPhoneState state) {
            State = state;
        }
        public void ChangeMode()
        {
            State.ChangeMode(this);
        }
    }
}
