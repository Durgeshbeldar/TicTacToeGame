using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame.Models
{
    internal class Player
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public char Symbol { get; set; }

        // Player Constructor
        public Player(int id,string name, char symbol)
        {
            Id = id;
            PlayerName = name;
            Symbol = symbol;
        }

        // Overriden version of ToString Method To Print Player Info.
        public override string ToString()
        {
            return $"Player{Id} Name : {PlayerName}\n" +
                $"Player Sign : {Symbol}\n";
        }
    }
}
