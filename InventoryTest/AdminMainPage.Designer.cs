namespace InventoryTest
{
    partial class AdminMainPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            logbox = new GroupBox();
            stocks = new GroupBox();
            tableLayoutPanel_StocksWithQuantity = new TableLayoutPanel();
            StockItem1 = new TextBox();
            StockItem2 = new TextBox();
            StockItem3 = new TextBox();
            StockItem4 = new TextBox();
            StockItem5 = new TextBox();
            StockItem6 = new TextBox();
            StockItem7 = new TextBox();
            Quantity1 = new TextBox();
            Quantity2 = new TextBox();
            Quantity3 = new TextBox();
            Quantity4 = new TextBox();
            Quantity5 = new TextBox();
            Quantity6 = new TextBox();
            Quantity7 = new TextBox();
            usermanagement = new GroupBox();
            changeuser1 = new TextBox();
            label2 = new Label();
            changepassword2 = new TextBox();
            changeuser2 = new TextBox();
            changepassword1 = new TextBox();
            LogoutButton = new Button();
            label1 = new Label();
            stocks.SuspendLayout();
            tableLayoutPanel_StocksWithQuantity.SuspendLayout();
            usermanagement.SuspendLayout();
            SuspendLayout();
            // 
            // logbox
            // 
            logbox.BackColor = Color.FromArgb(224, 224, 224);
            logbox.FlatStyle = FlatStyle.Flat;
            logbox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            logbox.Location = new Point(12, 12);
            logbox.Name = "logbox";
            logbox.Size = new Size(200, 271);
            logbox.TabIndex = 0;
            logbox.TabStop = false;
            logbox.Text = "Transaction Log";
            // 
            // stocks
            // 
            stocks.BackColor = Color.FromArgb(224, 224, 224);
            stocks.Controls.Add(tableLayoutPanel_StocksWithQuantity);
            stocks.FlatStyle = FlatStyle.Flat;
            stocks.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            stocks.Location = new Point(218, 12);
            stocks.Name = "stocks";
            stocks.Size = new Size(558, 271);
            stocks.TabIndex = 1;
            stocks.TabStop = false;
            stocks.Text = "Stocks Available                                        Quantity";
            // 
            // tableLayoutPanel_StocksWithQuantity
            // 
            tableLayoutPanel_StocksWithQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel_StocksWithQuantity.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel_StocksWithQuantity.ColumnCount = 2;
            tableLayoutPanel_StocksWithQuantity.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_StocksWithQuantity.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_StocksWithQuantity.Controls.Add(StockItem1, 0, 0);
            tableLayoutPanel_StocksWithQuantity.Controls.Add(StockItem2, 0, 1);
            tableLayoutPanel_StocksWithQuantity.Controls.Add(StockItem3, 0, 2);
            tableLayoutPanel_StocksWithQuantity.Controls.Add(StockItem4, 0, 3);
            tableLayoutPanel_StocksWithQuantity.Controls.Add(StockItem5, 0, 4);
            tableLayoutPanel_StocksWithQuantity.Controls.Add(StockItem6, 0, 5);
            tableLayoutPanel_StocksWithQuantity.Controls.Add(StockItem7, 0, 6);
            tableLayoutPanel_StocksWithQuantity.Controls.Add(Quantity1, 1, 0);
            tableLayoutPanel_StocksWithQuantity.Controls.Add(Quantity2, 1, 1);
            tableLayoutPanel_StocksWithQuantity.Controls.Add(Quantity3, 1, 2);
            tableLayoutPanel_StocksWithQuantity.Controls.Add(Quantity4, 1, 3);
            tableLayoutPanel_StocksWithQuantity.Controls.Add(Quantity5, 1, 4);
            tableLayoutPanel_StocksWithQuantity.Controls.Add(Quantity6, 1, 5);
            tableLayoutPanel_StocksWithQuantity.Controls.Add(Quantity7, 1, 6);
            tableLayoutPanel_StocksWithQuantity.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel_StocksWithQuantity.Location = new Point(6, 26);
            tableLayoutPanel_StocksWithQuantity.Name = "tableLayoutPanel_StocksWithQuantity";
            tableLayoutPanel_StocksWithQuantity.RowCount = 7;
            tableLayoutPanel_StocksWithQuantity.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_StocksWithQuantity.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_StocksWithQuantity.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_StocksWithQuantity.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_StocksWithQuantity.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_StocksWithQuantity.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_StocksWithQuantity.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_StocksWithQuantity.Size = new Size(407, 239);
            tableLayoutPanel_StocksWithQuantity.TabIndex = 0;
            // 
            // StockItem1
            // 
            StockItem1.BackColor = Color.Gainsboro;
            StockItem1.BorderStyle = BorderStyle.None;
            StockItem1.Location = new Point(3, 3);
            StockItem1.Name = "StockItem1";
            StockItem1.Size = new Size(197, 20);
            StockItem1.TabIndex = 0;
            // 
            // StockItem2
            // 
            StockItem2.BackColor = Color.Gainsboro;
            StockItem2.BorderStyle = BorderStyle.None;
            StockItem2.Location = new Point(3, 37);
            StockItem2.Name = "StockItem2";
            StockItem2.Size = new Size(197, 20);
            StockItem2.TabIndex = 1;
            // 
            // StockItem3
            // 
            StockItem3.BackColor = Color.Gainsboro;
            StockItem3.BorderStyle = BorderStyle.None;
            StockItem3.Location = new Point(3, 71);
            StockItem3.Name = "StockItem3";
            StockItem3.Size = new Size(197, 20);
            StockItem3.TabIndex = 2;
            // 
            // StockItem4
            // 
            StockItem4.BackColor = Color.Gainsboro;
            StockItem4.BorderStyle = BorderStyle.None;
            StockItem4.Location = new Point(3, 105);
            StockItem4.Name = "StockItem4";
            StockItem4.Size = new Size(197, 20);
            StockItem4.TabIndex = 3;
            // 
            // StockItem5
            // 
            StockItem5.BackColor = Color.Gainsboro;
            StockItem5.BorderStyle = BorderStyle.None;
            StockItem5.Location = new Point(3, 139);
            StockItem5.Name = "StockItem5";
            StockItem5.Size = new Size(197, 20);
            StockItem5.TabIndex = 4;
            // 
            // StockItem6
            // 
            StockItem6.BackColor = Color.Gainsboro;
            StockItem6.BorderStyle = BorderStyle.None;
            StockItem6.Location = new Point(3, 173);
            StockItem6.Name = "StockItem6";
            StockItem6.Size = new Size(197, 20);
            StockItem6.TabIndex = 5;
            // 
            // StockItem7
            // 
            StockItem7.BackColor = Color.Gainsboro;
            StockItem7.BorderStyle = BorderStyle.None;
            StockItem7.Location = new Point(3, 207);
            StockItem7.Name = "StockItem7";
            StockItem7.Size = new Size(197, 20);
            StockItem7.TabIndex = 6;
            // 
            // Quantity1
            // 
            Quantity1.BackColor = Color.Gainsboro;
            Quantity1.BorderStyle = BorderStyle.None;
            Quantity1.Location = new Point(206, 3);
            Quantity1.Name = "Quantity1";
            Quantity1.Size = new Size(197, 20);
            Quantity1.TabIndex = 7;
            Quantity1.TextChanged += new EventHandler(QuantityTextBox_TextChanged);
            // 
            // Quantity2
            // 
            Quantity2.BackColor = Color.Gainsboro;
            Quantity2.BorderStyle = BorderStyle.None;
            Quantity2.Location = new Point(206, 37);
            Quantity2.Name = "Quantity2";
            Quantity2.Size = new Size(197, 20);
            Quantity2.TabIndex = 8;
            Quantity2.TextChanged += new EventHandler(QuantityTextBox_TextChanged);
            // 
            // Quantity3
            // 
            Quantity3.BackColor = Color.Gainsboro;
            Quantity3.BorderStyle = BorderStyle.None;
            Quantity3.Location = new Point(206, 71);
            Quantity3.Name = "Quantity3";
            Quantity3.Size = new Size(197, 20);
            Quantity3.TabIndex = 9;
            Quantity3.TextChanged += new EventHandler(QuantityTextBox_TextChanged);
            // 
            // Quantity4
            // 
            Quantity4.BackColor = Color.Gainsboro;
            Quantity4.BorderStyle = BorderStyle.None;
            Quantity4.Location = new Point(206, 105);
            Quantity4.Name = "Quantity4";
            Quantity4.Size = new Size(197, 20);
            Quantity4.TabIndex = 10;
            Quantity4.TextChanged += new EventHandler(QuantityTextBox_TextChanged);
            // 
            // Quantity5
            // 
            Quantity5.BackColor = Color.Gainsboro;
            Quantity5.BorderStyle = BorderStyle.None;
            Quantity5.Location = new Point(206, 139);
            Quantity5.Name = "Quantity5";
            Quantity5.Size = new Size(197, 20);
            Quantity5.TabIndex = 11;
            Quantity5.TextChanged += new EventHandler(QuantityTextBox_TextChanged);
            // 
            // Quantity6
            // 
            Quantity6.BackColor = Color.Gainsboro;
            Quantity6.BorderStyle = BorderStyle.None;
            Quantity6.Location = new Point(206, 173);
            Quantity6.Name = "Quantity6";
            Quantity6.Size = new Size(197, 20);
            Quantity6.TabIndex = 12;
            Quantity6.TextChanged += new EventHandler(QuantityTextBox_TextChanged);
            // 
            // Quantity7
            // 
            Quantity7.BackColor = Color.Gainsboro;
            Quantity7.BorderStyle = BorderStyle.None;
            Quantity7.Location = new Point(206, 207);
            Quantity7.Name = "Quantity7";
            Quantity7.Size = new Size(197, 20);
            Quantity7.TabIndex = 13;
            Quantity7.TextChanged += new EventHandler(QuantityTextBox_TextChanged);
            // 
            // usermanagement
            // 
            usermanagement.BackColor = Color.FromArgb(224, 224, 224);
            usermanagement.Controls.Add(label1);
            usermanagement.Controls.Add(changeuser1);
            usermanagement.Controls.Add(label2);
            usermanagement.Controls.Add(changepassword2);
            usermanagement.Controls.Add(changeuser2);
            usermanagement.Controls.Add(changepassword1);
            usermanagement.FlatStyle = FlatStyle.Flat;
            usermanagement.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            usermanagement.Location = new Point(12, 289);
            usermanagement.Name = "usermanagement";
            usermanagement.Size = new Size(591, 149);
            usermanagement.TabIndex = 4;
            usermanagement.TabStop = false;
            usermanagement.Text = "Manage Users";
            usermanagement.Enter += usermanagement_Enter;
            // 
            // changeuser1
            // 
            changeuser1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            changeuser1.Location = new Point(6, 43);
            changeuser1.Name = "changeuser1";
            changeuser1.Size = new Size(153, 21);
            changeuser1.TabIndex = 9;
            changeuser1.Text = "Change Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(165, 23);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 7;
            label2.Text = "User 2:";
            // 
            // changepassword2
            // 
            changepassword2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            changepassword2.Location = new Point(165, 70);
            changepassword2.Name = "changepassword2";
            changepassword2.Size = new Size(153, 21);
            changepassword2.TabIndex = 6;
            changepassword2.Text = "Change Password";
            // 
            // changeuser2
            // 
            changeuser2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            changeuser2.Location = new Point(165, 43);
            changeuser2.Name = "changeuser2";
            changeuser2.Size = new Size(153, 21);
            changeuser2.TabIndex = 5;
            changeuser2.Text = "Change Username";
            // 
            // changepassword1
            // 
            changepassword1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            changepassword1.Location = new Point(6, 70);
            changepassword1.Name = "changepassword1";
            changepassword1.Size = new Size(153, 21);
            changepassword1.TabIndex = 4;
            changepassword1.Text = "Change Password";
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.DarkRed;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutButton.ForeColor = SystemColors.ButtonFace;
            LogoutButton.Location = new Point(638, 359);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(138, 30);
            LogoutButton.TabIndex = 5;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += new EventHandler(LogoutButton_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 10;
            label1.Text = "User 1:";
            // 
            // AdminMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = LogoutButton;
            ClientSize = new Size(788, 466);
            Controls.Add(LogoutButton);
            Controls.Add(usermanagement);
            Controls.Add(stocks);
            Controls.Add(logbox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMainPage";
            Text = "Admin Main Page";
            Load += new EventHandler(AdminMainPage_Load);
            stocks.ResumeLayout(false);
            tableLayoutPanel_StocksWithQuantity.ResumeLayout(false);
            tableLayoutPanel_StocksWithQuantity.PerformLayout();
            usermanagement.ResumeLayout(false);
            usermanagement.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox logbox;
        private GroupBox stocks;
        private GroupBox usermanagement;
        private TextBox changeuser2;
        private TextBox changepassword1;
        private TextBox changepassword2;
        private Label label1;
        private Label label2;
        private Button LogoutButton;
        private TableLayoutPanel tableLayoutPanel_StocksWithQuantity;
        private TextBox StockItem1;
        private TextBox StockItem2;
        private TextBox StockItem3;
        private TextBox StockItem4;
        private TextBox StockItem5;
        private TextBox StockItem6;
        private TextBox StockItem7;
        private TextBox Quantity1;
        private TextBox Quantity2;
        private TextBox Quantity3;
        private TextBox Quantity4;
        private TextBox Quantity5;
        private TextBox Quantity6;
        private TextBox Quantity7;
        private TextBox changeuser1;
    }
}
