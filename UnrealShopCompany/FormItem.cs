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
    public partial class FormItem : Form
    {
        public string TypeItem;
        public FormItem()
        {
            InitializeComponent();
            ShowItem();
            comboBoxType.SelectedIndex = 0;
            
        }
        void ShowItem()
        {
            listViewClient.Items.Clear();
            foreach (Items item in Program.usDb.Items)
            {
                ListViewItem items = new ListViewItem(new string[]
                    {
                        item.Id.ToString(), item.NameItem, item.Type, item.Info, item.Number.ToString(), item.Price.ToString()
                    });
                items.Tag = item;
                listViewClient.Items.Add(items);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.NameItem = textBoxNameItem.Text;
            items.Type = comboBoxType.Text;
            items.Info = textBoxInfo.Text;
            items.Number = Convert.ToInt32(textBoxNumber.Text);
            items.Price = Convert.ToDouble(textBoxPrice.Text);
            Program.usDb.Items.Add(items);
            Program.usDb.SaveChanges();
            ShowItem();
            textBoxNameItem.Text = "";
            comboBoxType.SelectedItem = null;
            textBoxInfo.Text = "";
            textBoxNumber.Text = "";
            textBoxPrice.Text = "";
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                Items items = listViewClient.SelectedItems[0].Tag as Items;
                items.NameItem = textBoxNameItem.Text;
                items.Type = comboBoxType.Text;
                items.Info = textBoxInfo.Text;
                items.Number = Convert.ToInt32(textBoxNumber.Text);
                items.Price = Convert.ToDouble(textBoxPrice.Text);
                Program.usDb.SaveChanges();
                ShowItem();
            }
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                Items items = listViewClient.SelectedItems[0].Tag as Items;
                textBoxNameItem.Text = items.NameItem;
                if (items.Type == "Компьютер/Ноутбук")
                {
                    comboBoxType.SelectedIndex = 0;
                }
                else if (items.Type == "Периферия")
                {
                    comboBoxType.SelectedIndex = 1;
                }
                else if (items.Type == "Комплектующие")
                {
                    comboBoxType.SelectedIndex = 2;
                }
                else
                {
                    comboBoxType.SelectedIndex = 3;
                }
                textBoxInfo.Text = items.Info;
                textBoxNumber.Text = Convert.ToString(items.Number);
                textBoxPrice.Text = Convert.ToString(items.Price);
            }
            else
            {
                textBoxNameItem.Text = "";
                comboBoxType.SelectedItem = null;
                textBoxInfo.Text = "";
                textBoxNumber.Text = "";
                textBoxPrice.Text = "";
            }
            
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    Items items = listViewClient.SelectedItems[0].Tag as Items;
                    Program.usDb.Items.Remove(items);
                    Program.usDb.SaveChanges();
                    ShowItem();
                }
                textBoxNameItem.Text = "";
                comboBoxType.SelectedItem = null;
                textBoxInfo.Text = "";
                textBoxNumber.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, этот товар используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
