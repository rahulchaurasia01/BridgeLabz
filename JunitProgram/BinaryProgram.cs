/*
 *  Purpose:  Program to swap the two nibbles and print their decimal value.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   12-12-2019
 */

using System;
using BridgeLabz.JunitProgram.Utils;

namespace BridgeLabz.JunitProgram
{
    class BinaryProgram
    {
        /// <summary>
        /// This Method is used to test the BinaryProgram Class.
        /// </summary>
        public static void Binary()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Swaping Nibbles and resultant Decimal Value PROGRAM----------------");
            Console.WriteLine();

            int decimalValue;

            Boolean flag;

            do
            {
                Console.Write("Enter the Decimal Number.:- ");
                flag = Int32.TryParse(Console.ReadLine(), out decimalValue);
            } while (!flag);

            String getBinaryValue = Utility.ToBinary(decimalValue);

            Utility.SwapAndGetNumber(getBinaryValue);
        }
    }
}
