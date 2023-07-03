namespace TicTacToeChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Display welcome message
            // Start new game loop
            //  Display rules
            //  Create board
            //  Start game loop
            //      Start player 1 turn
            //          Get move
            //          Set move on board
            //      Check for win
            //          If win, display game over message with winner
            //      Start player 2 turn
            //          Get move
            //          Set move on board
            //      Check for win
            //          If win, display game over message with winner
            //  End game loop
            // End new game loop
            bool playAgain = true;
            int player1Score = 0;
            int player2Score = 0;
            string[,] board = new string[3,3];

            Console.WriteLine("Let's play tic tac toe!");
            do
            {
                bool gameOver = false;

                DisplayRules();
                board = CreateBoard(board);
                DisplayBoard(board);
                Console.ReadLine();
                do
                {

                } while (!gameOver);
            } while (playAgain);
        }

        public static string[,] CreateBoard(string[,] board)
        {
            string[,] newBoard = new string[,]
                {
                    {"1", "2", "3"},
                    {"4", "5", "6"},
                    {"7", "8", "9"}
                };

            return newBoard;
        }

        public static void DisplayRules()
        {
            Console.WriteLine("Player 1 is X and player 2 is O.");
            Console.WriteLine("Match three in a row to win.");
            Console.WriteLine("Game Start!");
        }

        public static void DisplayBoard(string[,] board)
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", board[0,0], board[0, 1], board[0, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("   |   |   ");
        }

        public string MakeMove()
        {
            string move = "";

            return move;
        }


        public static bool CheckWin(string[,] board)
        {
            bool winner = false;

            // Horizontal check
            if (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2])
            {
                winner = true;
            }
            if (board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2])
            {
                winner = true;
            }
            if (board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2])
            {
                winner = true;
            }

            // Vertical check
            if (board[0, 0] == board[1, 0] && board[2, 0] == board[0, 0])
            {
                winner = true;
            }
            if (board[0, 1] == board[1, 1] && board[2, 1] == board[0, 1])
            {
                winner = true;
            }
            if (board[0, 2] == board[1, 2] && board[2, 2] == board[0, 2])
            {
                winner = true;
            }

            // Diaganol check
            if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
            {
                winner = true;
            }
            if (board[0, 2] == board[1, 1] && board[2, 0] == board[0, 2])
            {
                winner = true;
            }
            return winner;
        }
    }
}