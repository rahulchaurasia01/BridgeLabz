/*
 *  Purpose:  Program to Determine whether the two Strings are anagram or not.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   12-12-2019
 */

using BridgeLabz.AlgorithmProgram.Utils;
using System;

namespace BridgeLabz.AlgorithmProgram
{
    class BubbleSortProgram
    {
        /// <summary>
        /// This Method is used to test the BubbleSortProgram Class
        /// </summary>
        public static void BubbleSort()
        {
            Console.WriteLine();
            Console.WriteLine("---------------Buuble Sort PROGRAM----------------");
            Console.WriteLine();

            int n;

            Console.Write("Enter the number of numbers you have: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];

            Console.Write("Enter the number: ");
            for (int i = 0; i < n; i++)
                numbers[i] = Convert.ToInt32(Console.ReadLine());


            Utility utils = new Utility();

            utils.Sort(numbers);

            Console.Write("The Sorted Array is: ");
            foreach (int i in numbers)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
