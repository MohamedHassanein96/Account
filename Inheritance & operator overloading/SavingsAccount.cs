using System.Xml.Linq;

namespace Inheritance___operator_overloading
{
    partial class Program
    {
        class SavingsAccount :Account
        {
            
            public SavingsAccount(string name = "Unnamed Account",  double balance = 0.0 ,double interestRate=0) : base(name,balance)
            {
                InterestRate = interestRate;
            }

            public double InterestRate { get; set; }

            public override bool Deposit(double amount)
            {
                return base.Deposit(amount);
            }
            public override string ToString()
            {
                 var toString =base.ToString();
                return toString + " and the interestRate: " + InterestRate;
            }
        }
        
    }  
}