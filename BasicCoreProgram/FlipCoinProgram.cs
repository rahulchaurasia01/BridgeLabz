/*
 *  Purpose: To Flip the Coin and Find the percentage of Heads and Tails.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   10-12-2019
 */

using BridgeLabz.BasicCoreProgram.Utils;
using System;

namespace BridgeLabz.BasicCoreProgram
{
    class FlipCoinProgram
    {
        /// <summary>
        /// This Method is used to test the FlipCoin Program Class
        /// </summary>
        public static void FlipCoin()
        {
            Boolean flag;
            int numberOfTimes;

            do
            {
                Console.Write("How many times to flip coin: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out numberOfTimes);

            } while (flag != true);


            /// If Conversion is not Successfull then it will Print Invalid Number
            /// else It will try to print percentage of heads and tails.
            if (!flag)
            {
                Console.WriteLine("Invalid Number");
                return;
            }
            else
            {
                /// Created an Utility Object because Utility class contains all the logic
                /// for this Program to give Proper Output.
                Utility utils = new Utility();
                utils.PercentageOfHeadAndTails(numberOfTimes);
            }
        }
    }
}
