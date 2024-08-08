using System.ComponentModel.DataAnnotations;

namespace Inheritance___operator_overloading
{
    partial class Program
    {
        class TrustAccount :Account
            
        {
            
            const int BounceDeposit = 50;
            public int interestRate;
            const int MaxWithdrawalPerYear = 3;
            private int WithDrawlCount = 0;
            private DateTime accountCreationDate;
            public TrustAccount( string name = "Unnamed Account", double balance = 0.0,double interestRate=0) : base (name, balance)
            {
               InterestRate=interestRate;
               accountCreationDate = DateTime.Now;
            }

            public double InterestRate { get; set; }

           
            
            public override bool Deposit(double amount)
            {
                if (amount >= 5000)
                {
                    amount += BounceDeposit;
                    return base.Deposit(amount);
                }
                else
                {
                    return base.Deposit(amount);
                }
            }
            public override string ToString()
            {
                var toString = base.ToString();
                return toString + " and the interestRate: " + InterestRate;
            }
            public override bool Withdraw(double amount)
              
            { 
                double calculatePercentage = this.CalculateAmountWithTheDeterminedPercentage();
                
               
                if (DateTime.Now.Year > accountCreationDate.Year)
                {
                    WithDrawlCount = 0;
                    accountCreationDate = DateTime.Now;
                    return false;
                }

                if (WithDrawlCount> MaxWithdrawalPerYear)
                {
                    Console.WriteLine("sorry you have 3 Withdrawal only PerYear");
                    return false;
                }
                
                if (amount< calculatePercentage)
                {
                    base.Withdraw(amount);
                    WithDrawlCount++;
                    return true;
                }
                else
                {
                    Console.WriteLine("the amount you want to withdraw must be less than the account balance ");
                    return false;
                }

            }
        }
    }  
}