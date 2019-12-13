/*
 *  Purpose:  Program for Insertion Sort.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   13-12-2019
 */

using BridgeLabz.AlgorithmProgram.Utils;
using System;

namespace BridgeLabz.AlgorithmProgram
{
    class InsertionSortProgram
    {
        /// <summary>
        /// This Method is used to test the InsertionSortProgram Class.
        /// </summary>
        public static void InsertionSort()
        {

            Console.WriteLine();
            Console.WriteLine("----------------Insertion Sort PROGRAM----------------");
            Console.WriteLine();

            int n;

            Console.Write("Enter the numbers of number: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            Console.Write("Enter the numbers: ");
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());

            Utility utils = new Utility();

            utils.InsertionSort(a);

            Console.Write("By using Insertion Sort: ");
            foreach (int i in a)
                Console.Write(i + " ");

        }
    }
}
