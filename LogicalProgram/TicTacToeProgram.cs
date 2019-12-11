/*
 *  Purpose:  Program to Play the TicTacToe Game.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   11-12-2019
 */

using BridgeLabz.LogicalProgram.Utils;
using System;

namespace BridgeLabz.LogicalProgram
{
    class TicTacToeProgram
    {
        /// <summary>
        /// This Method is used to test the TicTacToeProgram Class
        /// </summary>
        public static void TicTacToe()
        {

            Console.WriteLine();
            Console.WriteLine("----------------TicTacToe PROGRAM----------------");
            Console.WriteLine();

            char computerSelected = 'O';
            char userSelected = 'X';

            Console.WriteLine("Player 1 is Computer!!");
            Console.WriteLine("Player 2 is User!!");
            Console.WriteLine();

            char[] ticTacToeBoard = new char[9];

            for (int i = 0; i < ticTacToeBoard.Length; i++)
                ticTacToeBoard[i] = '0';

            Utility utils = new Utility();
            utils.DisplayTicTacToeBoard(ticTacToeBoard);
            Console.WriteLine();

            int[] ticTacToePosition = new int[9];

            for (int i = 0; i < ticTacToePosition.Length; i++)
                ticTacToePosition[i] = -1;

            Boolean flag = false;

            do
            {
                Console.WriteLine("Player 1 Turns: ");
                utils.ComputerTurns(ticTacToeBoard, ticTacToePosition, computerSelected);
                utils.DisplayTicTacToeBoard(ticTacToeBoard);
                Console.WriteLine();

                if (utils.CheckComputerWin(ticTacToeBoard, computerSelected))
                {
                    Console.WriteLine("Player 1 Has Won the Game.");
                    Console.WriteLine();
                    break;
                }

                if (utils.CheckDraw(ticTacToePosition))
                {
                    Console.WriteLine("Nobody Wins!!! The Game Has been Draw");
                    break;
                }

                do
                {

                    Console.WriteLine("Player 2 Turns: ");
                    Console.Write("Enter Your Position:- ");
                    int userPostion = Convert.ToInt32(Console.ReadLine());
                    if (userPostion >= 0 && userPostion <= 8)
                    {
                        flag = utils.UserTurns(ticTacToeBoard, ticTacToePosition, userSelected, userPostion);

                        if (!flag)
                            Console.WriteLine("This Position is already Filled.!!");
                    }
                    else
                        Console.WriteLine("Invalid Postion. !!");
                    

                } while (!flag);
                utils.DisplayTicTacToeBoard(ticTacToeBoard);
                Console.WriteLine();

                if(utils.CheckUserWin(ticTacToeBoard, userSelected))
                {
                    Console.WriteLine("Player 2 Has Won the Game.");
                    Console.WriteLine();
                    break;
                }

                if (utils.CheckDraw(ticTacToePosition))
                {
                    Console.WriteLine("Nobody Wins!!! The Game Has been Draw");
                    break;
                }

            } while (true);

        }
    }
}
