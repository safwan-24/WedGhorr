namespace WedGhor
{
    partial class StaffScedule
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
            BackBtn = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            MorningCb = new CheckBox();
            DayCb = new CheckBox();
            NightCb = new CheckBox();
            AddBtn = new Button();
            StaffNameTb = new TextBox();
            StaffIdTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Black;
            BackBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(507, 282);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 29);
            BackBtn.TabIndex = 0;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(269, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(332, 227);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(583, 9);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 2;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // MorningCb
            // 
            MorningCb.AutoSize = true;
            MorningCb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            MorningCb.ForeColor = Color.Indigo;
            MorningCb.Location = new Point(35, 143);
            MorningCb.Name = "MorningCb";
            MorningCb.Size = new Size(221, 24);
            MorningCb.TabIndex = 6;
            MorningCb.Text = "Morning Shift (6 am - 2 pm)";
            MorningCb.UseVisualStyleBackColor = true;
            MorningCb.CheckedChanged += MorningCb_CheckedChanged;
            // 
            // DayCb
            // 
            DayCb.AutoSize = true;
            DayCb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            DayCb.ForeColor = Color.Indigo;
            DayCb.Location = new Point(35, 173);
            DayCb.Name = "DayCb";
            DayCb.Size = new Size(195, 24);
            DayCb.TabIndex = 7;
            DayCb.Text = "Day Shift (2 pm - 10 pm)";
            DayCb.UseVisualStyleBackColor = true;
            DayCb.CheckedChanged += DayCb_CheckedChanged;
            // 
            // NightCb
            // 
            NightCb.AutoSize = true;
            NightCb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            NightCb.ForeColor = Color.Indigo;
            NightCb.Location = new Point(35, 203);
            NightCb.Name = "NightCb";
            NightCb.Size = new Size(206, 24);
            NightCb.TabIndex = 8;
            NightCb.Text = "Night Shift (10 pm - 6 am)";
            NightCb.UseVisualStyleBackColor = true;
            NightCb.CheckedChanged += NightCb_CheckedChanged;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Black;
            AddBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(169, 247);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 29);
            AddBtn.TabIndex = 9;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // StaffNameTb
            // 
            StaffNameTb.Location = new Point(126, 49);
            StaffNameTb.Name = "StaffNameTb";
            StaffNameTb.Size = new Size(125, 27);
            StaffNameTb.TabIndex = 10;
            StaffNameTb.TextChanged += StaffNameTb_TextChanged;
            // 
            // StaffIdTb
            // 
            StaffIdTb.Location = new Point(126, 97);
            StaffIdTb.Name = "StaffIdTb";
            StaffIdTb.Size = new Size(125, 27);
            StaffIdTb.TabIndex = 11;
            StaffIdTb.TextChanged += StaffIdTb_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(35, 52);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 12;
            label2.Text = "Staff Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(35, 100);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 13;
            label3.Text = "Staff Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(169, 25);
            label4.TabIndex = 35;
            label4.Text = "Add Scedule";
            // 
            // StaffScedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(613, 323);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(StaffIdTb);
            Controls.Add(StaffNameTb);
            Controls.Add(AddBtn);
            Controls.Add(NightCb);
            Controls.Add(DayCb);
            Controls.Add(MorningCb);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(BackBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffScedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffScedule";
            Load += StaffScedule_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private DataGridView dataGridView1;
        private Label label1;
        private CheckBox MorningCb;
        private CheckBox DayCb;
        private CheckBox NightCb;
        private Button AddBtn;
        private TextBox StaffNameTb;
        private TextBox StaffIdTb;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}