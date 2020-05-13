namespace UnrealShopCompany
{
    partial class FormDeal
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
            this.textBoxStaff = new System.Windows.Forms.TextBox();
            this.radioButtonOk = new System.Windows.Forms.RadioButton();
            this.comboBoxOrder = new System.Windows.Forms.ComboBox();
            this.labelOk = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.labelStaff = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewListOrder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPremium = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStaff
            // 
            this.textBoxStaff.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStaff.Location = new System.Drawing.Point(80, 142);
            this.textBoxStaff.Multiline = true;
            this.textBoxStaff.Name = "textBoxStaff";
            this.textBoxStaff.Size = new System.Drawing.Size(166, 24);
            this.textBoxStaff.TabIndex = 95;
            // 
            // radioButtonOk
            // 
            this.radioButtonOk.AutoSize = true;
            this.radioButtonOk.Location = new System.Drawing.Point(80, 201);
            this.radioButtonOk.Name = "radioButtonOk";
            this.radioButtonOk.Size = new System.Drawing.Size(40, 17);
            this.radioButtonOk.TabIndex = 94;
            this.radioButtonOk.TabStop = true;
            this.radioButtonOk.Text = "Да";
            this.radioButtonOk.UseVisualStyleBackColor = true;
            // 
            // comboBoxOrder
            // 
            this.comboBoxOrder.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxOrder.FormattingEnabled = true;
            this.comboBoxOrder.Location = new System.Drawing.Point(80, 90);
            this.comboBoxOrder.Name = "comboBoxOrder";
            this.comboBoxOrder.Size = new System.Drawing.Size(166, 22);
            this.comboBoxOrder.TabIndex = 92;
            this.comboBoxOrder.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrder_SelectedIndexChanged);
            // 
            // labelOk
            // 
            this.labelOk.AutoSize = true;
            this.labelOk.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOk.Location = new System.Drawing.Point(18, 202);
            this.labelOk.Name = "labelOk";
            this.labelOk.Size = new System.Drawing.Size(64, 16);
            this.labelOk.TabIndex = 91;
            this.labelOk.Text = "Получен:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(66, 230);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(5);
            this.buttonAdd.Size = new System.Drawing.Size(180, 40);
            this.buttonAdd.TabIndex = 88;
            this.buttonAdd.Text = "Добавить в список";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxClient
            // 
            this.textBoxClient.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClient.Location = new System.Drawing.Point(80, 115);
            this.textBoxClient.Multiline = true;
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(166, 24);
            this.textBoxClient.TabIndex = 87;
            // 
            // labelStaff
            // 
            this.labelStaff.AutoSize = true;
            this.labelStaff.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStaff.Location = new System.Drawing.Point(11, 147);
            this.labelStaff.Name = "labelStaff";
            this.labelStaff.Size = new System.Drawing.Size(71, 16);
            this.labelStaff.TabIndex = 85;
            this.labelStaff.Text = "Работник:";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClient.Location = new System.Drawing.Point(23, 123);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(57, 16);
            this.labelClient.TabIndex = 84;
            this.labelClient.Text = "Клиент:";
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrder.Location = new System.Drawing.Point(30, 96);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(50, 16);
            this.labelOrder.TabIndex = 83;
            this.labelOrder.Text = "Заказ:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UnrealShopCompany.Properties.Resources.logoza1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // listViewListOrder
            // 
            this.listViewListOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.listViewListOrder.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewListOrder.FullRowSelect = true;
            this.listViewListOrder.GridLines = true;
            this.listViewListOrder.HideSelection = false;
            this.listViewListOrder.Location = new System.Drawing.Point(273, 12);
            this.listViewListOrder.MultiSelect = false;
            this.listViewListOrder.Name = "listViewListOrder";
            this.listViewListOrder.Size = new System.Drawing.Size(515, 212);
            this.listViewListOrder.TabIndex = 81;
            this.listViewListOrder.UseCompatibleStateImageBehavior = false;
            this.listViewListOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Товар";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Клиент";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Работник";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Премия работнику";
            this.columnHeader6.Width = 121;
            // 
            // textBoxPremium
            // 
            this.textBoxPremium.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPremium.Location = new System.Drawing.Point(80, 171);
            this.textBoxPremium.Multiline = true;
            this.textBoxPremium.Name = "textBoxPremium";
            this.textBoxPremium.Size = new System.Drawing.Size(166, 24);
            this.textBoxPremium.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 96;
            this.label1.Text = "Премия:";
            // 
            // FormDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(800, 293);
            this.Controls.Add(this.textBoxPremium);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStaff);
            this.Controls.Add(this.radioButtonOk);
            this.Controls.Add(this.comboBoxOrder);
            this.Controls.Add(this.labelOk);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.labelStaff);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewListOrder);
            this.Name = "FormDeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список заказов";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStaff;
        private System.Windows.Forms.RadioButton radioButtonOk;
        private System.Windows.Forms.ComboBox comboBoxOrder;
        private System.Windows.Forms.Label labelOk;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.Label labelStaff;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewListOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox textBoxPremium;
        private System.Windows.Forms.Label label1;
    }
}