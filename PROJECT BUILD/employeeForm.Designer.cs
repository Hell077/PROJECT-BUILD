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
            NameBox = new TextBox();
            LastNameBox = new TextBox();
            JobTitleBox = new TextBox();
            SalaryBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            RefreshButton = new Button();
            DeleteButton = new Button();
            AddNewButton = new Button();
            RefreshDB = new Button();
            ClearButton = new Button();
            label6 = new Label();
            label7 = new Label();
            PhoneNumber = new MaskedTextBox();
            IINBox = new MaskedTextBox();
            label8 = new Label();
            emailBox = new TextBox();
            button1 = new Button();
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
            dataGridView1.Location = new Point(12, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(968, 575);
            dataGridView1.TabIndex = 3;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged_1;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(254, 619);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(155, 23);
            NameBox.TabIndex = 4;
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(254, 648);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(155, 23);
            LastNameBox.TabIndex = 5;
            // 
            // JobTitleBox
            // 
            JobTitleBox.Location = new Point(254, 677);
            JobTitleBox.Name = "JobTitleBox";
            JobTitleBox.Size = new Size(155, 23);
            JobTitleBox.TabIndex = 6;
            // 
            // SalaryBox
            // 
            SalaryBox.Location = new Point(254, 706);
            SalaryBox.Name = "SalaryBox";
            SalaryBox.Size = new Size(155, 23);
            SalaryBox.TabIndex = 7;
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
            // RefreshButton
            // 
            RefreshButton.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            RefreshButton.Location = new Point(436, 690);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(129, 30);
            RefreshButton.TabIndex = 12;
            RefreshButton.Text = "Изменить";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += button1_Click;
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
            RefreshDB.AccessibleRole = AccessibleRole.None;
            RefreshDB.BackColor = Color.WhiteSmoke;
            RefreshDB.BackgroundImage = (Image)resources.GetObject("RefreshDB.BackgroundImage");
            RefreshDB.BackgroundImageLayout = ImageLayout.Stretch;
            RefreshDB.FlatAppearance.BorderSize = 0;
            RefreshDB.Location = new Point(12, 626);
            RefreshDB.Name = "RefreshDB";
            RefreshDB.Size = new Size(103, 103);
            RefreshDB.TabIndex = 15;
            RefreshDB.UseVisualStyleBackColor = false;
            RefreshDB.Click += RefreshDB_Click;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            ClearButton.Location = new Point(436, 726);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(129, 30);
            ClearButton.TabIndex = 16;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += button2_Click;
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
            // PhoneNumber
            // 
            PhoneNumber.Location = new Point(254, 735);
            PhoneNumber.Mask = "+7(999) 000-0000";
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(155, 23);
            PhoneNumber.TabIndex = 21;
            // 
            // IINBox
            // 
            IINBox.Location = new Point(254, 764);
            IINBox.Mask = "000000000000";
            IINBox.Name = "IINBox";
            IINBox.Size = new Size(155, 23);
            IINBox.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F);
            label8.Location = new Point(194, 796);
            label8.Name = "label8";
            label8.Size = new Size(54, 19);
            label8.TabIndex = 24;
            label8.Text = "Почта";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(254, 796);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(155, 23);
            emailBox.TabIndex = 25;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(12, 745);
            button1.Name = "button1";
            button1.Size = new Size(103, 103);
            button1.TabIndex = 26;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // employeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(992, 860);
            Controls.Add(button1);
            Controls.Add(emailBox);
            Controls.Add(label8);
            Controls.Add(IINBox);
            Controls.Add(PhoneNumber);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(ClearButton);
            Controls.Add(RefreshDB);
            Controls.Add(AddNewButton);
            Controls.Add(DeleteButton);
            Controls.Add(RefreshButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SalaryBox);
            Controls.Add(JobTitleBox);
            Controls.Add(LastNameBox);
            Controls.Add(NameBox);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox NameBox;
        private TextBox LastNameBox;
        private TextBox JobTitleBox;
        private TextBox SalaryBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button RefreshButton;
        private Button DeleteButton;
        private Button AddNewButton;
        private Button RefreshDB;
        private Button ClearButton;
        private Label label6;
        private Label label7;
        private MaskedTextBox PhoneNumber;
        private MaskedTextBox IINBox;
        private Label label8;
        private TextBox emailBox;
        private Button button1;
    }
}