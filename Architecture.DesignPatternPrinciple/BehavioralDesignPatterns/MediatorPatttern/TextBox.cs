
namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.MediatorPatttern
{
    public class TextBox
    {
        private string _value;
        private IMediator _mediator;
        public TextBox(IMediator mediator)
        {
            _mediator = mediator;
        }

        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                _mediator.Notify(this);
            }
        }


        public void Clear()
        {
            Value = string.Empty;
            Console.WriteLine("TextBox Cleared");
        }

    }
}