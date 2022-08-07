namespace HangMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words =
            {
                "identity",
                "lean",
                "strain",
                "aspect",
                "stool"
            };
            GetMenu(words);
        }

        static void StartGame(string[] words)
        {
            bool hasWon = false;
            string missedChar = "";
            int missedCharCount = 0;
            int index = RandomNumber(words);
            var hiddenGuessableWordLinesArray = new string('_', words[index].Length).ToCharArray();
            string nonHiddenGuessableWord = words[RandomNumber(words)];

            Console.WriteLine(String.Join("", hiddenGuessableWordLinesArray));
            Console.WriteLine("\n");

            while (!hasWon)
            {
                Console.WriteLine("Guess word");
                var guessedChar = Console.ReadKey().KeyChar;
                var foundIndexes = new List<int>();

                if (nonHiddenGuessableWord.Contains(guessedChar))
                {
                    for (int i = 0; i < nonHiddenGuessableWord.Length; i++)
                    {
                        if (nonHiddenGuessableWord[i] == guessedChar)
                        {
                            foundIndexes.Add(i);
                        }
                    }
                }
                else
                {
                    if (!missedChar.Contains(guessedChar))
                    {
                        missedChar += guessedChar;
                        missedCharCount++;
                    }
                }

                foreach (var item in foundIndexes)
                {
                    hiddenGuessableWordLinesArray[item] = guessedChar;
                }

                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("Word:" + String.Join("", hiddenGuessableWordLinesArray));
                Console.WriteLine("Misses:" + missedChar);

                if (String.Join("", hiddenGuessableWordLinesArray) == nonHiddenGuessableWord)
                {
                    hasWon = true;
                    Console.Clear();
                    Console.WriteLine("word: " + nonHiddenGuessableWord + "\n");
                    Console.WriteLine("Misses:" + missedChar + "\n");
                    Console.WriteLine("YOU GOT IT!," + "\n" + "press any key to continue! \n" );
                    Console.ReadKey();
                    Console.Clear();
                    GetMenu(words);
                }
                else if (missedCharCount == 5)
                {
                    hasWon = true;
                    Console.Clear();
                    Console.WriteLine("Word:" + String.Join("", hiddenGuessableWordLinesArray));
                    Console.WriteLine("Misses:" + missedChar + "\n");
                    Console.WriteLine("YOU Lose!" + "\n" + "press any key to continue! \n");
                    Console.ReadKey();
                    Console.Clear();
                    GetMenu(words);
                }
            }
        }
        static void GetMenu(string[] words)
        {
            Console.WriteLine("Start Game? y/n");
            var userChoice = Console.ReadLine().ToLower();
            if (userChoice == "y")
            {
                StartGame(words);
            }
            else if (userChoice == "n")
            {
                Console.WriteLine("bye");
            }
            else
            {
                Console.WriteLine("Unknown command");
            }
        }
        static int RandomNumber(string[] words)
        {
            Random rnd = new Random();
            return rnd.Next(0, words.Length);
        }
    }
}