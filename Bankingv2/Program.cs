using System.Security.AccessControl;

namespace Bankingv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            Account a2 = new Account();

            Console.WriteLine($"Your balance is {a1.Balance:C} ");
            a1.Deposit(1000);
            Console.WriteLine($"Your current balance is {a1.Balance:C}");
            a1.Withdraw(100);
            Console.WriteLine($"Your current balance is {a1.Balance:C}");

            a1.Transfer(100,a2);
            Console.WriteLine($"A2 Balance {a2.Balance:C}");
        }
    }
}
