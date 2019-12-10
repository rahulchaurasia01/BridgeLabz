﻿/*
 *  Purpose: The Utility Class is used to store the logic of the Basic Core Program.
 *  
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   10-12-2019
 * 
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz.BasicCoreProgram.Utils
{
    class Utility
    {

        /// <summary>
        /// This function will check the length of the username.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public Boolean CheckUserNameLength(String userName)
        {
            if (userName.Length < 3)
                return false;
            else
                return true;
        }


        /// <summary>
        /// This function will print the percentage of heads and tails generated using random Number.
        /// </summary>
        /// <param name="numberOfTimes"></param>
        public void PercentageOfHeadAndTails(int numberOfTimes)
        {
            int heads = 0, tails = 0, temp = numberOfTimes;

            /// randomNumber is used to store the random Number.
            float randomNumber;

            /// percentHeads is used to store the Percentage of heads
            /// generated by the random Number.
            float percentHeads;

            /// percentHeads is used to store the Percentage of Tails
            /// generated by the random Number.
            float percentTails;

            /// To Check the numberOfTimes to flipCoin Cannot be negative.
            if(numberOfTimes < 0)
            {
                Console.WriteLine("Number Cannot be Negative.");
                return;
            }

            /// This method will calculate the percentage of heads and tails.
            while(numberOfTimes > 0)
            {
                Random random = new Random();
                randomNumber = (float)random.NextDouble();

                /// If randomNumber generated is less than 0.5 then it
                /// will increment tails value by 1 and If it is geaterThan
                /// by 0.5 it will increment heads value by 1.
                if (randomNumber < 0.5)
                    tails++;
                else
                    heads++;
                
                numberOfTimes--;
            }

            percentHeads = (heads * 100) / temp;
            percentTails = (tails * 100) / temp;

            Console.WriteLine("Percentage of Heads: {0}", percentHeads);
            Console.WriteLine("Percentage of Tails: {0}", percentTails);
        }
    

        /// <summary>
        /// This method will Check whether the Entered Number is 4 Digit No. or not.
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public Boolean IsAFourDigitNumber(int no)
        {
            if (no > 1000 && no < 9999)
                return true;
            else
                return false;
        }
    

        /// <summary>
        /// It will Check Whether the entered year is a leap year or not
        /// </summary>
        /// <param name="leapYear"></param>
        /// <returns></returns>
        public Boolean CheckLeapYear(int leapYear)
        {
            if (leapYear % 4 == 0)
            {
                if (leapYear % 100 == 0)
                {
                    if (leapYear % 400 == 0)
                        return true;
                    else
                        return false;
                }
                else
                    return true;
            }
            else
                return false;
        }
    
        /// <summary>
        /// To Check the 2^N, where N should be >=0 and <31
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public Boolean CheckRaisedToNumber(int number)
        {
            if (number >= 0 && number < 31)
                return true;
            else
                return false;
        }
    
        /// <summary>
        /// To Print the Two Power Numbers.
        /// </summary>
        /// <param name="Number"></param>
        public void TwoPowerNumber(int Number)
        {
            int result = 0;

            for(int init=0; init<=Number; init++)
            {
                if (init == 0)
                    result = 1;
                else
                    result *= 2;
                Console.WriteLine("2's Power {0} is: {1}",init, result);
            }
        }

        /// <summary>
        /// This method Calculate the Nth Harmonic Number.
        /// </summary>
        /// <param name="harmonicNumber"></param>
        /// <returns></returns>
        public double HarmonicNumber(int harmonicNumber)
        {
            double result = 0.0;
            if (harmonicNumber == 0)
            {
                Console.WriteLine("Number Should not be zero.");
                return 0.0;
            }
            else
            {
                for(int init=1; init<=harmonicNumber; init++)
                    result += (1.0/ init);

                return result;
            }
        }
    
        /// <summary>
        /// This Method helps in finding the Prime Factorization of
        /// the number.
        /// </summary>
        /// <param name="number"></param>
        public void PrimeFactorization(int number)
        {
            Boolean flag = false;

            int temp = number;

            for(int i=2; i<=number; i++)
            {
                flag = false;

                /// To Determine whether the nos are Prime Number or not.
                for(int j=2;j<i;j++)
                {
                    if (i%j == 0)
                    {
                        flag = true;
                        break;
                    }
                }

                /// If the Nos are Prime Number then divide the given no. by it.
                if(!flag)
                {
                   while(temp%i == 0)
                   {
                        temp = temp / i;
                        Console.Write(i+" ");
                   }
                    
                }
            }
        }
    
    }
}
