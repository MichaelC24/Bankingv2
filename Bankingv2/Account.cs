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
            try
            {
                Balance -= withdraw;
                return true;
            }
            catch () {
               
            }
            //} return false;
        }
        //account number needs to be same type as the variable you pass to it
        public bool Transfer(decimal Amount, Account account)
        {
            var success = Withdraw(Amount);

            if (success) 
            {
               account.Deposit(Amount);
            }

            return true;
        }

        
    }
}

