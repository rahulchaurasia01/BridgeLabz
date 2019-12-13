/*
 *  Purpose:  Program for Permutation of a string.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   13-12-2019
 */

using BridgeLabz.AlgorithmProgram.Utils;
using System;

namespace BridgeLabz.AlgorithmProgram
{
    class PermutationStringProgram
    {
        /// <summary>
        /// This Method is used to test the permutationStringProgram class.
        /// </summary>
        public static void PermutationString()
        {
            Console.WriteLine();
            Console.WriteLine("---------------Permutation String PROGRAM----------------");
            Console.WriteLine();

            Console.Write("Enter the String: ");
            string str = Console.ReadLine();

            Console.WriteLine("The Permutation Of the {0}: ", str);
            Utility.StringPermutation(str, 0, str.Length - 1);

        }
    }
}
