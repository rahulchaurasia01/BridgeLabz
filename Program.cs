/*
 *  Purpose: Entry Point For the Program.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   10-12-2019
 */


using System;
using BridgeLabz.AlgorithmProgram;
using BridgeLabz.BasicCoreProgram;
using BridgeLabz.FunctionalProgram;
using BridgeLabz.JunitProgram;
using BridgeLabz.LogicalProgram;

namespace BridgeLabz
{
    class Program
    {

        /// <summary>
        /// This is the Entry Point for the Program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            Boolean flag;
            do
            {
                flag = false;
                Console.WriteLine();
                Console.WriteLine("Welcome to BridgeLabz !!!");
                Console.WriteLine();
                Console.WriteLine("Select the type of Program You want to Run");
                Console.WriteLine("1st) Basic Core Program");
                Console.WriteLine("2nd) Functional Program");
                Console.WriteLine("3rd) Logical Program");
                Console.WriteLine("4th) JUnit Program");
                Console.WriteLine("5th) Algorithm Program");
                Console.WriteLine("6th) Exit.");
                Console.Write("Enter Your Choice:- ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: BasicCoreProgram();
                            break;

                    case 2: FunctionalProgram();
                            break;

                    case 3: LogicalProgram();
                            break;

                    case 4: JUnitProgram();
                            break;

                    case 5: AlgorithmProgram();
                            break;

                    case 6: flag = true;
                            break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            } while (!flag);
        }

        /// <summary>
        /// This Method is used to Run all the Basic Core Program.
        /// </summary>
        public static void BasicCoreProgram()
        {
            char exit;
            do
            {
                Console.WriteLine();
                Console.WriteLine("The Basic Core Program Contains the Following list.");
                Console.WriteLine();
                Console.WriteLine("1. Simple String Program");
                Console.WriteLine("2. Flip Coin Program");
                Console.WriteLine("3. Leap Year Program");
                Console.WriteLine("4. Power 2 Program");
                Console.WriteLine("5. Harmonic Number Program");
                Console.WriteLine("6. Prime Factorization Program");
                Console.Write("Enter Your Choice:- ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1: SimpleStringProgram.SimpleString();
                            break;

                    case 2: FlipCoinProgram.FlipCoin();
                            break;

                    case 3: LeapYearProgram.LeapYear();
                            break;

                    case 4: PowerOf2Program.PowerOf2();
                            break;

                    case 5: HarmonicNumberProgram.HarmonicNumber();
                            break;

                    case 6: PrimeFactorizationProgram.PrimeFactorization();
                            break;

                    default: Console.WriteLine("Invalid Choice.");
                             break;
                }

                Console.WriteLine();
                Console.Write("Do You want to Continue [y/n]: ");
                exit = Convert.ToChar(Console.ReadLine().ToLower());
            } while (exit != 'n');
        }

        /// <summary>
        /// This Method is used to run all the Functional Program.
        /// </summary>
        public static void FunctionalProgram()
        {
            char exit;
            do
            {
                Console.WriteLine();
                Console.WriteLine("The Functional Program Contains the Following list.");
                Console.WriteLine();
                Console.WriteLine("1. 2D Array Program");
                Console.WriteLine("2. Triplets Program");
                Console.WriteLine("3. Distance Program");
                Console.WriteLine("4. Quadratic Program");
                Console.WriteLine("5. WindChill Program");
                Console.Write("Enter Your Choice:- ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        TwoDimensionalArrayProgram.TwoDimensionalArray();
                        break;

                    case 2:
                        SumThreeToZeroProgram.SumThreeToZero();
                        break;

                    case 3:
                        DistanceProgram.Distance();
                        break;

                    case 4:
                        QuadraticProgram.Quadratic();
                        break;

                    case 5:
                        WindChillProgram.WindChill();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }

                Console.WriteLine();
                Console.Write("Do You want to Continue [y/n]: ");
                exit = Convert.ToChar(Console.ReadLine().ToLower());
            } while (exit != 'n');
        }

        /// <summary>
        /// This Method is used to run all the Logical Program.
        /// </summary>
        public static void LogicalProgram()
        {
            char exit;
            do
            {
                Console.WriteLine();
                Console.WriteLine("The Logical Program Contains the Following list.");
                Console.WriteLine();
                Console.WriteLine("1. Gambler Program");
                Console.WriteLine("2. Coupon Numbers Program");
                Console.WriteLine("3. StopWatch Program");
                Console.WriteLine("4. Tic-Tac-Toe Program");
                Console.Write("Enter Your Choice:- ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        GamblerProgram.Gambler();
                        break;

                    case 2:
                        CouponNumbersProgram.CouponNumbers();
                        break;

                    case 3:
                        StopWatchProgram.StopWatch();
                        break;

                    case 4:
                        TicTacToeProgram.TicTacToe();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }

                Console.WriteLine();
                Console.Write("Do You want to Continue [y/n]: ");
                exit = Convert.ToChar(Console.ReadLine().ToLower());
            } while (exit != 'n');
        }

        /// <summary>
        /// This Method is used to run all the JUnit Program
        /// </summary>
        public static void JUnitProgram()
        {
            char exit;
            do
            {
                Console.WriteLine();
                Console.WriteLine("The JUnit Program Contains the Following list.");
                Console.WriteLine();
                Console.WriteLine("1. Vending Machine Problem");
                Console.WriteLine("2. Day Of Week Program");
                Console.WriteLine("3. Temperature Conversion Program");
                Console.WriteLine("4. E.M.I Program");
                Console.WriteLine("5. Square Root Program");
                Console.WriteLine("6. Decimal To Binary Program");
                Console.WriteLine("7. Binary Program");
                Console.Write("Enter Your Choice:- ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        VendingMachineProblem.VendingMachine();
                        break;

                    case 2:
                        DayOfWeekProgram.DayOfWeek();
                        break;

                    case 3:
                        TemperatureConversionProgram.TemperatureConversion();
                        break;

                    case 4:
                        EmiCalculatorProgram.EmiCalculator();
                        break;

                    case 5:
                        SquareRootProgram.SquareRoot();
                        break;

                    case 6:
                        DecimalToBinaryProgram.DecimalToBinary();
                        break;

                    case 7:
                        BinaryProgram.Binary();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }

                Console.WriteLine();
                Console.Write("Do You want to Continue [y/n]: ");
                exit = Convert.ToChar(Console.ReadLine().ToLower());
            } while (exit != 'n');
        }

        /// <summary>
        /// This Method is used to run all the Algorithm Program
        /// </summary>
        public static void AlgorithmProgram()
        {
            char exit;
            do
            {
                Console.WriteLine();
                Console.WriteLine("The Algorithm Program Contains the Following list.");
                Console.WriteLine();
                Console.WriteLine("1. Permutation Problem");
                Console.WriteLine("2. Binary Search for String Program");
                Console.WriteLine("3. Insertion Sort Program");
                Console.WriteLine("4. Bubble Sort Program");
                Console.WriteLine("5. Merge Sort Program");
                Console.WriteLine("6. Anagram Detection Program");
                Console.WriteLine("7. Prime Number Program");
                Console.WriteLine("8. Prime Number that are Anagram and Palindrome Program");
                Console.WriteLine("9. Generics Search and Sort Program");
                Console.WriteLine("10. Question to find your Problem");
                Console.WriteLine("11. Empty Program");
                Console.Write("Enter Your Choice:- ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        PermutationStringProgram.PermutationString();
                        break;

                    case 2:
                        BinarySearchStringProgram.BinarySearchString();
                        break;

                    case 3:
                        InsertionSortProgram.InsertionSort();
                        break;

                    case 4:
                        BubbleSortProgram.BubbleSort();
                        break;

                    case 5:
                        MergeSortProgram.MergeSort();
                        break;

                    case 6:
                        AnagramDetectionProgram.AnagramDetection();
                        break;

                    case 7:
                        PrimeNumberProgram.PrimeNumber();
                        break;

                    case 8:
                        PrimeNumberAnagramPalindromeProgram.PrimeNumberAnagramPalindrome();
                        break;

                    case 9:
                        GenericsProgram.Generics();
                        break;

                    case 10:
                        Console.WriteLine("This Program has not been Implemented Yet!!");
                        break;

                    case 11:
                        Console.WriteLine("This Program has not been Implemented Yet!!");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }

                Console.WriteLine();
                Console.Write("Do You want to Continue [y/n]: ");
                exit = Convert.ToChar(Console.ReadLine().ToLower());
            } while (exit != 'n');
        }
    }
}
