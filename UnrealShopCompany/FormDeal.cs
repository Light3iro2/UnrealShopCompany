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
    public partial class FormDeal : Form
    {
        double premium;
        public FormDeal()
        {
            InitializeComponent();
            ShowOrder();
            ShowNameOrder();
            ShowStaff();
            ShowListOder();
        }
        void ShowOrder()
        {
            comboBoxOrder.Items.Clear();
            foreach (OrderSet order in Program.usDb.OrderSet)
            {
                string[] item = { order.Id.ToString() + ".", order.Items.NameItem.ToString(), "|", order.Clients.LastName };
                comboBoxOrder.Items.Add(string.Join(" ", item));
            }
        }
        void ShowNameOrder()
        {
            if (comboBoxOrder.SelectedItem != null)
            {
                OrderSet orderSet = Program.usDb.OrderSet.Find(Convert.ToInt32(comboBoxOrder.SelectedItem.ToString().Split('.')[0]));
                textBoxClient.Text = orderSet.Clients.LastName + " " + orderSet.Clients.FirstName + ", зак: " + orderSet.Clients.Orders;
            }
            else
            {
                textBoxClient.Text = "";
            }
        }
        void ShowStaff()
        {
            if (comboBoxOrder.SelectedItem != null)
            {
                OrderSet orderSet = Program.usDb.OrderSet.Find(Convert.ToInt32(comboBoxOrder.SelectedItem.ToString().Split('.')[0]));
                textBoxStaff.Text = orderSet.Users.NameUser;
            }
            else
            {
                textBoxStaff.Text = "";
            }
        }

        private void comboBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowNameOrder();
            ShowStaff();
            Premium();
        }
        void Premium()
        {
            double priceorder;
            if (comboBoxOrder.SelectedItem != null)
            {
                OrderSet orderSet = Program.usDb.OrderSet.Find(Convert.ToInt32(comboBoxOrder.SelectedItem.ToString().Split('.')[0]));
                priceorder = Convert.ToDouble(orderSet.Price);
                if (priceorder < 5000)
                {
                    premium = (priceorder / 100) * 1.5;
                }
                else if (priceorder > 5000)
                {
                    premium = (priceorder / 100) * 2.5;
                }
                else if (priceorder > 15000)
                {
                    premium = (priceorder / 100) * 4.5;
                }
                textBoxPremium.Text = premium.ToString();
            }
        }
        void ShowListOder()
        {
            listViewListOrder.Items.Clear();
            foreach (OrderList list in Program.usDb.OrderList)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        list.Id.ToString(), list.Items.ToString(), list.Clients.LastName, list.Staff, list.Premium.ToString(), list.Accept
                    });
                item.Tag = list;
                listViewListOrder.Items.Add(item);
                listViewListOrder.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxOrder.SelectedItem != null && radioButtonOk.Checked == true)
            {
                OrderSet orderInfo = Program.usDb.OrderSet.Find(Convert.ToInt32(comboBoxOrder.SelectedItem.ToString().Split('.')[0]));
                OrderList listSet = new OrderList();
                listSet.IdClients = orderInfo.Clients.Id;
                listSet.Items = comboBoxOrder.Text;
                listSet.Staff = textBoxStaff.Text;
                listSet.Premium = Convert.ToDouble(textBoxPremium.Text);
                listSet.Accept = "Да";
                Program.usDb.OrderList.Add(listSet);
                Program.usDb.SaveChanges();
                ShowListOder();
                comboBoxOrder.SelectedItem = null;
                orderInfo.Clients.Orders += 1;
            }
            else
            {
                MessageBox.Show("Укажите, получил ли клиент товар", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
