using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankingv2
{
    internal class Savings //: Account
    {
        //public decimal IntRate { get; set; } = 0.12m;

        //public void IntRates(int nbrOfMonths)
        //{   

        //     decimal intrest = Balance * (IntRate/12) * nbrOfMonths;
        //    Deposit(intrest);
        //}

        //public Savings(string description) : base(description) { }


        private Account acc = new Account("Savings Account");

        public decimal IntRate { get; set; } = .12m;

        public void IntRates(int nbrOfMonths)
        {

            decimal intrest = acc.Balance * (IntRate / 12) * nbrOfMonths;
            Deposit(intrest);
        }

        public int AccountId()
        {
            return acc.AccountId;
        }
        public string Description()
        {
            return acc.Description;
        }
        public void Description(string description)
        {
            acc.Description = description;
        }
        public decimal Balance()
        {
            return acc.Balance;
        }
        public bool Deposit(decimal Amount)
        {
            return acc.Deposit(Amount);
        }
        public bool Withdraw(decimal Amount)
        {
            return acc.Withdraw(Amount);
        }
        public bool Transfer(decimal Amount, Savings savings)
        {
            if (acc.Withdraw(Amount))
            {
                savings.Deposit(Amount);
            }
            return true;
        }
        public Savings(string description) 
        {
            new Account("Savings Account");
        }
    }
}
