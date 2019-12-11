/*
 *  Purpose: The Utility Class is used to store the logic of the Basic Core Program.
 *  
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   11-12-2019
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz.JunitProgram.Utils
{
    class Utility
    {
        /// <summary>
        /// It Convert the Temperature from celsius to Fahrenheit
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * (9.0 / 5)) + 32;
        }

        /// <summary>
        /// It Convert the Temperature from Fahrenheit to Celsius.
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <returns></returns>
        public static double FahrenheitToCelsius(double Fahrenheit)
        {
            return (Fahrenheit - 32) * (5.0 / 9);
        }

        /// <summary>
        /// Calculate the Monthly Emi using Formula
        ///                 principalAmount *n          where n = 12*year, r = CompoundInterest/(12 * 100);
        ///   Payment =   ---------------------------
        ///                 1 - (1+r)^(-n)
        /// </summary>
        /// <param name="principalAmount"></param>
        /// <param name="year"></param>
        /// <param name="compoundedInterest"></param>
        /// <returns></returns>
        public static double MonthlyPayment(double principalAmount, double year, double compoundedInterest)
        {
            double n = 12 * year;
            double r = compoundedInterest / (12 * 100);

            return principalAmount * r / (1 - Math.Pow(1 + r, -n));
        }
    
        /// <summary>
        /// Calculate the square root by using Newton Method.
        /// </summary>
        /// <param name="squareRoot"></param>
        /// <returns></returns>
        public static double Sqrt(int squareRoot)
        {
            double t = squareRoot;

            do
            {
                t = squareRoot / t;
                Console.WriteLine(t);
            } while (Math.Abs(t - squareRoot / t) < 1e-15 * t) ;


                return t;
        }

        /// <summary>
        /// Convert Decimal to Binary
        /// </summary>
        /// <param name="decimalValue"></param>
        public static String ToBinary(int decimalValue)
        {
            StringBuilder binary = new StringBuilder();
            do
            {
                int remainder = decimalValue % 2;
                binary.Append(remainder);
                decimalValue = decimalValue / 2;
            } while (decimalValue != 0);
            char[] reverse = binary.ToString().ToCharArray();
            Array.Reverse(reverse);
            binary.Clear();
            foreach (char a in reverse)
                binary.Append(a);
            return binary.ToString().PadLeft(8, '0');
        }



    }
}
