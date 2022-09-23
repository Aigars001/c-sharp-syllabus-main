namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Max value: ");
            var val = Convert.ToInt32(Console.ReadLine());
            var str = "";

            for (int i = 1; i <= val; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                     str += "FizzBuzz ";
                }
                else if (i % 3 == 0)
                { 
                   str += "Fizz ";
                }
                else if (i % 5 == 0)
                { 
                   str += "Buzz ";
                }
                else
                {
                    str += i + " ";
                }

                if (i % 20 == 0)
                {
                    str += "\n";
                }
            }

            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}