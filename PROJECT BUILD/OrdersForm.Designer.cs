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
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.Font = new Font("Tahoma", 9.25F);
            textBox1.Location = new Point(174, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 22);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLight;
            textBox2.Font = new Font("Tahoma", 9.25F);
            textBox2.Location = new Point(174, 309);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 200);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(114, 174);
            label1.Name = "label1";
            label1.Size = new Size(45, 23);
            label1.TabIndex = 2;
            label1.Text = "Имя";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlLight;
            textBox3.Font = new Font("Tahoma", 9.25F);
            textBox3.Location = new Point(174, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(243, 22);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ControlLight;
            textBox4.Font = new Font("Tahoma", 9.25F);
            textBox4.Location = new Point(174, 230);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(243, 22);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ControlLight;
            textBox5.Font = new Font("Tahoma", 9.25F);
            textBox5.Location = new Point(174, 258);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(243, 22);
            textBox5.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F);
            label2.Location = new Point(75, 202);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 7;
            label2.Text = "Фамилия ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F);
            label3.Location = new Point(97, 229);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 8;
            label3.Text = "Почта";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14.25F);
            label5.Location = new Point(-2, 257);
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
            label4.Location = new Point(140, 41);
            label4.Name = "label4";
            label4.Size = new Size(315, 35);
            label4.TabIndex = 11;
            label4.Text = "Составление заказа";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14.25F);
            label6.Location = new Point(-2, 309);
            label6.Name = "label6";
            label6.Size = new Size(172, 23);
            label6.TabIndex = 12;
            label6.Text = "Описание проекта";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Tahoma", 14.25F);
            button1.Location = new Point(174, 520);
            button1.Name = "button1";
            button1.Size = new Size(243, 60);
            button1.TabIndex = 13;
            button1.Text = "Оставить заяку";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(556, 592);
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
            Name = "OrdersForm";
            Text = "Order";
            Load += OrdersForm_Load;
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
    }
}