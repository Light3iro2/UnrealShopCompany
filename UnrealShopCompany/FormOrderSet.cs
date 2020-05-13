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
    public partial class FormOrderSet : Form
    {
        string disc;
        public FormOrderSet()
        {
            InitializeComponent();
            ShowClientsSet();
            ShowItemSet();
            ShowStaffSet();
            ShowOrderSet();
        }

        private void labelInfo_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelType_Click(object sender, EventArgs e)
        {

        }

        private void labelClient_Click(object sender, EventArgs e)
        {

        }

        private void FormOrderSet_Load(object sender, EventArgs e)
        {

        }
        void ShowClientsSet()
        {
            comboBoxClient.Items.Clear();
            foreach (Clients clients in Program.usDb.Clients)
            {
                string[] item = {clients.Id.ToString() + ".", clients.LastName, clients.FirstName };
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowItemSet()
        {
            comboBoxItem.Items.Clear();
            foreach (Items items in Program.usDb.Items)
            {
                string[] item = { items.Id.ToString() + ".", items.NameItem };
                comboBoxItem.Items.Add(string.Join(" ", item));
            }
        }
        void ShowStaffSet()
        {
            comboBoxStaff.Items.Clear();
            foreach (Users user in Program.usDb.Users)
            {
                if (user.TypeAccount == "staff")
                {
                    string[] item = { user.Id.ToString() + ".", user.NameUser };
                    comboBoxStaff.Items.Add(string.Join(" ", item));
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double discount;
            if (comboBoxClient.SelectedItem != null && comboBoxItem.SelectedItem != null && textBoxNumber.Text != "")
            {
                OrderSet orderSet = new OrderSet();
                orderSet.IdClients = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                orderSet.IdItems = Convert.ToInt32(comboBoxItem.SelectedItem.ToString().Split('.')[0]);
                orderSet.IdUsers = Convert.ToInt32(comboBoxStaff.SelectedItem.ToString().Split('.')[0]);
                orderSet.Number = Convert.ToInt32(textBoxNumber.Text);
                Items items = Program.usDb.Items.Find(Convert.ToInt32(comboBoxItem.SelectedItem.ToString().Split('.')[0]));
                int number;
                number = items.Number;
                number -= Convert.ToInt32(textBoxNumber.Text);
                items.Number = number;
                if (comboBoxDiscount.SelectedIndex == 0)
                {
                    orderSet.Price = items.Price;
                    disc = "Нет скидки";
                    orderSet.Discount = 0;
                }
                else if (comboBoxDiscount.SelectedIndex == 1)
                {

                    discount = Convert.ToDouble(items.Price) * 0.95;
                    orderSet.Price = discount;
                    disc = "Скидка 5%";
                    orderSet.Discount = 5;
                }
                else if (comboBoxDiscount.SelectedIndex == 2)
                {

                    discount = Convert.ToDouble(items.Price) * 0.9;
                    orderSet.Price = discount;
                    disc = "Скидка 10%";
                    orderSet.Discount = 10;
                }
                else if (comboBoxDiscount.SelectedIndex == 3)
                {

                    discount = Convert.ToDouble(items.Price) * 0.85;
                    orderSet.Price = discount;
                    disc = "Скидка 15%";
                    orderSet.Discount = 15;
                }
                Program.usDb.OrderSet.Add(orderSet);
                Program.usDb.SaveChanges();
                ShowOrderSet();
            }
        }
        void ShowOrderSet()
        {
            listViewOrderSet.Items.Clear();
            foreach (OrderSet orderSet in Program.usDb.OrderSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    orderSet.Id.ToString(),
                    orderSet.Clients.LastName + " " + orderSet.Clients.FirstName,
                    orderSet.Items.NameItem,
                    orderSet.Users.NameUser,
                    orderSet.Number.ToString(),
                    orderSet.Discount.ToString(),
                    orderSet.Price.ToString()
                    
                });
                item.Tag = orderSet;
                listViewOrderSet.Items.Add(item);
            }
            listViewOrderSet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewOrderSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrderSet.SelectedItems.Count == 1)
            {
                OrderSet orderSet = listViewOrderSet.SelectedItems[0].Tag as OrderSet;
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(orderSet.IdClients.ToString());
                comboBoxItem.SelectedIndex = comboBoxItem.FindString(orderSet.IdItems.ToString());
                comboBoxStaff.SelectedIndex = comboBoxStaff.FindString(orderSet.IdUsers.ToString());
                textBoxNumber.Text = Convert.ToString(orderSet.Number);
                if (orderSet.Discount == 0)
                {
                    comboBoxDiscount.SelectedIndex = 0;
                }
                else if (orderSet.Discount == 5)
                {
                    comboBoxDiscount.SelectedIndex = 1;
                }
                else if (orderSet.Discount == 10)
                {
                    comboBoxDiscount.SelectedIndex = 2;
                }
                else if (orderSet.Discount == 15)
                {
                    comboBoxDiscount.SelectedIndex = 3;
                }

            }
            else
            {
                comboBoxClient.SelectedItem = null;
                comboBoxItem.SelectedItem = null;
                comboBoxStaff.SelectedItem = null;
                textBoxNumber.Text = "";
                comboBoxDiscount.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrderSet.SelectedItems.Count == 1)
                {
                    OrderSet orderSet = listViewOrderSet.SelectedItems[0].Tag as OrderSet;
                    Items items = Program.usDb.Items.Find(Convert.ToInt32(comboBoxItem.SelectedItem.ToString().Split('.')[0]));
                    int number;
                    number = items.Number;
                    number += Convert.ToInt32(orderSet.Number);
                    items.Number = number;
                    Program.usDb.OrderSet.Remove(orderSet);
                    Program.usDb.SaveChanges();
                    ShowOrderSet();
                }
                comboBoxClient.SelectedItem = null;
                comboBoxItem.SelectedItem = null;
                comboBoxStaff.SelectedItem = null;
                textBoxNumber.Text = "";
                comboBoxDiscount.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            double discount;
            if (listViewOrderSet.SelectedItems.Count == 1)
            {
                OrderSet orderSet = listViewOrderSet.SelectedItems[0].Tag as OrderSet;
                orderSet.IdClients = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                orderSet.IdItems = Convert.ToInt32(comboBoxItem.SelectedItem.ToString().Split('.')[0]);
                orderSet.IdUsers = Convert.ToInt32(comboBoxStaff.SelectedItem.ToString().Split('.')[0]);
                orderSet.Number = Convert.ToInt32(textBoxNumber.Text);
                Items items = Program.usDb.Items.Find(Convert.ToInt32(comboBoxItem.SelectedItem.ToString().Split('.')[0]));
                int number;
                number = items.Number;
                number += Convert.ToInt32(textBoxNumber.Text);
                items.Number = number;
                if (comboBoxDiscount.SelectedIndex == 0)
                {
                    orderSet.Price = items.Price;
                    disc = "Нет скидки";
                    orderSet.Discount = 0;
                }
                else if (comboBoxDiscount.SelectedIndex == 1)
                {

                    discount = Convert.ToDouble(items.Price) * 0.95;
                    orderSet.Price = discount;
                    disc = "Скидка 5%";
                    orderSet.Discount = 5;
                }
                else if (comboBoxDiscount.SelectedIndex == 2)
                {

                    discount = Convert.ToDouble(items.Price) * 0.9;
                    orderSet.Price = discount;
                    disc = "Скидка 10%";
                    orderSet.Discount = 10;
                }
                else if (comboBoxDiscount.SelectedIndex == 3)
                {

                    discount = Convert.ToDouble(items.Price) * 0.85;
                    orderSet.Price = discount;
                    disc = "Скидка 15%";
                    orderSet.Discount = 15;
                }
                Program.usDb.SaveChanges();
                ShowOrderSet();
            }
        }
    }
}
