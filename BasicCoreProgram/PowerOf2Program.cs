/*
 *  Purpose: Program to print the Power of 2.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   10-12-2019
 */

using BridgeLabz.BasicCoreProgram.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz.BasicCoreProgram
{
    class PowerOf2Program
    {
        /// <summary>
        /// This Method is used to test the PowerOf2 Program Class.
        /// </summary>
        public static void PowerOf2()
        {
            Boolean flag;
            int twoRaisedToN;
            do
            {
                Console.Write("Enter the Number: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out twoRaisedToN);

            } while (flag != true);

            /// Created an Utility Object because Utility class contains all the logic
            /// for this Program to give Proper Output.
            Utility utils = new Utility();

            if (!utils.CheckRaisedToNumber(twoRaisedToN))
                Console.WriteLine("Number is not in the range of (0<=N<31)");
            else
                utils.TwoPowerNumber(twoRaisedToN);
        }

    }
}
