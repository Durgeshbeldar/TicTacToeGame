using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame.Exceptions
{
    internal class BoardIsFullException : Exception
    {
        public BoardIsFullException(string message) : base(message) { }
    }
}
