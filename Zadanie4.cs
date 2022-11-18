using System;

namespace TabliceWielowymiaroweZestawWDP1
{
    class Zadanie4
    {
        static void Main2(string[] args)
        {
            char[][] jagged = ReadJaggedArrayFromStdInput();
            PrintJaggedArrayToStdOutput(jagged);
            jagged = TransposeJaggedArray(jagged);
            Console.WriteLine();
            PrintJaggedArrayToStdOutput(jagged);
        }
        //CODE HERE
        static char[][] ReadJaggedArrayFromStdInput()
        {
            int size = int.Parse(Console.ReadLine());

            char[][] dataArray = new char[size][];

            for (int i = 0; i < size; i++)
            {
                dataArray[i] = Array.ConvertAll(Console.ReadLine().Split(' '), el => Convert.ToChar(el));
            }

            return dataArray;
        }
        static char[][] TransposeJaggedArray(char[][] dataArray)
        {
            //Find max length
            int maxLength = 0;
            for (int i = 0; i < dataArray.Length; i++)
                if (dataArray[i].Length > maxLength)
                    maxLength = dataArray[i].Length;

            char[][] cloneArray = new char[maxLength][];
            char temp;

            for (int i = 0; i < cloneArray.Length; i++)
            {
                cloneArray[i] = new char[dataArray.Length];
                for (int ii = 0; ii < cloneArray[i].Length; ii++)
                {
                    if (ii < dataArray.Length && i < dataArray[ii].Length)
                        temp = dataArray[ii][i];
                    else
                        temp = ' ';
                    cloneArray[i][ii] = temp;
                }
            }

            return cloneArray;
        }
        static void PrintJaggedArrayToStdOutput(char[][] dataArray)
        {
            for (int i = 0; i < dataArray.Length; i++)
            {
                for (int ii = 0; ii < dataArray[i].Length; ii++)
                {
                    Console.Write("{0} ", dataArray[i][ii]);
                }
                Console.WriteLine();
            }
        }
    }
}