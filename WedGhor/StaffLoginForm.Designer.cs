namespace WedGhor
{
    partial class StaffLoginForm
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
            BackToWelcomeButton = new Button();
            StaffLoginButton2 = new Button();
            login_password = new TextBox();
            PasswordLabel = new Label();
            login_username = new TextBox();
            UsernameLabel = new Label();
            TitleLabel = new Label();
            Closelabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BackToWelcomeButton
            // 
            BackToWelcomeButton.Location = new Point(347, 246);
            BackToWelcomeButton.Name = "BackToWelcomeButton";
            BackToWelcomeButton.Size = new Size(94, 29);
            BackToWelcomeButton.TabIndex = 15;
            BackToWelcomeButton.Text = "Back";
            BackToWelcomeButton.UseVisualStyleBackColor = true;
            BackToWelcomeButton.Click += BackToWelcomeButton_Click;
            // 
            // StaffLoginButton2
            // 
            StaffLoginButton2.Location = new Point(469, 246);
            StaffLoginButton2.Name = "StaffLoginButton2";
            StaffLoginButton2.Size = new Size(94, 29);
            StaffLoginButton2.TabIndex = 14;
            StaffLoginButton2.Text = "Login";
            StaffLoginButton2.UseVisualStyleBackColor = true;
            StaffLoginButton2.Click += StaffLoginButton2_Click;
            // 
            // login_password
            // 
            login_password.Location = new Point(438, 162);
            login_password.Name = "login_password";
            login_password.Size = new Size(125, 27);
            login_password.TabIndex = 13;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(354, 165);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(73, 20);
            PasswordLabel.TabIndex = 12;
            PasswordLabel.Text = "Password";
            // 
            // login_username
            // 
            login_username.Location = new Point(438, 95);
            login_username.Name = "login_username";
            login_username.Size = new Size(125, 27);
            login_username.TabIndex = 10;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameLabel.Location = new Point(354, 98);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(78, 20);
            UsernameLabel.TabIndex = 9;
            UsernameLabel.Text = "Username";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Algerian", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.Indigo;
            TitleLabel.Location = new Point(382, 34);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(181, 31);
            TitleLabel.TabIndex = 8;
            TitleLabel.Text = "Staff Login";
            // 
            // Closelabel
            // 
            Closelabel.AutoSize = true;
            Closelabel.BackColor = Color.Transparent;
            Closelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Closelabel.Location = new Point(583, 9);
            Closelabel.Name = "Closelabel";
            Closelabel.Size = new Size(19, 20);
            Closelabel.TabIndex = 4;
            Closelabel.Text = "X";
            Closelabel.Click += Closelabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.stafff1;
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 324);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // StaffLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(613, 323);
            Controls.Add(pictureBox1);
            Controls.Add(Closelabel);
            Controls.Add(BackToWelcomeButton);
            Controls.Add(StaffLoginButton2);
            Controls.Add(login_password);
            Controls.Add(PasswordLabel);
            Controls.Add(login_username);
            Controls.Add(UsernameLabel);
            Controls.Add(TitleLabel);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffLoginForm";
            Load += StaffLoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackToWelcomeButton;
        private Button StaffLoginButton2;
        private TextBox login_password;
        private Label PasswordLabel;
        private TextBox login_username;
        private Label UsernameLabel;
        private Label TitleLabel;
        private Label Closelabel;
        private PictureBox pictureBox1;
    }
}