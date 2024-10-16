using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame.Controllers;

namespace TicTacToeGame.Presentation
{
    internal class Printer
    {
        public static void PrintBoard(GameController gameController)
        {
            char[,] Grid = gameController.GetBoard();

            // Printing the Tic Tac Toe Game Board 

            Console.WriteLine($"\n*******************\n|  {Grid[0, 0]}  |  {Grid[0, 1]}  |  {Grid[0, 2]} " +
                $" |\n|*****************|\n| " +
                $" {Grid[1, 0]}  |  {Grid[1, 1]}  |  {Grid[1, 2]} " +
                $" |\n|*****************|\n|  " +
                $"{Grid[2, 0]}  |  {Grid[2, 1]}  |  {Grid[2, 2]}  " +
                $"|\n*******************\n");
        }
    }
}
