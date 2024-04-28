namespace PROJECT_BUILD
{
    partial class OrderStatusUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderStatusUser));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 20;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1327, 46);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel7_MouseDown;
            panel1.MouseMove += panel7_MouseMove;
            panel1.MouseUp += panel7_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14F);
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 36;
            label2.Text = "username";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1259, 14);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 35;
            button1.UseVisualStyleBackColor = true;
            button1.Click += minimizeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F);
            label1.Location = new Point(178, 9);
            label1.Name = "label1";
            label1.Size = new Size(339, 23);
            label1.TabIndex = 0;
            label1.Text = "Ваши активные|завершенные заказы";
            label1.MouseDown += panel7_MouseDown;
            label1.MouseMove += panel7_MouseMove;
            label1.MouseUp += panel7_MouseUp;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1290, 14);
            button3.Name = "button3";
            button3.Size = new Size(25, 25);
            button3.TabIndex = 34;
            button3.UseVisualStyleBackColor = true;
            button3.Click += CloseButton_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(iconButton1);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Left;
            guna2Panel1.Location = new Point(0, 46);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(172, 549);
            guna2Panel1.TabIndex = 4;
            guna2Panel1.MouseDown += panel7_MouseDown;
            guna2Panel1.MouseMove += panel7_MouseMove;
            guna2Panel1.MouseUp += panel7_MouseUp;
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Tahoma", 10F);
            iconButton1.ForeColor = SystemColors.ActiveCaptionText;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MailReplyAll;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(28, 495);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(128, 42);
            iconButton1.TabIndex = 5;
            iconButton1.Text = "Назад";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(162, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1137, 531);
            dataGridView1.TabIndex = 5;
            // 
            // OrderStatusUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 595);
            Controls.Add(dataGridView1);
            Controls.Add(guna2Panel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderStatusUser";
            Text = "OrderStatusUser";
            MouseDown += panel7_MouseDown;
            MouseMove += panel7_MouseMove;
            MouseUp += panel7_MouseUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Button button1;
        private Button button3;
        private Label label2;
        private DataGridView dataGridView1;
    }
}