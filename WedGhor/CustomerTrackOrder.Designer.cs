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
            Search.Location = new Point(15, 154);
            Search.Name = "Search";
            Search.Size = new Size(94, 29);
            Search.TabIndex = 1;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(280, 154);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 29);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Add New";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 294);
            label1.Name = "label1";
            label1.Size = new Size(345, 20);
            label1.TabIndex = 3;
            label1.Text = "If you don't confirm, your booking will be removed";
            // 
            // Confirm
            // 
            Confirm.Location = new Point(380, 154);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(120, 29);
            Confirm.TabIndex = 4;
            Confirm.Text = "Confirm Now";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += Confirm_Click;
            // 
            // button1
            // 
            button1.Location = new Point(506, 154);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(580, 4);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 6;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // CustomerTrackOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(613, 323);
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
    }
}