namespace Architecture.DesignPatternPrinciple.CreationalDesignPatterns.FactoryPattern
{
    public class NotifierFactory
    {
        public INotifier CreateNotifier(string type)
        {
            if (type == "Email")
                return new EmailNotifier();
            else if (type == "SMS")
                return new SMSNotifier();
            else if (type == "Push")
                return new PushNotifier();
            else
                throw new ArgumentException("Unknown notifier type");
        }
    }
}
