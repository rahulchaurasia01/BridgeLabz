/*
 *  Purpose: Program to Find the Prime Factorization of the Number.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   10-12-2019
 */

using BridgeLabz.BasicCoreProgram.Utils;
using System;

namespace BridgeLabz.BasicCoreProgram
{
    class PrimeFactorizationProgram
    {
        /// <summary>
        /// This Method is used to test the PrimeFactorizationProgram Class.
        /// </summary>
        public static void PrimeFactorization()
        {
            Boolean flag;
            int number;

            do
            {
                Console.Write("Enter the Number: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out number);

            } while (flag != true);

            /// Created an Utility Object because Utility class contains all the logic
            /// for this Program to give Proper Output.
            Utility utils = new Utility();
            utils.PrimeFactorization(number);
        }
    }
}
