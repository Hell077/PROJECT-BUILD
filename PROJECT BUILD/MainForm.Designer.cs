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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button6 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel2 = new LinkLabel();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.Location = new Point(0, 522);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button5
            // 
            button5.BackColor = Color.Silver;
            button5.Font = new Font("Tahoma", 14.25F);
            button5.Location = new Point(0, 139);
            button5.Name = "button5";
            button5.Size = new Size(275, 69);
            button5.TabIndex = 9;
            button5.Text = "Оставить отзыв";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Tahoma", 14.25F);
            button4.Location = new Point(0, 289);
            button4.Name = "button4";
            button4.Size = new Size(275, 69);
            button4.TabIndex = 8;
            button4.Text = "Список логинов/паролей";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.Font = new Font("Tahoma", 14.25F);
            button3.Location = new Point(0, 139);
            button3.Name = "button3";
            button3.Size = new Size(275, 69);
            button3.TabIndex = 7;
            button3.Text = "Таблица заказов";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Silver;
            button6.Font = new Font("Tahoma", 14.25F);
            button6.Location = new Point(0, 64);
            button6.Name = "button6";
            button6.Size = new Size(275, 69);
            button6.TabIndex = 5;
            button6.Text = "Сделать заказ";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 14.25F);
            button2.Location = new Point(0, 214);
            button2.Name = "button2";
            button2.Size = new Size(275, 69);
            button2.TabIndex = 1;
            button2.Text = "Список сотрудников";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(0, 64);
            button1.Name = "button1";
            button1.Size = new Size(275, 69);
            button1.TabIndex = 0;
            button1.Text = "Склад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGray;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(linkLabel1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(0, -10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 709);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14.75F);
            label5.Location = new Point(0, 575);
            label5.Name = "label5";
            label5.Size = new Size(186, 24);
            label5.TabIndex = 12;
            label5.Text = "Имя пользователя:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.75F);
            label4.Location = new Point(0, 599);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DarkRed;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Tahoma", 12F);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(0, 623);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(146, 19);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Выйти из аккаунта";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F);
            label3.Location = new Point(4, 30);
            label3.Name = "label3";
            label3.Size = new Size(232, 27);
            label3.TabIndex = 11;
            label3.Text = "Панель пользователя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(224, 39);
            label2.TabIndex = 10;
            label2.Text = "Админ панель";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(287, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(511, 400);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Tahoma", 12F);
            linkLabel2.Location = new Point(677, 415);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(121, 19);
            linkLabel2.TabIndex = 4;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Заменить фото";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(810, 641);
            Controls.Add(linkLabel2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Name = "MainForm";
            Text = "MainForm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button6;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel2;
    }
}