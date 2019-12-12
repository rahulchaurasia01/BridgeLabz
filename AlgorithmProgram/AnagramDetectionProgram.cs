/*
 *  Purpose:  Program to Determine whether the two Strings are anagram or not.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   12-12-2019
 */

using System;
using BridgeLabz.AlgorithmProgram.Utils;

namespace BridgeLabz.AlgorithmProgram
{
    class AnagramDetectionProgram
    {
        /// <summary>
        /// This method is used to test the AnagramDetectionProgram Class.
        /// </summary>
        public static void AnagramDetection()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Anagram Detection PROGRAM----------------");
            Console.WriteLine();

            Console.Write("Enter the 1st. String: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the 2nd. String: ");
            string str2 = Console.ReadLine();

            Utility utils = new Utility();

            if (utils.AnagramDetection(str1, str2))
                Console.WriteLine("The two String {0} and {1} are Anagram", str1, str2);
            else
                Console.WriteLine("The two strings are not anagram.");

        }
    }
}
