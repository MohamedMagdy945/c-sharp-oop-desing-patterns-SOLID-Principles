namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.MediatorPatttern
{
    public class Button
    {
        private bool _isEnable { get; set; } = false;

        public bool IsEnable
        {
            get
            {
                return _isEnable ;
            }
            set
            {
                _isEnable = value;
            }
        }
        private IMediator _mediator;
        public Button(IMediator mediator) {
            _mediator = mediator;
        }
        public void Click()
        {
            if (IsEnable)
            {
                Console.WriteLine($"button is Enable");
                _mediator.Notify(this);
            }
            else
            {
                Console.WriteLine($"button is disable");
            }
        }
    }
}