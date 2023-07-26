using System;
using System.Collections.Generic;


namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var newAccount = new BankAccount("nima mot", 423);
            Console.WriteLine($"account {newAccount.Number} was made for {newAccount.Owner.ToUpper()} whit {newAccount.BalanceOfAcuuount} balance.");

            newAccount.MakeWithdrawal(119, DateTime.Now, "Nike Air Force");
            //showing balnce change
            //Console.WriteLine(newAccount.BalanceOfAcuuount);

            //example for exception
            //newAccount.MakeDeposit(-400, DateTime.Now, "stealing");

            newAccount.MakeWithdrawal(50, DateTime.Now, "Xbox Game Pass");
            
            Console.WriteLine(newAccount.GetAccountHistory());


            // Test for a negative balance.
            // try
            //     {
            //         newAccount.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            //     }
            // catch (InvalidOperationException e)
            //     {
            //         Console.WriteLine("Exception caught trying to overdraw");
            //         Console.WriteLine(e.ToString());
            //     }


            // Test that the initial balances must be positive.
            // BankAccount invalidAccount;
            // try
            //     {
            //         invalidAccount = new BankAccount("invalid", -55);
            //     }
            // catch (ArgumentOutOfRangeException e)
            //     {
            //         Console.WriteLine("Exception caught creating account with negative balance");
            //         Console.WriteLine(e.ToString());
            //         return;
            //     }


        }
        
    }
}