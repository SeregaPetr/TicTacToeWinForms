namespace TicTacToeBL
{
    internal class TicTacToeMemento
    {
        public string[] PlayingField { get; private set; } // игровое поле
        public bool IsComputerMove { get; private set; } //чей ход
        public bool IsWinPlayer { get; private set; } // победа игрока
        public bool IsWinComputer { get; private set; } // победа компьютера
        public bool IsDraw { get; private set; } // ничья
        public int ComputerScore { get; private set; } //счет компьютера
        public int PlayerrScore { get; private set; } // счет игрока
        public int Level { get; private set; } // уровень игры

        public TicTacToeMemento(string[] playingField, bool isComputerMove, bool isWinPlayer,
            bool isWinComputer, bool isDraw, int computerScore, int playerrScore, int level)
        {
            this.PlayingField = new string[playingField.Length];
            for (int i = 0; i < PlayingField.Length; i++)
            {
                PlayingField[i] = playingField[i];
            }

            this.IsComputerMove = isComputerMove;
            this.IsWinPlayer = isWinPlayer;
            this.IsWinComputer = isWinComputer;
            this.IsDraw = isDraw;
            this.ComputerScore = computerScore;
            this.PlayerrScore = playerrScore;
            this.Level = level;
        }
    }
}
