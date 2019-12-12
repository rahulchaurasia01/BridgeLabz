/*
 *  Purpose:  Program to print the day of week from the given date.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   12-12-2019
 */

using System;
using BridgeLabz.JunitProgram.Utils;

namespace BridgeLabz.JunitProgram
{
    class DayOfWeekProgram
    {
        /// <summary>
        /// This Method is Used to test the dayOfWeek Program Class.
        /// </summary>
        public static void DayOfWeek()
        {
            Console.WriteLine();
            Console.WriteLine("----------------DayOfWeek PROGRAM----------------");
            Console.WriteLine();

            int month, day, year;
            Boolean flag;

            do
            {
                Console.Write("Enter the month.:- ");
                flag = Int32.TryParse(Console.ReadLine(), out month);
            } while (!flag);

            do
            {
                Console.Write("Enter the Day.:- ");
                flag = Int32.TryParse(Console.ReadLine(), out day);
            } while (!flag);

            do
            {
                Console.Write("Enter the Year.:- ");
                flag = Int32.TryParse(Console.ReadLine(), out year);
            } while (!flag);


            String dayOfWeek = Utility.dayOfWeek(month, day, year);
            Console.WriteLine("The Day Of Week For the above Date is:- {0}", dayOfWeek);

        }
    }
}
