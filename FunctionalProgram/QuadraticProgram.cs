/*
 *  Purpose:  To Find the roots of the Quadratic Equations.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   10-12-2019
 */

using System;
using BridgeLabz.FunctionalProgram.Utils;

namespace BridgeLabz.FunctionalProgram
{
    class QuadraticProgram
    {
        /// <summary>
        /// This Method is used to test the QuadraticProgram Class
        /// </summary>
        public static void Quadratic()
        {

            Console.WriteLine();
            Console.WriteLine("----------------QUADRATIC PROGRAM----------------");
            Console.WriteLine();

            Boolean flag;

            int a, b, c;
            do
            {
                Console.Write("Enter the Coefficent of a: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out a);

            } while (flag != true);

            do
            {
                Console.Write("Enter the Coefficent of b: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out b);

            } while (flag != true);

            do
            {
                Console.Write("Enter the Coefficent of c: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out c);

            } while (flag != true);

            /// Created an Utility Object because Utility class contains all the logic
            /// for this Program to give Proper Output.
            Utility utils = new Utility();
            utils.RootsOfQuadratic(a, b, c);
        }
    }
}
