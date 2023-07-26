using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankAccount
    {
        //Properties
        public string Number { get;}
        public string Owner { get; set; }
        public decimal BalanceOfAcuuount
        {
            get
            {
                decimal Tempbalance = 0;
                foreach (var item in Alltransactions)
                {
                  Tempbalance += item.AmountTransaction;
                }
                return Tempbalance;
            }
        }

        //Account Number Seed
        private static int accountNumberSeed = 1234567890; 


        //List of all transactions of each account
        private List<Transaction> Alltransactions = new List<Transaction>();


        //BankAccount Constructor
        public BankAccount(string name, decimal initialBalace)
        {
            this.Owner = name;
            MakeDeposit(initialBalace, DateTime.Now, "inittial balance & account created.");
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }


        //Methods - make a deposit
        public void MakeDeposit(decimal amount, DateTime date, string notes)
        {
            if (amount <= 0)
             {
               throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
             }
             var deposit = new Transaction(amount, date, notes);
             Alltransactions.Add(deposit);
             
        }


        //Methods - make a withdrawal
        public void MakeWithdrawal(decimal amount, DateTime date, string notes)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (BalanceOfAcuuount - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
                
            }
            var withdrawal = new Transaction(-amount, date, notes);
            Alltransactions.Add(withdrawal);
        }


        //Methods - get the account transactions history
        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            report.Append("Date\t\tAmount\tNotes");
            foreach(var item in Alltransactions)
            {
                report.Append($"\t{item.Date}\t{item.AmountTransaction}\t{item.Notes}\t");
            }
            return report.ToString();
        }


    }
}

