/*
 *  Purpose:  Program for Merge Sort.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   13-12-2019
 */

using System;
using BridgeLabz.AlgorithmProgram.Utils;

namespace BridgeLabz.AlgorithmProgram
{
    class MergeSortProgram
    {
        /// <summary>
        /// This method is used to test the MergeSortProgram Class.
        /// </summary>
        public static void MergeSort()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Merge Sort PROGRAM----------------");
            Console.WriteLine();

            int n;

            Console.Write("Enter the numbers of number: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            Console.Write("Enter the numbers: ");
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());

            Utility utils = new Utility();

            utils.sort(a, 0, a.Length - 1);

            Console.Write("By using Merge Sort: ");
            foreach (int i in a)
                Console.Write(i + " ");
        }
    }
}
