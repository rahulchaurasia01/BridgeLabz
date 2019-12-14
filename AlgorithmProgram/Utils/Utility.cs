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

        /// <summary>
        /// This method is used to merged the array.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <param name="r"></param>
        void merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two subarrays to be merged 
            int n1 = m - l + 1;
            int n2 = r - m;

            /* Create temp arrays */
            int[] L = new int[n1];
            int[] R = new int[n2];

            /*Copy data to temp arrays*/
            for (int a = 0; a < n1; ++a)
                L[a] = arr[l + a];

            for (int b = 0; b < n2; ++b)
                R[b] = arr[m + 1 + b];


            /* Merge the temp arrays */

            // Initial indexes of first and second subarrays 
            int i = 0, j = 0;

            // Initial index of merged subarry array 
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            /* Copy remaining elements of L[] if any */
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            /* Copy remaining elements of R[] if any */
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        // Main function that sorts arr[l..r] using 
        // merge() 
        public void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // Find the middle point 
                int m = (l + r) / 2;

                // Sort first and second halves 
                Console.WriteLine("Holaaa");
                sort(arr, l, m);
                Console.WriteLine("Miaaaa");
                sort(arr, m + 1, r);

                Console.WriteLine("rahullll");
                // Merge the sorted halves 
                merge(arr, l, m, r);
            }
        }


        /// <summary>
        /// Optimally completing the task.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="m"></param>
        public void TaskCompletion(int[] d, int[] m)
        {
            int n = m.Length;

            int[] temp = new int[n];
            int[] dTemp = new int[n];
            int[] mTemp = new int[n];
            int result = 0, count=0, time = 1, mPos, mMin;

            for(int i=0;i<n;i++)
            {
                for(int j = 0; j <= i;j++)
                {
                    dTemp[j] = d[j];
                    mTemp[j] = m[j];
                }
                mMin = mTemp[0];
                mPos = 0;
                for(int j=0;j<=i;j++)
                {
                    if(mMin < mTemp[j])
                    {
                        mPos = j;
                        mMin = mTemp[j];
                    }
                }
            }
        }

    }
}
