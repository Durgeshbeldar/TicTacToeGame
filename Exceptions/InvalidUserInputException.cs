﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame.Exceptions
{
    internal class InvalidUserInputException : Exception
    {
        public InvalidUserInputException(string message) : base(message) { }
    }
}
