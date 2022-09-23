using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account matt = new Account("Matt's account", 1000);
            Account me = new Account("My account", 0);

            matt.Withdrawal(100);
            me.Deposit(100);

            Console.WriteLine(matt);
            Console.WriteLine(me);

            Account A = new Account("A", 100);
            Account B = new Account("B", 0);
            Account C = new Account("C", 0);

            Console.WriteLine("\nBefore transfer:");
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);

            Transfer(A, B, 50);
            Transfer(B, C, 25);
           
            Console.WriteLine("\nAfter transfer:");
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, decimal howMuch)
        {
            from.Withdrawal(howMuch);
            to.Deposit(howMuch);
        }
    }
}
