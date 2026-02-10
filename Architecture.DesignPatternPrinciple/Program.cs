using Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.MementoPattern;
using Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.StatePattern;
using Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.StrategyPattern;

namespace Architecture.DesignPatternPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Design Pattern Principles

            #region Creational Design Patterns  
            #endregion

            #region Structural Patterns



            #endregion
            #region Behavioral Patterns
            #region Memento Pattern
            //Caretaker caretaker = new Caretaker();
            //Originator originator = new Originator();
            //originator.Content = "state1";
            //caretaker.AddMemento(originator.SaveState());

            //originator.Content = "state2";
            //caretaker.AddMemento(originator.SaveState());

            //caretaker.ShowHistory();
            //originator.RestorState(caretaker.GetMemento(0));
            //Console.WriteLine("---------------------");
            //Console.WriteLine(originator.Content);
            #endregion
            #region State Patterns
            //Phone phone = new Phone(new SilentState());
            //phone.ChangeMode();
            //phone.ChangeMode();
            //phone.ChangeMode();
            #endregion
            #region Strategy Pattern
            var payContext = new PaymentContext(new VisaPayment());
            payContext.Pay(100);

            payContext.SetStrategy(new PaypalPayment());
            payContext.Pay(200);
            #endregion
            #endregion

            #endregion
        }
    }
}
