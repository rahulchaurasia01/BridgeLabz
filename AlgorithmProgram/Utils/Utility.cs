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

        /// <summary>
        /// This method uses generics for BinarySearch.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public Boolean BinarySearch<T>(T[] list, T search)
        {
            int n = list.Length-1;
            int first = 0;
            while(first <= n)
            {
                int m = first + (n - first) / 2;

                int result = (list[m].ToString()).CompareTo(search.ToString());

                if (result == 0)
                    return true;

                if (result < 0)
                    first = m + 1;
                else
                    n = m - 1;

            }

            return false;
        }

        /// <summary>
        /// This method is used to do the permutation of the String.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public static void StringPermutation(string str, int start, int end)
        {
            if (start == end)
                Console.WriteLine(str);   
            else
            {
                for (int i = start; i <= end; i++)
                {
                    str = Swap(str, start, i);
                    StringPermutation(str, start + 1, end);
                    str = Swap(str, start, i);
                }
            }
        }

        /// <summary>
        /// This method is a part of the StringPermutation method. It is used to
        /// swap the character.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static String Swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    
        /// <summary>
        /// This method is used to sort the array of numbers by uing Insertion Sort.
        /// </summary>
        /// <param name="numbers"></param>
        public void InsertionSort(int[] numbers)
        {
           
            for(int i=1;i< numbers.Length;i++)
            {
                int temp = numbers[i];
                int j = i - 1;

                while(j >= 0 && numbers[j] > temp)
                {
                    numbers[j + 1] = numbers[j];
                    j = j - 1;
                }

                numbers[j + 1] = temp;
            }
        }


    }
}
