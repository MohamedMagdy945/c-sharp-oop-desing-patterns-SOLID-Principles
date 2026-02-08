using Architecture.src.OOPPrinciples.Encapsulation;

namespace Architecture.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation
            // ## wrong method
            BadBankAccount badAccount = new BadBankAccount();
            // no validating
            badAccount.balance = -60 ;
            Console.WriteLine(badAccount.balance);
            
            // correct method
            BankAccount bankAccount = new BankAccount(100);
            Console.WriteLine(bankAccount.GetBalance());
            bankAccount.WithDraw(50);
            Console.WriteLine(bankAccount.GetBalance());
            #endregion
        }
    }
}
