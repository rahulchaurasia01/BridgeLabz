/*
 *  Purpose: The Utility Class is used to store the logic of the Basic Core Program.
 *  
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   12-12-2019
 * 
 */

using System;
using System.Collections.Generic;

namespace BridgeLabz.AlgorithmProgram.Utils
{
    class Utility
    {

       /// <summary>
       /// It Check Whether the Number is a Prime Number or Not.
       /// </summary>
       /// <param name="number"></param>
       /// <returns></returns>
        public Boolean IsPrimeNumber(int number)
        {
            if (number == 0 || number == 1)
                return false;
            for(int i=2;i<number;i++)
            {
                if (number % i == 0)
                    return false;
                    
            }
            return true;
        }

        /// <summary>
        /// This Method is used to Check whether the given parameter is a palindrome or not.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public Boolean IsPalindrome(int number)
        {
            if (number < 10)
                return false;
            string numberToString = number + "";
            char[] numberArray = numberToString.ToCharArray();

            for (int i = 0; i < numberToString.Length/2; i++)
            {
                if (numberArray[i] != numberArray[numberToString.Length - 1 - i])
                    return false;
            }

            return true;

        }
    
        /// <summary>
        /// Anagram Detection.
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public Boolean AnagramDetection(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            char[] a = str1.ToCharArray();
            char[] b = str2.ToCharArray();

            Array.Sort(a);
            Array.Sort(b);

            for (int i=0;i<a.Length;i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            
            return true;
        }
    
        /// <summary>
        /// Sort the numbers using Bubble Sort Method.
        /// </summary>
        public void Sort(int[] numbers)
        {
            int temp;

            for(int i=0;i<numbers.Length;i++)
            {
                for(int j=0;j<numbers.Length;j++)
                {
                    if(numbers[i] < numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }




    }
}
