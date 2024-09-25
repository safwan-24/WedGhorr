namespace WedGhor
{
    partial class BookingForm
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
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            PersonTb = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            textBox8 = new TextBox();
            label10 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            CokeQty = new TextBox();
            label9 = new Label();
            WaterQty = new TextBox();
            CocktailQty = new TextBox();
            CokePrice = new TextBox();
            CocktailPrice = new TextBox();
            WaterPrice = new TextBox();
            CocktailCb = new CheckBox();
            CokeCb = new CheckBox();
            WaterCb = new CheckBox();
            DrinkCostLbl = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            button2 = new Button();
            groupBox4 = new GroupBox();
            textBox14 = new TextBox();
            label15 = new Label();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            textBox18 = new TextBox();
            textBox19 = new TextBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            ChickenQty = new TextBox();
            label20 = new Label();
            MuttonQty = new TextBox();
            BeefQty = new TextBox();
            ChickenPrice = new TextBox();
            BeefPrice = new TextBox();
            MuttonPrice = new TextBox();
            BeefCb = new CheckBox();
            ChickenCb = new CheckBox();
            MuttonCb = new CheckBox();
            BiriyaniCostLbl = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            groupBox5 = new GroupBox();
            GridTotalTb = new TextBox();
            label21 = new Label();
            label8 = new Label();
            AddBookingBtn = new Button();
            button4 = new Button();
            label25 = new Label();
            label4 = new Label();
            label26 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(21, 38);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "Shift";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(19, 70);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Person";
            label3.Click += label3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(77, 9);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Day ", "Night" });
            comboBox1.Location = new Point(77, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // PersonTb
            // 
            PersonTb.Location = new Point(77, 70);
            PersonTb.Name = "PersonTb";
            PersonTb.Size = new Size(125, 27);
            PersonTb.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Thistle;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(CokeQty);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(WaterQty);
            groupBox1.Controls.Add(CocktailQty);
            groupBox1.Controls.Add(CokePrice);
            groupBox1.Controls.Add(CocktailPrice);
            groupBox1.Controls.Add(WaterPrice);
            groupBox1.Controls.Add(CocktailCb);
            groupBox1.Controls.Add(CokeCb);
            groupBox1.Controls.Add(WaterCb);
            groupBox1.Controls.Add(DrinkCostLbl);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(21, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 172);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(13, 133);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(textBox11);
            groupBox2.Controls.Add(textBox12);
            groupBox2.Controls.Add(textBox13);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox6);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Location = new Point(0, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 172);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(215, 74);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(85, 27);
            textBox8.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(140, 13);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 13;
            label10.Text = "Price";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(215, 44);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(85, 27);
            textBox9.TabIndex = 10;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(215, 104);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(85, 27);
            textBox10.TabIndex = 12;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(129, 74);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(78, 27);
            textBox11.TabIndex = 9;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(129, 104);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(78, 27);
            textBox12.TabIndex = 8;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(129, 44);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(78, 27);
            textBox13.TabIndex = 7;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 107);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(101, 24);
            checkBox4.TabIndex = 6;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 77);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(101, 24);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "checkBox5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(6, 47);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(101, 24);
            checkBox6.TabIndex = 4;
            checkBox6.Text = "checkBox6";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(129, 137);
            label11.Name = "label11";
            label11.Size = new Size(77, 20);
            label11.TabIndex = 3;
            label11.Text = "Drink Cost";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(215, 13);
            label12.Name = "label12";
            label12.Size = new Size(65, 20);
            label12.TabIndex = 2;
            label12.Text = "Quantity";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(117, 13);
            label13.Name = "label13";
            label13.Size = new Size(0, 20);
            label13.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(24, 13);
            label14.Name = "label14";
            label14.Size = new Size(77, 20);
            label14.TabIndex = 0;
            label14.Text = "Baverages";
            // 
            // CokeQty
            // 
            CokeQty.Location = new Point(215, 74);
            CokeQty.Name = "CokeQty";
            CokeQty.Size = new Size(85, 27);
            CokeQty.TabIndex = 11;
            CokeQty.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(140, 13);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 13;
            label9.Text = "Price";
            // 
            // WaterQty
            // 
            WaterQty.Location = new Point(215, 44);
            WaterQty.Name = "WaterQty";
            WaterQty.Size = new Size(85, 27);
            WaterQty.TabIndex = 10;
            WaterQty.Text = "0";
            // 
            // CocktailQty
            // 
            CocktailQty.Location = new Point(215, 104);
            CocktailQty.Name = "CocktailQty";
            CocktailQty.Size = new Size(85, 27);
            CocktailQty.TabIndex = 12;
            CocktailQty.Text = "0";
            // 
            // CokePrice
            // 
            CokePrice.Location = new Point(129, 74);
            CokePrice.Name = "CokePrice";
            CokePrice.Size = new Size(78, 27);
            CokePrice.TabIndex = 9;
            CokePrice.Text = "30";
            // 
            // CocktailPrice
            // 
            CocktailPrice.Location = new Point(129, 104);
            CocktailPrice.Name = "CocktailPrice";
            CocktailPrice.Size = new Size(78, 27);
            CocktailPrice.TabIndex = 8;
            CocktailPrice.Text = "100";
            // 
            // WaterPrice
            // 
            WaterPrice.Location = new Point(129, 44);
            WaterPrice.Name = "WaterPrice";
            WaterPrice.Size = new Size(78, 27);
            WaterPrice.TabIndex = 7;
            WaterPrice.Text = "15";
            // 
            // CocktailCb
            // 
            CocktailCb.AutoSize = true;
            CocktailCb.Location = new Point(6, 107);
            CocktailCb.Name = "CocktailCb";
            CocktailCb.Size = new Size(84, 24);
            CocktailCb.TabIndex = 6;
            CocktailCb.Text = "Cocktail";
            CocktailCb.UseVisualStyleBackColor = true;
            CocktailCb.CheckedChanged += CocktailCb_CheckedChanged;
            // 
            // CokeCb
            // 
            CokeCb.AutoSize = true;
            CokeCb.Location = new Point(6, 77);
            CokeCb.Name = "CokeCb";
            CokeCb.Size = new Size(64, 24);
            CokeCb.TabIndex = 5;
            CokeCb.Text = "Coke";
            CokeCb.UseVisualStyleBackColor = true;
            CokeCb.CheckedChanged += CokeCb_CheckedChanged;
            // 
            // WaterCb
            // 
            WaterCb.AutoSize = true;
            WaterCb.Location = new Point(6, 47);
            WaterCb.Name = "WaterCb";
            WaterCb.Size = new Size(70, 24);
            WaterCb.TabIndex = 4;
            WaterCb.Text = "Water";
            WaterCb.UseVisualStyleBackColor = true;
            WaterCb.CheckedChanged += WaterCb_CheckedChanged;
            // 
            // DrinkCostLbl
            // 
            DrinkCostLbl.AutoSize = true;
            DrinkCostLbl.Location = new Point(129, 137);
            DrinkCostLbl.Name = "DrinkCostLbl";
            DrinkCostLbl.Size = new Size(77, 20);
            DrinkCostLbl.TabIndex = 3;
            DrinkCostLbl.Text = "Drink Cost";
            DrinkCostLbl.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(215, 13);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 2;
            label7.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 13);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 13);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 0;
            label5.Text = "Baverages";
            label5.Click += label5_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Thistle;
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(ChickenQty);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(MuttonQty);
            groupBox3.Controls.Add(BeefQty);
            groupBox3.Controls.Add(ChickenPrice);
            groupBox3.Controls.Add(BeefPrice);
            groupBox3.Controls.Add(MuttonPrice);
            groupBox3.Controls.Add(BeefCb);
            groupBox3.Controls.Add(ChickenCb);
            groupBox3.Controls.Add(MuttonCb);
            groupBox3.Controls.Add(BiriyaniCostLbl);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(label24);
            groupBox3.Location = new Point(369, 134);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(306, 172);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(13, 133);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "Calculate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox14);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(textBox15);
            groupBox4.Controls.Add(textBox16);
            groupBox4.Controls.Add(textBox17);
            groupBox4.Controls.Add(textBox18);
            groupBox4.Controls.Add(textBox19);
            groupBox4.Controls.Add(checkBox7);
            groupBox4.Controls.Add(checkBox8);
            groupBox4.Controls.Add(checkBox9);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label19);
            groupBox4.Location = new Point(0, 178);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(306, 172);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(215, 74);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(85, 27);
            textBox14.TabIndex = 11;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(140, 13);
            label15.Name = "label15";
            label15.Size = new Size(41, 20);
            label15.TabIndex = 13;
            label15.Text = "Price";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(215, 44);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(85, 27);
            textBox15.TabIndex = 10;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(215, 104);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(85, 27);
            textBox16.TabIndex = 12;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(129, 74);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(78, 27);
            textBox17.TabIndex = 9;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(129, 104);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(78, 27);
            textBox18.TabIndex = 8;
            // 
            // textBox19
            // 
            textBox19.Location = new Point(129, 44);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(78, 27);
            textBox19.TabIndex = 7;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(6, 107);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(101, 24);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "checkBox7";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(6, 77);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(101, 24);
            checkBox8.TabIndex = 5;
            checkBox8.Text = "checkBox8";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(6, 47);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(101, 24);
            checkBox9.TabIndex = 4;
            checkBox9.Text = "checkBox9";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(129, 137);
            label16.Name = "label16";
            label16.Size = new Size(77, 20);
            label16.TabIndex = 3;
            label16.Text = "Drink Cost";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(215, 13);
            label17.Name = "label17";
            label17.Size = new Size(65, 20);
            label17.TabIndex = 2;
            label17.Text = "Quantity";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(117, 13);
            label18.Name = "label18";
            label18.Size = new Size(0, 20);
            label18.TabIndex = 1;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(24, 13);
            label19.Name = "label19";
            label19.Size = new Size(77, 20);
            label19.TabIndex = 0;
            label19.Text = "Baverages";
            // 
            // ChickenQty
            // 
            ChickenQty.Location = new Point(215, 74);
            ChickenQty.Name = "ChickenQty";
            ChickenQty.Size = new Size(85, 27);
            ChickenQty.TabIndex = 11;
            ChickenQty.Text = "0";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(140, 13);
            label20.Name = "label20";
            label20.Size = new Size(41, 20);
            label20.TabIndex = 13;
            label20.Text = "Price";
            // 
            // MuttonQty
            // 
            MuttonQty.Location = new Point(215, 44);
            MuttonQty.Name = "MuttonQty";
            MuttonQty.Size = new Size(85, 27);
            MuttonQty.TabIndex = 10;
            MuttonQty.Text = "0";
            // 
            // BeefQty
            // 
            BeefQty.Location = new Point(215, 104);
            BeefQty.Name = "BeefQty";
            BeefQty.Size = new Size(85, 27);
            BeefQty.TabIndex = 12;
            BeefQty.Text = "0";
            // 
            // ChickenPrice
            // 
            ChickenPrice.Location = new Point(129, 74);
            ChickenPrice.Name = "ChickenPrice";
            ChickenPrice.Size = new Size(78, 27);
            ChickenPrice.TabIndex = 9;
            ChickenPrice.Text = "200";
            // 
            // BeefPrice
            // 
            BeefPrice.Location = new Point(129, 104);
            BeefPrice.Name = "BeefPrice";
            BeefPrice.Size = new Size(78, 27);
            BeefPrice.TabIndex = 8;
            BeefPrice.Text = "300";
            // 
            // MuttonPrice
            // 
            MuttonPrice.Location = new Point(129, 44);
            MuttonPrice.Name = "MuttonPrice";
            MuttonPrice.Size = new Size(78, 27);
            MuttonPrice.TabIndex = 7;
            MuttonPrice.Text = "250";
            // 
            // BeefCb
            // 
            BeefCb.AutoSize = true;
            BeefCb.Location = new Point(6, 107);
            BeefCb.Name = "BeefCb";
            BeefCb.Size = new Size(61, 24);
            BeefCb.TabIndex = 6;
            BeefCb.Text = "Beef";
            BeefCb.UseVisualStyleBackColor = true;
            BeefCb.CheckedChanged += checkBox10_CheckedChanged;
            // 
            // ChickenCb
            // 
            ChickenCb.AutoSize = true;
            ChickenCb.Location = new Point(6, 77);
            ChickenCb.Name = "ChickenCb";
            ChickenCb.Size = new Size(82, 24);
            ChickenCb.TabIndex = 5;
            ChickenCb.Text = "Chicken";
            ChickenCb.UseVisualStyleBackColor = true;
            ChickenCb.CheckedChanged += ChickenCb_CheckedChanged;
            // 
            // MuttonCb
            // 
            MuttonCb.AutoSize = true;
            MuttonCb.Location = new Point(6, 47);
            MuttonCb.Name = "MuttonCb";
            MuttonCb.Size = new Size(79, 24);
            MuttonCb.TabIndex = 4;
            MuttonCb.Text = "Mutton";
            MuttonCb.UseVisualStyleBackColor = true;
            MuttonCb.CheckedChanged += MuttonCb_CheckedChanged;
            // 
            // BiriyaniCostLbl
            // 
            BiriyaniCostLbl.AutoSize = true;
            BiriyaniCostLbl.Location = new Point(129, 137);
            BiriyaniCostLbl.Name = "BiriyaniCostLbl";
            BiriyaniCostLbl.Size = new Size(91, 20);
            BiriyaniCostLbl.TabIndex = 3;
            BiriyaniCostLbl.Text = "Biriyani Cost";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(215, 13);
            label22.Name = "label22";
            label22.Size = new Size(65, 20);
            label22.TabIndex = 2;
            label22.Text = "Quantity";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(117, 13);
            label23.Name = "label23";
            label23.Size = new Size(0, 20);
            label23.TabIndex = 1;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(24, 13);
            label24.Name = "label24";
            label24.Size = new Size(58, 20);
            label24.TabIndex = 0;
            label24.Text = "Biriyani";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Thistle;
            groupBox5.Controls.Add(GridTotalTb);
            groupBox5.Controls.Add(label21);
            groupBox5.Controls.Add(label8);
            groupBox5.Location = new Point(197, 325);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(306, 74);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            // 
            // GridTotalTb
            // 
            GridTotalTb.Location = new Point(142, 41);
            GridTotalTb.Name = "GridTotalTb";
            GridTotalTb.Size = new Size(125, 27);
            GridTotalTb.TabIndex = 2;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(34, 44);
            label21.Name = "label21";
            label21.Size = new Size(86, 20);
            label21.TabIndex = 1;
            label21.Text = "Grand Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(110, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 0;
            label8.Text = "Payments";
            // 
            // AddBookingBtn
            // 
            AddBookingBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBookingBtn.Location = new Point(581, 360);
            AddBookingBtn.Name = "AddBookingBtn";
            AddBookingBtn.Size = new Size(94, 29);
            AddBookingBtn.TabIndex = 17;
            AddBookingBtn.Text = "Add Booking";
            AddBookingBtn.UseVisualStyleBackColor = true;
            AddBookingBtn.Click += AddBookingBtn_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(21, 360);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 18;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(683, 9);
            label25.Name = "label25";
            label25.Size = new Size(19, 20);
            label25.TabIndex = 19;
            label25.Text = "X";
            label25.Click += label25_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Algerian", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.HotPink;
            label4.Location = new Point(65, 105);
            label4.Name = "label4";
            label4.Size = new Size(191, 19);
            label4.TabIndex = 20;
            label4.Text = "Select Baverages";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Algerian", 10.2F, FontStyle.Bold);
            label26.ForeColor = Color.HotPink;
            label26.Location = new Point(441, 105);
            label26.Name = "label26";
            label26.Size = new Size(159, 19);
            label26.TabIndex = 21;
            label26.Text = "Select Biriyani";
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(713, 423);
            Controls.Add(label26);
            Controls.Add(label4);
            Controls.Add(label25);
            Controls.Add(button4);
            Controls.Add(AddBookingBtn);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(PersonTb);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookingForm";
            Load += BookingForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TextBox PersonTb;
        private ComboBox CustIdCb;
        private GroupBox groupBox1;
        private CheckBox CocktailCb;
        private CheckBox CokeCb;
        private CheckBox WaterCb;
        private Label DrinkCostLbl;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox WaterPrice;
        private TextBox CokeQty;
        private Label label9;
        private TextBox WaterQty;
        private TextBox CocktailQty;
        private TextBox CokePrice;
        private TextBox CocktailPrice;
        private GroupBox groupBox2;
        private TextBox textBox8;
        private Label label10;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox textBox14;
        private Label label15;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox ChickenQty;
        private Label label20;
        private TextBox MuttonQty;
        private TextBox BeefQty;
        private TextBox ChickenPrice;
        private TextBox BeefPrice;
        private TextBox MuttonPrice;
        private CheckBox BeefCb;
        private CheckBox ChickenCb;
        private CheckBox MuttonCb;
        private Label BiriyaniCostLbl;
        private Label label22;
        private Label label23;
        private Label label24;
        private Button button1;
        private Button button2;
        private GroupBox groupBox5;
        private Label label21;
        private Label label8;
        private TextBox GridTotalTb;
        private Button AddBookingBtn;
        private Button button4;
        private Label label25;
        private Label label26;
    }
}