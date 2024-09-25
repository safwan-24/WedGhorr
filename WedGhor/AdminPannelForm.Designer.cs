namespace WedGhor
{
    partial class AdminPannelForm
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
            ViewBookingBtn = new Button();
            ViewCustomerBtn = new Button();
            ViewStaffBtn = new Button();
            BackBtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ViewBookingBtn
            // 
            ViewBookingBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ViewBookingBtn.Location = new Point(412, 25);
            ViewBookingBtn.Name = "ViewBookingBtn";
            ViewBookingBtn.Size = new Size(124, 41);
            ViewBookingBtn.TabIndex = 0;
            ViewBookingBtn.Text = "View Booking";
            ViewBookingBtn.UseVisualStyleBackColor = true;
            ViewBookingBtn.Click += ViewBookingBtn_Click;
            // 
            // ViewCustomerBtn
            // 
            ViewCustomerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ViewCustomerBtn.Location = new Point(412, 95);
            ViewCustomerBtn.Name = "ViewCustomerBtn";
            ViewCustomerBtn.Size = new Size(124, 41);
            ViewCustomerBtn.TabIndex = 1;
            ViewCustomerBtn.Text = "View Customer";
            ViewCustomerBtn.UseVisualStyleBackColor = true;
            ViewCustomerBtn.Click += ViewCustomerBtn_Click;
            // 
            // ViewStaffBtn
            // 
            ViewStaffBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ViewStaffBtn.Location = new Point(412, 164);
            ViewStaffBtn.Name = "ViewStaffBtn";
            ViewStaffBtn.Size = new Size(124, 41);
            ViewStaffBtn.TabIndex = 2;
            ViewStaffBtn.Text = "View Staff";
            ViewStaffBtn.UseVisualStyleBackColor = true;
            ViewStaffBtn.Click += ViewStaffBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BackBtn.Location = new Point(412, 246);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(124, 41);
            BackBtn.TabIndex = 3;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(583, 9);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 4;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.desktop_wallpaper_engineer_gzsihai_com_amazing_computer_science_engineering1;
            pictureBox1.Location = new Point(0, -74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(613, 423);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // AdminPannelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 323);
            Controls.Add(label1);
            Controls.Add(BackBtn);
            Controls.Add(ViewStaffBtn);
            Controls.Add(ViewCustomerBtn);
            Controls.Add(ViewBookingBtn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPannelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPannelForm";
            Load += AdminPannelForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ViewBookingBtn;
        private Button ViewCustomerBtn;
        private Button ViewStaffBtn;
        private Button BackBtn;
        private Label label1;
        private PictureBox pictureBox1;
    }
}