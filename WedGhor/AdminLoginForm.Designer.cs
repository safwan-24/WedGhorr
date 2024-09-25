namespace WedGhor
{
    partial class AdminLoginForm
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
            AdminLoginButton2 = new Button();
            ATB2 = new TextBox();
            PasswordLabel = new Label();
            ATB1 = new TextBox();
            UsernameLabel = new Label();
            TitleLabel = new Label();
            Closelabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BackToWelcomeButton
            // 
            BackToWelcomeButton.BackColor = Color.Black;
            BackToWelcomeButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BackToWelcomeButton.ForeColor = Color.White;
            BackToWelcomeButton.Location = new Point(29, 240);
            BackToWelcomeButton.Name = "BackToWelcomeButton";
            BackToWelcomeButton.Size = new Size(94, 29);
            BackToWelcomeButton.TabIndex = 15;
            BackToWelcomeButton.Text = "Back";
            BackToWelcomeButton.UseVisualStyleBackColor = false;
            BackToWelcomeButton.Click += BackToWelcomeButton_Click;
            // 
            // AdminLoginButton2
            // 
            AdminLoginButton2.BackColor = Color.Black;
            AdminLoginButton2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            AdminLoginButton2.ForeColor = Color.White;
            AdminLoginButton2.Location = new Point(151, 240);
            AdminLoginButton2.Name = "AdminLoginButton2";
            AdminLoginButton2.Size = new Size(94, 29);
            AdminLoginButton2.TabIndex = 14;
            AdminLoginButton2.Text = "Login";
            AdminLoginButton2.UseVisualStyleBackColor = false;
            AdminLoginButton2.Click += AdminLoginButton2_Click;
            // 
            // ATB2
            // 
            ATB2.Location = new Point(120, 153);
            ATB2.Name = "ATB2";
            ATB2.Size = new Size(125, 27);
            ATB2.TabIndex = 13;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = SystemColors.WindowText;
            PasswordLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            PasswordLabel.ForeColor = Color.DeepPink;
            PasswordLabel.Location = new Point(29, 156);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(73, 20);
            PasswordLabel.TabIndex = 12;
            PasswordLabel.Text = "Password";
            // 
            // ATB1
            // 
            ATB1.Location = new Point(120, 86);
            ATB1.Name = "ATB1";
            ATB1.Size = new Size(125, 27);
            ATB1.TabIndex = 10;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.BackColor = SystemColors.WindowText;
            UsernameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            UsernameLabel.ForeColor = Color.DeepPink;
            UsernameLabel.Location = new Point(29, 89);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(78, 20);
            UsernameLabel.TabIndex = 9;
            UsernameLabel.Text = "Username";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = SystemColors.WindowText;
            TitleLabel.Font = new Font("Algerian", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.DeepPink;
            TitleLabel.Location = new Point(29, 23);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(233, 31);
            TitleLabel.TabIndex = 8;
            TitleLabel.Text = "Log In as admin";
            // 
            // Closelabel
            // 
            Closelabel.AutoSize = true;
            Closelabel.BackColor = Color.Black;
            Closelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Closelabel.ForeColor = Color.White;
            Closelabel.Location = new Point(583, 9);
            Closelabel.Name = "Closelabel";
            Closelabel.Size = new Size(19, 20);
            Closelabel.TabIndex = 4;
            Closelabel.Text = "X";
            Closelabel.Click += Closelabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_534208398_612x612_1;
            pictureBox1.Location = new Point(-124, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(738, 323);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 323);
            Controls.Add(Closelabel);
            Controls.Add(BackToWelcomeButton);
            Controls.Add(AdminLoginButton2);
            Controls.Add(ATB2);
            Controls.Add(PasswordLabel);
            Controls.Add(ATB1);
            Controls.Add(UsernameLabel);
            Controls.Add(TitleLabel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLoginForm";
            Load += AdminLoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackToWelcomeButton;
        private Button AdminLoginButton2;
        private TextBox ATB2;
        private Label PasswordLabel;
        private TextBox ATB1;
        private Label UsernameLabel;
        private Label TitleLabel;
        private Label Closelabel;
        private PictureBox pictureBox1;
    }
}