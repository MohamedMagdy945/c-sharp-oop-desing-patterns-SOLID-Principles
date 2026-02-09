using Architecture.src.OOPPrinciples.Abstraction;
using Architecture.src.OOPPrinciples.Coupling;
using Architecture.src.OOPPrinciples.Encapsulation;
using Architecture.src.OOPPrinciples.Inheritance;
using Architecture.src.OOPPrinciples.Polymorphism;

namespace Architecture.src
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation
            //// wrong way
            //BadBankAccount badAccount = new BadBankAccount();
            //// no validating
            //badAccount.balance = -60 ;
            //Console.WriteLine(badAccount.balance);

            //// correct way
            //BankAccount bankAccount = new BankAccount(100);
            //Console.WriteLine(bankAccount.GetBalance());
            //bankAccount.WithDraw(50);
            //Console.WriteLine(bankAccount.GetBalance());
            #endregion
            #region Abstraction
            // wrong way
            //BadEmailService badEmailService = new BadEmailService();
            //badEmailService.Connect();
            //badEmailService.Autheticate();
            //badEmailService.SendEmail();
            //badEmailService.Disconnect();

            //// correct way
            //EmailService emailService = new EmailService();
            //emailService.SendEmail();
            #endregion
            #region Inheritance
            //Car car = new Car();
            //// shared fields
            //car.Brand = "Ford";
            //car.Start();
            //car.Stop();

            //// uniqu fields
            //car.NumberOfDoors = 4;

            //Bike bike = new Bike();
            //bike.Start();
            //bike.Stop();
            #endregion
            #region Polymorphism
            // bad way
            //List<object> vehicles = new List<object>();
            //vehicles.Add(new Bus { Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4 });
            //vehicles.Add(new Motorcycle { Brand = "Harley", Model = "Sports" , Year = 2024});

            //foreach (var vehicel in vehicles)
            //{ 
            //    if(vehicel is Bus)
            //    {
            //        var bus = (Bus)vehicel;
            //        bus.Start();
            //    }
            //    else if (vehicel is Motorcycle)
            //    {
            //        var motor = (Motorcycle)vehicel;
            //        motor.Start();
            //    }
            //}
            //Console.WriteLine("---------------------");
            //// corrent way of polymarphism
            //List<Transport> transports = new List<Transport>();
            //transports.Add(new Bus { Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4 });
            //transports.Add(new Motorcycle { Brand = "Harley", Model = "Sports", Year = 2024 });

            //foreach (var transport in transports)
            //{
            //    transport.Start();
            //}
            #endregion
            #region Coupling
            // wrong way 
            Order order = new Order();
            order.BadPlaceOrder();

            // correct way
            Order order1 = new Order(new MailService());
            order1.PlaceOrder();
            Order order2 = new Order(new SmsService());
            order2.PlaceOrder();
            #endregion

        }
    }
}
