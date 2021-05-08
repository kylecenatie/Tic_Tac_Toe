using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tick_Tac_Toe
{
    class tic_tac_toe
    {
            public int player = 1;
            public string p = "X";

            public string[,] matrix =
            {
            {"1","2","3"},
            {"4","5","6"},
            {"7","8","9"}
            };
            public void UpdateBoard()
            {
                Console.WriteLine("   |   |   ");
                Console.WriteLine(" {0} | {1} | {2} ", matrix[0, 0], matrix[0, 1], matrix[0, 2]);
                Console.WriteLine("___|___|___");
                Console.WriteLine("   |   |   ");
                Console.WriteLine(" {0} | {1} | {2} ", matrix[1, 0], matrix[1, 1], matrix[1, 2]);
                Console.WriteLine("___|___|___");
                Console.WriteLine("   |   |   ");
                Console.WriteLine(" {0} | {1} | {2} ", matrix[2, 0], matrix[2, 1], matrix[2, 2]);
                Console.WriteLine("   |   |   ");

            }
            public void StartGame()
            {
                int count = 1;
                bool gamePlay = true;
                while (gamePlay)
                {
                    Console.WriteLine("Player {0}: Choose your field!", player);
                    string spot = Console.ReadLine();
                    if (CheckBoard(spot))
                    {
                        if (CheckWinner())
                        {
                            Console.WriteLine("Congrats player {0}! You have just won!", player);
                            gamePlay = false;
                        }
                        else
                        {
                            PlayerSwitch();
                            count++;
                            if (count == 9)
                            {
                                Console.WriteLine("This game is a draw!");
                                gamePlay = false;
                            }
                        }
                    }
                }
                Console.WriteLine("Would you like to play another game Y or N?");
                string r = Console.ReadLine();
                if (r.Equals("Y"))
                    ResetGame();
                else if (r.Equals("N"))
                    Console.WriteLine("Well it was fun playing with you!");
                else
                    Console.WriteLine("You didnt select a correct response! Well call it good for now");
            }
            private bool CheckBoard(string spot)
            {
                switch (spot)
                {
                    case "1":
                        if (CheckSpace(matrix[0, 0]))
                        {
                            matrix[0, 0] = p;
                            UpdateBoard();
                            return true;
                        }
                        else
                            return false;
                    case "2":
                        if (CheckSpace(matrix[0, 1]))
                        {
                            matrix[0, 1] = p;
                            UpdateBoard();
                            return true;
                        }
                        else
                            return false;
                    case "3":
                        if (CheckSpace(matrix[0, 2]))
                        {
                            matrix[0, 2] = p;
                            UpdateBoard();
                            return true;
                        }
                        else
                            return false;
                    case "4":
                        if (CheckSpace(matrix[1, 0]))
                        {
                            matrix[1, 0] = p;
                            UpdateBoard();
                            return true;
                        }
                        else
                            return false;
                    case "5":
                        if (CheckSpace(matrix[1, 1]))
                        {
                            matrix[1, 1] = p;
                            UpdateBoard();
                            return true;
                        }
                        else
                            return false;
                    case "6":
                        if (CheckSpace(matrix[1, 2]))
                        {
                            matrix[1, 2] = p;
                            UpdateBoard();
                            return true;
                        }
                        else
                            return false;
                    case "7":
                        if (CheckSpace(matrix[2, 0]))
                        {
                            matrix[2, 0] = p;
                            UpdateBoard();
                            return true;
                        }
                        else
                            return false;
                    case "8":
                        if (CheckSpace(matrix[2, 1]))
                        {
                            matrix[2, 1] = p;
                            UpdateBoard();
                            return true;
                        }
                        else
                            return false;
                    case "9":
                        if (CheckSpace(matrix[2, 2]))
                        {
                            matrix[2, 2] = p;
                            UpdateBoard();
                            return true;
                        }
                        else
                            return false;
                    default:
                        Console.WriteLine("Unfortunately you did not choose a correct spot. Please try again");
                        return false;
                }

            }
            private bool CheckSpace(string m)
            {
                if (m.Equals("X") || m.Equals("O"))
                {
                    Console.WriteLine("A player already played this spot...");
                    return false;
                }
                else
                {
                    Console.WriteLine("Good spot player {0}", player);
                    return true;
                }
            }
            private bool CheckWinner()
            {
                if (matrix[0, 0].Equals(matrix[0, 1]) && matrix[0, 1].Equals(matrix[0, 2]))
                    return true;
                else if (matrix[1, 0].Equals(matrix[1, 1]) && matrix[1, 1].Equals(matrix[1, 2]))
                    return true;
                else if (matrix[2, 0].Equals(matrix[2, 1]) && matrix[2, 1].Equals(matrix[2, 2]))
                    return true;
                else if (matrix[0, 0].Equals(matrix[1, 0]) && matrix[1, 0].Equals(matrix[2, 0]))
                    return true;
                else if (matrix[0, 1].Equals(matrix[1, 1]) && matrix[1, 1].Equals(matrix[2, 1]))
                    return true;
                else if (matrix[0, 2].Equals(matrix[1, 2]) && matrix[1, 2].Equals(matrix[2, 2]))
                    return true;
                else if (matrix[0, 0].Equals(matrix[1, 1]) && matrix[1, 1].Equals(matrix[2, 2]))
                    return true;
                else if (matrix[0, 2].Equals(matrix[1, 1]) && matrix[1, 1].Equals(matrix[2, 0]))
                    return true;
                else
                    return false;
            }
            private void PlayerSwitch()
            {
                if (player == 1)
                {
                    player = 2;
                    p = "O";
                }
                else
                {
                    player = 1;
                    p = "X";
                }
            }
            private void ResetGame()
            {
                matrix[0, 0] = "1";
                matrix[0, 1] = "2";
                matrix[0, 2] = "3";
                matrix[1, 0] = "4";
                matrix[1, 1] = "5";
                matrix[1, 2] = "6";
                matrix[2, 0] = "7";
                matrix[2, 1] = "8";
                matrix[2, 2] = "9";
                UpdateBoard();
                StartGame();
            }

            static void Main(string[] args)
            {
                tic_tac_toe game = new tic_tac_toe();
                game.UpdateBoard();
                game.StartGame();
                Console.ReadKey();
            }
    }
}
