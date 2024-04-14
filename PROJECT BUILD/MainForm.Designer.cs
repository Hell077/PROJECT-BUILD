namespace PROJECT_BUILD
{
    partial class MainForm
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
            groupBox1 = new GroupBox();
            button3 = new Button();
            label2 = new Label();
            button6 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12.25F, FontStyle.Bold);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(12, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(756, 579);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(215, 394);
            button3.Name = "button3";
            button3.Size = new Size(300, 69);
            button3.TabIndex = 7;
            button3.Text = "Таблица заказов";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12.25F, FontStyle.Bold);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 6;
            label2.Text = "Admin панель";
            // 
            // button6
            // 
            button6.Location = new Point(215, 22);
            button6.Name = "button6";
            button6.Size = new Size(300, 69);
            button6.TabIndex = 5;
            button6.Text = "Сделать заказ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(215, 319);
            button2.Name = "button2";
            button2.Size = new Size(300, 69);
            button2.TabIndex = 1;
            button2.Text = "Список сотрудников";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(215, 244);
            button1.Name = "button1";
            button1.Size = new Size(300, 69);
            button1.TabIndex = 0;
            button1.Text = "Склад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(780, 641);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private Button button6;
        private Button button2;
        private Label label2;
        private Button button3;
    }
}