namespace PROJECT_BUILD
{
    partial class Statistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistic));
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1 = new Panel();
            minimizeButton = new Button();
            CloseButton = new Button();
            panel2 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            averageLabel = new Label();
            minLabel = new Label();
            maxLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(148, 291);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(619, 340);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(148, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(619, 248);
            dataGridView1.TabIndex = 1;
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
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(minimizeButton);
            panel1.Controls.Add(CloseButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 34);
            panel1.TabIndex = 23;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // minimizeButton
            // 
            minimizeButton.BackgroundImage = (Image)resources.GetObject("minimizeButton.BackgroundImage");
            minimizeButton.BackgroundImageLayout = ImageLayout.Stretch;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Location = new Point(703, 3);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(29, 29);
            minimizeButton.TabIndex = 24;
            minimizeButton.UseVisualStyleBackColor = true;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackgroundImage = (Image)resources.GetObject("CloseButton.BackgroundImage");
            CloseButton.BackgroundImageLayout = ImageLayout.Stretch;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(738, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(29, 29);
            CloseButton.TabIndex = 25;
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(iconButton1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(142, 698);
            panel2.TabIndex = 24;
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Tahoma", 10F);
            iconButton1.ForeColor = SystemColors.ActiveCaptionText;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MailReplyAll;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(11, 644);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(128, 42);
            iconButton1.TabIndex = 26;
            iconButton1.Text = "Назад";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // averageLabel
            // 
            averageLabel.AutoSize = true;
            averageLabel.Font = new Font("Tahoma", 14F);
            averageLabel.Location = new Point(175, 645);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(59, 23);
            averageLabel.TabIndex = 25;
            averageLabel.Text = "label1";
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Font = new Font("Tahoma", 14F);
            minLabel.Location = new Point(175, 677);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(59, 23);
            minLabel.TabIndex = 26;
            minLabel.Text = "label2";
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Font = new Font("Tahoma", 14F);
            maxLabel.Location = new Point(175, 705);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(59, 23);
            maxLabel.TabIndex = 27;
            maxLabel.Text = "label3";
            // 
            // Statistic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(779, 732);
            Controls.Add(maxLabel);
            Controls.Add(minLabel);
            Controls.Add(averageLabel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(chart1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Statistic";
            Text = "Form2";
            Load += Stats_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Panel panel1;
        private Panel panel2;
        private Button minimizeButton;
        private Button CloseButton;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label maxLabel;
        private Label minLabel;
        private Label averageLabel;
    }
}