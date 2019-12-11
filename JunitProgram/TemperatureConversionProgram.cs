/*
 *  Purpose:  Program to convert the Temperature unit (i.e Celsius to fahrenheit and vice-versa.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   11-12-2019
 */

using System;
using BridgeLabz.JunitProgram.Utils;

namespace BridgeLabz.JunitProgram
{
    class TemperatureConversionProgram
    {
        /// <summary>
        /// This Method is used to test the TemperatureConversionProgram Class
        /// </summary>
        public static void TemperatureConversion()
        {
            Console.WriteLine();
            Console.WriteLine("----------------TemperatureConversion PROGRAM----------------");
            Console.WriteLine();

            Console.WriteLine("1. Convert Celsius to Fahrenheit.");
            Console.WriteLine("2. Convert Fahrenheit to Celsius.");
            Console.Write("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1: Console.Write("Enter the Temperature in Celsius: ");
                        double tempCelsius = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The Temperature in Fahrenheit is: {0}", Utility.CelsiusToFahrenheit(tempCelsius));
                        break;

                case 2: Console.Write("Enter the Temperature in Fahrenheit: ");
                        double tempFahren = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The Temperature in Celsius: {0}", Utility.FahrenheitToCelsius(tempFahren));
                        break;

                default: Console.WriteLine("Invalid Choice !!!");
                         break;
            }
        }
    }
}
