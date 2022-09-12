namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var numberArray = new int[20];

            for (int i = 0; i < numberArray.Length; i++)
            {
                int number = rnd.Next(0, 100);
                numberArray[i] = number;
            }
            
            Console.WriteLine(String.Join(" ", numberArray));
            Console.WriteLine("Which number position you would like to know?");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (numberArray.Contains(userInput))
            {
                int index = Array.IndexOf(numberArray, userInput);
                Console.WriteLine($"Number is located at index: {index}");
            }
            else
            {
                Console.WriteLine("No number found");
            }

            Console.ReadKey();
        }
    }
}
