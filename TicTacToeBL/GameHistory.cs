using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeBL
{
    internal class GameHistory
    {
        public Stack<TicTacToeMemento> History { get; private set; }

        public GameHistory()
        {
            History = new Stack<TicTacToeMemento>();
        }
    }
}
