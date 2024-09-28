namespace WedGhor
{
    partial class CustomerTrackOrder
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
            dataGridView1 = new DataGridView();
            Search = new Button();
            AddBtn = new Button();
            label1 = new Label();
            Confirm = new Button();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(589, 83);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Search
            // 
            Search.BackColor = Color.Black;
            Search.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Search.ForeColor = Color.White;
            Search.Location = new Point(56, 131);
            Search.Name = "Search";
            Search.Size = new Size(94, 29);
            Search.TabIndex = 1;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = false;
            Search.Click += Search_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Black;
            AddBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(370, 154);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 29);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Add New";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 294);
            label1.Name = "label1";
            label1.Size = new Size(345, 20);
            label1.TabIndex = 3;
            label1.Text = "If you don't confirm, your booking will be removed";
            // 
            // Confirm
            // 
            Confirm.BackColor = Color.Black;
            Confirm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Confirm.ForeColor = Color.White;
            Confirm.Location = new Point(479, 154);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(120, 29);
            Confirm.TabIndex = 4;
            Confirm.Text = "Confirm Now";
            Confirm.UseVisualStyleBackColor = false;
            Confirm.Click += Confirm_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(505, 282);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(580, 9);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 6;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(183, 19);
            label3.Name = "label3";
            label3.Size = new Size(235, 25);
            label3.TabIndex = 8;
            label3.Text = "see your booking";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 89);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 9;
            label4.Text = "Booking Id";
            // 
            // CustomerTrackOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(613, 323);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(Confirm);
            Controls.Add(label1);
            Controls.Add(AddBtn);
            Controls.Add(Search);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerTrackOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerTrackOrder";
            Load += CustomerTrackOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Search;
        private Button AddBtn;
        private Label label1;
        private Button Confirm;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
    }
}