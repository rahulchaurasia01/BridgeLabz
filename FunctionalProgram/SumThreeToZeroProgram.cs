/*
 *  Purpose:  To find the triplets thats add to zero.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   10-12-2019
 */

using BridgeLabz.FunctionalProgram.Utils;
using System;

namespace BridgeLabz.FunctionalProgram
{
    class SumThreeToZeroProgram
    {
        /// <summary>
        /// This Method is used to test the SumThreeToZero Class
        /// </summary>
        public static void SumThreeToZero()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Triplets PROGRAM----------------");
            Console.WriteLine();

            Boolean flag;
            int size;

            do
            {
                Console.Write("Enter the size of an Array: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out size);

            } while (flag != true);

            int[] a = new int[size];

            Console.Write("Enter the Value: ");
            for (int i = 0; i < size; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());

            /// Created an Utility Object because Utility class contains all the logic
            /// for this Program to give Proper Output.
            Utility utils = new Utility();
            utils.Triplets(a);

        }
    }
}
