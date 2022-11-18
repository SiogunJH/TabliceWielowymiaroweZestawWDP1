using System;

namespace TabliceWielowymiaroweZestawWDP1
{
    class Zadanie5
    {
        static void Main5(string[] args)
        {
            int[,] sudoku = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                int[] userInput = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                for (int ii = 0; ii < userInput.Length; ii++)
                {
                    sudoku[i, ii] = userInput[ii];
                }
            }

            /*
            for (int i = 0; i < 9; i++)
            {
                for (int ii = 0; ii < 9; ii++)
                {
                    Console.Write("{0} ", sudoku[i, ii]);
                }
                Console.WriteLine();
            }
            */

            string isCorrect = "yes";
            for (int i = 0; i < 9; i++) //sprawdź wiersze
            {
                for (int ii = 0; ii < 9; ii++)
                {
                    for (int jj = ii; jj < 9; jj++)
                    {
                        if (ii != jj && (sudoku[i, ii] == sudoku[i, jj] || sudoku[ii, i] == sudoku[jj, i]))
                        {
                            isCorrect = "no";
                        }
                    }
                }
            }

            Console.WriteLine(isCorrect);

        }
    }
}