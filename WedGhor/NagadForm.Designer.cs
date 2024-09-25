namespace WedGhor
{
    partial class NagadForm
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
            CustIdTb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            ConfirmBtn = new Button();
            BackBtn = new Button();
            textBox2 = new TextBox();
            MobileNumberTb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CustIdTb
            // 
            CustIdTb.Location = new Point(248, 274);
            CustIdTb.Name = "CustIdTb";
            CustIdTb.Size = new Size(125, 27);
            CustIdTb.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(248, 237);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 18;
            label4.Text = "Enter your Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(587, 5);
            label3.Name = "label3";
            label3.Size = new Size(19, 20);
            label3.TabIndex = 16;
            label3.Text = "X";
            label3.Click += label3_Click_1;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.BackColor = Color.Black;
            ConfirmBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            ConfirmBtn.ForeColor = Color.White;
            ConfirmBtn.Location = new Point(508, 282);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(94, 29);
            ConfirmBtn.TabIndex = 15;
            ConfirmBtn.Text = "Confirm";
            ConfirmBtn.UseVisualStyleBackColor = false;
            ConfirmBtn.Click += ConfirmBtn_Click_1;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Black;
            BackBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(12, 282);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 29);
            BackBtn.TabIndex = 14;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 13;
            // 
            // MobileNumberTb
            // 
            MobileNumberTb.Location = new Point(248, 111);
            MobileNumberTb.Name = "MobileNumberTb";
            MobileNumberTb.Size = new Size(125, 27);
            MobileNumberTb.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(257, 156);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 11;
            label2.Text = "Enter Your Pin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 72);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 10;
            label1.Text = "Enter Your Mobile Number";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IMG_20240910_WA0010_1_;
            pictureBox1.Location = new Point(248, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // NagadForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 323);
            Controls.Add(pictureBox1);
            Controls.Add(CustIdTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ConfirmBtn);
            Controls.Add(BackBtn);
            Controls.Add(textBox2);
            Controls.Add(MobileNumberTb);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NagadForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NagadForm";
            Load += NagadForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CustIdTb;
        private Label label4;
        private Label label3;
        private Button ConfirmBtn;
        private Button BackBtn;
        private TextBox textBox2;
        private TextBox MobileNumberTb;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}