namespace WedGhor
{
    partial class SignUpForm
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
            SignUpButton2 = new Button();
            SignupPasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            panel1 = new Panel();
            Closelabel = new Label();
            SignupUserNametextBox = new TextBox();
            UsernameLabel = new Label();
            TitleLabel = new Label();
            SignupEmailTextBox = new TextBox();
            EmailLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BackToWelcomeButton
            // 
            BackToWelcomeButton.Location = new Point(19, 240);
            BackToWelcomeButton.Name = "BackToWelcomeButton";
            BackToWelcomeButton.Size = new Size(94, 29);
            BackToWelcomeButton.TabIndex = 23;
            BackToWelcomeButton.Text = "Back";
            BackToWelcomeButton.UseVisualStyleBackColor = true;
            BackToWelcomeButton.Click += BackToWelcomeButton_Click;
            // 
            // SignUpButton2
            // 
            SignUpButton2.Location = new Point(141, 240);
            SignUpButton2.Name = "SignUpButton2";
            SignUpButton2.Size = new Size(94, 29);
            SignUpButton2.TabIndex = 22;
            SignUpButton2.Text = "Signup";
            SignUpButton2.UseVisualStyleBackColor = true;
            SignUpButton2.Click += SignUpButton2_Click;
            // 
            // SignupPasswordTextBox
            // 
            SignupPasswordTextBox.Location = new Point(97, 183);
            SignupPasswordTextBox.Name = "SignupPasswordTextBox";
            SignupPasswordTextBox.Size = new Size(125, 27);
            SignupPasswordTextBox.TabIndex = 21;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(19, 183);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(70, 20);
            PasswordLabel.TabIndex = 20;
            PasswordLabel.Text = "Password";
            // 
            // panel1
            // 
            panel1.Controls.Add(Closelabel);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(293, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 323);
            panel1.TabIndex = 19;
            // 
            // Closelabel
            // 
            Closelabel.AutoSize = true;
            Closelabel.Location = new Point(290, 9);
            Closelabel.Name = "Closelabel";
            Closelabel.Size = new Size(18, 20);
            Closelabel.TabIndex = 4;
            Closelabel.Text = "X";
            // 
            // SignupUserNametextBox
            // 
            SignupUserNametextBox.Location = new Point(97, 133);
            SignupUserNametextBox.Name = "SignupUserNametextBox";
            SignupUserNametextBox.Size = new Size(125, 27);
            SignupUserNametextBox.TabIndex = 18;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(19, 136);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(75, 20);
            UsernameLabel.TabIndex = 17;
            UsernameLabel.Text = "Username";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Algerian", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.DeepPink;
            TitleLabel.Location = new Point(72, 26);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(116, 31);
            TitleLabel.TabIndex = 16;
            TitleLabel.Text = "Sign Up";
            TitleLabel.Click += TitleLabel_Click;
            // 
            // SignupEmailTextBox
            // 
            SignupEmailTextBox.Location = new Point(97, 84);
            SignupEmailTextBox.Name = "SignupEmailTextBox";
            SignupEmailTextBox.Size = new Size(125, 27);
            SignupEmailTextBox.TabIndex = 25;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(19, 87);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(46, 20);
            EmailLabel.TabIndex = 24;
            EmailLabel.Text = "Email";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 323);
            Controls.Add(SignupEmailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(BackToWelcomeButton);
            Controls.Add(SignUpButton2);
            Controls.Add(SignupPasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(panel1);
            Controls.Add(SignupUserNametextBox);
            Controls.Add(UsernameLabel);
            Controls.Add(TitleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            Load += SignUpForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackToWelcomeButton;
        private Button SignUpButton2;
        private TextBox SignupPasswordTextBox;
        private Label PasswordLabel;
        private Panel panel1;
        private Label Closelabel;
        private TextBox SignupUserNametextBox;
        private Label UsernameLabel;
        private Label TitleLabel;
        private TextBox SignupEmailTextBox;
        private Label EmailLabel;
    }
}