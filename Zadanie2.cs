using System;

namespace TabliceWielowymiaroweZestawWDP1
{
    class Zadanie2
    {
        static void Main2()
        {
            //MACIERZ 1
            int[] arrSize = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[,] dataArray1 = new int[arrSize[0], arrSize[1]];

            int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for (int i = 0; i < inputArray.Length; i++)
            {
                //Console.WriteLine("dataArray[{0}/{1}={3},{0}%{2}={4}] = {5}", i, arrSize[1], arrSize[1], i / arrSize[1], i % arrSize[1], inputArray[i]);
                dataArray1[i / arrSize[1], i % arrSize[1]] = inputArray[i];
            }

            //MACIERZ 2
            arrSize = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[,] dataArray2 = new int[arrSize[0], arrSize[1]];

            inputArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for (int i = 0; i < inputArray.Length; i++)
            {
                dataArray2[i / arrSize[1], i % arrSize[1]] = inputArray[i];
            }

            //Sprawdź czy mnożenie jest możliwe
            if (dataArray1.GetLength(1) != dataArray2.GetLength(0))
            {
                Console.WriteLine("impossible");
                return;
            }
            int sizeMul = dataArray1.GetLength(1);

            //Wykonaj mnożenie
            int[,] dataArray3 = new int[dataArray1.GetLength(0), dataArray2.GetLength(1)];
            for (int i = 0; i < dataArray3.GetLength(0); i++) //wiersze (poziomo)
            {
                for (int ii = 0; ii < dataArray3.GetLength(1); ii++) //kolumny (pionowo)
                {
                    int temp = 0;

                    for (int iii = 0; iii < sizeMul; iii++)
                        temp += dataArray1[i, iii] * dataArray2[iii, ii];

                    dataArray3[i, ii] = temp;
                }
            }

            //Wyświetl wynik mnożenia
            for (int i = 0; i < dataArray3.GetLength(0); i++)
            {
                for (int ii = 0; ii < dataArray3.GetLength(1); ii++)
                {
                    Console.Write("{0} ", dataArray3[i, ii]);
                }
                Console.WriteLine();
            }
        }
    }
}