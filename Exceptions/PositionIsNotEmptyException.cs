using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame.Exceptions
{
    internal class PositionIsNotEmptyException : Exception
    {
        public PositionIsNotEmptyException(string message):base(message) { }
    }
}
