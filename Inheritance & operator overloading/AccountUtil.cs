﻿namespace Inheritance___operator_overloading
{
    using System;
    using System.Collections.Generic;

    partial class Program
    {
        public static class AccountUtil
        {
            // Utility helper functions for Account class

            public static void Display<T>(List<T> accounts) where T : Account
            {
                Console.WriteLine("\n=== Accounts ==========================================");
                foreach (var acc in accounts)
                {
                    Console.WriteLine(acc);
                }
            }

            public static void Deposit<T>(List<T> accounts, double amount) where T : Account
            {
                Console.WriteLine("\n=== Depositing to Accounts =================================");
                foreach (var acc in accounts)
                {
                    
                    if (acc.Deposit(amount))
                        Console.WriteLine($"Deposited {amount} to {acc}");
                    else
                        Console.WriteLine($"Failed Deposit of {amount} to {acc}");
                }
            }

            public static void Withdraw<T>(List<T> accounts, double amount) where T:Account
            {
                Console.WriteLine("\n=== Withdrawing from Accounts ==============================");
                foreach (var acc in accounts)
                {
                    if (acc.Withdraw(amount))
                        Console.WriteLine($"Withdrew {amount} from {acc}");
                    else
                        Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
                }
            }
            
        }
    }  
}