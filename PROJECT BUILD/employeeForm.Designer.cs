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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            minimizeButton = new Button();
            CloseButton = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            guna2Panel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 25);
            label1.TabIndex = 2;
            label1.Text = "Наши сотрудники";
            label1.MouseDown += panel1_MouseDown_1;
            label1.MouseMove += panel1_MouseMove_1;
            label1.MouseUp += panel1_MouseUp_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Linen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(992, 372);
            dataGridView1.TabIndex = 3;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged_1;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(236, 4);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(155, 23);
            NameBox.TabIndex = 4;
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(236, 33);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(155, 23);
            LastNameBox.TabIndex = 5;
            // 
            // JobTitleBox
            // 
            JobTitleBox.Location = new Point(236, 62);
            JobTitleBox.Name = "JobTitleBox";
            JobTitleBox.Size = new Size(155, 23);
            JobTitleBox.TabIndex = 6;
            // 
            // SalaryBox
            // 
            SalaryBox.Location = new Point(236, 91);
            SalaryBox.Name = "SalaryBox";
            SalaryBox.Size = new Size(155, 23);
            SalaryBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(192, 3);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 8;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(156, 32);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 9;
            label3.Text = "Фамилия";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(139, 62);
            label4.Name = "label4";
            label4.Size = new Size(91, 19);
            label4.TabIndex = 10;
            label4.Text = "Должность";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F);
            label5.Location = new Point(153, 91);
            label5.Name = "label5";
            label5.Size = new Size(77, 19);
            label5.TabIndex = 11;
            label5.Text = "Зарплата";
            // 
            // RefreshButton
            // 
            RefreshButton.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            RefreshButton.Location = new Point(418, 75);
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
            DeleteButton.Location = new Point(418, 39);
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
            AddNewButton.Location = new Point(418, 3);
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
            RefreshDB.Location = new Point(35, 3);
            RefreshDB.Name = "RefreshDB";
            RefreshDB.Size = new Size(103, 103);
            RefreshDB.TabIndex = 15;
            RefreshDB.UseVisualStyleBackColor = false;
            RefreshDB.Click += RefreshDB_Click;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            ClearButton.Location = new Point(418, 111);
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
            label6.Location = new Point(153, 124);
            label6.Name = "label6";
            label6.Size = new Size(74, 19);
            label6.TabIndex = 19;
            label6.Text = "Телефон";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F);
            label7.Location = new Point(189, 153);
            label7.Name = "label7";
            label7.Size = new Size(38, 19);
            label7.TabIndex = 20;
            label7.Text = "Иин";
            // 
            // PhoneNumber
            // 
            PhoneNumber.Location = new Point(236, 120);
            PhoneNumber.Mask = "+7(999) 000-0000";
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(155, 23);
            PhoneNumber.TabIndex = 21;
            // 
            // IINBox
            // 
            IINBox.Location = new Point(236, 149);
            IINBox.Mask = "000000000000";
            IINBox.Name = "IINBox";
            IINBox.Size = new Size(155, 23);
            IINBox.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F);
            label8.Location = new Point(176, 182);
            label8.Name = "label8";
            label8.Size = new Size(54, 19);
            label8.TabIndex = 24;
            label8.Text = "Почта";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(236, 178);
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
            button1.Location = new Point(35, 115);
            button1.Name = "button1";
            button1.Size = new Size(103, 103);
            button1.TabIndex = 26;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 20;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.WhiteSmoke;
            guna2Panel1.Controls.Add(RefreshDB);
            guna2Panel1.Controls.Add(emailBox);
            guna2Panel1.Controls.Add(button1);
            guna2Panel1.Controls.Add(label8);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(IINBox);
            guna2Panel1.Controls.Add(NameBox);
            guna2Panel1.Controls.Add(PhoneNumber);
            guna2Panel1.Controls.Add(LastNameBox);
            guna2Panel1.Controls.Add(label7);
            guna2Panel1.Controls.Add(JobTitleBox);
            guna2Panel1.Controls.Add(label6);
            guna2Panel1.Controls.Add(SalaryBox);
            guna2Panel1.Controls.Add(ClearButton);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(AddNewButton);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(DeleteButton);
            guna2Panel1.Controls.Add(label5);
            guna2Panel1.Controls.Add(RefreshButton);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Bottom;
            guna2Panel1.Location = new Point(0, 416);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(992, 236);
            guna2Panel1.TabIndex = 27;
            // 
            // minimizeButton
            // 
            minimizeButton.BackgroundImage = (Image)resources.GetObject("minimizeButton.BackgroundImage");
            minimizeButton.BackgroundImageLayout = ImageLayout.Stretch;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Location = new Point(916, 7);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(29, 29);
            minimizeButton.TabIndex = 30;
            minimizeButton.UseVisualStyleBackColor = true;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackgroundImage = (Image)resources.GetObject("CloseButton.BackgroundImage");
            CloseButton.BackgroundImageLayout = ImageLayout.Stretch;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(951, 7);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(29, 29);
            CloseButton.TabIndex = 29;
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(minimizeButton);
            panel1.Controls.Add(CloseButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 39);
            panel1.TabIndex = 31;
            panel1.MouseDown += panel1_MouseDown_1;
            panel1.MouseMove += panel1_MouseMove_1;
            panel1.MouseUp += panel1_MouseUp_1;
            // 
            // employeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(992, 652);
            Controls.Add(panel1);
            Controls.Add(guna2Panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "employeeForm";
            Text = "Сотрудники";
            Load += employee_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Panel panel1;
        private Button minimizeButton;
        private Button CloseButton;
    }
}