using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bankingv2
{
    public class Account
    {
        private static int nextId { get; set; } = 1;
        public int AccountId { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        public decimal Balance { get; set; } = 0;

        public bool Deposit(decimal deposit)
        {
            if (deposit > 0)
            {
                Balance += deposit;
                return true;
            }
            return false;

        }

        public bool Withdraw(decimal withdraw)
        {
            if (withdraw <= Balance)
            {
                Balance -= withdraw;
                return true;

            } return false;
        }
        //account number needs to be same type as the variable you pass to it
        public bool Transfer(decimal Amount, Account account)
        {
            bool success = Withdraw(Amount);

            if (success) 
            {
               account.Deposit(Amount);
            }

            return true;
        }

        public Account(string description)
        {
            AccountId = nextId++;
            Description = description;
            Balance = 0;
        }
    }
}