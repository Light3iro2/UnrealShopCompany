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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            labelInfo.Text = "Вы авторизовались как: " + FormWelcome.users.login + "."
            + "\n Вы имеете статус: " + FormWelcome.users.TypeAccount + "."
            + "\n Время сейчас: " + DateTime.Now;
        }

        private void labelInfo_Click(object sender, EventArgs e)
        {
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            FormClient form = new FormClient();
            form.Show();
        }

        private void buttonItem_Click(object sender, EventArgs e)
        {
            FormItem form = new FormItem();
            form.Show();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            FormOrderSet form = new FormOrderSet();
            form.Show();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            FormReturn form = new FormReturn();
            form.Show();
        }

        private void buttonDeal_Click(object sender, EventArgs e)
        {
            FormDeal form = new FormDeal();
            form.Show();
        }
    }
}
