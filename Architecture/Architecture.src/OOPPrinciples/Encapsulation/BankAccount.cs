namespace Architecture.src.OOPPrinciples.Encapsulation
{
    public class BankAccount
    {
        private decimal balance;
        public BankAccount()
        {
            this.balance = 0;
        }
        public BankAccount(decimal amount)
        {
            this.balance = amount;
        }
        public decimal GetBalance()
        {
            return this.balance;
        }
        public void Deposit(decimal amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException("deposit amount must be positive");
            }
            this.balance += amount; 
        }
        public void WithDraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("deposit amount must be positive");
            }
            if(amount > balance)
            {
                throw new InvalidOperationException("insufficient funds");
            }
            this.balance -= amount;
        }
        
    }
}
