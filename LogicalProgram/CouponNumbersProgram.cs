/*
 *  Purpose:  Program to Print the total Random Number needed to have all the distinct numbers.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   10-12-2019
 */

using BridgeLabz.LogicalProgram.Utils;
using System;

namespace BridgeLabz.LogicalProgram
{
    class CouponNumbersProgram
    {
        /// <summary>
        /// This Method is used to test the CouponNumbersProgram Class.
        /// </summary>
        public static void CouponNumbers()
        {
            Console.WriteLine();
            Console.WriteLine("----------------COUPON NUMBER PROGRAM----------------");
            Console.WriteLine();

            Boolean flag;
            int uniqueCouponNumber;

            do
            {
                Console.Write("How Many Unique Coupon Needed: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out uniqueCouponNumber);

            } while (flag != true);

            Utility.GenerateUniqueCoupons(uniqueCouponNumber);

        }
    }
}
