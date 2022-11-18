using System;

namespace TabliceWielowymiaroweZestawWDP1
{
    class Zadanie3
    {
        static void Main3()
        {
            //Define variables
            string userInput;
            System.Collections.Generic.List<int[]> arrList = new System.Collections.Generic.List<int[]>();

            //Await input
            int columnCount = 0;
            while ((userInput = Console.ReadLine()) != null && userInput != "")
            {
                columnCount = userInput.Split(' ').Length;
                arrList.Add(Array.ConvertAll(userInput.Split(' '), int.Parse));
            }

            /*
            //Display data
            for (int i = 0; i < arrList.Count; i++)
            {
                for (int ii = 0; ii < arrList[i].Length; ii++)
                {
                    Console.Write("{0} ", arrList[i][ii]);
                }
                Console.WriteLine();
            }
            */

            //Count comulns sums
            int rowCount = arrList.Count;
            int[] columnSum = new int[columnCount];
            for (int i = 0; i < columnCount; i++)
            {
                columnSum[i] = 0;
                for (int ii = 0; ii < rowCount; ii++)
                {
                    columnSum[i] += arrList[ii][i];
                }
            }

            //Find max
            int index = 0;
            int max = 0;
            for (int i = 0; i < columnCount; i++)
            {
                if (columnSum[i] > max)
                {
                    max = columnSum[i];
                    index = i;
                }
            }

            //Display index
            Console.WriteLine(index);
        }
    }
}