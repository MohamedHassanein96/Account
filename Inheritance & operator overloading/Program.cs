namespace Inheritance___operator_overloading
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Security.Principal;
 

    partial class Program
    {
        static void Main()
        {
            //accounts
            var accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account("larry"));
            accounts.Add(new Account("moe", 2000));
            accounts.Add(new Account("curly", 5000));

            AccountUtil.Display(accounts);
            AccountUtil.Deposit(accounts, 1000);
            AccountUtil.Withdraw(accounts, 2000);

            // savings
            var saveccounts = new List<SavingsAccount>();
            saveccounts.Add(new SavingsAccount());
            saveccounts.Add(new SavingsAccount("superman"));
            saveccounts.Add(new SavingsAccount("batman", 2000));
            saveccounts.Add(new SavingsAccount("wonderwoman", 5000, 5.0));

            AccountUtil.Display(saveccounts);
            AccountUtil.Deposit(saveccounts, 1000);
            AccountUtil.Withdraw(saveccounts, 2000);

            // checking
            var checkaccounts = new List<CheckingAccount>();
            checkaccounts.Add(new CheckingAccount());
            checkaccounts.Add(new CheckingAccount("larry2"));
            checkaccounts.Add(new CheckingAccount("moe2", 2000));
            checkaccounts.Add(new CheckingAccount("curly2", 5000));



            AccountUtil.Display(checkaccounts);
            AccountUtil.Deposit(checkaccounts, 1000);
            AccountUtil.Withdraw(checkaccounts, 2000);
            AccountUtil.Withdraw(checkaccounts, 2000);

            // trust
            var trustaccounts = new List<TrustAccount>();
            trustaccounts.Add(new TrustAccount());
            trustaccounts.Add(new TrustAccount("superman2"));
            trustaccounts.Add(new TrustAccount("batman2", 2000));
            trustaccounts.Add(new TrustAccount("wonderwoman2", 5000, 5.0));

            AccountUtil.Display(trustaccounts);
            AccountUtil.Deposit(trustaccounts, 1000);
            AccountUtil.Deposit(trustaccounts, 6000);
            AccountUtil.Withdraw(trustaccounts, 2000);
            AccountUtil.Withdraw(trustaccounts, 3000);
            AccountUtil.Withdraw(trustaccounts, 500);




            Console.WriteLine();
        }
       
    }  
}