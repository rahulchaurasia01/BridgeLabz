/*
 *  Purpose:  Program to Convert the Decimal Value to Binary Value.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   11-12-2019
 */

using System;
using BridgeLabz.JunitProgram.Utils;

namespace BridgeLabz.JunitProgram
{
    class DecimalToBinaryProgram
    {
        /// <summary>
        /// This Method is used to Test the DecimalToBinaryProgram Class
        /// </summary>
        public static void DecimalToBinary()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Decimal To Binary PROGRAM----------------");
            Console.WriteLine();

            int decimalValue;

            Boolean flag;

            do
            {
                Console.Write("Enter the Decimal Number.:- ");
                flag = Int32.TryParse(Console.ReadLine(), out decimalValue);
            } while (!flag);

            String binaryValue = Utility.ToBinary(decimalValue);
            Console.WriteLine("The Binary Representation is: {0}", binaryValue);
        }
    }
}
