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

            while(Math.Abs(t - squareRoot / t) > 1e-15 * t)
            {
                t = ((squareRoot / t) + t) / 2.0;
                Console.WriteLine(t);
            }
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

        /// <summary>
        /// Swaping the nibbles and getting the resultant decimal value of it.
        /// </summary>
        /// <param name="getBinaryValue"></param>
        /// <param name="getBinaryValue"></param>
        public static void SwapAndGetNumber(String getBinaryValue)
        {
            String nibble1 = getBinaryValue.Substring(0, getBinaryValue.Length / 2);
            String nibble2 = getBinaryValue.Substring(getBinaryValue.Length / 2);

            Console.WriteLine("The Two nibbles are: {0}, {1}", nibble1, nibble2);

            String afterSwaping = nibble2 + nibble1;
            
            Console.WriteLine("After the swaping nibbles we get: {0}", afterSwaping);

            int temp = Convert.ToInt32(afterSwaping);
            double addition=0.0, count=0;

            do
            {
                double lastNumber = (double)temp % 10;
                temp /= 10;
                addition = addition + (lastNumber * Math.Pow(2, count));
                count++;
                
            } while (temp != 0);

            Console.WriteLine("The resultant Decimal Value is: {0}", addition);
        }

        /// <summary>
        /// To get the Day Of Week from the date.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="d"></param>
        /// <param name="y"></param>
        public static String dayOfWeek(int m, int d, int y)
        {
            String[] day = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            int y0 = y - (14 - m) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + ((31 * m0) / 12)) % 7;

            return day[d0];

        }
    
    
        /// <summary>
        /// This Method Give the Minimum number of notes as a change from the vending machine.
        /// </summary>
        /// <param name="change"></param>
        public static int minimumNotesRecursion(int change, int[] rupees, int n, int minimumNotes)
        {

            if (change == 0)
                return minimumNotes;
            else
            {
                if (change >= rupees[n - 1])
                {
                    change -= rupees[n - 1];
                    minimumNotes += 1;
                    Console.WriteLine(rupees[n-1]);
                    return minimumNotesRecursion(change, rupees, n, minimumNotes);
                }
                else
                {
                    n -= 1;
                    return minimumNotesRecursion(change, rupees, n, minimumNotes);
                }
            }

        }


    }
}
