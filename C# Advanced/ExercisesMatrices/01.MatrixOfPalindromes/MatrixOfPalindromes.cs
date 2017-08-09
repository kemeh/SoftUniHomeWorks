using System;

namespace _01.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main()
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var sizes = Console.ReadLine().Split();
            var rows = int.Parse(sizes[0]);
            var cols = int.Parse(sizes[1]);
            string[][] matrix = new string[rows][];

            for (int i = 0; i < rows; i++)
            {
                var boundChar = alphabet[i];

                matrix[i] = new string[cols];
                
                for (int j = 0; j < cols; j++)
                {
                    var middleChar = alphabet[i + j];
                    matrix[i][j] = boundChar.ToString() + middleChar.ToString() + boundChar.ToString();
                }
            }

            foreach (var m in matrix)
            {
                Console.WriteLine(string.Join(" ", m));
            }
        }
    }
}
