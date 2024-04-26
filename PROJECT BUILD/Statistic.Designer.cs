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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistic));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            CloseButton = new Guna.UI2.WinForms.Guna2Button();
            minimizeButton = new Guna.UI2.WinForms.Guna2Button();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chart1.Legends.Add(legend4);
            chart1.Location = new Point(12, 310);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chart1.Series.Add(series4);
            chart1.Size = new Size(564, 321);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(564, 248);
            dataGridView1.TabIndex = 1;
            // 
            // CloseButton
            // 
            CloseButton.BackgroundImage = (Image)resources.GetObject("CloseButton.BackgroundImage");
            CloseButton.BackgroundImageLayout = ImageLayout.Stretch;
            CloseButton.CustomizableEdges = customizableEdges13;
            CloseButton.DisabledState.BorderColor = Color.DarkGray;
            CloseButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CloseButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CloseButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CloseButton.FillColor = Color.Empty;
            CloseButton.Font = new Font("Segoe UI", 9F);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(737, 4);
            CloseButton.Name = "CloseButton";
            CloseButton.ShadowDecoration.CustomizableEdges = customizableEdges14;
            CloseButton.Size = new Size(30, 30);
            CloseButton.TabIndex = 22;
            CloseButton.Click += CloseButton_Click;
            // 
            // minimizeButton
            // 
            minimizeButton.BackgroundImage = (Image)resources.GetObject("minimizeButton.BackgroundImage");
            minimizeButton.BackgroundImageLayout = ImageLayout.Stretch;
            minimizeButton.CustomizableEdges = customizableEdges15;
            minimizeButton.DisabledState.BorderColor = Color.DarkGray;
            minimizeButton.DisabledState.CustomBorderColor = Color.DarkGray;
            minimizeButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            minimizeButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            minimizeButton.FillColor = Color.Empty;
            minimizeButton.Font = new Font("Segoe UI", 9F);
            minimizeButton.ForeColor = Color.White;
            minimizeButton.Location = new Point(701, 4);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.ShadowDecoration.CustomizableEdges = customizableEdges16;
            minimizeButton.Size = new Size(30, 30);
            minimizeButton.TabIndex = 21;
            minimizeButton.Click += minimizeButton_Click;
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
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 34);
            panel1.TabIndex = 23;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // Statistic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 74, 74);
            ClientSize = new Size(779, 643);
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
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button minimizeButton;
        private Guna.UI2.WinForms.Guna2Button CloseButton;
        private Panel panel1;
    }
}