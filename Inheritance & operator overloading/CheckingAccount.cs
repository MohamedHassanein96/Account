namespace Inheritance___operator_overloading
{
    partial class Program
    {
        class CheckingAccount : Account
        {
            const double feeOfWithdrawalTransaction = 1.50;
            public CheckingAccount(string name = "Unnamed Account", double balance = 0.0) : base(name, balance)
            {

            }
            public override bool Withdraw(double amount)
            {
                var res = amount -= feeOfWithdrawalTransaction;
                if (base.Withdraw(res))
                {
                    return true;
                }
                else return false;
            }
            public override string ToString()
            {
                return base.ToString();
            }
        }
        
     }  
}