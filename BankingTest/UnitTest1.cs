using System;
using Xunit;
using BankLibrary;
using System.Security.Principal;

namespace BankingTest
{
    public class UnitTest1
    {
        [Fact]
        public void OverdrawNotAllowed()
        {
            var newAccount = new BankAccount("nima mot", 423);

            // Test for a negative balance.
            Assert.Throws<InvalidOperationException>(
                ()=> newAccount.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw")
                );
        }

        [Fact]
        public void NeedMoneyToStart()
        {
            //Test that the initial balances must be positive.
            Assert.Throws<ArgumentOutOfRangeException>(
                ()=> new BankAccount("invalid", -55)
                );
        }
    }
}