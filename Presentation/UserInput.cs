using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame.Exceptions;
using TicTacToeGame.Models;

namespace TicTacToeGame.Presentation
{
    internal class UserInput
    {
       public static Player GetPlayerDetail(int id,char symbol)
       {
            Console.WriteLine($"\nEnter Player{id} Name : ");
            string name = Console.ReadLine();
            return new Player(id,name, symbol);
       }

       public static int ChooseValidPlayer()
       {
            try
            {
                int userInput = int.Parse(Console.ReadLine());
                if (userInput != 1 && userInput != 2)
                    throw new InvalidUserInputException("Please Enter the Correct Input 1 Or 2.");
                return userInput;
            }catch(InvalidUserInputException ex)
            {
                Console.WriteLine(ex.Message);
                return ChooseValidPlayer();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message );
                return ChooseValidPlayer();
            }
       }

        public static int GetValidInputPosition(Board board)
        {
            try
            {
                int userInput = int.Parse(Console.ReadLine());
                if (userInput < 1 || userInput > 9)
                    throw new InvalidUserInputException("Please Enter the Correct Input 1 to 9 Only.");
                else if (board.IsPositionEmpty(userInput))
                    throw new PositionIsNotEmptyException("\nThe Selected Position is already Occupied Please Choose Another Position");
                return userInput;
            }
            catch (InvalidUserInputException ex)
            {
                Console.WriteLine(ex.Message);
                return GetValidInputPosition(board);
            }
            catch (PositionIsNotEmptyException ex)
            {
                Console.WriteLine(ex.Message);
                return GetValidInputPosition(board);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return GetValidInputPosition(board);
            }
        }

        public static string GetUserDecisionOnPlayAgain()
        {
            try
            {
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "yes" || userInput == "no")
                    return userInput;
                throw new InvalidUserInputException("Invalid Input, Please Enter Yes or No only");
            }
            catch (InvalidUserInputException ex) 
            {
                Console.WriteLine(ex.Message);
                return GetUserDecisionOnPlayAgain();
            }
        }


    }
}
