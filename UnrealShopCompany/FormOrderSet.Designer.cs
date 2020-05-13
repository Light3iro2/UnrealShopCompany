namespace UnrealShopCompany
{
    partial class FormOrderSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelStaff = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.listViewOrderSet = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxStaff = new System.Windows.Forms.ComboBox();
            this.comboBoxDiscount = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Items.AddRange(new object[] {
            "Компьютер/Ноутбук",
            "Периферия",
            "Комплектующие",
            "Аксессуары"});
            this.comboBoxItem.Location = new System.Drawing.Point(80, 121);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(166, 24);
            this.comboBoxItem.TabIndex = 60;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiscount.Location = new System.Drawing.Point(23, 206);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(57, 16);
            this.labelDiscount.TabIndex = 58;
            this.labelDiscount.Text = "Скидка:";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonDel.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDel.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(608, 243);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(180, 40);
            this.buttonDel.TabIndex = 57;
            this.buttonDel.Text = "Удалить товар";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(422, 243);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(180, 40);
            this.buttonEdit.TabIndex = 56;
            this.buttonEdit.Text = "Изменить информацию";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(65, 243);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(180, 40);
            this.buttonAdd.TabIndex = 55;
            this.buttonAdd.Text = "Добавить товар";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumber.Location = new System.Drawing.Point(79, 176);
            this.textBoxNumber.Multiline = true;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(166, 24);
            this.textBoxNumber.TabIndex = 54;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(23, 179);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(57, 16);
            this.labelNumber.TabIndex = 53;
            this.labelNumber.Text = "Кол-во:";
            // 
            // labelStaff
            // 
            this.labelStaff.AutoSize = true;
            this.labelStaff.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStaff.Location = new System.Drawing.Point(9, 152);
            this.labelStaff.Name = "labelStaff";
            this.labelStaff.Size = new System.Drawing.Size(71, 16);
            this.labelStaff.TabIndex = 51;
            this.labelStaff.Text = "Работник:";
            this.labelStaff.Click += new System.EventHandler(this.labelInfo_Click);
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItem.Location = new System.Drawing.Point(30, 124);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(50, 16);
            this.labelItem.TabIndex = 50;
            this.labelItem.Text = "Товар:";
            this.labelItem.Click += new System.EventHandler(this.labelType_Click);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClient.Location = new System.Drawing.Point(23, 97);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(57, 16);
            this.labelClient.TabIndex = 48;
            this.labelClient.Text = "Клиент:";
            this.labelClient.Click += new System.EventHandler(this.labelClient_Click);
            // 
            // listViewOrderSet
            // 
            this.listViewOrderSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewOrderSet.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewOrderSet.FullRowSelect = true;
            this.listViewOrderSet.GridLines = true;
            this.listViewOrderSet.HideSelection = false;
            this.listViewOrderSet.Location = new System.Drawing.Point(273, 12);
            this.listViewOrderSet.MultiSelect = false;
            this.listViewOrderSet.Name = "listViewOrderSet";
            this.listViewOrderSet.Size = new System.Drawing.Size(515, 225);
            this.listViewOrderSet.TabIndex = 46;
            this.listViewOrderSet.UseCompatibleStateImageBehavior = false;
            this.listViewOrderSet.View = System.Windows.Forms.View.Details;
            this.listViewOrderSet.SelectedIndexChanged += new System.EventHandler(this.listViewOrderSet_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя клиента";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Товар";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Работник";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Кол-во";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Скидка";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Итог";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UnrealShopCompany.Properties.Resources.logoza1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(80, 94);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(166, 24);
            this.comboBoxClient.TabIndex = 61;
            this.comboBoxClient.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxStaff
            // 
            this.comboBoxStaff.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStaff.FormattingEnabled = true;
            this.comboBoxStaff.Items.AddRange(new object[] {
            "Компьютер/Ноутбук",
            "Периферия",
            "Комплектующие",
            "Аксессуары"});
            this.comboBoxStaff.Location = new System.Drawing.Point(80, 149);
            this.comboBoxStaff.Name = "comboBoxStaff";
            this.comboBoxStaff.Size = new System.Drawing.Size(166, 24);
            this.comboBoxStaff.TabIndex = 62;
            this.comboBoxStaff.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBoxDiscount
            // 
            this.comboBoxDiscount.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDiscount.FormattingEnabled = true;
            this.comboBoxDiscount.Items.AddRange(new object[] {
            "Нет скидки",
            "Скидка 5%",
            "Скидка 10%",
            "Скидка 15%"});
            this.comboBoxDiscount.Location = new System.Drawing.Point(79, 203);
            this.comboBoxDiscount.Name = "comboBoxDiscount";
            this.comboBoxDiscount.Size = new System.Drawing.Size(166, 24);
            this.comboBoxDiscount.TabIndex = 63;
            // 
            // FormOrderSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(800, 295);
            this.Controls.Add(this.comboBoxDiscount);
            this.Controls.Add(this.comboBoxStaff);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelStaff);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewOrderSet);
            this.Name = "FormOrderSet";
            this.Text = "Составить заказ";
            this.Load += new System.EventHandler(this.FormOrderSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelStaff;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewOrderSet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxStaff;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox comboBoxDiscount;
    }
}