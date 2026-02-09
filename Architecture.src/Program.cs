using Architecture.src.OOPPrinciples.Abstraction;
using Architecture.src.OOPPrinciples.Encapsulation;

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

        }
    }
}
