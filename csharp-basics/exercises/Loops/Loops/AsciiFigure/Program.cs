namespace AsciiFigure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int userInputRows = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < userInputRows; i++)
            {
                for (int j = (userInputRows - (i + 1)) * 4; j >= 1; j--)
                {
                    Console.Write("/");
                }
                for (int k = i + 1; k <= i * 9; k++)
                {
                    Console.Write("*");
                }
                for (int d = (userInputRows - (i + 1)) * 4; d >= 1; d--)
                {
                    Console.Write("\\");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}