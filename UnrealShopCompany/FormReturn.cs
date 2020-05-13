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
    public partial class FormReturn : Form
    {
        public FormReturn()
        {
            InitializeComponent();
            ShowOrder();
            ShowReturnSet();
            ShowStaff();
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
        void ShowOrderNumber()
        {
            if (comboBoxOrder.SelectedItem != null)
            {
                OrderSet orderSet = Program.usDb.OrderSet.Find(Convert.ToInt32(comboBoxOrder.SelectedItem.ToString().Split('.')[0]));
                textBoxNumber.Text = orderSet.Number.ToString();
            }
            else
            {
                textBoxNumber.Text = "";
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
            ShowOrderNumber();
            ShowStaff();
        }
        void ShowReturnSet()
        {

            listViewReturn.Items.Clear();
            foreach (Return returnSet in Program.usDb.Return)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                    returnSet.Id.ToString(),returnSet.OrderSet.Items.NameItem.ToString() , returnSet.OrderSet.Clients.LastName + " " + returnSet.OrderSet.Clients.FirstName,
                    returnSet.OrderSet.Users.NameUser, returnSet.NumberReturn.ToString(), returnSet.Status.ToString()
                    });
                item.Tag = returnSet;
                listViewReturn.Items.Add(item);
                listViewReturn.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            foreach (Return returnstatus in Program.usDb.Return)
            {
                if (returnstatus.Status == "Одобрен")
                {
                    int number;
                    number = returnstatus.OrderSet.Items.Number;
                    number += returnstatus.NumberReturn;
                    returnstatus.OrderSet.Items.Number = number;
                }
            }
            Program.usDb.SaveChanges();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxOrder.SelectedItem != null && radioButtonOk.Checked == true)
            {
                OrderSet orderInfo = Program.usDb.OrderSet.Find(Convert.ToInt32(comboBoxOrder.SelectedItem.ToString().Split('.')[0]));
                Return returnSet = new Return();
                returnSet.IdOrder = Convert.ToInt32(comboBoxOrder.SelectedItem.ToString().Split('.')[0]);
                returnSet.NumberReturn = Convert.ToInt32(textBoxNumber.Text);
                returnSet.StaffName = orderInfo.Users.Id;
                returnSet.Status = comboBoxStatus.Text;
                Program.usDb.Return.Add(returnSet);
                Program.usDb.SaveChanges();
                ShowReturnSet();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewReturn.SelectedItems.Count == 1)
            {
                OrderSet orderInfo = Program.usDb.OrderSet.Find(Convert.ToInt32(comboBoxOrder.SelectedItem.ToString().Split('.')[0]));
                Return returnedit = listViewReturn.SelectedItems[0].Tag as Return;
                returnedit.IdOrder = Convert.ToInt32(comboBoxOrder.SelectedItem.ToString().Split('.')[0]);
                returnedit.NumberReturn = Convert.ToInt32(textBoxNumber.Text);
                returnedit.StaffName = orderInfo.Users.Id;
                returnedit.Status = comboBoxStatus.Text;
                Program.usDb.SaveChanges();
                ShowReturnSet();
            }
        }

        private void listViewReturn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewReturn.SelectedItems.Count == 1)
            {
                Return returns = listViewReturn.SelectedItems[0].Tag as Return;
                comboBoxOrder.SelectedIndex = comboBoxOrder.FindString(returns.IdOrder.ToString());
                textBoxNumber.Text = Convert.ToString(returns.NumberReturn);
                comboBoxStatus.Text = returns.Status;
                textBoxStaff.Text = returns.OrderSet.Users.NameUser;
                radioButtonOk.Checked = true;
            }
            else
            {
                comboBoxOrder.SelectedItem = null;
                comboBoxStatus.SelectedItem = null;
                radioButtonOk.Checked = false;
                textBoxNumber.Text = "";
                textBoxStaff.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewReturn.SelectedItems.Count == 1)
                {
                    Return returndel = listViewReturn.SelectedItems[0].Tag as Return;
                    Program.usDb.Return.Remove(returndel);
                    Program.usDb.SaveChanges();
                    ShowReturnSet();
                }
                comboBoxOrder.SelectedItem = null;
                comboBoxStatus.SelectedItem = null;
                textBoxNumber.Text = "";
                textBoxStaff.Text = "";
                radioButtonOk.Checked = false;
            }
            catch
            {
                MessageBox.Show("Данный возврат невозможно удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
