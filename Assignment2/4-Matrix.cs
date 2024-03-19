using System;
namespace Assignment2
{
    class Matrix
    {
        public static bool IsthatMatrix(int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException("The argument cann't be null");
            for (int i = 1; i < matrix.GetLength(0); i++)
                for (int j = 1; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] != matrix[i - 1, j - 1]) return false;
            return true;
        }

        static void Main(string[] args)
        {
            int[,] matrix =
            {
                { 1, 2, 3, 4 },
                { 5, 1, 2, 3 },
                { 9, 5, 1, 2}
            };
            Console.WriteLine($"结果是:{IsthatMatrix(matrix)}");
        }
    }
}