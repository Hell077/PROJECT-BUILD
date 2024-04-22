namespace PROJECT_BUILD
{
    partial class OrdersForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            totalPriceTextBox = new TextBox();
            button2 = new Button();
            label10 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.Font = new Font("Tahoma", 9.25F);
            textBox1.Location = new Point(174, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 22);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLight;
            textBox2.Font = new Font("Tahoma", 9.25F);
            textBox2.Location = new Point(174, 250);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 213);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(27, 126);
            label1.Name = "label1";
            label1.Size = new Size(45, 23);
            label1.TabIndex = 2;
            label1.Text = "Имя";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlLight;
            textBox3.Font = new Font("Tahoma", 9.25F);
            textBox3.Location = new Point(174, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(243, 22);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ControlLight;
            textBox4.Font = new Font("Tahoma", 9.25F);
            textBox4.Location = new Point(174, 190);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(243, 22);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ControlLight;
            textBox5.Font = new Font("Tahoma", 9.25F);
            textBox5.Location = new Point(174, 220);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(243, 22);
            textBox5.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F);
            label2.Location = new Point(27, 160);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 7;
            label2.Text = "Фамилия ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F);
            label3.Location = new Point(27, 186);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 8;
            label3.Text = "Почта";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14.25F);
            label5.Location = new Point(-4, 214);
            label5.Name = "label5";
            label5.Size = new Size(170, 23);
            label5.TabIndex = 10;
            label5.Text = "Название проекта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(140, 44);
            label4.Name = "label4";
            label4.Size = new Size(315, 35);
            label4.TabIndex = 11;
            label4.Text = "Составление заказа";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14.25F);
            label6.Location = new Point(-4, 239);
            label6.Name = "label6";
            label6.Size = new Size(172, 23);
            label6.TabIndex = 12;
            label6.Text = "Описание проекта";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Tahoma", 14.25F);
            button1.Location = new Point(174, 543);
            button1.Name = "button1";
            button1.Size = new Size(243, 64);
            button1.TabIndex = 13;
            button1.Text = "Оставить заяку";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 14.25F);
            label7.Location = new Point(11, 465);
            label7.Name = "label7";
            label7.Size = new Size(148, 23);
            label7.TabIndex = 15;
            label7.Text = "Площадь в м^2";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = SystemColors.ControlLight;
            maskedTextBox1.Location = new Point(174, 469);
            maskedTextBox1.Mask = "00000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(243, 24);
            maskedTextBox1.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Обычный", "Средний", "Элитный" });
            comboBox1.BackColor = SystemColors.ControlLight;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Обычный", "Средний", "Элитный" });
            comboBox1.Location = new Point(174, 500);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(243, 24);
            comboBox1.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 14.25F);
            label8.Location = new Point(11, 500);
            label8.Name = "label8";
            label8.Size = new Size(162, 23);
            label8.TabIndex = 18;
            label8.Text = "Ремонт квартиры";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 14.25F);
            label9.Location = new Point(6, 20);
            label9.Name = "label9";
            label9.Size = new Size(217, 23);
            label9.TabIndex = 19;
            label9.Text = "Калькулятор стоимости";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(totalPriceTextBox);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(465, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 195);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // totalPriceTextBox
            // 
            totalPriceTextBox.BackColor = SystemColors.ControlLight;
            totalPriceTextBox.Font = new Font("Tahoma", 9.25F);
            totalPriceTextBox.Location = new Point(63, 63);
            totalPriceTextBox.Name = "totalPriceTextBox";
            totalPriceTextBox.ReadOnly = true;
            totalPriceTextBox.Size = new Size(160, 22);
            totalPriceTextBox.TabIndex = 21;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 14F);
            button2.Location = new Point(6, 151);
            button2.Name = "button2";
            button2.Size = new Size(176, 37);
            button2.TabIndex = 22;
            button2.Text = "Расчёт стоимости";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 14.25F);
            label10.Location = new Point(6, 59);
            label10.Name = "label10";
            label10.Size = new Size(61, 23);
            label10.TabIndex = 21;
            label10.Text = "Цена:";
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(726, 631);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Tahoma", 10F);
            Name = "OrdersForm";
            Text = "Order";
            Load += OrdersForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Button button1;
        private Label label7;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox1;
        private Label label8;
        private Label label9;
        private GroupBox groupBox1;
        private Button button2;
        private Label label10;
        private TextBox totalPriceTextBox;
    }
}