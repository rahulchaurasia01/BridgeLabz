/*
 *  Purpose: The Utility Class is used to store the logic of the Basic Core Program.
 *  
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   10-12-2019
 * 
 */

using System;

namespace BridgeLabz.LogicalProgram.Utils
{
    class Utility
    {
        /// <summary>
        /// This method will generate the unique Coupon and the total Random
        /// number needed to generate it.
        /// </summary>
        /// <param name="number"></param>
        public static void GenerateUniqueCoupons(int number)
        {
            ///Array a is declare to store the unique Coupon Number.
            int[] a = new int[number];
            int count = 0, uniqueNumber, randomCount=0;
            Boolean flag = false;
            Random random = new Random();
            do
            {
                uniqueNumber = random.Next(1, number+1);
                randomCount++;
                flag = false;
                if(count == 0)
                {
                    a[0] = uniqueNumber;
                    count++;
                }
                else
                {
                    ///This loop will check the random Number generated is
                    ///already present in the array or not.
                    for(int i=0;i<count;i++)
                    {
                        if(a[i] == uniqueNumber)
                        {
                            flag = true;
                            break;
                        }
                    }
                    ///If the random number is not in the array then it is a unique number
                    ///So add in the array.
                    if(!flag)
                    {
                        a[count] = uniqueNumber;
                        count++;
                    }
                }
            } while (count < number);

            Console.WriteLine("Total Random Number Needed to Generate {0} Unique Coupon is: {1}",number, randomCount);

            foreach (int i in a)
                Console.WriteLine("Unique Coupon Number are: {0}", i);

            
        }
    
        /// <summary>
        /// Display TicTacToe Board 
        /// </summary>
        /// <param name="ticTacToe"></param>
        public void DisplayTicTacToeBoard(char[] ticTacToe)
        {
            Console.WriteLine("  {0} | {1} | {2} ", ticTacToe[0], ticTacToe[1], ticTacToe[2]);
            Console.WriteLine(" --  --  -- ");
            Console.WriteLine("  {0} | {1} | {2} ", ticTacToe[3], ticTacToe[4], ticTacToe[5]);
            Console.WriteLine(" --  --  --");
            Console.WriteLine("  {0} | {1} | {2} ", ticTacToe[6], ticTacToe[7], ticTacToe[8]);
        }
    
        /// <summary>
        /// Computer Turns to play TicTacToe Game.
        /// </summary>
        /// <param name="ticTacToe"></param>
        /// <param name="postion"></param>
        /// <param name="computerSelected"></param>
        public void ComputerTurns(char[] ticTacToe, int[] postion, char computerSelected)
        { 
            Random random = new Random();
            do
            {
                int computerPostion = random.Next(0, 9);
                
                if(postion[computerPostion] != computerPostion)
                {
                    ticTacToe[computerPostion] = computerSelected;
                    postion[computerPostion] = computerPostion;
                    break;
                }
            } while (true);
        }
    
        /// <summary>
        /// User Turns to play TicTacToe Game
        /// </summary>
        /// <param name="ticTacToe"></param>
        /// <param name="positon"></param>
        /// <param name="userSelected"></param>
        /// <param name="userPostion"></param>
        /// <returns></returns>
        public Boolean UserTurns(char[] ticTacToe, int[] positon, char userSelected, int userPostion)
        {
            if (positon[userPostion] == userPostion)
                return false;
            else
            {
                ticTacToe[userPostion] = userSelected;
                positon[userPostion] = userPostion;
                return true;
            }
        }

        /// <summary>
        /// Check whether the game has been drawn or not.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public Boolean CheckDraw(int[] position)
        {
            for(int i=0;i<position.Length;i++)
            {
                if (position[i] != i)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Check whether user has won the Game Or Not.
        /// </summary>
        /// <param name="ticTacToe"></param>
        /// <param name="userSelected"></param>
        /// <param name="computerSelected"></param>
        /// <returns></returns>
        public Boolean CheckUserWin(char[] ticTacToe, char userSelected)
        {

            if(ticTacToe[0] == userSelected && ticTacToe[1] == userSelected && ticTacToe[2] == userSelected)
                return true;
            else if (ticTacToe[3] == userSelected && ticTacToe[4] == userSelected && ticTacToe[5] == userSelected)
                return true;
            else if (ticTacToe[6] == userSelected && ticTacToe[7] == userSelected && ticTacToe[8] == userSelected)
                return true;
            else if (ticTacToe[0] == userSelected && ticTacToe[4] == userSelected && ticTacToe[8] == userSelected)
                return true;
            else if (ticTacToe[2] == userSelected && ticTacToe[4] == userSelected && ticTacToe[6] == userSelected)
                return true;
            else if (ticTacToe[0] == userSelected && ticTacToe[3] == userSelected && ticTacToe[6] == userSelected)
                return true;
            else if (ticTacToe[1] == userSelected && ticTacToe[4] == userSelected && ticTacToe[7] == userSelected)
                return true;
            else if (ticTacToe[2] == userSelected && ticTacToe[5] == userSelected && ticTacToe[8] == userSelected)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Check Whether Computer has Won the game Or not.
        /// </summary>
        /// <param name="ticTacToe"></param>
        /// <param name="computerSelected"></param>
        /// <returns></returns>
        public Boolean CheckComputerWin(char[] ticTacToe, char computerSelected)
        {

            if (ticTacToe[0] == computerSelected && ticTacToe[1] == computerSelected && ticTacToe[2] == computerSelected)
                return true;
            else if (ticTacToe[3] == computerSelected && ticTacToe[4] == computerSelected && ticTacToe[5] == computerSelected)
                return true;
            else if (ticTacToe[6] == computerSelected && ticTacToe[7] == computerSelected && ticTacToe[8] == computerSelected)
                return true;
            else if (ticTacToe[0] == computerSelected && ticTacToe[4] == computerSelected && ticTacToe[8] == computerSelected)
                return true;
            else if (ticTacToe[2] == computerSelected && ticTacToe[4] == computerSelected && ticTacToe[6] == computerSelected)
                return true;
            else if (ticTacToe[0] == computerSelected && ticTacToe[3] == computerSelected && ticTacToe[6] == computerSelected)
                return true;
            else if (ticTacToe[1] == computerSelected && ticTacToe[4] == computerSelected && ticTacToe[7] == computerSelected)
                return true;
            else if (ticTacToe[2] == computerSelected && ticTacToe[5] == computerSelected && ticTacToe[8] == computerSelected)
                return true;
            else
                return false;
        }

        /// <summary>
        /// This Method give win, percentage of win and percentage of loss.
        /// </summary>
        /// <param name="stake"></param>
        /// <param name="goal"></param>
        /// <param name="trail"></param>
        public void Gambler(int stake, int goal, int trail)
        {
            int bet = 0;
            int win = 0;
            int cash = 0;
            int randToken;
            Random random = new Random();

            for(int i=0;i<trail;i++)
            {
                cash = stake;
                while(cash > 0 && cash <= goal)
                {
                    randToken = random.Next(-100, 100);
                    bet++;
                    if (randToken < 0)
                        cash++;
                    else
                        cash--;
                    if (cash == goal)
                        win++;
                }
            }
            Console.WriteLine("You win {0} out of {1} Trails", win, trail);
            Console.WriteLine("The Win Percentage of the Gambler is: {0}", win * 100 / trail);
            Console.WriteLine("The Loss Percentage of the Gambler is {0}", bet * 0.01 / trail);
        }

    }
}
