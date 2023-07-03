namespace TicTacToeChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Display welcome message
            // Display rules
            // Create board
            // Start game loop
            //  Start player 1 turn
            //      Get move
            //      Set move on board
            //  Check for win
            //      If win, display game over message with winner
            //  Start player 2 turn
            //      Get move
            //      Set move on board
            //  Check for win
            //      If win, display game over message with winner


        }

        public static bool Checker(string[,] board)
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