/*
 *  Purpose:  To Calulate the WindChill.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   10-12-2019
 */

using BridgeLabz.FunctionalProgram.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz.FunctionalProgram
{
    class WindChillProgram
    {
        /// <summary>
        /// This Method is Used to Test the WindChillProgram Class
        /// </summary>
        public static void WindChill()
        {
            Console.WriteLine();
            Console.WriteLine("----------------WINDCHILL PROGRAM----------------");
            Console.WriteLine();

            Boolean flag;
            int t, v;

            do
            {
                Console.Write("Enter the temperature in fahrenheit: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out t);

            } while (flag != true);

            do
            {
                Console.Write("Enter the wind Speed: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out v);

            } while (flag != true);

            /// Created an Utility Object because Utility class contains all the logic
            /// for this Program to give Proper Output.
            Utility utils = new Utility();
            double result = utils.WindChill(t,v);

            Console.WriteLine("Wind Chill is: {0}", result);
        }
    }
}
