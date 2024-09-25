namespace WedGhor
{
    partial class BkashForm
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
            label2 = new Label();
            MobileNumberTb = new TextBox();
            textBox2 = new TextBox();
            BackBtn = new Button();
            ConfirmBtn = new Button();
            label3 = new Label();
            CustIdTb = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 61);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Your Mobile Number";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 145);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter Your Pin";
            label2.Click += label2_Click;
            // 
            // MobileNumberTb
            // 
            MobileNumberTb.Location = new Point(231, 100);
            MobileNumberTb.Name = "MobileNumberTb";
            MobileNumberTb.Size = new Size(125, 27);
            MobileNumberTb.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(231, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Black;
            BackBtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(12, 282);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 29);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.BackColor = Color.Black;
            ConfirmBtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            ConfirmBtn.ForeColor = Color.White;
            ConfirmBtn.Location = new Point(507, 282);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(94, 29);
            ConfirmBtn.TabIndex = 5;
            ConfirmBtn.Text = "Confirm";
            ConfirmBtn.UseVisualStyleBackColor = false;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(583, 9);
            label3.Name = "label3";
            label3.Size = new Size(19, 20);
            label3.TabIndex = 6;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // CustIdTb
            // 
            CustIdTb.Location = new Point(231, 263);
            CustIdTb.Name = "CustIdTb";
            CustIdTb.Size = new Size(125, 27);
            CustIdTb.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(234, 229);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 8;
            label4.Text = "Enter your Email";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IMG_20240910_WA0011_1_;
            pictureBox1.Location = new Point(231, -17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 75);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // BkashForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepPink;
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
            Name = "BkashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BkashForm";
            Load += BkashForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox MobileNumberTb;
        private TextBox textBox2;
        private Button BackBtn;
        private Button ConfirmBtn;
        private Label label3;
        private TextBox CustIdTb;
        private Label label4;
        private PictureBox pictureBox1;
    }
}