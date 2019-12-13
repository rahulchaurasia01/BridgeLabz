/*
 *  Purpose:  Program to Search the word in the list of String using Binary Search.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   13-12-2019
 */


using System;
using System.IO;
using BridgeLabz.AlgorithmProgram.Utils;

namespace BridgeLabz.AlgorithmProgram
{
    class BinarySearchStringProgram
    {
        /// <summary>
        /// This Method is used to Test the Binary Search 
        /// </summary>
        public static void BinarySearchString()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Binary Search for String PROGRAM----------------");
            Console.WriteLine();

            string[] list = null;
            try
            {
                Console.WriteLine("Reading list of words from file.");
                list = File.ReadAllText(@"C:\Users\User\source\repos\BridgeLabz\BridgeLabz\Input.txt").Split(',');
                for (int i = 0; i < list.Length; i++)
                    list[i] = list[i].Trim();
                Console.WriteLine("Reading from file Completed.");
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Reading from file failed.");
                return;
            }

            Array.Sort(list);

            Console.WriteLine();

            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i]);


            Console.Write("Enter the word to be search: ");
            string search = Console.ReadLine();

            Utility utils = new Utility();

            if (utils.BinarySearch(list, search))
                Console.WriteLine("The word {0} is present in the list.", search);
            else
                Console.WriteLine("The Word {0} is not Present in the list", search);

        }
    }
}
