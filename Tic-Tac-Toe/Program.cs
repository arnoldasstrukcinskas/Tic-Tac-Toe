using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[,]
            {
                { " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " " },
                { "-", "-", "-", "+", "-", "-", "-", "+", "-", "-", "-" },
                { " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " " },
                { "-", "-", "-", "+", "-", "-", "-", "+", "-", "-", "-" },
                { " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " " }
            };
            ////////////////////////////////////////////
            int input;
            int moves = 0;
            List<int> UsedCells = new List<int>();


            for (int choices = 1; choices > 0; choices++)           // loopina, kad be sustojimo veiktu programa
            {
                input = Convert.ToInt16(Console.ReadLine());
                if (input > 0 && input < 10 && !UsedCells.Contains(input))   // tikrina ar skaicius nuo 1 iki 9 ir ar langelis uzimtas
                {
                    UsedCells.Add(input);
                    array[boardPositionRow(input), boardPositionColumns(input)] = movesScanner(moves);      // tam tikrai pasirinktai zaidimo lentos vietai, priskiria # arba O
                    moves++;

                    for (int row = 0; row < array.GetLength(0); row++)              // printina lentos eilutes
                    {
                        for (int column = 0; column < array.GetLength(1); column++) // printina lentos stul
                        {
                            Console.Write(array[row, column]);
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Wrong MOVE!");
                }
                WinChecker(array);
            }
        }
        static string movesScanner(int number) // nustato ejimus ir parenka simboli. pirmas visada X.
        {
            if (number % 2 == 0)
            {
                return "X";
            }
            else
            {
                return "O";
            }
        }
        static void WinChecker(string[,] array) // Tikrina, kas laimejo
        {
            if(array[0,1].Contains("X") && array[0,5].Contains("X") && array[0,9].Contains("X")) //virsus
            {
                Console.WriteLine("First player WON!!");
            }
            else if (array[2,1].Contains("X") && array[2,5].Contains("X") && array[2,9].Contains("X")) //vidurys
            {
                Console.WriteLine("First player WON!!");
            }
            else if (array[4, 1].Contains("X") && array[4, 5].Contains("X") && array[4, 9].Contains("X")) // apacia
            {
                Console.WriteLine("First player WON!!");
            }
            else if (array[0, 1].Contains("X") && array[2, 1].Contains("X") && array[4, 1].Contains("X")) //pirmas stulpelis
            {
                Console.WriteLine("First player WON!!");
            }
            else if (array[0, 5].Contains("X") && array[2, 5].Contains("X") && array[4, 5].Contains("X")) // antras stulpelis
            {
                Console.WriteLine("First player WON!!");
            }
            else if (array[0, 9].Contains("X") && array[2, 9].Contains("X") && array[4, 9].Contains("X")) // trecias stulpelis
            {
                Console.WriteLine("First player WON!!");
            }
            else if (array[0, 1].Contains("X") && array[2, 5].Contains("X") && array[4, 9].Contains("X")) // skersas
            {
                Console.WriteLine("First player WON!!");
            }
            else if (array[4, 1].Contains("X") && array[2, 5].Contains("X") && array[0, 9].Contains("X")) // skersas
            {
                Console.WriteLine("First player WON!!");
            }
            /////////////////////////////////////////////////////////////////////
            else if (array[0, 1].Contains("O") && array[0, 5].Contains("O") && array[0, 9].Contains("O")) // virsus
            {
                Console.WriteLine("Second player WON!!");
            }
            else if (array[2, 1].Contains("O") && array[2, 5].Contains("O") && array[2, 9].Contains("O")) // vidurys
            {
                Console.WriteLine("Second player WON!!");
            }
            else if (array[4, 1].Contains("O") && array[4, 5].Contains("O") && array[4, 9].Contains("O")) // apacia
            {
                Console.WriteLine("Second player WON!!");
            }
            else if (array[0, 1].Contains("O") && array[2, 1].Contains("O") && array[4, 1].Contains("O")) //pirmas stulpelis
            {
                Console.WriteLine("Second player WON!!");
            }
            else if (array[0, 5].Contains("O") && array[2, 5].Contains("O") && array[4, 5].Contains("O")) // antras stulpelis
            {
                Console.WriteLine("Second player WON!!");
            }
            else if (array[0, 9].Contains("O") && array[2, 9].Contains("O") && array[4, 9].Contains("O")) // trecias stulpelis
            {
                Console.WriteLine("Second player WON!!");
            }
            else if (array[0, 1].Contains("O") && array[2, 5].Contains("O") && array[4, 9].Contains("O")) // skersas
            {
                Console.WriteLine("Second player WON!!");
            }
            else if (array[4, 1].Contains("O") && array[2, 5].Contains("O") && array[0, 9].Contains("O")) //skersas
            {
                Console.WriteLine("Second player WON!!");
            }
        }
        static int boardPositionRow(int number)  // nustato i kuri langeli irasyti
        {
            int answer = 0;
            switch (number) // nustato, kurioje eiluteje pasirinkimas
            {
                case 1:
                    {
                        if (number == 1)
                            answer = 4;
                        break;
                    }
                case 2:
                    {
                        if (number == 2)
                            answer = 4;
                        break;
                    }
                case 3:
                    {
                        if (number == 3)
                            answer = 4;
                        break;
                    }
                case 4:
                    {
                        if (number == 4)
                            answer = 2;
                        break;
                    }
                case 5:
                    {
                        if (number == 5)
                            answer = 2;
                        break;
                    }
                case 6:
                    {
                        if (number == 6)
                            answer = 2;
                        break;
                    }
                case 7:
                    {
                        if (number == 7)
                            answer = 0;
                        break;
                    }
                case 8:
                    {
                        if (number == 8)
                            answer = 0;
                        break;
                    }
                case 9:
                    {
                        if (number == 9)
                            answer = 0;
                        break;
                    }
                }
            return answer;
        }
        static int boardPositionColumns(int number)     // piesia zaidimo lenta
        {
            int answer = 0;
            switch (number) // nustato, kuriame stulpelyje yra atsakymas
            {
                case 1:
                    {
                        if (number == 1)
                            answer = 1;
                        break;
                    }
                case 2:
                    {
                        if (number == 2)
                            answer = 5;
                        break;
                    }
                case 3:
                    {
                        if (number == 3)
                            answer = 9;
                        break;
                    }
                case 4:
                    {
                        if (number == 4)
                            answer = 1;
                        break;
                    }
                case 5:
                    {
                        if (number == 5)
                            answer = 5;
                        break;
                    }
                case 6:
                    {
                        if (number == 6)
                            answer = 9;
                        break;
                    }
                case 7:
                    {
                        if (number == 7)
                            answer = 1;
                        break;
                    }
                case 8:
                    {
                        if (number == 8)
                            answer = 5;
                        break;
                    }
                case 9:
                    {
                        if (number == 9)
                            answer = 9;
                        break;
                    }
                }
            return answer;
        }
    }
}