namespace PROJECT_BUILD
{
    partial class employeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeForm));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            DeleteButton = new Button();
            AddNewButton = new Button();
            RefreshDB = new Button();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 25);
            label1.TabIndex = 2;
            label1.Text = "Наши сотрудники";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Linen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(968, 562);
            dataGridView1.TabIndex = 3;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 619);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(254, 648);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(254, 677);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(254, 706);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(155, 23);
            textBox4.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(210, 618);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 8;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(174, 647);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 9;
            label3.Text = "Фамилия";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(157, 677);
            label4.Name = "label4";
            label4.Size = new Size(91, 19);
            label4.TabIndex = 10;
            label4.Text = "Должность";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F);
            label5.Location = new Point(171, 706);
            label5.Name = "label5";
            label5.Size = new Size(77, 19);
            label5.TabIndex = 11;
            label5.Text = "Зарплата";
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button1.Location = new Point(436, 690);
            button1.Name = "button1";
            button1.Size = new Size(129, 30);
            button1.TabIndex = 12;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            DeleteButton.Location = new Point(436, 654);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(129, 30);
            DeleteButton.TabIndex = 13;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AddNewButton
            // 
            AddNewButton.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            AddNewButton.Location = new Point(436, 618);
            AddNewButton.Name = "AddNewButton";
            AddNewButton.Size = new Size(129, 30);
            AddNewButton.TabIndex = 14;
            AddNewButton.Text = "Добавить";
            AddNewButton.UseVisualStyleBackColor = true;
            AddNewButton.Click += AddNewButton_Click;
            // 
            // RefreshDB
            // 
            RefreshDB.BackColor = Color.Transparent;
            RefreshDB.BackgroundImage = (Image)resources.GetObject("RefreshDB.BackgroundImage");
            RefreshDB.BackgroundImageLayout = ImageLayout.Stretch;
            RefreshDB.Location = new Point(597, 626);
            RefreshDB.Name = "RefreshDB";
            RefreshDB.Size = new Size(103, 103);
            RefreshDB.TabIndex = 15;
            RefreshDB.UseVisualStyleBackColor = false;
            RefreshDB.Click += RefreshDB_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button2.Location = new Point(436, 726);
            button2.Name = "button2";
            button2.Size = new Size(129, 30);
            button2.TabIndex = 16;
            button2.Text = "Отчистить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.Location = new Point(171, 739);
            label6.Name = "label6";
            label6.Size = new Size(74, 19);
            label6.TabIndex = 19;
            label6.Text = "Телефон";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F);
            label7.Location = new Point(207, 768);
            label7.Name = "label7";
            label7.Size = new Size(38, 19);
            label7.TabIndex = 20;
            label7.Text = "Иин";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(254, 735);
            maskedTextBox1.Mask = "+7(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(155, 23);
            maskedTextBox1.TabIndex = 21;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(254, 764);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(155, 23);
            maskedTextBox2.TabIndex = 23;
            // 
            // employeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(992, 859);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(RefreshDB);
            Controls.Add(AddNewButton);
            Controls.Add(DeleteButton);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "employeeForm";
            Text = "Сотрудники";
            Load += employee_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button DeleteButton;
        private Button AddNewButton;
        private Button RefreshDB;
        private Button button2;
        private Label label6;
        private Label label7;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
    }
}