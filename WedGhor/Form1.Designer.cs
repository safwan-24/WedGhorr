namespace WedGhor
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CustomerLoginButton = new Button();
            AdminLoginButton = new Button();
            StaffLoginButton = new Button();
            Closelabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CustomerLoginButton
            // 
            CustomerLoginButton.BackColor = Color.DarkGoldenrod;
            CustomerLoginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CustomerLoginButton.ForeColor = Color.Transparent;
            CustomerLoginButton.Location = new Point(73, 278);
            CustomerLoginButton.Name = "CustomerLoginButton";
            CustomerLoginButton.Size = new Size(99, 33);
            CustomerLoginButton.TabIndex = 0;
            CustomerLoginButton.Text = "Customer";
            CustomerLoginButton.UseVisualStyleBackColor = false;
            CustomerLoginButton.Click += CustomerLoginButton_Click;
            // 
            // AdminLoginButton
            // 
            AdminLoginButton.BackColor = Color.DarkGoldenrod;
            AdminLoginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AdminLoginButton.ForeColor = Color.Transparent;
            AdminLoginButton.Location = new Point(266, 280);
            AdminLoginButton.Name = "AdminLoginButton";
            AdminLoginButton.Size = new Size(94, 31);
            AdminLoginButton.TabIndex = 1;
            AdminLoginButton.Text = "Admin";
            AdminLoginButton.UseVisualStyleBackColor = false;
            AdminLoginButton.Click += AdminLoginButton_Click;
            // 
            // StaffLoginButton
            // 
            StaffLoginButton.BackColor = Color.DarkGoldenrod;
            StaffLoginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            StaffLoginButton.ForeColor = Color.Transparent;
            StaffLoginButton.Location = new Point(458, 279);
            StaffLoginButton.Name = "StaffLoginButton";
            StaffLoginButton.Size = new Size(94, 30);
            StaffLoginButton.TabIndex = 2;
            StaffLoginButton.Text = "Staff";
            StaffLoginButton.UseVisualStyleBackColor = false;
            StaffLoginButton.Click += StaffLoginButton_Click;
            // 
            // Closelabel
            // 
            Closelabel.AutoSize = true;
            Closelabel.BackColor = Color.White;
            Closelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Closelabel.Location = new Point(583, 9);
            Closelabel.Name = "Closelabel";
            Closelabel.Size = new Size(19, 20);
            Closelabel.TabIndex = 3;
            Closelabel.Text = "X";
            Closelabel.Click += Closelabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IMG_20240910_WA0014;
            pictureBox1.Location = new Point(0, -21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(614, 344);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 323);
            Controls.Add(Closelabel);
            Controls.Add(StaffLoginButton);
            Controls.Add(AdminLoginButton);
            Controls.Add(CustomerLoginButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CustomerLoginButton;
        private Button AdminLoginButton;
        private Button StaffLoginButton;
        private Label Closelabel;
        private PictureBox pictureBox1;
    }
}
