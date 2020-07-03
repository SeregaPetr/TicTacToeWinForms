using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeBL
{
    public class GameTicTacToe
    {
        public string[] PlayingField { get; private set; } // игровое поле
        public bool IsComputerMove { get; private set; } //чей ход
        public bool IsWinPlayer { get; private set; } // победа игрока
        public bool IsWinComputer { get; private set; } // победа компьютера
        public bool IsDraw { get; private set; } // ничья
        public int ComputerScore { get; private set; } //счет компьютера
        public int PlayerScore { get; private set; } // счет игрока
        public int Level // уровень игры
        {
            get { return _level; }
            set
            {
                if (value < 1) { _level = 1; }
                else if (value > 3) { _level = 3; }
                else { _level = value; }
            }
        }
        private int _level;
        private GameHistory _gameHistory;

        //массивы ходов компьютера
        #region ArraysOfMoves

        private int[] _moves; //основной массив ходов

        private int[] _moveCentre = { 4 };
        private int[] _movesCorners = { 0, 2, 8, 6 };
        private int[] _movesSide = { 3, 1, 5, 7 };

        #endregion

        //массив проверок конца игры
        private int[,] _checksEndOfGame = { {0,1,2 },
                                           {3,4,5 },
                                           {6,7,8 },
                                           {0,3,6 },
                                           {1,4,7 },
                                           {2,5,8 },
                                           {0,4,8 },
                                           {2,4,6 } };

        public GameTicTacToe(int level)
        {
            PlayingField = new string[9];
            ComputerScore = 0;
            PlayerScore = 0;
            _moves = new int[9];
            _level = level;

            // NewGame();
        }

        public event EventHandler ComputerMadeMove;

        protected virtual void OnComputerMadeMove(EventArgs e)
        {
            EventHandler handler = ComputerMadeMove;
            handler?.Invoke(this, e);
        }

        public event EventHandler GameOver;

        protected virtual void OnGameOver(EventArgs e)
        {
            EventHandler handler = GameOver;
            handler?.Invoke(this, e);
        }
        //новая игра
        public void NewGame()
        {
            for (int i = 0; i < PlayingField.Length; i++)
            {
                PlayingField[i] = string.Empty;
            }
            IsComputerMove = new Random().Next(0, 2) != 0;
            IsWinPlayer = false;
            IsWinComputer = false;
            IsDraw = false;
            MixingAndCombiningAnArrayOfMoves(_moveCentre, _movesCorners, _movesSide);

            if (_gameHistory == null)
            {
                _gameHistory = new GameHistory();
            }
            _gameHistory.History.Clear();

            ComputerMove();
        }

        //перемешивание и создание массива ходов
        private void MixingAndCombiningAnArrayOfMoves(int[] arr1, int[] arr2, int[] arr3)
        {
            MixingArrayMoves(arr2);
            MixingArrayMoves(arr3);

            _moves = arr1.Concat(arr2).Concat(arr3).ToArray();
        }

        //перемешивание массива ходов
        private void MixingArrayMoves(int[] arr)
        {
            Random random = new Random();
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                if (i != j)
                {
                    var temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }

        //ход компьютера взависимости от выбранного уровня
        private void ComputerMove()
        {
            if (IsComputerMove)
            {
                switch (Level)
                {
                    case 1:
                        Level1(); break;
                    case 2:
                        Level2(); break;
                    case 3:
                        Level3(); break;
                }
                if (!IsWinComputer && !IsWinPlayer)
                {
                    if (DrawCheck())
                    {
                        OnGameOver(EventArgs.Empty);
                    }
                }
            }
        }

        //уровень 1
        private void Level1()
        {
            for (int i = 0; i < _moves.Length; i++)
            {
                if (string.IsNullOrEmpty(PlayingField[_moves[i]]))
                {
                    Move(_moves[i]);
                    break;
                }
            }
        }

        //уровень 2
        private void Level2()
        {
            if (FindingMoveToWin(out int indexWin))
            {
                Move(indexWin);
            }
            else
            {
                Level1();
            }
        }

        //уровень 3
        private void Level3()
        {
            if (FindingMoveToWin(out int indexWin))
            {
                Move(indexWin);
            }
            else
            {
                if (FindingMoveNotToLose(out int indexLose))
                {
                    Move(indexLose);
                }
                else
                {
                    Level1();
                }
            }
        }

        //ход компьютера
        private void Move(int index)
        {
            PlayingField[index] = "C";

            OnComputerMadeMove(EventArgs.Empty);

            if (WinCheck("C"))
            {
                IsWinComputer = true;
                ComputerScore++;

                OnGameOver(EventArgs.Empty);
            }
            else
            {
                IsComputerMove = false;
            }
        }

        //ход игрока
        public void PlayerMove(int index)
        {
            _gameHistory.History.Push(this.SaveState());

            PlayingField[index] = "P";

            if (WinCheck("P"))
            {
                IsWinPlayer = true;
                PlayerScore++;

                OnGameOver(EventArgs.Empty);
            }
            else
            {
                IsComputerMove = true;
                ComputerMove();
            }
        }

        //компьютер ищет поле чтобы не проиграть
        private bool FindingMoveNotToLose(out int indexMove)
        {
            int sum = 0;
            indexMove = -1;

            for (int i = 0; i < _checksEndOfGame.GetLength(0); i++)
            {
                for (int j = 0; j < _checksEndOfGame.GetLength(1); j++)
                {
                    if (PlayingField[_checksEndOfGame[i, j]] == "P")
                        sum++;
                    else
                    {
                        if (PlayingField[_checksEndOfGame[i, j]] == "C")
                            sum--;
                        else
                            indexMove = _checksEndOfGame[i, j];
                    }
                }

                if (sum == 2)
                    return true;
                else
                    sum = 0;
            }
            return false;
        }

        //компьютер ищет поле для выиграша
        private bool FindingMoveToWin(out int indexMove)
        {
            int sum = 0;
            indexMove = -1;

            for (int i = 0; i < _checksEndOfGame.GetLength(0); i++)
            {
                for (int j = 0; j < _checksEndOfGame.GetLength(1); j++)
                {
                    if (PlayingField[_checksEndOfGame[i, j]] == "C")
                    {
                        sum++;
                    }
                    else
                    {
                        if (PlayingField[_checksEndOfGame[i, j]] == "P")
                            sum--;
                        else
                            indexMove = _checksEndOfGame[i, j];
                    }
                }

                if (sum == 2)
                    return true;
                else
                    sum = 0;
            }
            return false;
        }

        //проверка на ничью
        private bool DrawCheck()
        {
            for (int i = 0; i < _moves.Length; i++)
            {
                IsDraw = true;
                if (string.IsNullOrEmpty(PlayingField[i]))
                {
                    IsDraw = false;
                    return false;
                }
            }
            return true;
        }

        // проверка на выигрыш
        private bool WinCheck(string str)
        {
            if (
                (PlayingField[0] == str && PlayingField[1] == str && PlayingField[2] == str) ||
                (PlayingField[3] == str && PlayingField[4] == str && PlayingField[5] == str) ||
                (PlayingField[6] == str && PlayingField[7] == str && PlayingField[8] == str) ||
                (PlayingField[0] == str && PlayingField[3] == str && PlayingField[6] == str) ||
                (PlayingField[1] == str && PlayingField[4] == str && PlayingField[7] == str) ||
                (PlayingField[2] == str && PlayingField[5] == str && PlayingField[8] == str) ||
                (PlayingField[0] == str && PlayingField[4] == str && PlayingField[8] == str) ||
                (PlayingField[2] == str && PlayingField[4] == str && PlayingField[6] == str)
                )
                return true;
            return false;
        }

        // сохранение состояния
        private TicTacToeMemento SaveState()
        {
            return new TicTacToeMemento(PlayingField, IsComputerMove, IsWinPlayer, IsWinComputer,
            IsDraw, ComputerScore, PlayerScore, Level);
        }

        // восстановление состояния
        private void RestoreState(TicTacToeMemento memento)
        {
            this.PlayingField = memento.PlayingField;
            this.IsComputerMove = memento.IsComputerMove;
            this.IsWinPlayer = memento.IsWinPlayer;
            this.IsWinComputer = memento.IsWinComputer;
            this.IsDraw = memento.IsDraw;
            this.ComputerScore = memento.ComputerScore;
            this.PlayerScore = memento.PlayerrScore;
            this.Level = memento.Level;
        }

        //ход назад
        public void MoveBack()
        {
            if (_gameHistory.History.Count > 0)
            {
                RestoreState(_gameHistory.History.Pop());
            }
        }
    }
}

