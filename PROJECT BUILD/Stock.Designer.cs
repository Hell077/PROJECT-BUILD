namespace PROJECT_BUILD
{
    partial class Stock
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1 = new Panel();
            CloseButton = new Guna.UI2.WinForms.Guna2Button();
            minimizeButton = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.DarkGray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 13.25F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(13, 74);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(936, 593);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 34);
            label1.Name = "label1";
            label1.Size = new Size(461, 22);
            label1.TabIndex = 4;
            label1.Text = "Доступные материалы на складе и их цена за единицу";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Location = new Point(719, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 29);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(1027, 34);
            button1.Name = "button1";
            button1.Size = new Size(29, 29);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(543, 34);
            label2.Name = "label2";
            label2.Size = new Size(170, 22);
            label2.TabIndex = 7;
            label2.Text = "Поиск по названию";
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 30;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(minimizeButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1063, 66);
            panel1.TabIndex = 8;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // CloseButton
            // 
            CloseButton.BackgroundImage = (Image)resources.GetObject("CloseButton.BackgroundImage");
            CloseButton.BackgroundImageLayout = ImageLayout.Stretch;
            CloseButton.CustomizableEdges = customizableEdges3;
            CloseButton.DisabledState.BorderColor = Color.DarkGray;
            CloseButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CloseButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CloseButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CloseButton.FillColor = Color.Empty;
            CloseButton.Font = new Font("Segoe UI", 9F);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(1020, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CloseButton.Size = new Size(30, 30);
            CloseButton.TabIndex = 21;
            CloseButton.Click += CloseButton_Click;
            // 
            // minimizeButton
            // 
            minimizeButton.BackgroundImage = (Image)resources.GetObject("minimizeButton.BackgroundImage");
            minimizeButton.BackgroundImageLayout = ImageLayout.Stretch;
            minimizeButton.CustomizableEdges = customizableEdges5;
            minimizeButton.DisabledState.BorderColor = Color.DarkGray;
            minimizeButton.DisabledState.CustomBorderColor = Color.DarkGray;
            minimizeButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            minimizeButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            minimizeButton.FillColor = Color.Empty;
            minimizeButton.Font = new Font("Segoe UI", 9F);
            minimizeButton.ForeColor = Color.White;
            minimizeButton.Location = new Point(984, 0);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            minimizeButton.Size = new Size(30, 30);
            minimizeButton.TabIndex = 20;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.MistyRose;
            guna2Button1.Font = new Font("Tahoma", 10F);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(957, 74);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(99, 65);
            guna2Button1.TabIndex = 9;
            guna2Button1.Text = "Экспорт в Excel";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 74, 74);
            ClientSize = new Size(1063, 672);
            Controls.Add(guna2Button1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Font = new Font("Tahoma", 13.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Stock";
            Text = "Склад";
            Load += Stock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button minimizeButton;
        private Guna.UI2.WinForms.Guna2Button CloseButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
