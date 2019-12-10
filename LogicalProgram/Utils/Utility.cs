/*
 *  Purpose: The Utility Class is used to store the logic of the Basic Core Program.
 *  
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   10-12-2019
 * 
 */

using System;

namespace BridgeLabz.LogicalProgram.Utils
{
    class Utility
    {
        /// <summary>
        /// This method will generate the unique Coupon and the total Random
        /// number needed to generate it.
        /// </summary>
        /// <param name="number"></param>
        public static void GenerateUniqueCoupons(int number)
        {
            int[] a = new int[number];
            int count = 0, uniqueNumber, randomCount=0;
            Boolean flag = false;
            Random random = new Random();
            do
            {
                uniqueNumber = random.Next(1, number);
                randomCount++;
                Console.WriteLine(count);
                if(count == 0)
                {
                    a[0] = uniqueNumber;
                    count++;
                }
                else
                {
                    for(int i=0;i<count;i++)
                    {
                        if(a[i] == uniqueNumber)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if(!flag)
                    {
                        a[count] = uniqueNumber;
                        count++;
                    }
                }
            } while (count != number);

            Console.WriteLine("Total Random Number Needed to Generate Unique Coupon is: {0}", randomCount);

            foreach (int i in a)
                Console.WriteLine("Unique Coupon Number are: {0}", i);

            
        }
    }
}
