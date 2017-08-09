using System;
using System.Linq;

namespace _02.DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main()
        {
            var rowCol = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rowCol][];

            for (int i = 0; i < rowCol; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var primaryDiagonalSum = 0;
            var secondaryDiagonalSum = 0;

            for (int i = 0; i < rowCol; i++)
            {
                primaryDiagonalSum += matrix[i][i];
                secondaryDiagonalSum += matrix[i][rowCol - i - 1];
            }

            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}
