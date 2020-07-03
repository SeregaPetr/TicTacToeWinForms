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

namespace TicTacToeWinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private string path = "users.txt";

        private void linkLabelAddUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string user = comboBoxSelectUser.Text;
            if (!string.IsNullOrEmpty(user))
            {
                List<string> listWithItCB = AddUser(user);

                SavingUsers(listWithItCB, path);
            }
        }

        //добавление пользователя
        private List<string> AddUser(string user)
        {
            List<string> listWithItCB = comboBoxSelectUser.Items.Cast<string>().ToList();

            if (!listWithItCB.Contains(user))
            {
                listWithItCB.Add(comboBoxSelectUser.Text);
                listWithItCB.Sort();
            }
            else
            {
                MessageBox.Show("Имя пользователя уже существует!!!");
            }

            comboBoxSelectUser.Items.Clear();
            comboBoxSelectUser.Items.AddRange(listWithItCB.ToArray());
            return listWithItCB;
        }

        //сохранение пользователей
        private static void SavingUsers(List<string> listWithItCB, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < listWithItCB.Count; i++)
                {
                    sw.WriteLine(listWithItCB[i]);
                }
            }
        }
    }
}
