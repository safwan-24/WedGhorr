namespace WedGhor
{
    partial class StaffForm
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
            label3 = new Label();
            StaffPassTb = new TextBox();
            StaffPhoneTb = new TextBox();
            StaffNameTb = new TextBox();
            AddStaffBtn = new Button();
            EditStaffBtn = new Button();
            DeleteStaffBtn = new Button();
            ResetStaffBtn = new Button();
            StaffDGV = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)StaffDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 0;
            label1.Text = "Staff";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(36, 53);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "Staff Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(251, 53);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 2;
            label3.Text = "Staff Password:";
            // 
            // StaffPassTb
            // 
            StaffPassTb.Location = new Point(251, 88);
            StaffPassTb.Name = "StaffPassTb";
            StaffPassTb.Size = new Size(125, 27);
            StaffPassTb.TabIndex = 4;
            // 
            // StaffPhoneTb
            // 
            StaffPhoneTb.Location = new Point(491, 88);
            StaffPhoneTb.Name = "StaffPhoneTb";
            StaffPhoneTb.Size = new Size(125, 27);
            StaffPhoneTb.TabIndex = 6;
            // 
            // StaffNameTb
            // 
            StaffNameTb.Location = new Point(12, 88);
            StaffNameTb.Name = "StaffNameTb";
            StaffNameTb.Size = new Size(125, 27);
            StaffNameTb.TabIndex = 7;
            // 
            // AddStaffBtn
            // 
            AddStaffBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            AddStaffBtn.Location = new Point(36, 136);
            AddStaffBtn.Name = "AddStaffBtn";
            AddStaffBtn.Size = new Size(94, 29);
            AddStaffBtn.TabIndex = 8;
            AddStaffBtn.Text = "Add Staff";
            AddStaffBtn.UseVisualStyleBackColor = true;
            AddStaffBtn.Click += AddStaffBtn_Click;
            // 
            // EditStaffBtn
            // 
            EditStaffBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            EditStaffBtn.Location = new Point(193, 136);
            EditStaffBtn.Name = "EditStaffBtn";
            EditStaffBtn.Size = new Size(94, 29);
            EditStaffBtn.TabIndex = 9;
            EditStaffBtn.Text = "Edit Staff";
            EditStaffBtn.UseVisualStyleBackColor = true;
            EditStaffBtn.Click += EditStaffBtn_Click;
            // 
            // DeleteStaffBtn
            // 
            DeleteStaffBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            DeleteStaffBtn.Location = new Point(335, 136);
            DeleteStaffBtn.Name = "DeleteStaffBtn";
            DeleteStaffBtn.Size = new Size(112, 29);
            DeleteStaffBtn.TabIndex = 10;
            DeleteStaffBtn.Text = "Delete Staff";
            DeleteStaffBtn.UseVisualStyleBackColor = true;
            DeleteStaffBtn.Click += DeleteStaffBtn_Click;
            // 
            // ResetStaffBtn
            // 
            ResetStaffBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ResetStaffBtn.Location = new Point(504, 136);
            ResetStaffBtn.Name = "ResetStaffBtn";
            ResetStaffBtn.Size = new Size(94, 29);
            ResetStaffBtn.TabIndex = 11;
            ResetStaffBtn.Text = "Reset";
            ResetStaffBtn.UseVisualStyleBackColor = true;
            ResetStaffBtn.Click += ResetStaffBtn_Click;
            // 
            // StaffDGV
            // 
            StaffDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StaffDGV.Location = new Point(36, 196);
            StaffDGV.Name = "StaffDGV";
            StaffDGV.RowHeadersWidth = 51;
            StaffDGV.Size = new Size(580, 135);
            StaffDGV.TabIndex = 12;
            StaffDGV.CellClick += StaffDGV_CellContentClick;
            StaffDGV.CellContentClick += StaffDGV_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(504, 53);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 13;
            label5.Text = "Staff Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(623, 7);
            label6.Name = "label6";
            label6.Size = new Size(18, 20);
            label6.TabIndex = 14;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.Location = new Point(547, 348);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(653, 400);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(StaffDGV);
            Controls.Add(ResetStaffBtn);
            Controls.Add(DeleteStaffBtn);
            Controls.Add(EditStaffBtn);
            Controls.Add(AddStaffBtn);
            Controls.Add(StaffNameTb);
            Controls.Add(StaffPhoneTb);
            Controls.Add(StaffPassTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffForm";
            Load += StaffForm_Load;
            ((System.ComponentModel.ISupportInitialize)StaffDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox StaffPassTb;
        private TextBox StaffPhoneTb;
        private TextBox StaffNameTb;
        private Button AddStaffBtn;
        private Button EditStaffBtn;
        private Button DeleteStaffBtn;
        private Button ResetStaffBtn;
        private DataGridView StaffDGV;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}