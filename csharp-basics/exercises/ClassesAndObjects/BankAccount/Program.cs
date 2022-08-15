using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("Benson", (decimal)17.25);
            Account acc2 = new Account("Benson", (decimal)-17.25);
            Account acc3 = new Account("Benson", (decimal)0);
            Account acc4 = new Account("Benson", (decimal)200);

            Console.WriteLine(acc1.ShowUSerDetails());
            Console.WriteLine(acc2.ShowUSerDetails());
            Console.WriteLine(acc3.ShowUSerDetails());
            Console.WriteLine(acc4.ShowUSerDetails());
            Console.ReadKey();
        }
    }
}
