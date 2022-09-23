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

        private static string missedChar = "";
        private static int missedCharCount = 0;
        private static int gameCount = 0;
        private static readonly string nonHiddenGuessableWord = RandomWord(words);
        private static char[] hiddenGuessableWordLinesArray = new string('_', nonHiddenGuessableWord.Length).ToCharArray();

        static void Main(string[] args)
        {
            GetMenu();
        }

        static void StartGame()
        {
            var win = isWinner();
            if (gameCount > 0)
            {
                win = false;
            }
            do
            {
                DisplayGame();
                isWinner();
                Looser();
                GameLogic();
            }
            while (!win);
        }

        private static void GameLogic()
        {
            var userInput = Console.ReadLine();

            if (userInput.Length > 1)
            {
                Console.WriteLine("Enter single letter");
                userInput = Console.ReadLine();
            }

            var guessedChar = Convert.ToChar(userInput);
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
                if (missedChar.Contains(guessedChar) || hiddenGuessableWordLinesArray.Contains(guessedChar))
                {
                    Console.WriteLine("Character already guessed");
                    Console.WriteLine("Try again");
                    guessedChar = Convert.ToChar(Console.ReadLine());
                }
                else
                {
                    missedChar += guessedChar;
                    missedCharCount++;
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
            Console.Write("Word: ");
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
                gameCount++;
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

        private static string RandomWord(string[] words)
        {
            Random rnd = new Random();
            var num = rnd.Next(0, words.Length);
            return words[num];
        }
    }
}