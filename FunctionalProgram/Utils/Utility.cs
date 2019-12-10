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

        /// <summary>
        /// To Calculate the Roots of the Quadratic Equation
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public void RootsOfQuadratic(int a, int b, int c)
        {
            double delta = (b * b) - (4 * a * c);

            double root1, root2;

            root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            root2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("The First roots is: {0}", root1);
            Console.WriteLine("The Second roots is: {0}", root2);
        }

        /// <summary>
        ///  Program To Calculate the Wind Chill 
        /// </summary>
        /// <param name="t"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public double WindChill(int t, int v)
        {
            double vPower = Math.Pow(v, 0.16);

            double result = 35.74 + (0.6215 * t) + ((0.4275 * t) - 35.75) * vPower;

            return result;

        }

        /// <summary>
        /// To Display the 2D Array 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        public void Display2DArray(int[,] arr, int rows, int columns)
        {
            for(int i=0;i<rows;i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write(arr[i,j] + " ");

                Console.WriteLine();
            }
        }


        public void Triplets(int[] arr)
        {
            Console.WriteLine("The Triplets are: ");
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    for(int k=j+1;k<arr.Length;k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                            Console.WriteLine(arr[i] + " " + arr[j] + " " + arr[k]);
                    }
                }
            }
        }
    }
}
