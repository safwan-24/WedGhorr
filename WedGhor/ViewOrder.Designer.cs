namespace WedGhor
{
    partial class ViewOrder
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
            DeleteBtn = new Button();
            button1 = new Button();
            label1 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            MuttonQtyTb = new TextBox();
            TotalCostTb = new TextBox();
            BeefQtyTb = new TextBox();
            label5 = new Label();
            ViewOrderDGV = new DataGridView();
            EditBtn = new Button();
            CokeQtyTb = new TextBox();
            ChickenQtyTb = new TextBox();
            WaterQtyTb = new TextBox();
            CocktailQtyTb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)ViewOrderDGV).BeginInit();
            SuspendLayout();
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Black;
            DeleteBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(172, 234);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(122, 29);
            DeleteBtn.TabIndex = 72;
            DeleteBtn.Text = "Delete Order";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(779, 234);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 71;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 70;
            label1.Text = "View Order";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(942, 105);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 69;
            label8.Text = "Total Cost";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(798, 105);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 68;
            label7.Text = "Beef Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(641, 105);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 67;
            label6.Text = "Mutton Quantity";
            // 
            // MuttonQtyTb
            // 
            MuttonQtyTb.Location = new Point(624, 138);
            MuttonQtyTb.Name = "MuttonQtyTb";
            MuttonQtyTb.Size = new Size(125, 27);
            MuttonQtyTb.TabIndex = 66;
            // 
            // TotalCostTb
            // 
            TotalCostTb.Location = new Point(929, 138);
            TotalCostTb.Name = "TotalCostTb";
            TotalCostTb.Size = new Size(125, 27);
            TotalCostTb.TabIndex = 65;
            // 
            // BeefQtyTb
            // 
            BeefQtyTb.Location = new Point(779, 138);
            BeefQtyTb.Name = "BeefQtyTb";
            BeefQtyTb.Size = new Size(125, 27);
            BeefQtyTb.TabIndex = 64;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(464, 105);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 63;
            label5.Text = "Chicken Quantity";
            // 
            // ViewOrderDGV
            // 
            ViewOrderDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewOrderDGV.Location = new Point(15, 287);
            ViewOrderDGV.Name = "ViewOrderDGV";
            ViewOrderDGV.RowHeadersWidth = 51;
            ViewOrderDGV.Size = new Size(1039, 135);
            ViewOrderDGV.TabIndex = 62;
            ViewOrderDGV.CellClick += dataGridView1_CellContentClick;
            ViewOrderDGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Black;
            EditBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(476, 234);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(94, 29);
            EditBtn.TabIndex = 61;
            EditBtn.Text = "Edit Order";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // CokeQtyTb
            // 
            CokeQtyTb.Location = new Point(21, 138);
            CokeQtyTb.Name = "CokeQtyTb";
            CokeQtyTb.Size = new Size(125, 27);
            CokeQtyTb.TabIndex = 60;
            // 
            // ChickenQtyTb
            // 
            ChickenQtyTb.Location = new Point(476, 138);
            ChickenQtyTb.Name = "ChickenQtyTb";
            ChickenQtyTb.Size = new Size(125, 27);
            ChickenQtyTb.TabIndex = 59;
            // 
            // WaterQtyTb
            // 
            WaterQtyTb.Location = new Point(332, 138);
            WaterQtyTb.Name = "WaterQtyTb";
            WaterQtyTb.Size = new Size(125, 27);
            WaterQtyTb.TabIndex = 58;
            // 
            // CocktailQtyTb
            // 
            CocktailQtyTb.Location = new Point(172, 138);
            CocktailQtyTb.Name = "CocktailQtyTb";
            CocktailQtyTb.Size = new Size(125, 27);
            CocktailQtyTb.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(332, 105);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 56;
            label4.Text = "Water Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(172, 105);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 55;
            label3.Text = "Cocktail Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(21, 105);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 54;
            label2.Text = "Coke Quantity";
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(838, 500);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 73;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1058, 9);
            label9.Name = "label9";
            label9.Size = new Size(18, 20);
            label9.TabIndex = 74;
            label9.Text = "X";
            label9.Click += label9_Click;
            // 
            // ViewOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1088, 623);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(DeleteBtn);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(MuttonQtyTb);
            Controls.Add(TotalCostTb);
            Controls.Add(BeefQtyTb);
            Controls.Add(label5);
            Controls.Add(ViewOrderDGV);
            Controls.Add(EditBtn);
            Controls.Add(CokeQtyTb);
            Controls.Add(ChickenQtyTb);
            Controls.Add(WaterQtyTb);
            Controls.Add(CocktailQtyTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewOrder";
            Load += ViewOrder_Load;
            ((System.ComponentModel.ISupportInitialize)ViewOrderDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteBtn;
        private Button button1;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox MuttonQtyTb;
        private TextBox TotalCostTb;
        private TextBox BeefQtyTb;
        private Label label5;
        private DataGridView ViewOrderDGV;
        private Button EditBtn;
        private TextBox CokeQtyTb;
        private TextBox ChickenQtyTb;
        private TextBox WaterQtyTb;
        private TextBox CocktailQtyTb;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Label label9;
    }
}