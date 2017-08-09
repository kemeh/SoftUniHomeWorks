using System;
using System.Linq;

namespace _05.Rubiks_Matrix
{
    class RubiksMatrix
    {
        static void Main()
        {
            var sizes = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = sizes[0];
            var cols = sizes[1];
            var number = 1;
            var commandLines = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];

                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = number;

                    number++;
                }
            }
            
            for (int i = 0; i < commandLines; i++)
            {
                var command = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var rowCol = int.Parse(command[0]);
                var direction = command[1];
                var moves = int.Parse(command[2]);

                switch (direction)
                {
                    case "up":                          
                        MoveCol(matrix, rowCol, moves);
                        break;
                    case "down":
                        MoveCol(matrix, rowCol, rows - moves % rows);
                        break;
                    case "left":
                        MoveRow(matrix, rowCol, moves);
                        break;
                    case "right":
                        MoveRow(matrix, rowCol, cols - moves % cols);
                        break;
                }
            }

            var element = 1;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == element)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int r = 0; r < matrix.Length; r++)
                        {
                            for (int c = 0; c < matrix[r].Length; c++)
                            {
                                if (matrix[r][c] == element)
                                {
                                    var currentElement = matrix[i][j];
                                    matrix[i][j] = element;
                                    matrix[r][c] = currentElement;
                                    Console.WriteLine($"Swap ({i}, {j}) with ({r}, {c})");

                                    break;
                                }
                            }
                        }
                    }

                    element++;
                }
            }
        }

        private static void MoveRow(int[][] matrix, int rowIndex, int moves)
        {
            var temp = new int[matrix[rowIndex].Length];

            for (int i = 0; i < matrix[rowIndex].Length; i++)
            {
                temp[i] = matrix[rowIndex][(i + moves) % matrix[rowIndex].Length];
            }

            matrix[rowIndex] = temp;
        }

        private static void MoveCol(int[][] matrix, int colIndex, int moves)
        {
            var temp = new int[matrix.Length];

            for (int j = 0; j < matrix.Length; j++)
            {
                temp[j] = matrix[(j + moves) % matrix.Length][colIndex];
            }

            for (int j = 0; j < matrix.Length; j++)
            {
                matrix[j][colIndex] = temp[j];
            }
        }
    }
}
