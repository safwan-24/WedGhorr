namespace WedGhor
{
    partial class StaffPanelForm
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
            label1 = new Label();
            BackBtn = new Button();
            ViewSceduleBtn = new Button();
            VipBtn = new Button();
            ViewBookingBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleGoldenrod;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(581, 9);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 9;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Black;
            BackBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(410, 246);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(124, 41);
            BackBtn.TabIndex = 8;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // ViewSceduleBtn
            // 
            ViewSceduleBtn.BackColor = Color.Black;
            ViewSceduleBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ViewSceduleBtn.ForeColor = Color.White;
            ViewSceduleBtn.Location = new Point(410, 182);
            ViewSceduleBtn.Name = "ViewSceduleBtn";
            ViewSceduleBtn.Size = new Size(124, 41);
            ViewSceduleBtn.TabIndex = 7;
            ViewSceduleBtn.Text = "View Scedule";
            ViewSceduleBtn.UseVisualStyleBackColor = false;
            ViewSceduleBtn.Click += ViewSceduleBtn_Click;
            // 
            // VipBtn
            // 
            VipBtn.BackColor = Color.Black;
            VipBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            VipBtn.ForeColor = Color.White;
            VipBtn.Location = new Point(410, 114);
            VipBtn.Name = "VipBtn";
            VipBtn.Size = new Size(124, 41);
            VipBtn.TabIndex = 6;
            VipBtn.Text = "Paid Customer";
            VipBtn.UseVisualStyleBackColor = false;
            VipBtn.Click += VipBtn_Click;
            // 
            // ViewBookingBtn
            // 
            ViewBookingBtn.BackColor = Color.Black;
            ViewBookingBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ViewBookingBtn.ForeColor = Color.White;
            ViewBookingBtn.Location = new Point(410, 50);
            ViewBookingBtn.Name = "ViewBookingBtn";
            ViewBookingBtn.Size = new Size(124, 41);
            ViewBookingBtn.TabIndex = 5;
            ViewBookingBtn.Text = "View Booking";
            ViewBookingBtn.UseVisualStyleBackColor = false;
            ViewBookingBtn.Click += ViewBookingBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._360_F_621463250_F9bPpwWh4dclGOUAMEqzfq6ObIJ4nn921;
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(613, 323);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // StaffPanelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(613, 323);
            Controls.Add(label1);
            Controls.Add(BackBtn);
            Controls.Add(ViewSceduleBtn);
            Controls.Add(VipBtn);
            Controls.Add(ViewBookingBtn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffPanelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffPanelForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BackBtn;
        private Button ViewSceduleBtn;
        private Button VipBtn;
        private Button ViewBookingBtn;
        private PictureBox pictureBox1;
    }
}