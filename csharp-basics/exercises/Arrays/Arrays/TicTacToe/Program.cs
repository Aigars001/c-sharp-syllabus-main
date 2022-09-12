using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
            Console.ReadKey();
            PlayGame();
        }

        public static char GetTurn()
        {
            int countX = 0;
            int countO = 0;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 'X')
                    {
                        countX++;
                    }
                    else if (board[i, j] == 'O')
                    {
                        countO++;
                    }
                }
            }

            return (countX == countO) ? 'X' : 'O';
        }
        private static char GetWinner()
        {
            if (board[0, 0] == board[0, 1] && board[0, 2] == board[0, 0] && board[0, 0] != ' ')
            {
                return board[0, 0];
            }

            if (board[1, 0] == board[1, 1] && board[1, 2] == board[1, 0] && board[1, 0] != ' ')
            {
                return board[1, 0];
            }

            if (board[2, 0] == board[2, 1] && board[2, 2] == board[2, 0] && board[2, 0] != ' ')
            {
                return board[2, 0];
            }

            if (board[0, 0] == board[1, 0] && board[2, 0] == board[0, 0] && board[0, 0] != ' ')
            {
                return board[0, 0];
            }

            if (board[0, 1] == board[1, 1] && board[2, 1] == board[0, 1] && board[0, 1] != ' ')
            {
                return board[0, 1];
            }

            if (board[0, 2] == board[1, 2] && board[2, 2] == board[0, 2] && board[0, 2] != ' ')
            {
                return board[0, 2];
            }

            if (board[0, 0] == board[1, 1] && board[2, 2] == board[0, 0] && board[0, 0] != ' ')
            {
                return board[0, 0];
            }

            if (board[0, 2] == board[1, 1] && board[2, 0] == board[0, 2] && board[0, 2] != ' ')
            {
                return board[0, 2];
            }

            return ' ';
        }

        private static void MakeMove()
        {
            if (GetTurn() == 'X')
            {
                 Console.WriteLine("Player X Choose row and column");
            }
            else
            {
                Console.WriteLine("Player O Choose row and column");
            }

            string input = Console.ReadLine();
            string[] move = input.Split(' ');

            int row = Convert.ToInt32(move[0]);
            int col = Convert.ToInt32(move[1]);

            if (row > 2 || row < 0 || col > 2 || col < 0)
            {
                Console.WriteLine("Choose correct field");
            }
            else
            {
                if (board[row, col] == ' ')
                {
                    board[row, col] = GetTurn();
                    Console.Clear();
                    DisplayBoard();
                    return;
                }

                if (board[row, col] != ' ')
                {
                    Console.WriteLine("Pick empty field");
                    Console.Clear();
                    DisplayBoard();
                    return;
                }
            }
            Console.ReadLine();
        }

        private static bool IsTie()
        {
            bool tie = false;
            var board1 = new List<char>();

            foreach (char c in board)
            {
                board1.Add(c);
            }
            
            for (var i = 0; i < board1.Count; i++)
            {
                if (!board1.Contains(' ') && GetWinner() == ' ')
                {
                    tie = true;
                }
            }
            return tie;
        }

        private static void PlayGame()
        {
            int turns = 1;
            for (var i = 0; i < turns; i++)
            {
                if (GetWinner() == ' ' && IsTie() == false)
                {
                    MakeMove();
                    turns++;
                }
                else if (IsTie())
                {
                    Console.WriteLine("Game tie");
                }
                else
                {
                    Console.WriteLine("Winner is Player: " + GetWinner());
                }
            }
            Console.ReadLine();
        }

        private static void InitBoard()
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine(board[0, 0] + "  | " + board[0, 1] + " | " + board[0, 2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(board[1, 0] + "  | " + board[1, 1] + " | " + board[1, 2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(board[2, 0] + "  | " + board[2, 1] + " | " + board[2, 2]);
            Console.WriteLine("\n");
        }
    }
}
