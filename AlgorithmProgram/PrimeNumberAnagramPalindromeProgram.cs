/*
 *  Purpose:  Program to print Prime Number that are anagram and Palindrome.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   12-12-2019
 */

using System;
using System.Collections.Generic;
using BridgeLabz.AlgorithmProgram.Utils;

namespace BridgeLabz.AlgorithmProgram
{
    class PrimeNumberAnagramPalindromeProgram
    {
        /// <summary>
        /// This Method is used to test the PrimeNumberAnagramPalindromeProgram Class.
        /// </summary>
        public static void PrimeNumberAnagramPalindrome()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Prime Number that are Anagram and Palindrome PROGRAM----------------");
            Console.WriteLine();

            Utility utils = new Utility();
            int count = 0, tempCount = 0;
            List<string> primeNumber = new List<string>();
            Console.WriteLine("The Prime Number which are palindrome is within (0-1000): ");
            while (count <= 1000)
            {
                Boolean flag = utils.IsPrimeNumber(count);

                if (flag)
                {
                    primeNumber.Add((count+"").PadLeft(3, '0'));
                    if(utils.IsPalindrome(count))
                    {
                        Console.Write(count + "\t");
                        tempCount++;
                    }
                }

                if (tempCount == 10)
                {
                    Console.WriteLine();
                    tempCount = 0;
                }

                count++;
            }
            Console.WriteLine();
            tempCount = 0;

            Console.WriteLine("The Prime Number which are Anagram is within (0-1000): ");
            do
            {
                string str1 = primeNumber[0];
                for(int i=1;i<primeNumber.Count;i++)
                {
                    string str2 = primeNumber[i]+"";
                    if (utils.AnagramDetection(str1, str2))
                        Console.WriteLine("{0} \t {1}",str1, str2);
                }
                primeNumber.RemoveAt(0);
            } while (primeNumber.Count != 0);
        }
    }
}
