using System;

namespace TabliceWielowymiaroweZestawWDP1
{
    class Zadanie1
    {
        static void Main1()
        {
            //Wczytaj rozmiar
            int[] arrSize = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            //Utwórz tablicę 2D
            int[,] dataArray = new int[arrSize[0], arrSize[1]];

            //Wczytaj dane
            for (int i = 0; i < arrSize[0]; i++)
            {
                int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                for (int ii = 0; ii < arrSize[1]; ii++)
                {
                    dataArray[i, ii] = inputArray[ii];
                }
            }

            //Wyświetl dane
            for (int i = 0; i < arrSize[1]; i++)
            {
                for (int ii = 0; ii < arrSize[0]; ii++)
                {
                    Console.Write("{0} ", dataArray[ii, i]);
                }
                Console.WriteLine();
            }
        }
    }
}