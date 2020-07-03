using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeBL;

namespace TicTacToeWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string computerMark;
        private string playerMark;
        private string playerName;
        private Button[] buttons;
        private readonly string path = "users.txt";
        private int level;
        private GameTicTacToe game;

        private void MainForm_Load(object sender, EventArgs e)
        {
            PreparationForTheStartOfTheGame();
        }

        //подготовка к старту игры
        private void PreparationForTheStartOfTheGame()
        {
            this.Hide();

            LoginForm loginForm = UserUpload(path);

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                LevelSetting(loginForm);
                playerName = loginForm.comboBoxSelectUser.Text;
                buttons = new Button[] { button0, button1, button2, button3,
                                button4, button5, button6, button7, button8};

                bool isZero = loginForm.radioButtonZero.Checked;
                DetermineWhoPlaysWhat(isZero);

                game = new GameTicTacToe(level);
                game.ComputerMadeMove += Game_ComputerMadeMove;
                game.GameOver += Game_GameOver;
                LoadingSelectedData();

                loginForm.Close();
                this.Show();

                NewGame();
            }
            else
                Application.Exit();
        }

        private void Game_GameOver(object sender, EventArgs e)
        {
            LoadingSelectedData();
            if (game.IsDraw)
            {
                GameMessage("\t       Ничья!!!");
            }
            else if (game.IsWinComputer)
            {
                GameMessage("\tВыиграл компьютер!!!");
            }
            else if (game.IsWinPlayer)
            {
                GameMessage($"\tВыиграл(а) {playerName}!!!");
            }
        }

        private void Game_ComputerMadeMove(object sender, EventArgs e)
        {
            for (int i = 0; i < game.PlayingField.Length; i++)
            {
                if (string.IsNullOrEmpty(buttons[i].Text) && game.PlayingField[i] == "C")
                {
                    buttons[i].Text = computerMark;
                    break;
                }
            }
        }

        //установка уровня
        private void LevelSetting(LoginForm loginForm)
        {
            if (loginForm.radioButtonLevel1.Checked)
            {
                level = 1;
            }
            else
            {
                if (loginForm.radioButtonLevel2.Checked)
                {
                    level = 2;
                }
                else
                {
                    level = 3;
                }
            }
        }

        //загрузка списка пользователей
        private static LoginForm UserUpload(string path)
        {
            LoginForm loginForm = new LoginForm();
            List<string> users = new List<string>();

            using (StreamReader sr = new StreamReader(path))
            {
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    users.Add(str);
                }
            }

            loginForm.comboBoxSelectUser.Items.Clear();
            loginForm.comboBoxSelectUser.Items.AddRange(users.ToArray());
            loginForm.comboBoxSelectUser.Text = "Аноним";
            return loginForm;
        }

        //определяем кто чем играет
        private void DetermineWhoPlaysWhat(bool isZero)
        {
            playerMark = isZero ? "O" : "X";
            computerMark = isZero ? "X" : "O";
        }

        //загрузка выбранных данных в status strip
        private void LoadingSelectedData()
        {
            StLbLevel.Text = $"Уровень {level}";
            StLbComputer.Text = $"{game.ComputerScore}   Компьютер ({computerMark})";
            StLbPlayer.Text = $"{playerName} ({playerMark})   {game.PlayerScore}";
        }

        //ходит игрок
        private void PlayerMove(object sender)
        {
            if (!game.IsComputerMove && sender is Button button && string.IsNullOrEmpty(button.Text))
            {
                button.Text = playerMark;

                game.PlayerMove(Convert.ToInt32(button.Tag));
            }
        }

        // сообщение о результате игры
        private void GameMessage(string message)
        {
            if (MessageBox.Show(message
                  + Environment.NewLine
                  + Environment.NewLine
                  + Environment.NewLine + "\t   Сыграем еще?",
                  "Результат игры",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                NewGame();
            }
        }

        //очистка поля
        private void FieldCleaning()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = string.Empty;
            }
        }

        //смена пользователя
        private void UserChange()
        {
            FieldCleaning();
            PreparationForTheStartOfTheGame();
        }

        // новая игра
        private void NewGame()
        {
            FieldCleaning();
            game.NewGame();
        }

        //смена уровня
        private void LevelChange(int lev)
        {
            level = lev;
            game.Level = lev;
            LoadingSelectedData();
        }

        private void MenuItemChangeUser_Click(object sender, EventArgs e)
        {
            UserChange();
        }

        private void MenuItemNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button_Click(object sender, EventArgs e)
        {
            PlayerMove(sender);
        }

        private void MenuItemLevel_Click(object sender, EventArgs e)
        {
            LevelChange(Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
        }

        //сообщение о программе
        private void MenuItemAboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program: v3.0" +
                 Environment.NewLine +
                 "Developer: Petrenro",
                 "О программе");
        }

        //сообщение информация
        private void menuItemInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа имеет 3 уровня сложности." +
                   Environment.NewLine +
                  "Возможность выбора и создания нового пользователя." +
                   Environment.NewLine +
                  "Добавление нового пользователя в общий список." +
                   Environment.NewLine +
                  "Возможность выбора и изменения уровня во время игры." +
                   Environment.NewLine +
                  "Ведется подсчет выиграшей.",
                  "Информация");
        }

        //ход назад
        private void moveBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.MoveBack();
            DrawPlayingField();
        }

        //отрисовка поля при ходе назад
        private void DrawPlayingField()
        {
            for (int i = 0; i < game.PlayingField.Length; i++)
            {
                buttons[i].Text = "";

                if (game.PlayingField[i] == "C")
                {
                    buttons[i].Text = computerMark;
                }
                else if (game.PlayingField[i] == "P")
                {
                    buttons[i].Text = playerMark;
                }
            }
        }
    }
}

