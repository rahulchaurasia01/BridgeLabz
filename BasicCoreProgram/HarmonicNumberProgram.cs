/*
 *  Purpose: Program for calculating the Nth Harmonic Number.
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
    class HarmonicNumberProgram
    {
        /// <summary>
        /// This Method is used to test the HarmonicNumberProgram Class.
        /// </summary>
        public static void HarmonicNumber()
        {

            Console.WriteLine();
            Console.WriteLine("----------------HARMONIC NUMBER PROGRAM----------------");
            Console.WriteLine();

            Boolean flag;
            int nthHarmonic;

            do
            {
                Console.Write("Enter the Nth Harmonic Number: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out nthHarmonic);

            } while (flag != true);

            /// Created an Utility Object because Utility class contains all the logic
            /// for this Program to give Proper Output.
            Utility utils = new Utility();

            double harmonicNumber = utils.HarmonicNumber(nthHarmonic);
            Console.WriteLine("The {0}th Harmonic Number is: {1}", nthHarmonic, harmonicNumber);
        }

    }
}
