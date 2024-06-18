using System.Security.AccessControl;

namespace Bankingv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Savings("Savings1");
            var a2 = new Savings("Savings2");

            Console.WriteLine($"Your balance is {a1.Balance:C} ");
            a1.Deposit(1000);
            Console.WriteLine($"Your current balance is {a1.Balance:C}");
            a1.Withdraw(100);
            Console.WriteLine($"Your current balance is {a1.Balance:C}");

            a1.Transfer(100,a2);
            Console.WriteLine($"A2 Balance {a2.Balance:C}");

            a1.IntRates(1);
            Console.WriteLine($" Your balance is {a1.Balance : C}");
      }
    }
}
