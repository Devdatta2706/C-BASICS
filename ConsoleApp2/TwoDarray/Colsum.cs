using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.TwoDarray
{
    internal class Colsum
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int numRows = matrix.GetLength(0);
            int numCols = matrix.GetLength(1);

            int[] colSums = new int[numCols];

            for (int col = 0; col < numCols; col++)
            {
                int sum = 0;
                for (int row = 0; row < numRows; row++)
                {
                    sum += matrix[row, col];
                }
                colSums[col] = sum;
            }

            
            for (int i = 0; i < numCols; i++)
            {
                Console.WriteLine("Sum of column "+ i + "is "+colSums[i]);
            }

        }
    }
}
