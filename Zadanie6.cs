using System;

namespace TabliceWielowymiaroweZestawWDP1
{
    class Zadanie6
    {
        static void Main(string[] args)
        {
            //Define variables
            int[] arrSize = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[,] dataArray = new int[arrSize[0], arrSize[1]];
            char[] userInput;

            //Read data
            for (int i = 0; i < arrSize[0]; i++)
            {
                userInput = Console.ReadLine().ToCharArray();
                for (int ii = 0; ii < arrSize[1]; ii++)
                {
                    if (userInput[ii] == '*')
                        dataArray[i, ii] = -1;
                    else
                        dataArray[i, ii] = 0;
                }
            }

            //Update data
            int bombCount = 0;
            for (int i = 0; i < arrSize[0]; i++)
            {
                for (int ii = 0; ii < arrSize[1]; ii++)
                {
                    bombCount = 0;
                    if ((i - 1 >= 0 && ii - 1 >= 0) && dataArray[i - 1, ii - 1] == -1) //LEFT TOP
                        bombCount++;
                    if ((i - 1 >= 0) && dataArray[i - 1, ii] == -1) //MID TOP
                        bombCount++;
                    if ((i - 1 >= 0 && ii + 1 < arrSize[1]) && dataArray[i - 1, ii + 1] == -1) //RIGHT TOP
                        bombCount++;
                    if ((ii - 1 >= 0) && dataArray[i, ii - 1] == -1) //LEFT MID
                        bombCount++;
                    if ((ii + 1 < arrSize[1]) && dataArray[i, ii + 1] == -1) //RIGHT MID
                        bombCount++;
                    if ((i + 1 < arrSize[0] && ii - 1 >= 0) && dataArray[i + 1, ii - 1] == -1) //LEFT BOTTOM
                        bombCount++;
                    if ((i + 1 < arrSize[0]) && dataArray[i + 1, ii] == -1) //MID BOTTOM
                        bombCount++;
                    if ((i + 1 < arrSize[0] && ii + 1 < arrSize[1]) && dataArray[i + 1, ii + 1] == -1) //RIGHT BOTTOM
                        bombCount++;
                    if (dataArray[i, ii] != -1)
                    {
                        dataArray[i, ii] = bombCount;
                    }
                }
            }

            //Display data
            for (int i = 0; i < arrSize[0]; i++)
            {
                for (int ii = 0; ii < arrSize[1]; ii++)
                {

                    if (dataArray[i, ii] == 0)
                        Console.Write(".");
                    else if (dataArray[i, ii] == -1)
                        Console.Write("*");
                    else
                        Console.Write(dataArray[i, ii]);
                }
                Console.WriteLine();
            }
        }
    }
}