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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }
        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (Clients clients in Program.usDb.Clients)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        clients.Id.ToString(), clients.FirstName, clients.LastName, clients.Sex, clients.Age.ToString(), clients.Orders.ToString()
                    });
                item.Tag = clients;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.FirstName = textBoxFirstName.Text;
            clients.LastName = textBoxLastName.Text;
            if (radioButtonSex1.Checked == true)
            {
                clients.Sex = radioButtonSex1.Text;
            }
            else if (radioButtonSex2.Checked == true)
            {
                clients.Sex = radioButtonSex2.Text;
            }
            clients.Age = Convert.ToInt32(textBoxAge.Text);
            if (textBoxOrder.Text == "")
            {
                clients.Orders = 0;
            }
            else
            {
                clients.Orders = Convert.ToInt32(textBoxOrder.Text);
            }
            Program.usDb.Clients.Add(clients);
            Program.usDb.SaveChanges();
            ShowClient();

        }



        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                Clients clients = listViewClient.SelectedItems[0].Tag as Clients;
                textBoxFirstName.Text = clients.FirstName;
                textBoxLastName.Text = clients.LastName;
                if (clients.Sex == radioButtonSex1.Text)
                {
                    radioButtonSex1.Checked = true;
                }
                else if (clients.Sex == radioButtonSex2.Text)
                {
                    radioButtonSex2.Checked = true;
                }
                textBoxAge.Text = Convert.ToString(clients.Age);
                textBoxOrder.Text = Convert.ToString(clients.Orders);
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                radioButtonSex1.Checked = false;
                radioButtonSex2.Checked = false;
                textBoxAge.Text = "";
                textBoxOrder.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                Clients clients = listViewClient.SelectedItems[0].Tag as Clients;
                clients.FirstName = textBoxFirstName.Text;
                clients.LastName = textBoxLastName.Text;
                if (radioButtonSex1.Checked == true)
                {
                    clients.Sex = radioButtonSex1.Text;
                }
                else if (radioButtonSex2.Checked == true)
                {
                    clients.Sex = radioButtonSex2.Text;
                }
                clients.Age = Convert.ToInt32(textBoxAge.Text);
                if (textBoxOrder.Text == "")
                {
                    clients.Orders = 0;
                }
                else
                {
                    clients.Orders = Convert.ToInt32(textBoxOrder.Text);
                }
                ShowClient();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    Clients clients = listViewClient.SelectedItems[0].Tag as Clients;
                    Program.usDb.Clients.Remove(clients);
                    Program.usDb.SaveChanges();
                    ShowClient();
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    radioButtonSex1.Checked = false;
                    radioButtonSex2.Checked = false;
                    textBoxAge.Text = "";
                    textBoxOrder.Text = "";
                }
                else
                {
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    radioButtonSex1.Checked = false;
                    radioButtonSex2.Checked = false;
                    textBoxAge.Text = "";
                    textBoxOrder.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Клиента нельзя удалить, эта запись используеться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
