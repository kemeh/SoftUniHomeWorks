using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Crossfire
{
    class Crossfire
    {
        static void Main()
        {
            var sizes = Console.ReadLine().Split();
            var rowCount = int.Parse(sizes[0]);
            var colCount = int.Parse(sizes[1]);
            int[][] matrix = new int[rowCount][];

            FillMatrix(matrix, rowCount, colCount);

            var command = Console.ReadLine();

            while (command != "Nuke it from orbit")
            {
                var tokens = command.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var row = int.Parse(tokens[0]);
                var col = int.Parse(tokens[1]);

                
                var radius = int.Parse(tokens[2]);

                Destroy(matrix, row, col, radius);

                command = Console.ReadLine();
            }

            PrintResult(matrix);

        }

        private static void Destroy(int[][] matrix, int row, int col, int radius)
        {
            for (int i = 0; i <= radius; i++)
            {
                try
                {
                    matrix[row][col + i] = 0;
                }
                catch (IndexOutOfRangeException)
                {
                    
                }

                try
                {
                    matrix[row][col - i] = 0;
                }
                catch (IndexOutOfRangeException)
                {

                }
                try
                {
                    matrix[row + i][col] = 0;
                }
                catch (IndexOutOfRangeException)
                {

                }
                try
                {
                    matrix[row - i][col] = 0;
                }
                catch (IndexOutOfRangeException)
                {

                }
            }

            for (int r = 0; r < matrix.Length; r++)
            {
                matrix[r] = matrix[r]
                    .Where(x => x != 0)
                    .ToArray();
            }
        }

        private static void PrintResult(int[][] matrix)
        {
            foreach (var m in matrix)
            {
                Console.WriteLine(string.Join(" ", m));
            }
        }

        private static void FillMatrix(int[][] matrix, int rowCount, int colCount)
        {
            var number = 1;

            

            for (int i = 0; i < rowCount; i++)
            {
                matrix[i] = new int[colCount];

                for (int j = 0; j < colCount; j++)
                {
                    matrix[i][j] = number;

                    number++;
                }
            }
        }
    }
}
