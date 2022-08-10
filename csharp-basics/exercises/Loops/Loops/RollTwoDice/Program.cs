namespace RollTwoDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 2 to 12");
            var userInput = Console.ReadLine();
            var rnd = new Random();
            var sumOfRandomNumbers = 0;

            Console.Clear();
            Console.WriteLine($"Desired number {userInput}");

            if (int.TryParse(userInput, out int intValUserInput))
            {
                if (intValUserInput < 2 || intValUserInput > 12)
                {
                    Console.WriteLine("Error out of bound");
                }
                else
                {
                     while (sumOfRandomNumbers != intValUserInput)
                     {
                         int num1 = rnd.Next(1,7);
                         int num2 = rnd.Next(1,7);
                         sumOfRandomNumbers = num1 + num2;

                         Console.WriteLine($"{num1} + {num2} = {sumOfRandomNumbers}");
                     }
                }
            }
            else
            {
                Console.WriteLine("Error not a number");
            }

            Console.ReadKey();
        }
    }
}
