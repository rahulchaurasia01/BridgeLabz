/*
 *  Purpose: The Utility Class is used to store the logic of the Basic Core Program.
 *  
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   10-12-2019
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz.FunctionalProgram.Utils
{
    class Utility
    {
        /// <summary>
        /// To Calculate the Distance between the two Points.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double EuclideanDistance(int x, int y)
        {
            return Math.Sqrt(Math.Pow(x, 2) - Math.Pow(y, 2));
        }

    }
}
