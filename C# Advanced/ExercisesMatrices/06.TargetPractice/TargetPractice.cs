using System;
using System.Linq;

namespace _06.TargetPractice
{
    class TargetPractice
    {
        static void Main()
        {
            var sizes = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rowsCount = sizes[0];
            var colsCount = sizes[1];
            char[][] stairs = new char[rowsCount][];

            var snake = Console.ReadLine().ToCharArray();

            FillStairs(rowsCount, colsCount, snake, stairs);

            var shotArgs = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var impactRow = shotArgs[0];
            var impactCol = shotArgs[1];
            var radius = shotArgs[2];

            FireAShot(stairs, impactRow, impactCol, radius);

            for (int col = 0; col < colsCount; col++)
            {
                RunGravity(stairs, col);
            }

            PrintResult(stairs);
        }

        private static void RunGravity(char[][] stairs, int col)
        {
            while (true)
            {
                bool hasFallen = false;

                for (int i = 1; i < stairs.Length; i++)
                {
                    char top = stairs[i - 1][col];
                    char current = stairs[i][col];

                    if (current == ' ' && top != ' ')
                    {
                        stairs[i][col] = top;
                        stairs[i - 1][col] = ' ';
                        hasFallen = true;
                    }
                }

                if (!hasFallen)
                {
                    break;
                }
            }            
        }

        private static void FireAShot(char[][] stairs, int impactRow, int impactCol, int radius)
        {
            for (int row = 0; row < stairs.Length; row++)
            {
                for (int col = 0; col < stairs[row].Length; col++)
                {
                    if ((col - impactCol) * (col - impactCol) + (row - impactRow) * (row - impactRow) <= radius * radius)
                    {
                        stairs[row][col] = ' ';
                    }
                }
            }
        }

        private static void PrintResult(char[][] stairs)
        {
            foreach (var stair in stairs)
            {
                Console.WriteLine(string.Join("", stair));
            }
        }

        private static void FillStairs(int rowsCount, int colsCount, char[] snake, char[][] stairs)
        {
            bool isMovingLeft = true;
            var currentIndex = 0;

            for (int row = rowsCount - 1; row >= 0; row--)
            {
                stairs[row] = new char[colsCount];
                if (isMovingLeft)
                {
                    for (int col = colsCount - 1; col >= 0; col--)
                    {
                        if (currentIndex >= snake.Length)
                        {
                            currentIndex = 0;
                        }
                        stairs[row][col] = snake[currentIndex];
                        currentIndex++;
                    }
                }
                else
                {
                    for (int col = 0; col < colsCount; col++)
                    {
                        if (currentIndex >= snake.Length)
                        {
                            currentIndex = 0;
                        }
                        stairs[row][col] = snake[currentIndex];
                        currentIndex++;
                    }
                }

                isMovingLeft = !isMovingLeft;
            }
        }
    }
}
