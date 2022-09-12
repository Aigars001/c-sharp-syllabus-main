using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory phone = new PhoneDirectory();

            phone.PutNumber("John", "2131231");
            phone.PutNumber("Jane", "2132424");

            Console.WriteLine(phone.GetNumber("John"));
            Console.WriteLine(phone.GetNumber("Jane"));
            Console.WriteLine(phone.GetNumber("David"));
            Console.ReadKey();
        }
    }
}
