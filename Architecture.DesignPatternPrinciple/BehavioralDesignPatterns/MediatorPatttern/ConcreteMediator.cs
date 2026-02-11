namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.MediatorPatttern
{
    public class ConcreteMediator : IMediator
    {
        private Button _button;
        private TextBox _textBox;
        public ConcreteMediator()
        {

        }
        ConcreteMediator(Button button, TextBox textBox)
        {
            _button = button;
            _textBox = textBox;
        }
        public Button Button
        {
            set { _button = value; }
        }
        public TextBox TextBox
        {
            set { _textBox = value; }
        }
        public void Notify(object sender)
        {
            if (sender == _button)
            {
                _textBox.Clear();
            }
            else if (sender == _textBox)
            {
                if (_textBox.Value == "")
                {
                    _button.IsEnable = false;
                }
                else
                {
                    _button.IsEnable = true;
                }
            }
        }
    }
}
