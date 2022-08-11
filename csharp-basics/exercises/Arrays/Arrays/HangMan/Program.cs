namespace HangMan
{
    internal class Program
    {
        private static string[] words =
        {
            "identity",
            "lean",
            "strain",
            "aspect",
            "stool"
        };

        private static int index = RandomNumber(words);
        private static string missedChar = "";
        private static int missedCharCount = 0;
        private static readonly string nonHiddenGuessableWord = RandomWord(words);
        private static char[] hiddenGuessableWordLinesArray = new string('_', nonHiddenGuessableWord.Length).ToCharArray();

        static void Main(string[] args)
        {
            GetMenu();
        }

        static void StartGame()
        {
            Console.WriteLine(String.Join("", hiddenGuessableWordLinesArray));
            while (!isWinner())
            {
                DisplayGame();
                isWinner();
                Looser();
                GameLogic();
            }
        }

        private static void GameLogic()
        {
            var guessedChar = Char.Parse(Console.ReadLine().ToLower());
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
                else
                {
                    Console.WriteLine("Character already guessed");
                }
            }

            foreach (var item in foundIndexes)
            {
                hiddenGuessableWordLinesArray[item] = guessedChar;
            }
        }

        private static void DisplayGame()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(String.Join("", hiddenGuessableWordLinesArray));
            Console.WriteLine($"Misses: {missedChar}");
            Console.Write("Guess: ");
            
        }

        private static bool isWinner()
        {
            bool win = false;
            if (String.Join("", hiddenGuessableWordLinesArray) == nonHiddenGuessableWord)
            {
                win = true;
                Console.Clear();
                Console.WriteLine("Word:" + String.Join("", hiddenGuessableWordLinesArray));
                Console.WriteLine("Misses:" + missedChar + "\n");
                Console.WriteLine("YOU GOT IT!," + "\n");
                ExitGame();
            }

            return win;
        }

        private static void Looser()
        {
            if (missedCharCount == 5)
            {
                Console.Clear();
                Console.WriteLine("Word:" + String.Join("", hiddenGuessableWordLinesArray));
                Console.WriteLine("Misses:" + missedChar + "\n");
                Console.WriteLine("YOU Lose!" + "\n" );
                ExitGame();
            }
        }

        private static void ExitGame()
        {
            Console.WriteLine("Do you want to continue? y/n");
            var userInput = Console.ReadLine().ToLower();
            if (userInput == "y")
            {
                StartGame();
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Thanks for playing!");
                Console.ReadKey();
                Environment.Exit(0);
            }

        }

        private static void GetMenu()
        {
            Console.WriteLine("Start Game? y/n");
            var userChoice = Console.ReadLine().ToLower();
            if (userChoice == "y")
            {
                StartGame();
            }
            else if (userChoice == "n")
            {
                Console.Clear();
                Console.WriteLine("bye");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Unknown command");
                Environment.Exit(0);
            }
        }
        private static int RandomNumber(string[] words)
        {
            Random rnd = new Random();
            return rnd.Next(0, words.Length);
        }

        private static string RandomWord(string[] words)
        {
            return words[index];
        }
    }
}