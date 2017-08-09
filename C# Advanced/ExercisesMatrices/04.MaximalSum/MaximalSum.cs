using System;
using System.Linq;

namespace _04.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            var sizes = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = sizes[0];
            var cols = sizes[1];
            var startRow = 0;
            var startCol = 0;
            var sum = int.MinValue;

            int[][] matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    var currentSum = matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2]
                                     + matrix[i + 1][j] + matrix[i + 1][j + 1] + matrix[i + 1][j + 2]
                                     + matrix[i + 2][j] + matrix[i + 2][j + 1] + matrix[i + 2][j + 2];

                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        startRow = i;
                        startCol = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {sum}");

            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
