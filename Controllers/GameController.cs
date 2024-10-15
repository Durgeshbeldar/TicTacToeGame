using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame.Exceptions;
using TicTacToeGame.Models;

namespace TicTacToeGame.Controllers
{
    internal class GameController
    {
        public Board Board { get; set; }
        public bool IsGameOver { get; set; }

        public GameController()
        {
            Board = new Board();
            IsGameOver = false;
        }

        public string PlayTurn(int selectedPosition, Player player)
        {
            try
            {
                if (Board.IsBoardFull())
                {
                    IsGameOver = true;
                    throw new BoardIsFullException("\nThe Board is already Full You Cant Place Your Move :(");
                }

                Board.UpdateBoardPosition(selectedPosition,player.Symbol);

                // Checking Player is Won or Not...?

                if (IsWin(player.Symbol))
                {
                    IsGameOver = true;
                    return $"\nCongratulations... {player.PlayerName}, You Won the Game...! :)\n";
                }

                // Here  We are checking that Game is weather Draw Or Not...?

                if (Board.IsBoardFull())
                {
                    IsGameOver = true;
                    return "\n The Game is Draw...! Try Again and Congrats to Both Players\n";
                }
                return $"\n{player.PlayerName} is Placed Sign {player.Symbol} on Selected Position Successfully\n";

            }catch(BoardIsFullException ex)
            {
                return ex.Message;
            }
        }
        public bool IsWin(char symbol)
        {
            char[,]grid = Board.Grid;

            
            for (int i = 0; i < 3; i++)
            {
                // Row Checking...

                if (grid[i, 0] == symbol && grid[i, 1] == symbol && grid[i, 2] == symbol)
                    return true;

                // Column Checking...
                if (grid[0, i] == symbol && grid[1, i] == symbol && grid[2, i] == symbol)
                    return true;
            }

            // Check For Diagonals...

            if (grid[0, 0] == symbol && grid[1, 1] == symbol && grid[2, 2] == symbol)
                return true;

            if (grid[0, 2] == symbol && grid[1, 1] == symbol && grid[2, 0] == symbol)
                return true;

            return false;

        }
        public char[,] GetBoard() 
        { 
            return Board.Grid; 
        }



    }
}
