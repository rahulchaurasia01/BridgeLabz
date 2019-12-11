/*
 *  Purpose:  Program to calculate the Square Root of the number using Newton Method.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   11-12-2019
 */

using System;
using BridgeLabz.JunitProgram.Utils;

namespace BridgeLabz.JunitProgram
{
    class SquareRootProgram
    {
        /// <summary>
        /// This Method Will test the SquareRootProgram Class
        /// </summary>
        public static void SquareRoot()
        {

            Console.WriteLine();
            Console.WriteLine("----------------Square Root PROGRAM----------------");
            Console.WriteLine();

            int squareRoot;

            Boolean flag;

            do
            {
                Console.Write("Enter the No.:- ");
                flag = Int32.TryParse(Console.ReadLine(), out squareRoot);
            } while (!flag);


            double result = Utility.Sqrt(squareRoot);
            Console.WriteLine("The square Root of {0} by Newton Method is: {1}", squareRoot, result);
        }

    }
}
