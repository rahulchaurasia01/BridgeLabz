/*
 *  Purpose:  Program to Play the Gambler Game.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   11-12-2019
 */

using System;
using BridgeLabz.LogicalProgram.Utils;

namespace BridgeLabz.LogicalProgram
{
    class GamblerProgram
    {
        /// <summary>
        /// This method is used to test the Gambler Program Class
        /// </summary>
        public static void Gambler()
        {
            Console.WriteLine();
            Console.WriteLine("----------------GAMBLER PROGRAM----------------");
            Console.WriteLine();

            Boolean flag;
            int stake, goal, trails;

            do
            {
                Console.Write("Enter your Stake: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out stake);

            } while (flag != true);

            do
            {
                Console.Write("Enter your Goal: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out goal);

            } while (flag != true);

            do
            {
                Console.Write("Enter your Trail: ");

                /// TryParse Method take 2 argument, 1st string value, 2nd int value
                /// TryParse Method tries to Convert String Value to Int Value.
                /// If the Conversion is successfull it will return true or else False.
                flag = Int32.TryParse(Console.ReadLine(), out trails);

            } while (flag != true);

            /// Created an Utility Object because Utility class contains all the logic
            /// for this Program to give Proper Output.
            Utility utils = new Utility();
            utils.Gambler(stake, goal, trails);
            
        }
    }
}
