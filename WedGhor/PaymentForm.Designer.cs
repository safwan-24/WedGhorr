namespace WedGhor
{
    partial class PaymentForm
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
            NagadCb = new CheckBox();
            BkashCb = new CheckBox();
            BackBtn = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // NagadCb
            // 
            NagadCb.AutoSize = true;
            NagadCb.Location = new Point(418, 109);
            NagadCb.Name = "NagadCb";
            NagadCb.Size = new Size(18, 17);
            NagadCb.TabIndex = 0;
            NagadCb.UseVisualStyleBackColor = true;
            NagadCb.CheckedChanged += NagadCb_CheckedChanged;
            // 
            // BkashCb
            // 
            BkashCb.AutoSize = true;
            BkashCb.Location = new Point(418, 175);
            BkashCb.Name = "BkashCb";
            BkashCb.Size = new Size(18, 17);
            BkashCb.TabIndex = 1;
            BkashCb.UseVisualStyleBackColor = true;
            BkashCb.CheckedChanged += BkashCb_CheckedChanged;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Black;
            BackBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(507, 282);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 29);
            BackBtn.TabIndex = 2;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(583, 9);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 3;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(261, 281);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(95, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cancel Order";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 261);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 5;
            label2.Text = "Don't want to order now?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IMG_20240910_WA0010_1_;
            pictureBox1.Location = new Point(442, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IMG_20240910_WA0011_1_;
            pictureBox2.Location = new Point(444, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 70);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 21);
            label3.Name = "label3";
            label3.Size = new Size(198, 20);
            label3.TabIndex = 9;
            label3.Text = "Select your Payment Method";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(613, 323);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(BackBtn);
            Controls.Add(BkashCb);
            Controls.Add(NagadCb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox NagadCb;
        private CheckBox BkashCb;
        private Button BackBtn;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
    }
}