using Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.ChainOfResposibilityPattern;
using Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.CommandPattern;
using Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.InterpreterPattern;
using Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.IteratorPattern;
using Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.MediatorPatttern;
using Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.MementoPattern;
using Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.ObserverPattern;
using Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.StatePattern;
using Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.StrategyPattern;
using Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.TemplatePattern;
using Architecture.DesignPatternPrinciple.BehavioralDesignPatterns.VisitorPattern;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            #region State Pattern
            //Phone phone = new Phone(new SilentState());
            //phone.ChangeMode();
            //phone.ChangeMode();
            //phone.ChangeMode();
            #endregion

            #region Strategy Pattern
            //var payContext = new PaymentContext(new VisaPayment());
            //payContext.Pay(100);

            //payContext.SetStrategy(new PaypalPayment());
            //payContext.Pay(200);
            #endregion

            #region Iterator Pattern 
            //List<string> name = new List<string>() { "Mohamed" , "Ahmed", "Mahmoud"};
            //MyIterator<string> nameIteratro = new MyIterator<string>(name);
            //while(nameIteratro.MoveNext())
            //{
            //    Console.WriteLine(nameIteratro.Current);
            //}
            #endregion

            #region Command Pattern
            //Light light = new Light();
            //TurnOnCommand turnOn = new TurnOnCommand(light);
            //TurnOffCommand turnOff = new TurnOffCommand(light);

            //RemoteControl remoteControl = new RemoteControl();

            //remoteControl.SetCommand(turnOn);
            //remoteControl.PressButton();
            //remoteControl.PressUndo();

            //remoteControl.SetCommand(turnOff);
            //remoteControl.PressButton();
            //remoteControl.PressUndo();
            #endregion

            #region Template Method Pattern
            //Beverage tea = new Tea();
            //tea.Prepare();

            //Beverage coffee = new Coffee();
            //coffee.Prepare();
            #endregion

            #region Observer Pattern
            //NewsChannel channel = new NewsChannel();
            //Subscriber ahmed = new Subscriber("ahmed");
            //Subscriber sara = new Subscriber("Sara");
            //channel.Subscribe(ahmed);
            //channel.Subscribe(sara);
            //channel.PublishNews("New video uploaded!");
            #endregion

            #region Mediator Pattern
            //ConcreteMediator mediator = new ConcreteMediator();
            //Button btn = new Button(mediator);
            //TextBox txt = new TextBox(mediator);
            //mediator.Button = btn;
            //mediator.TextBox = txt;
            //txt.Value = "mohamed";
            //btn.Click(); 
            //btn.Click();
            #endregion

            #region Chain of Responsibility Pattern
            //var manager = new Manager();
            //var director = new Director();
            //var ceo = new CEO();

            //manager.SetNext(director);
            //director.SetNext(ceo);

            //manager.Handle(7000);
            #endregion

            #region Visitor Pattern
            //AreaVisitor areaVisitor = new AreaVisitor();
            //List<IShape> shapes = new List<IShape>();
            //Circle circle = new Circle() { Radius = 2};
            //Rectangle rectangle = new Rectangle() { Height = 10 , Width = 5};
            //shapes.Add(circle);
            //shapes.Add(rectangle);
            //foreach (IShape shape in shapes)
            //{
            //    shape.Accept(areaVisitor);
            //}
            #endregion

            #region InterpreterPattern
            //15 + 1 + 2 - 8 = 10
            IExpression expression = new SubExpression(new AddExpression(new AddExpression(new NumberExpression(15), new NumberExpression(1)), new NumberExpression(2)), new NumberExpression(8));
            Console.WriteLine(expression.Interpret()); // 10
            #endregion

            #endregion

            #endregion
        }
    }
}
