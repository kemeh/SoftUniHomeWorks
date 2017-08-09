using System;
using System.Linq;

namespace _07.LegoBlocks
{
    class LegoBlocks
    {
        static void Main()
        {
            var rowsCount = int.Parse(Console.ReadLine());

            int[][] firstMatrix = new int[rowsCount][];
            int[][] secondMatrix = new int[rowsCount][];

            FillMatrix(firstMatrix, rowsCount);
            FillMatrix(secondMatrix, rowsCount);

            for (int row = 0; row < rowsCount; row++)
            {
                firstMatrix[row] = firstMatrix[row].Concat(secondMatrix[row].Reverse()).ToArray();
            }
            
            var initialCount = firstMatrix[0].Length;
            var count = initialCount;

            bool isLengthEqual = true;
            
            for (int i = 1; i < rowsCount; i++)
            {
                var currentCount = firstMatrix[i].Length;

                if (currentCount != initialCount)
                {
                    isLengthEqual = false;
                }

                count += currentCount;
            }

            PrintResult(isLengthEqual, count, firstMatrix);
            
        }

        private static void PrintResult(bool isLengthEqual, int count, int[][] matrix)
        {
            if (isLengthEqual)
            {
                foreach (var row in matrix)
                {
                    Console.WriteLine($"[{string.Join(", ", row)}]");
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {count}");
            }
        }

        private static void FillMatrix(int[][] matrix, int rows)
        {
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
        }
    }
}
