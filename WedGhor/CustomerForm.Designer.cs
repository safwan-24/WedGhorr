namespace WedGhor
{
    partial class CustomerForm
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
            label6 = new Label();
            label5 = new Label();
            CustomerDGV = new DataGridView();
            ResetStaffBtn = new Button();
            CustomerDeleteBtn = new Button();
            EditCustomerBtn = new Button();
            AddStaffBtn = new Button();
            CustNameTb = new TextBox();
            CustPasswordTb = new TextBox();
            CustEmailTb = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(614, 3);
            label6.Name = "label6";
            label6.Size = new Size(19, 20);
            label6.TabIndex = 29;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(426, 45);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 28;
            label5.Text = "Customer Password";
            label5.Click += label5_Click;
            // 
            // CustomerDGV
            // 
            CustomerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDGV.Location = new Point(22, 168);
            CustomerDGV.Name = "CustomerDGV";
            CustomerDGV.RowHeadersWidth = 51;
            CustomerDGV.Size = new Size(598, 135);
            CustomerDGV.TabIndex = 27;
            CustomerDGV.CellClick += CustomerDGV_CellContentClick;
            CustomerDGV.CellContentClick += CustomerDGV_CellContentClick;
            // 
            // ResetStaffBtn
            // 
            ResetStaffBtn.BackColor = Color.Black;
            ResetStaffBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ResetStaffBtn.ForeColor = Color.White;
            ResetStaffBtn.Location = new Point(526, 130);
            ResetStaffBtn.Name = "ResetStaffBtn";
            ResetStaffBtn.Size = new Size(94, 29);
            ResetStaffBtn.TabIndex = 26;
            ResetStaffBtn.Text = "Reset";
            ResetStaffBtn.UseVisualStyleBackColor = false;
            ResetStaffBtn.Click += ResetStaffBtn_Click;
            // 
            // CustomerDeleteBtn
            // 
            CustomerDeleteBtn.BackColor = Color.Black;
            CustomerDeleteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CustomerDeleteBtn.ForeColor = Color.White;
            CustomerDeleteBtn.Location = new Point(360, 130);
            CustomerDeleteBtn.Name = "CustomerDeleteBtn";
            CustomerDeleteBtn.Size = new Size(112, 29);
            CustomerDeleteBtn.TabIndex = 25;
            CustomerDeleteBtn.Text = "Delete Customer";
            CustomerDeleteBtn.UseVisualStyleBackColor = false;
            CustomerDeleteBtn.Click += DeleteStaffBtn_Click;
            // 
            // EditCustomerBtn
            // 
            EditCustomerBtn.BackColor = Color.Black;
            EditCustomerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EditCustomerBtn.ForeColor = Color.White;
            EditCustomerBtn.Location = new Point(197, 130);
            EditCustomerBtn.Name = "EditCustomerBtn";
            EditCustomerBtn.Size = new Size(94, 29);
            EditCustomerBtn.TabIndex = 24;
            EditCustomerBtn.Text = "Edit Customer";
            EditCustomerBtn.UseVisualStyleBackColor = false;
            EditCustomerBtn.Click += EditCustomerBtn_Click;
            // 
            // AddStaffBtn
            // 
            AddStaffBtn.BackColor = Color.Black;
            AddStaffBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AddStaffBtn.ForeColor = Color.White;
            AddStaffBtn.Location = new Point(22, 130);
            AddStaffBtn.Name = "AddStaffBtn";
            AddStaffBtn.Size = new Size(112, 29);
            AddStaffBtn.TabIndex = 23;
            AddStaffBtn.Text = "Add Customer";
            AddStaffBtn.UseVisualStyleBackColor = false;
            AddStaffBtn.Click += AddStaffBtn_Click;
            // 
            // CustNameTb
            // 
            CustNameTb.Location = new Point(73, 82);
            CustNameTb.Name = "CustNameTb";
            CustNameTb.Size = new Size(125, 27);
            CustNameTb.TabIndex = 22;
            // 
            // CustPasswordTb
            // 
            CustPasswordTb.Location = new Point(437, 82);
            CustPasswordTb.Name = "CustPasswordTb";
            CustPasswordTb.Size = new Size(125, 27);
            CustPasswordTb.TabIndex = 21;
            // 
            // CustEmailTb
            // 
            CustEmailTb.Location = new Point(259, 82);
            CustEmailTb.Name = "CustEmailTb";
            CustEmailTb.Size = new Size(125, 27);
            CustEmailTb.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(257, 45);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 18;
            label4.Text = "Customer Email";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(73, 45);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 16;
            label2.Text = "Customer Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 3);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 15;
            label1.Text = "Customer";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(539, 309);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 30;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(645, 350);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(CustomerDGV);
            Controls.Add(ResetStaffBtn);
            Controls.Add(CustomerDeleteBtn);
            Controls.Add(EditCustomerBtn);
            Controls.Add(AddStaffBtn);
            Controls.Add(CustNameTb);
            Controls.Add(CustPasswordTb);
            Controls.Add(CustEmailTb);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private DataGridView CustomerDGV;
        private Button ResetStaffBtn;
        private Button CustomerDeleteBtn;
        private Button EditCustomerBtn;
        private Button AddStaffBtn;
        private TextBox CustNameTb;
        private TextBox CustPasswordTb;
        private TextBox CustEmailTb;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}