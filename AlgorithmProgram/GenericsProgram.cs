/*
 *  Purpose:  Program for generic sorting and searching.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   13-12-2019
 */

using BridgeLabz.AlgorithmProgram.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz.AlgorithmProgram
{
    class GenericsProgram
    {
        /// <summary>
        /// This method is used to test the GenericsProgram Class.
        /// </summary>
        public static void Generics()
        {

            Console.WriteLine();
            Console.WriteLine("---------------Generics PROGRAM----------------");
            Console.WriteLine();

            int choice;
            Boolean flag = false;
            do
            {
                Utility utils = new Utility();
                Console.WriteLine("1. Binary Search");
                Console.WriteLine("2. Bubble Sort");
                Console.WriteLine("3. Exit");
                Console.Write("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1: int[] a = { 1, 5, 7, 8, 19, 28 };
                            Array.Sort(a);
                            Console.Write("Enter the key to be Searched: ");
                            int key = Convert.ToInt32(Console.ReadLine());
                            if(utils.BinarySearch<int>(a, key))
                                Console.WriteLine("The word {0} is present in the list.", key);
                            else
                                Console.WriteLine("The word {0} is present in the list.", key);
                            break;

                    case 3: flag = true;
                            break;

                    default: Console.WriteLine("Invalid Choice.!!");
                             break;
                }

            } while (!flag);

        }
    }
}
