namespace InventoryTest
{
    partial class UserMainPage
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
            itemInput = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            quantityInput = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            itemNameField = new Label();
            quantityError = new Label();
            SuspendLayout();
            // 
            // itemInput
            // 
            itemInput.Location = new Point(80, 193);
            itemInput.Name = "itemInput";
            itemInput.Size = new Size(238, 23);
            itemInput.TabIndex = 0;
            itemInput.UseWaitCursor = true;
            itemInput.TextChanged += itemInput_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 169);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 1;
            label1.Text = "Item:";
            label1.UseWaitCursor = true;
            // 
            // quantityInput
            // 
            quantityInput.Location = new Point(80, 273);
            quantityInput.Name = "quantityInput";
            quantityInput.Size = new Size(238, 23);
            quantityInput.TabIndex = 2;
            quantityInput.UseWaitCursor = true;
            quantityInput.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 249);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 3;
            label2.Text = "Item Quantity";
            label2.UseWaitCursor = true;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(80, 23);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 4;
            label3.Text = "Item Name:";
            label3.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(80, 44);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 5;
            label4.Text = "Item Price:";
            label4.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(80, 65);
            label5.Name = "label5";
            label5.Size = new Size(102, 37);
            label5.TabIndex = 6;
            label5.Text = "TOTAL: ";
            label5.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(150, 354);
            button1.Name = "button1";
            button1.Size = new Size(98, 35);
            button1.TabIndex = 7;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // itemNameField
            // 
            itemNameField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itemNameField.AutoSize = true;
            itemNameField.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemNameField.Location = new Point(151, 23);
            itemNameField.MinimumSize = new Size(160, 12);
            itemNameField.Name = "itemNameField";
            itemNameField.Size = new Size(160, 21);
            itemNameField.TabIndex = 9;
            itemNameField.UseWaitCursor = true;
            itemNameField.Click += itemNameField_Click;
            // 
            // quantityError
            // 
            quantityError.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            quantityError.AutoSize = true;
            quantityError.Font = new Font("Franklin Gothic Medium Cond", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            quantityError.ForeColor = Color.Red;
            quantityError.Location = new Point(173, 253);
            quantityError.MinimumSize = new Size(160, 12);
            quantityError.Name = "quantityError";
            quantityError.Size = new Size(160, 15);
            quantityError.TabIndex = 10;
            quantityError.UseWaitCursor = true;
            // 
            // UserMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button1;
            ClientSize = new Size(389, 450);
            Controls.Add(quantityError);
            Controls.Add(itemNameField);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(quantityInput);
            Controls.Add(label1);
            Controls.Add(itemInput);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserMainPage";
            Text = "UserMainPage";
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox itemInput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private TextBox quantityInput;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label itemNameField;
        private Label quantityError;
    }
}