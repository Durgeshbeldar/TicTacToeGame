using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame.Controllers;
using TicTacToeGame.Models;

namespace TicTacToeGame.Presentation
{
    internal class GameUI
    {
        public static void PlayGame()
        {
            // *************** WELCOME TO TIC-TAC-TOE GAME ***************

            Console.WriteLine("\n*************** WELCOME TO TIC-TAC-TOE GAME ***************\n");

            Console.WriteLine("\nEnter The Players Details For Player 1 and Player 2\n");

            // Taking Seperate User Inputs to Enhance Readabilty

            Player player1 = UserInput.GetPlayerDetail(1, 'X');
            Player player2 = UserInput.GetPlayerDetail(2, 'O');

            Console.WriteLine("\n********** PLAYER DETAILS **********\n");

            Console.WriteLine(player1);
            Console.WriteLine(player2);

            StartGame(player1, player2);
        }

        public static void StartGame(Player player1, Player player2)
        {
            Console.WriteLine("\n***** Game is Started....All The Best *****\n");

            GameController gameController = new GameController();
            bool gameActive = true;
            Console.WriteLine(
                $"Who Will Play The First Turn : 1.{player1.PlayerName} "
                    + $"2.{player2.PlayerName} (Enter 1 OR 2)\n"
            );

            int choice = UserInput.ChooseValidPlayer();
            Player activePlayer = (choice == 1) ? player1 : player2;

            while (gameActive)
            {
                Console.WriteLine(
                    $"{activePlayer.PlayerName}'s Turn. Sign of Player is : {activePlayer.Symbol} Enter Position 1 to 9 only\n"
                        + $"NOTE : Enter Code 1234 To Reset the Board (if you want)"
                );
                Printer.PrintBoard(gameController);   

                // if user enter 1234 it will reset the board ...

                int selectedPosition = UserInput.GetValidInputPosition(gameController.Board);

                Console.WriteLine(gameController.PlayTurn(selectedPosition, activePlayer));

                if (gameController.IsGameOver == true)
                {
                    Printer.PrintBoard(gameController);
                    gameController.ResetBoard();
                    gameActive = false;
                }

                // Altering the Players Turn...

                activePlayer = activePlayer == player1 ? player2 : player1;
            }

            Console.WriteLine("Do You Want To Play Again (Yes/No) ?");
            string userDecision = UserInput.GetUserDecisionOnPlayAgain();
            if (userDecision == "yes")
                PlayGame();

            Console.WriteLine("\nSuccessfully Exited ... Thank You!\n\n");
        }
    }
}
