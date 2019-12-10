/*
 *  Purpose:  To Display the Two Dimensional Array.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   10-12-2019
 */

using System;
using BridgeLabz.FunctionalProgram.Utils;

namespace BridgeLabz.FunctionalProgram
{
    class TwoDimensionalArrayProgram
    {
        /// <summary>
        /// This Method is used to Test the TwoDimensionalArrayProgram Class
        /// </summary>
        public static void TwoDimensionalArray()
        {
            Console.WriteLine();
            Console.WriteLine("----------------2D Array PROGRAM----------------");
            Console.WriteLine();

            Boolean flag;
            int M, N;

            do
            {
                Console.Write("Enter the no. of rows: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out M);

            } while (flag != true);

            do
            {
                Console.Write("Enter the No. of Columns: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out N);

            } while (flag != true);

            int[,] arr = new int[M,N];

            Console.Write("Enter the Value for the matrix: ");
            for(int i=0;i<M;i++)
            {
                for (int j = 0; j < N; j++)
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
            }

            Utility utils = new Utility();
            utils.Display2DArray(arr, M, N);

        }
    }
}
