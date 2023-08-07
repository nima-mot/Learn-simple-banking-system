using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public class Transaction
    {
        public decimal AmountTransaction { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string notes)
        {
            this.AmountTransaction = amount;
            this.Date = date;
            this.Notes = notes;

        }


    }
}
