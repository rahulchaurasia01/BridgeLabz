/*
 *  Purpose:  Program for finding the prime number in 0-1000.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   12-12-2019
 */

using System;
using BridgeLabz.AlgorithmProgram.Utils;

namespace BridgeLabz.AlgorithmProgram
{
    class PrimeNumberProgram
    {
        /// <summary>
        /// This Method is used to Test the PrimeNumberProgram Class.
        /// </summary>
        public static void PrimeNumber()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Prime Number PROGRAM----------------");
            Console.WriteLine();

            Utility utils = new Utility();
            int count = 0, tempCount = 0;
            Console.WriteLine("The Prime Number in the range of (0 - 1000) are: ");

            while(count <= 1000)
            {
                Boolean flag = utils.IsPrimeNumber(count);

                if (flag)
                {
                    Console.Write(count+"\t");
                    tempCount++;
                }

                if (tempCount == 10)
                {
                    Console.WriteLine();
                    tempCount = 0;
                }
                    
                count++;
            }

            Console.WriteLine();


        }
    }
}
