using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RadioactiveBunnies
{
    class RadioactiveBunnies
    {
        static void Main()
        {
            var matrixSizes = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rowsCount = matrixSizes[0];
            var colsCount = matrixSizes[1];
            char[][] board = new char[rowsCount][];
            string result = "";

            for (var row = 0; row < rowsCount; row++)
            {
                board[row] = Console.ReadLine().ToCharArray();
            }

            char player = 'P';
            char bunny = 'B';
            var isDead = false;
            var isAway = false;

            var directions = Console.ReadLine();

            var playerRow = 0;
            var playerCol = 0;

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    if (board[i][j] == player)
                    {
                        playerCol = j;
                        playerRow = i;

                        break;
                    }
                }
            }

            for (int move = 0; move < directions.Length; move++)
            {
                var currentDirection = directions[move];

                switch (currentDirection)
                {
                    case 'R':
                        if (playerCol + 1 >= board[playerRow].Length)
                        {
                            board[playerRow][playerCol] = '.';
                            isAway = true;
                        }
                        else if (board[playerRow][playerCol + 1] == bunny || board[playerRow][playerCol] == bunny)
                        {
                            board[playerRow][playerCol] = '.';
                            isDead = true;
                            playerCol += 1;
                        }
                        else
                        {
                            board[playerRow][playerCol + 1] = player;
                            board[playerRow][playerCol] = '.';

                            playerCol += 1;
                        }
                        break;
                    case 'L':
                        if (playerCol - 1 < 0)
                        {
                            board[playerRow][playerCol] = '.';
                            isAway = true;
                        }
                        else if (board[playerRow][playerCol - 1] == bunny || board[playerRow][playerCol] == bunny)
                        {
                            board[playerRow][playerCol] = '.';
                            isDead = true;  
                            playerCol -= 1;
                        }
                        else
                        {
                            board[playerRow][playerCol - 1] = player;
                            board[playerRow][playerCol] = '.';

                            playerCol -= 1;
                        }
                        break;
                    case 'U':

                        if (!(playerRow - 1 < 0))
                        {
                            board[playerRow][playerCol] = '.';
                            isAway = true;
                        }
                        else if (board[playerRow - 1][playerCol] == bunny || board[playerRow][playerCol] == bunny)
                        {
                            board[playerRow - 1][playerCol] = '.';
                            isDead = true;
                            playerRow -= 1;
                        }
                        else
                        {
                            board[playerRow - 1][playerCol] = player;
                            board[playerRow][playerCol] = '.';

                            playerRow -= 1;
                        }
                        break;
                    case 'D':
                        if (playerRow + 1 >= rowsCount)
                        {
                            board[playerRow][playerCol] = '.';
                            isAway = true;
                        }
                        else if (board[playerRow + 1][playerCol] == bunny || board[playerRow][playerCol] == bunny)
                        {
                            board[playerRow][playerCol] = '.';
                            isDead = true;
                            playerRow += 1;
                        }
                        else
                        {
                            board[playerRow + 1][playerCol] = player;
                            board[playerRow][playerCol] = '.';

                            playerRow += 1;
                        }
                        break;
                }

                MultuplyBunnies(board, colsCount, rowsCount);

                if (isDead)
                {
                    result = $"dead: {playerRow} {playerCol}";
                    break;
                }
                if (isAway)
                {
                    result = $"won: {playerRow} {playerCol}";
                    break;
                }               
            }

            PrintResult(board, result);
        }

        private static void MultuplyBunnies(char[][] matrix, int cols, int rows)
        {
            var bunnyList = new List<int[]>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] == 'B')
                    {
                        bunnyList.Add(new[] {i, j});
                    }
                }
            }

            foreach (var bun in bunnyList)
            {
                    SpreadBunny(bun[0] - 1, bun[1], matrix);
                SpreadBunny(bun[0], bun[1] - 1, matrix);
                SpreadBunny(bun[0] + 1, bun[1], matrix);
                SpreadBunny(bun[0], bun[1] + 1, matrix);
            }
        }

        private static void SpreadBunny(int row, int col, char[][] matrix)
        {
            try
            {
                matrix[row][col] = 'B';
            }
            catch (IndexOutOfRangeException)
            {
                
            }
        }

        private static void PrintResult(char[][] board, string result)
        {
            for (int i = 0; i < board.Length; i++)
            {
                Console.WriteLine(string.Join("", board[i]));
            }

            Console.WriteLine(result);
        }
    }
}
