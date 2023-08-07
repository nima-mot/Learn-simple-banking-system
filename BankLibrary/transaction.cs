using System;
using System.Collections.Generic;
using System.Text;
using Humanizer;

namespace BankLibrary
{
    public class Transaction
    {
        public decimal AmountTransaction { get; }

        public string AmountToWord
        {
            get
            {
                return ((int)AmountTransaction).ToWords();
            }
        }
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
