/*
 *  Purpose:  Program to calculate the Monthly Emi.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   11-12-2019
 */

using System;
using BridgeLabz.JunitProgram.Utils;

namespace BridgeLabz.JunitProgram
{
    class EmiCalculatorProgram
    {
        /// <summary>
        /// This Method is used to test the EmiCalculatorProgram Class.
        /// </summary>
        public static void EmiCalculator()
        {
            Console.WriteLine();
            Console.WriteLine("----------------EMI CALCULATOR PROGRAM----------------");
            Console.WriteLine();

            double principalAmount, year, compoundInterest;

            Boolean flag;

            do
            {
                Console.Write("Enter the Principal Amount: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = double.TryParse(Console.ReadLine(), out principalAmount);

            } while (flag != true);

            do
            {
                Console.Write("Enter the Year: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = double.TryParse(Console.ReadLine(), out year);

            } while (flag != true);

            do
            {
                Console.Write("Enter the Compounded Interest: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = double.TryParse(Console.ReadLine(), out compoundInterest);

            } while (flag != true);

            double result = Utility.MonthlyPayment(principalAmount, year, compoundInterest);
            Console.WriteLine("Your Monthly Emi is: {0}", result);
        }
    }
}
