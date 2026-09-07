namespace VerzosaLabActivity4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            cmbFood = new ComboBox();
            cmbDrink = new ComboBox();
            cmbDrinkQty = new ComboBox();
            cmbFoodQty = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            rdoDineIn = new RadioButton();
            rdoTakeOut = new RadioButton();
            rdoDelivery = new RadioButton();
            chkSenior = new CheckBox();
            txtPayment = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtSubtotal = new TextBox();
            label7 = new Label();
            txtTotal = new TextBox();
            label8 = new Label();
            txtDiscount = new TextBox();
            label9 = new Label();
            txtChange = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(325, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 49);
            textBox1.TabIndex = 0;
            textBox1.Text = "MENU";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(221, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Food";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(448, 78);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Drink";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbFood
            // 
            cmbFood.FormattingEnabled = true;
            cmbFood.Items.AddRange(new object[] { "Burger", "Chicken Sandwich", "Spaghetti", "French Fries" });
            cmbFood.Location = new Point(221, 116);
            cmbFood.Name = "cmbFood";
            cmbFood.Size = new Size(121, 23);
            cmbFood.TabIndex = 3;
            // 
            // cmbDrink
            // 
            cmbDrink.FormattingEnabled = true;
            cmbDrink.Items.AddRange(new object[] { "Soft Drink", "Iced Tea", "Coffee", "Bottled Water" });
            cmbDrink.Location = new Point(448, 116);
            cmbDrink.Name = "cmbDrink";
            cmbDrink.Size = new Size(121, 23);
            cmbDrink.TabIndex = 4;
            // 
            // cmbDrinkQty
            // 
            cmbDrinkQty.FormattingEnabled = true;
            cmbDrinkQty.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbDrinkQty.Location = new Point(448, 178);
            cmbDrinkQty.Name = "cmbDrinkQty";
            cmbDrinkQty.Size = new Size(100, 23);
            cmbDrinkQty.TabIndex = 6;
            // 
            // cmbFoodQty
            // 
            cmbFoodQty.FormattingEnabled = true;
            cmbFoodQty.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbFoodQty.Location = new Point(221, 178);
            cmbFoodQty.Name = "cmbFoodQty";
            cmbFoodQty.Size = new Size(100, 23);
            cmbFoodQty.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 142);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 8;
            label1.Text = "Select food";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(448, 142);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 9;
            label2.Text = "Select drink";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 204);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 10;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 204);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 11;
            label4.Text = "Quantity";
            // 
            // rdoDineIn
            // 
            rdoDineIn.AutoSize = true;
            rdoDineIn.Location = new Point(316, 254);
            rdoDineIn.Name = "rdoDineIn";
            rdoDineIn.Size = new Size(62, 19);
            rdoDineIn.TabIndex = 12;
            rdoDineIn.TabStop = true;
            rdoDineIn.Text = "Dine In";
            rdoDineIn.UseVisualStyleBackColor = true;
            // 
            // rdoTakeOut
            // 
            rdoTakeOut.AutoSize = true;
            rdoTakeOut.Location = new Point(430, 254);
            rdoTakeOut.Name = "rdoTakeOut";
            rdoTakeOut.Size = new Size(71, 19);
            rdoTakeOut.TabIndex = 13;
            rdoTakeOut.TabStop = true;
            rdoTakeOut.Text = "Take Out";
            rdoTakeOut.UseVisualStyleBackColor = true;
            // 
            // rdoDelivery
            // 
            rdoDelivery.AutoSize = true;
            rdoDelivery.Location = new Point(543, 254);
            rdoDelivery.Name = "rdoDelivery";
            rdoDelivery.Size = new Size(67, 19);
            rdoDelivery.TabIndex = 14;
            rdoDelivery.TabStop = true;
            rdoDelivery.Text = "Delivery";
            rdoDelivery.UseVisualStyleBackColor = true;
            // 
            // chkSenior
            // 
            chkSenior.AutoSize = true;
            chkSenior.Location = new Point(193, 254);
            chkSenior.Name = "chkSenior";
            chkSenior.Size = new Size(98, 19);
            chkSenior.TabIndex = 15;
            chkSenior.Text = "Senior Citizen";
            chkSenior.UseVisualStyleBackColor = true;
            // 
            // txtPayment
            // 
            txtPayment.Location = new Point(487, 373);
            txtPayment.Multiline = true;
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(121, 40);
            txtPayment.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(409, 376);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 17;
            label5.Text = "Payment:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 443);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 19;
            label6.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(221, 440);
            txtSubtotal.Multiline = true;
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(121, 37);
            txtSubtotal.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(143, 511);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 23;
            label7.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(221, 508);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(121, 37);
            txtTotal.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(409, 440);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 21;
            label8.Text = "Discount:";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(487, 437);
            txtDiscount.Multiline = true;
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(121, 40);
            txtDiscount.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(409, 511);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 25;
            label9.Text = "Change:";
            // 
            // txtChange
            // 
            txtChange.Location = new Point(487, 508);
            txtChange.Multiline = true;
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(121, 37);
            txtChange.TabIndex = 24;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.IndianRed;
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(221, 373);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(121, 40);
            btnCalculate.TabIndex = 26;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(828, 557);
            Controls.Add(btnCalculate);
            Controls.Add(label9);
            Controls.Add(txtChange);
            Controls.Add(label7);
            Controls.Add(txtTotal);
            Controls.Add(label8);
            Controls.Add(txtDiscount);
            Controls.Add(label6);
            Controls.Add(txtSubtotal);
            Controls.Add(label5);
            Controls.Add(txtPayment);
            Controls.Add(chkSenior);
            Controls.Add(rdoDelivery);
            Controls.Add(rdoTakeOut);
            Controls.Add(rdoDineIn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbFoodQty);
            Controls.Add(cmbDrinkQty);
            Controls.Add(cmbDrink);
            Controls.Add(cmbFood);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox cmbFood;
        private ComboBox cmbDrink;
        private ComboBox cmbDrinkQty;
        private ComboBox cmbFoodQty;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton rdoDineIn;
        private RadioButton rdoTakeOut;
        private RadioButton rdoDelivery;
        private CheckBox chkSenior;
        private TextBox txtPayment;
        private Label label5;
        private Label label6;
        private TextBox txtSubtotal;
        private Label label7;
        private TextBox txtTotal;
        private Label label8;
        private TextBox txtDiscount;
        private Label label9;
        private TextBox txtChange;
        private Button btnCalculate;
    }
}
