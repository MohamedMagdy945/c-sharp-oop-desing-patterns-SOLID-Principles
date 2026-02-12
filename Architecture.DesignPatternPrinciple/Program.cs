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
using Architecture.DesignPatternPrinciple.CreationalDesignPatterns.AbstractFactoryPattern;
using Architecture.DesignPatternPrinciple.CreationalDesignPatterns.FactoryPattern;
using Architecture.DesignPatternPrinciple.CreationalDesignPatterns.PrototypePattern;
using Architecture.DesignPatternPrinciple.CreationalDesignPatterns.SingltonPattern;
using Architecture.DesignPatternPrinciple.StructuralDesignPatterns.AdapterPattern;
using Architecture.DesignPatternPrinciple.StructuralDesignPatterns.BridgePattern;
using Architecture.DesignPatternPrinciple.StructuralDesignPatterns.CompositPattern;
using Architecture.DesignPatternPrinciple.StructuralDesignPatterns.DecoratorPattern;
using Architecture.DesignPatternPrinciple.StructuralDesignPatterns.FacadePattern;
using Architecture.DesignPatternPrinciple.StructuralDesignPatterns.FlyweightPattern;
using Architecture.DesignPatternPrinciple.StructuralDesignPatterns.ProxyPattern;

namespace Architecture.DesignPatternPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Design Pattern Principles

            #region Creational Design Patterns  

            #region Prototype pattern

            //User adminTemplate = new User("Mohamed", "Admin", "IT");

            //// clone
            //User user1 = adminTemplate.Clone();
            //user1.Name = "Ahmed";


            //Console.WriteLine($"{user1.Name} - {user1.Role} - {user1.Department}");
            //Console.WriteLine($"{adminTemplate.Name} - {adminTemplate.Role} - {adminTemplate.Department}");

            #endregion

            #region Singlton Pattern

            //Logger.Instance.Log("Starting application");
            //Logger.Instance.Log("Doing work");

            #endregion

            #region Factory Pattern

            //NotifierFactory notifierFactory = new NotifierFactory();
            //INotifier notifier1 = notifierFactory.CreateNotifier("Email");
            //notifier1.Send("Hello Email");

            //INotifier notifier2 = notifierFactory.CreateNotifier("SMS");
            //notifier2.Send("Hello SMS");

            //INotifier notifier3 = notifierFactory.CreateNotifier("Push");
            //notifier3.Send("Hello Push");

            #endregion

            #region Abstract Factory Pattern

            IGUIFactory factory ;
            string os = "Windows";

            if (os == "Windows")
            {
                factory = new WindowsFactory();
            }
            else
            { 
                factory = new MacFactory();
            }
            var button = factory.CreateButton();
            var textbox = factory.CreateTextbox();

            button.Render();   // Render Windows Button
            textbox.Render();  // Render Windows Textbox

            #endregion

            #endregion

            #region Structural Design Patterns

            #region Composit Pattern
            //FolderSystem root = new FolderSystem("Root");
            //FileSystem file1 = new FileSystem("file1.txt");
            //FileSystem file2 = new FileSystem("file2.txt");
            //FolderSystem subFolder = new FolderSystem("SubFolder");
            //FileSystem file3 = new FileSystem("File3.txt");

            //root.Add(file1);
            //root.Add(subFolder);
            //subFolder.Add(file2);
            //subFolder.Add(file3);
            //root.Display(0);
            #endregion

            #region Adaptor Pattern
            //OldPaymentSystem oldSystem = new OldPaymentSystem();
            //IPayment payment = new PaymentAdapter(oldSystem);
            //payment.Pay(100);
            #endregion

            #region Bridge Pattern
            //IDevice tv = new TV();
            //RemoteAccess remote = new RemoteAccess(tv);
            //remote.PowerOn();

            //Console.WriteLine("-----");

            //IDevice radio = new Radio();
            //AdvancedRemote advanced = new AdvancedRemote(radio);
            //advanced.PowerOn();
            //advanced.Mute();
            #endregion

            #region Proxy Pattern
            //IImage image1 = new ProxyImage("Photo1.jpg");
            //IImage image2 = new ProxyImage("Photo2.jpg");

            //Console.WriteLine("Images created");

            //image1.Display();
            //Console.WriteLine();

            //image2.Display();
            //Console.WriteLine();

            //image1.Display();
            #endregion

            #region Flyweight Pattern

            //TreeFactory factory = new TreeFactory();
            //List<Tree> forest = new List<Tree>();

            //forest.Add(new Tree(10, 20, factory.GetTreeType("Oak", "Green", "Rough")));
            //forest.Add(new Tree(30, 40, factory.GetTreeType("Oak", "Green", "Rough")));
            //forest.Add(new Tree(50, 60, factory.GetTreeType("Pine", "Dark Green", "Smooth")));

            //foreach (var tree in forest)
            //{
            //    tree.Display();
            //}

            #endregion

            #region Facade Pattern

            //Amplifier amp = new Amplifier();
            //DVDPlayer dvd = new DVDPlayer();
            //Projector projector = new Projector();

            //HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, dvd, projector);

            //homeTheater.WatchMovie("Inception");
            //Console.WriteLine();
            //homeTheater.EndMovie();

            #endregion

            #region Decorator Pattern

            //Pizza pizza = new PlainPizza();

            //pizza = new CheeseDecorator(pizza);

            //pizza = new TomatoDecorator(pizza);

            //Console.WriteLine($"{pizza.GetDescription()} : ${pizza.GetCost()}");

            #endregion

            #endregion

            #region Behavioral Design Patterns

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
            ////15 + 1 + 2 - 8 = 10
            //IExpression expression = new SubExpression(new AddExpression(new AddExpression(new NumberExpression(15), new NumberExpression(1)), new NumberExpression(2)), new NumberExpression(8));
            //Console.WriteLine(expression.Interpret()); // 10
            #endregion

            #endregion

            #endregion
        }
    }
}
