using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize
            int[][] matrix = new int[3][];

            matrix[0] = new int[4] { 2, 4, 6, 8 };
            matrix[1] = new int[2] { 6, 7 };
            matrix[2] = new int[3] { 1, 2, 3 };

            //access and display
            int element = matrix[0][1];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();





            int[][] matrix = new int[3][];

            matrix[0] = new int[4] { 2, 4, 6, 8 };
            matrix[1] = new int[3] { 6, 7, 0 };
            matrix[2] = new int[3] { 1, 2, 3 };

            //modify the element
            matrix[1][2] = 15;

            //access and display
            int element = matrix[0][1];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();




            object[][] objmatrix = new object[2][];
            objmatrix[0] = new dynamic[] { 55, "surya", 1.56 };
            objmatrix[1] = new dynamic[] { true, 's', DateTime.Now };

            for (int i = 0; i < objmatrix.Length; i++)
            {
                for (int j = 0; j < objmatrix[i].Length; j++)
                {
                    Console.WriteLine($"type: {objmatrix[i][j].GetType()},value: {objmatrix[i][j]}");
                }
            }

            Console.ReadKey();

        }
    }
}
