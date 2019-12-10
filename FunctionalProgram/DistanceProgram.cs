/*
 *  Purpose:  .
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   10-12-2019
 */

using System;
using BridgeLabz.FunctionalProgram.Utils;

namespace BridgeLabz.FunctionalProgram
{
    class DistanceProgram
    {
        /// <summary>
        /// This Method is used to test the DistanceProgram Class.
        /// </summary>
        public static void Distance()
        {
            Boolean flag;
            int xAxis, yAxis;

            do
            {
                Console.Write("Enter the Position of X-Axis: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out xAxis);

            } while (flag != true);

            do
            {
                Console.Write("Enter the Position of Y-Axis: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out yAxis);

            } while (flag != true);

            /// Created an Utility Object because Utility class contains all the logic
            /// for this Program to give Proper Output.
            Utility utils = new Utility();
            Console.WriteLine("The Distance b/w the point and origin is: {0}", utils.EuclideanDistance(xAxis, yAxis));
        }
    }
}
