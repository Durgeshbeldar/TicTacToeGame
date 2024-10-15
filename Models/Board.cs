using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame.Models
{
    internal class Board
    {
        public char[,] Grid = new char[3, 3];
        public List<int> PositionChecker {  get; set; }     
        static int position = 1;
        static int limit = 3;
        public Board()
        {
            PositionChecker = new List<int>();

            // Initialized an Empty Board...

            for (int i = 0; i < limit; i++)
            {
                for (int j = 0; j < limit; j++)
                {
                    Grid[i, j] = (char) (position + '0');
                    position++;
                }
            }
        }

        public bool IsPositionEmpty(int position)
        {
            position = position - 1;
            int row = (position) / limit;
            int col = (position) % limit;
            if(Grid[row, col] == 'X' || Grid[row,col] == 'O')
                return true;
            return false;
        }

        public bool IsBoardFull()
        {
            if (PositionChecker.Count == 9)
                return true;
            return false;
        }
        public void UpdateBoardPosition(int position, char symbol)
        {
            position = position - 1;
            int row = (position ) / limit;
            int col = (position ) % limit;

            Grid[row, col] = symbol; 
            PositionChecker.Add(position);
        }
        
       
    }
}
