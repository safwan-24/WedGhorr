namespace WedGhor
{
    partial class CustomerLoginForm
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
            TitleLabel = new Label();
            UsernameLabel = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            PasswordLabel = new Label();
            CustomerLoginButton2 = new Button();
            BackToWelcomeButton = new Button();
            SignUpLabel = new Label();
            SignUp = new LinkLabel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Algerian", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.DeepPink;
            TitleLabel.Location = new Point(80, 23);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(142, 31);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "WedGhor";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            UsernameLabel.Location = new Point(39, 89);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(78, 20);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username";
            // 
            // login_username
            // 
            login_username.Location = new Point(117, 86);
            login_username.Name = "login_username";
            login_username.Size = new Size(125, 27);
            login_username.TabIndex = 2;
            // 
            // login_password
            // 
            login_password.Location = new Point(117, 156);
            login_password.Name = "login_password";
            login_password.Size = new Size(125, 27);
            login_password.TabIndex = 5;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            PasswordLabel.Location = new Point(39, 156);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(73, 20);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password";
            // 
            // CustomerLoginButton2
            // 
            CustomerLoginButton2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            CustomerLoginButton2.Location = new Point(169, 210);
            CustomerLoginButton2.Name = "CustomerLoginButton2";
            CustomerLoginButton2.Size = new Size(94, 29);
            CustomerLoginButton2.TabIndex = 6;
            CustomerLoginButton2.Text = "Login";
            CustomerLoginButton2.UseVisualStyleBackColor = true;
            CustomerLoginButton2.Click += CustomerLoginButton2_Click;
            // 
            // BackToWelcomeButton
            // 
            BackToWelcomeButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BackToWelcomeButton.Location = new Point(39, 210);
            BackToWelcomeButton.Name = "BackToWelcomeButton";
            BackToWelcomeButton.Size = new Size(94, 29);
            BackToWelcomeButton.TabIndex = 7;
            BackToWelcomeButton.Text = "Back";
            BackToWelcomeButton.UseVisualStyleBackColor = true;
            BackToWelcomeButton.Click += BackToWelcomeButton_Click;
            // 
            // SignUpLabel
            // 
            SignUpLabel.AutoSize = true;
            SignUpLabel.Location = new Point(79, 253);
            SignUpLabel.Name = "SignUpLabel";
            SignUpLabel.Size = new Size(143, 20);
            SignUpLabel.TabIndex = 8;
            SignUpLabel.Text = "Don't have account?";
            // 
            // SignUp
            // 
            SignUp.AutoSize = true;
            SignUp.Location = new Point(117, 282);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(61, 20);
            SignUp.TabIndex = 9;
            SignUp.TabStop = true;
            SignUp.Text = "Sign Up";
            SignUp.LinkClicked += SignUp_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IMG_20240910_WA0006_2_;
            pictureBox1.Location = new Point(301, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 323);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaptionText;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(582, 9);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 11;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // CustomerLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(613, 323);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(SignUp);
            Controls.Add(SignUpLabel);
            Controls.Add(BackToWelcomeButton);
            Controls.Add(CustomerLoginButton2);
            Controls.Add(login_password);
            Controls.Add(PasswordLabel);
            Controls.Add(login_username);
            Controls.Add(UsernameLabel);
            Controls.Add(TitleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerLoginForm";
            Load += CustomerLoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label UsernameLabel;
        private TextBox login_username;
        private TextBox login_password;
        private Label PasswordLabel;
        private Button CustomerLoginButton2;
        private Button BackToWelcomeButton;
        private Label SignUpLabel;
        private LinkLabel SignUp;
        private PictureBox pictureBox1;
        private Label label1;
    }
}