using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnrealShopCompany
{
    public struct UserAccount
    {
        public string login;
        public string password;
        public string TypeAccount;
    }
    public partial class FormWelcome : Form
    {
        string TypeAccount;
        public static UserAccount users = new UserAccount();
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormWelcome_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "" && (radioButtonType1.Checked == false || radioButtonType2.Checked == false))
            {
                MessageBox.Show("Вы не ввели данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool accountdone = false;
                foreach (Users user in Program.usDb.Users)
                {
                    if (textBoxLogin.Text == user.NameUser && textBoxPassword.Text == user.Password && TypeAccount == user.TypeAccount)
                    {
                        accountdone = true;
                        users.login = user.NameUser;
                        users.password = user.Password;
                        users.TypeAccount = user.TypeAccount;
                    }
                }
                if (!accountdone)
                {
                    MessageBox.Show("Вы указали не верные данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    radioButtonType1.Checked = false;
                    radioButtonType2.Checked = false;
                }
                else
                {
                    MessageBox.Show("Данные введены верно", "Добро пожаловать", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMenu menu = new FormMenu();
                    menu.Show();
                    this.Hide();
                }
            }
        }

        private void radioButtonType1_CheckedChanged(object sender, EventArgs e)
        {
            TypeAccount = "staff";
        }

        private void radioButtonType2_CheckedChanged(object sender, EventArgs e)
        {
            TypeAccount = "admin";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
