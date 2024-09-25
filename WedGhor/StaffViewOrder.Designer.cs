namespace WedGhor
{
    partial class StaffViewOrder
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
            label5 = new Label();
            ViewOrderDGV = new DataGridView();
            ResetStaffBtn = new Button();
            CokeQtyTb = new TextBox();
            ChickenQtyTb = new TextBox();
            WaterQtyTb = new TextBox();
            CocktailQtyTb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            MuttonQtyTb = new TextBox();
            TotalCostTb = new TextBox();
            BeefQtyTb = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label1 = new Label();
            BackBtn = new Button();
            label9 = new Label();
            AddBtn = new Button();
            EditBtn = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ViewOrderDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(467, 61);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 26;
            label5.Text = "Chicken Quantity";
            // 
            // ViewOrderDGV
            // 
            ViewOrderDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewOrderDGV.Location = new Point(6, 195);
            ViewOrderDGV.Name = "ViewOrderDGV";
            ViewOrderDGV.RowHeadersWidth = 51;
            ViewOrderDGV.Size = new Size(1039, 135);
            ViewOrderDGV.TabIndex = 25;
            ViewOrderDGV.CellClick += dataGridView1_CellContentClick;
            ViewOrderDGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ResetStaffBtn
            // 
            ResetStaffBtn.BackColor = Color.Black;
            ResetStaffBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ResetStaffBtn.ForeColor = Color.White;
            ResetStaffBtn.Location = new Point(287, 146);
            ResetStaffBtn.Name = "ResetStaffBtn";
            ResetStaffBtn.Size = new Size(94, 29);
            ResetStaffBtn.TabIndex = 24;
            ResetStaffBtn.Text = "Reset";
            ResetStaffBtn.UseVisualStyleBackColor = false;
            ResetStaffBtn.Click += ResetStaffBtn_Click;
            // 
            // CokeQtyTb
            // 
            CokeQtyTb.Location = new Point(12, 94);
            CokeQtyTb.Name = "CokeQtyTb";
            CokeQtyTb.Size = new Size(125, 27);
            CokeQtyTb.TabIndex = 20;
            // 
            // ChickenQtyTb
            // 
            ChickenQtyTb.Location = new Point(467, 94);
            ChickenQtyTb.Name = "ChickenQtyTb";
            ChickenQtyTb.Size = new Size(125, 27);
            ChickenQtyTb.TabIndex = 19;
            // 
            // WaterQtyTb
            // 
            WaterQtyTb.Location = new Point(323, 94);
            WaterQtyTb.Name = "WaterQtyTb";
            WaterQtyTb.Size = new Size(125, 27);
            WaterQtyTb.TabIndex = 18;
            // 
            // CocktailQtyTb
            // 
            CocktailQtyTb.Location = new Point(163, 94);
            CocktailQtyTb.Name = "CocktailQtyTb";
            CocktailQtyTb.Size = new Size(125, 27);
            CocktailQtyTb.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(323, 61);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 16;
            label4.Text = "Water Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(163, 61);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 15;
            label3.Text = "Cocktail Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 14;
            label2.Text = "Coke Quantity";
            // 
            // MuttonQtyTb
            // 
            MuttonQtyTb.Location = new Point(615, 94);
            MuttonQtyTb.Name = "MuttonQtyTb";
            MuttonQtyTb.Size = new Size(125, 27);
            MuttonQtyTb.TabIndex = 30;
            // 
            // TotalCostTb
            // 
            TotalCostTb.Location = new Point(920, 94);
            TotalCostTb.Name = "TotalCostTb";
            TotalCostTb.Size = new Size(125, 27);
            TotalCostTb.TabIndex = 28;
            // 
            // BeefQtyTb
            // 
            BeefQtyTb.Location = new Point(770, 94);
            BeefQtyTb.Name = "BeefQtyTb";
            BeefQtyTb.Size = new Size(125, 27);
            BeefQtyTb.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(617, 61);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 31;
            label6.Text = "Mutton Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(770, 61);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 32;
            label7.Text = "Beef Quantity";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(933, 61);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 33;
            label8.Text = "Total Cost";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 34;
            label1.Text = "View Order";
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Black;
            BackBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(951, 582);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 29);
            BackBtn.TabIndex = 35;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1058, 9);
            label9.Name = "label9";
            label9.Size = new Size(19, 20);
            label9.TabIndex = 36;
            label9.Text = "X";
            label9.Click += label9_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Black;
            AddBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(67, 146);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 29);
            AddBtn.TabIndex = 38;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Black;
            EditBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(177, 146);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(94, 29);
            EditBtn.TabIndex = 39;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 371);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1039, 164);
            dataGridView2.TabIndex = 40;
            dataGridView2.CellClick += dataGridView2_CellContentClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // StaffViewOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(1088, 623);
            Controls.Add(dataGridView2);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(label9);
            Controls.Add(BackBtn);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(MuttonQtyTb);
            Controls.Add(TotalCostTb);
            Controls.Add(BeefQtyTb);
            Controls.Add(label5);
            Controls.Add(ViewOrderDGV);
            Controls.Add(ResetStaffBtn);
            Controls.Add(CokeQtyTb);
            Controls.Add(ChickenQtyTb);
            Controls.Add(WaterQtyTb);
            Controls.Add(CocktailQtyTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffViewOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Load += StaffViewOrder_Load;
            ((System.ComponentModel.ISupportInitialize)ViewOrderDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView ViewOrderDGV;
        private Button ResetStaffBtn;
        private TextBox CokeQtyTb;
        private TextBox ChickenQtyTb;
        private TextBox WaterQtyTb;
        private TextBox CocktailQtyTb;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox MuttonQtyTb;
        private TextBox TotalCostTb;
        private TextBox BeefQtyTb;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label1;
        private Button BackBtn;
        private Label label9;
        private Button AddBtn;
        private Button EditBtn;
        private DataGridView dataGridView2;
    }
}