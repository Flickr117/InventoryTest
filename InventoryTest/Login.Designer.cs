namespace InventoryTest
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            UsernameInput = new TextBox();
            PasswordInput = new TextBox();
            ResultLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(70, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 68);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UsernameInput
            // 
            UsernameInput.AcceptsReturn = true;
            UsernameInput.BackColor = Color.FromArgb(50, 50, 50);
            UsernameInput.BorderStyle = BorderStyle.FixedSingle;
            UsernameInput.Cursor = Cursors.IBeam;
            UsernameInput.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameInput.ForeColor = Color.LightGray;
            UsernameInput.Location = new Point(70, 220);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(145, 22);
            UsernameInput.TabIndex = 1;
            UsernameInput.Text = "Username";
            UsernameInput.TextAlign = HorizontalAlignment.Center;
            UsernameInput.TextChanged += UsernameInput_TextChanged;
            // 
            // PasswordInput
            // 
            PasswordInput.AcceptsReturn = true;
            PasswordInput.BackColor = Color.FromArgb(50, 50, 50);
            PasswordInput.BorderStyle = BorderStyle.FixedSingle;
            PasswordInput.Cursor = Cursors.IBeam;
            PasswordInput.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordInput.ForeColor = Color.LightGray;
            PasswordInput.Location = new Point(70, 248);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(145, 22);
            PasswordInput.TabIndex = 2;
            PasswordInput.Text = "Password";
            PasswordInput.TextAlign = HorizontalAlignment.Center;
            PasswordInput.TextChanged += PasswordInput_TextChanged;
            // 
            // ResultLabel
            // 
            ResultLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ResultLabel.AutoSize = true;
            ResultLabel.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ResultLabel.ForeColor = Color.Red;
            ResultLabel.Location = new Point(70, 203);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(0, 14);
            ResultLabel.TabIndex = 3;
            ResultLabel.Click += label1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(285, 450);
            Controls.Add(ResultLabel);
            Controls.Add(PasswordInput);
            Controls.Add(UsernameInput);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox UsernameInput;
        private TextBox PasswordInput;
        private Label ResultLabel;
    }
}