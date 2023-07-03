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
            const string PLAYER1 = "X";
            const string PLAYER2 = "O";
            bool playAgain = true;
            int player1Score = 0;
            int player2Score = 0;
            string currentPlayer = "";
            string[,] board = new string[3,3];

            Console.WriteLine("Let's play tic tac toe!");
            do
            {
                bool winner = false;
                bool gameOver = false;
                currentPlayer = PLAYER1;

                DisplayRules();
                board = CreateBoard(board);
                DisplayBoard(board);
                Console.ReadLine();
                do
                {
                    board = MakeMove(board, currentPlayer);
                    winner = CheckWin(board);

                    if (winner)
                    {
                        Console.WriteLine("{0} wins!", currentPlayer);
                        if (currentPlayer == PLAYER1)
                        {
                            player1Score += 1;
                        }
                        else
                        {
                            player2Score += 1;
                        }
                        gameOver = true;
                    }
                    else
                    {
                        currentPlayer = PLAYER2;
                    }
                } while (!gameOver);
                playAgain = PlayAgain();
            } while (playAgain);
            Console.WriteLine("Player 1 had {0} wins and Player 2 had {1} wins.", player1Score, player2Score);
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

        public static string[,] MakeMove(string[,] board, string player)
        {
            string playerMove = "";
            bool validMove = false;
            do
            {
                playerMove = GetMove();
                switch (playerMove)
                {
                    case "1":
                        if (board[0,0] == "1")
                        {
                            board[0,0] = "player";
                            validMove = true;
                        }
                        else
                        {
                            Console.WriteLine("That square is already taken. Pick another.");
                        }
                        break;
                    case "2":
                        if (board[0, 0] == "1")
                        {
                            board[0, 0] = "player";
                            validMove = true;
                        }
                        else
                        {
                            Console.WriteLine("That square is already taken. Pick another.");
                        }
                        break;
                    case "3":
                        if (board[0, 0] == "1")
                        {
                            board[0, 0] = "player";
                            validMove = true;
                        }
                        else
                        {
                            Console.WriteLine("That square is already taken. Pick another.");
                        }
                        break;
                    case "4":
                        if (board[0, 0] == "1")
                        {
                            board[0, 0] = "player";
                            validMove = true;
                        }
                        else
                        {
                            Console.WriteLine("That square is already taken. Pick another.");
                        }
                        break;
                    case "5":
                        if (board[0, 0] == "1")
                        {
                            board[0, 0] = "player";
                            validMove = true;
                        }
                        else
                        {
                            Console.WriteLine("That square is already taken. Pick another.");
                        }
                        break;
                    case "6":
                        if (board[0, 0] == "1")
                        {
                            board[0, 0] = "player";
                            validMove = true;
                        }
                        else
                        {
                            Console.WriteLine("That square is already taken. Pick another.");
                        }
                        break;
                    case "7":
                        if (board[0, 0] == "1")
                        {
                            board[0, 0] = "player";
                            validMove = true;
                        }
                        else
                        {
                            Console.WriteLine("That square is already taken. Pick another.");
                        }
                        break;
                    case "8":
                        if (board[0, 0] == "1")
                        {
                            board[0, 0] = "player";
                            validMove = true;
                        }
                        else
                        {
                            Console.WriteLine("That square is already taken. Pick another.");
                        }
                        break;
                    case "9":
                        if (board[0, 0] == "1")
                        {
                            board[0, 0] = "player";
                            validMove = true;
                        }
                        else
                        {
                            Console.WriteLine("That square is already taken. Pick another.");
                        }
                        break;
                }
            } while (validMove);


            return board;
        }

        public static string GetMove()
        {
            string move = "";
            bool validInput = false;

            do
            {
                Console.WriteLine("Pick an available square on the board(1-9): ");
                string input = Console.ReadLine();
                if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5" || input == "6" || input == "7" || input == "8" || input == "9")
                {
                    move = input;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Choice needs to be a number from 1 to 9. Try again.");
                }
            } while (!validInput);


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
        
        public static bool PlayAgain()
        {
            bool again = false;
            bool validInput = false;
            do
            {
                Console.WriteLine("Would you like to play again?(y/n): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "y")
                {
                    Console.WriteLine("Let's play another round.");
                    again = true;
                    validInput = true;
                }
                else if (input.ToLower() == "n")
                {
                    Console.WriteLine("See you next time.");
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. input should either by y or n. Try again.");
                }
            } while (!validInput);

            return again;
        }
    }
}