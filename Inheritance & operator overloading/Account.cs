namespace Inheritance___operator_overloading
{
    partial class Program
    {
        public class Account
        {
            private string name;
            private double balance;

            public Account(string name = "Unnamed Account", double balance = 0.0)
            {
                this.name = name;
                this.balance = balance;
            }

            public virtual bool Deposit(double amount)
            {
                if (amount < 0)
                    return false;
                else
                {
                    balance += amount;
                    return true;
                }
            }

            public virtual bool Withdraw(double amount)
            {
                if (balance - amount >= 0)
                {
                    balance -= amount;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public override string ToString()
            {
                return $"[Account: {name}: {balance}]";
            }
            public double CalculateAmountWithTheDeterminedPercentage()
            {
                return balance * 0.2;
            }

            public static Account operator+(Account  account1,Account account2)
            {
                Account account3 = new();
                account3.balance = account1.balance + account2.balance;
                account3.name = account1.name + account2.name;
                return account3;
            }
           
        }
        
    }  
}