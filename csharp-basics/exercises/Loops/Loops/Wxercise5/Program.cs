namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write fist word");
            var first = Console.ReadLine();
            Console.WriteLine("Write second word");
            var second = Console.ReadLine();

            var sumWordsLength = (first + second).Length;
            
            Console.Write(first);
            for (int i = 0; i < 30 - sumWordsLength; i++)
            {
                Console.Write(".");
            }

            Console.Write(second);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}