using System;
using System.Linq;

namespace _03.SquaresInMatrix
{
    class SquaresInMatrix
    {
        static void Main()
        {
            var matrixSizes = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = matrixSizes[0];
            var cols = matrixSizes[1];

            char[][] matrix = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
            }

            var count = 0;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i][j].Equals(matrix[i][j + 1])
                        && matrix[i][j + 1].Equals(matrix[i + 1][j])
                        && matrix[i + 1][j].Equals(matrix[i + 1][j + 1]))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
