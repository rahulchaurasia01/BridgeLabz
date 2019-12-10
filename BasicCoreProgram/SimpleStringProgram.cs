/*
 *  Purpose: Simple String Manuplication.
 *  
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   10-12-2019
 * 
 */

using BridgeLabz.BasicCoreProgram.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz.BasicCoreProgram
{
    class SimpleStringProgram
    {
       
        /// <summary>
        /// This Method will test the SimpleStringProgram.
        /// </summary>
        public static void SimpleString()
        {
            Console.Write("Enter Your UserName:- ");
            String userName = Console.ReadLine();

            /// Created an Utility Object because Utility class contains all the logic
            /// for this Program to give Proper Output.
            Utility utils = new Utility();

            if (utils.CheckUserNameLength(userName))
                Console.WriteLine("Hello {0}, How are you?", userName);
            else
                Console.WriteLine("Invalid UserName.");

        }
    }
}
