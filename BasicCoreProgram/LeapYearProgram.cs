/*
 *  Purpose: Program to find whether the entered year is a leap year or not.
 *  
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   10-12-2019
 * 
 */


using System;
using BridgeLabz.BasicCoreProgram.Utils;

namespace BridgeLabz.BasicCoreProgram
{
    public class LeapYearProgram
    {
        /// <summary>
        /// This Method is Used to test the LeapYearProgram.
        /// </summary>
        public static void LeapYear()
        {
            Console.WriteLine();
            Console.WriteLine("----------------LEAP YEAR PROGRAM----------------");
            Console.WriteLine();

            Boolean flag;
            int leapYear;
            do
            {
                Console.Write("Enter Year: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out leapYear);

            } while (flag != true);

            /// Created an Utility Object because Utility class contains all the logic
            /// for this Program to give Proper Output.
            Utility utils = new Utility();

            if(!utils.IsAFourDigitNumber(leapYear))
                Console.WriteLine("The Number is not a Four Digit Number.");
            else
            {
                if(utils.CheckLeapYear(leapYear))
                    Console.WriteLine("{0} is a leap year.",leapYear);
                else
                    Console.Write("{0} is not a leap year.", leapYear);
            }   
        }
    }
}
