/*
 *  Purpose:  Program for Determining the miniumum no. of notes should be 
 *  returned by the vending machine.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   12-12-2019
 */

using System;
using BridgeLabz.JunitProgram.Utils;

namespace BridgeLabz.JunitProgram
{
    class VendingMachineProblem
    {
        /// <summary>
        /// This Method is used to test the Vending Machine Problem class.
        /// </summary>
        public static void VendingMachine()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Vending Machine PROGRAM----------------");
            Console.WriteLine();

            int change;
            Boolean flag;

            do
            {
                Console.Write("How Much Rupees Change you need.:- ");
                flag = Int32.TryParse(Console.ReadLine(), out change);
            } while (!flag);


            int[] rupees = { 1, 2, 5, 10, 50, 100, 500, 2000 };

            Console.WriteLine("The list of rupees Given as a change are: ");

            int minimumNotes = Utility.minimumNotesRecursion(change, rupees, rupees.Length, 0);

            Console.WriteLine("Minimum Notes Needed to give the change: {0}", minimumNotes);
        }
    }
}
