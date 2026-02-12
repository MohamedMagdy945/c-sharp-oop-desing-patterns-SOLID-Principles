namespace Architecture.DesignPatternPrinciple.CreationalDesignPatterns.BuilderPattern
{
    public class JuiceBuilder
    {
        private Juice juice = new Juice();

        public JuiceBuilder SetSize(string size)
        {
            juice.Size = size;
            return this;
        }

        public JuiceBuilder AddSugar()
        {
            juice.Sugar = true;
            return this;
        }

        public JuiceBuilder AddIce()
        {
            juice.Ice = true;
            return this;
        }

        public JuiceBuilder AddMilk()
        {
            juice.Milk = true;
            return this;
        }

        public Juice Build()
        {
            return juice;
            juice = new Juice();
        }

    }
}
