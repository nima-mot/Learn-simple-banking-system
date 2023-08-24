using BankLibrary;
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
            newAccount.MakeWithdrawal(5, DateTime.Now, "Coffe");
            
            Console.WriteLine(newAccount.GetAccountHistory());



        }
        
    }
}