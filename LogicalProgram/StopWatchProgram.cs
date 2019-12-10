/*
 *  Purpose:  Program to find the elapsed Time.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   10-12-2019
 */

using System;
using System.Diagnostics;

namespace BridgeLabz.LogicalProgram
{
    class StopWatchProgram
    {
        /// <summary>
        /// This Method is used to Test the StopWatchProgram Class
        /// </summary>
        public static void StopWatch()
        {
            Console.WriteLine();
            Console.WriteLine("----------------StopWatch PROGRAM----------------");
            Console.WriteLine();

            Console.Write("Type 'start' command to start the stopWatch:- ");
            String startStopWatch = Console.ReadLine();
            Stopwatch stopWatch = new Stopwatch();

            if (!startStopWatch.Equals("start"))
            {
                Console.WriteLine("Invalid Command Enter.");
                return;
            }
            else
                stopWatch.Start();

            Console.WriteLine("Timer has Started:- ");
            Console.Write("Type 'stop' command to stop the stopWatch:- ");
            startStopWatch = Console.ReadLine();

            if (!startStopWatch.Equals("stop"))
            {
                Console.WriteLine("Invalid Command Enter.");
                return;
            }
            else
            {
                stopWatch.Stop();
                Console.WriteLine("Elapsed Time is:- {0}", stopWatch.Elapsed);
            }
        }
    }
}
