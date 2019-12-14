/*
 *  Purpose:  Program for Task Completion.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   14-12-2019
 */

using BridgeLabz.AlgorithmProgram.Utils;
using System;

namespace BridgeLabz.AlgorithmProgram
{
    class TaskCompletionProgram
    {
        /// <summary>
        /// This Method is used to test the TaskCompletetionPorgram Class
        /// </summary>
        public static void TaskCompletion()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Task Completion PROGRAM----------------");
            Console.WriteLine();


            Console.Write("Enter the No. Of Task: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] d = new int[n];
            int[] m = new int[n];

            for(int i=0;i<n;i++)
            {
                Console.Write("Enter the task {0} Deadline and Minutes to Complete: ", i + 1);
                d[i] = Convert.ToInt32(Console.ReadLine());
                m[i] = Convert.ToInt32(Console.ReadLine());
            }

            Utility utils = new Utility();
            utils.TaskCompletion(d, m);
        }
    }
}
