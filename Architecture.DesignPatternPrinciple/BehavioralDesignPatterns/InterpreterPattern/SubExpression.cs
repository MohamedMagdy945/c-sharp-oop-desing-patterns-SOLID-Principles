namespace Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.InterpreterPattern
{
    public class SubExpression : IExpression
    {
        private IExpression _left;
        private IExpression _right;
        public SubExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret()
        {
            return _left.Interpret() - _right.Interpret();
        }
    }
}
