namespace PROJECT_BUILD
{
    partial class Stats
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
            dataGridView1 = new DataGridView();
            lblAverageSalary = new Label();
            lblMaxSalary = new Label();
            lblMinSalary = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Linen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(558, 274);
            dataGridView1.TabIndex = 4;
            // 
            // lblAverageSalary
            // 
            lblAverageSalary.AutoSize = true;
            lblAverageSalary.Font = new Font("Tahoma", 14.25F);
            lblAverageSalary.Location = new Point(390, 19);
            lblAverageSalary.Name = "lblAverageSalary";
            lblAverageSalary.Size = new Size(59, 23);
            lblAverageSalary.TabIndex = 5;
            lblAverageSalary.Text = "label1";
            // 
            // lblMaxSalary
            // 
            lblMaxSalary.AutoSize = true;
            lblMaxSalary.Font = new Font("Tahoma", 14.25F);
            lblMaxSalary.Location = new Point(390, 51);
            lblMaxSalary.Name = "lblMaxSalary";
            lblMaxSalary.Size = new Size(59, 23);
            lblMaxSalary.TabIndex = 6;
            lblMaxSalary.Text = "label1";
            // 
            // lblMinSalary
            // 
            lblMinSalary.AutoSize = true;
            lblMinSalary.Font = new Font("Tahoma", 14.25F);
            lblMinSalary.Location = new Point(390, 85);
            lblMinSalary.Name = "lblMinSalary";
            lblMinSalary.Size = new Size(59, 23);
            lblMinSalary.TabIndex = 7;
            lblMinSalary.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblMinSalary);
            groupBox1.Controls.Add(lblMaxSalary);
            groupBox1.Controls.Add(lblAverageSalary);
            groupBox1.Location = new Point(12, 303);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(558, 133);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(171, 23);
            label1.TabIndex = 8;
            label1.Text = "Средняя зарплата";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F);
            label2.Location = new Point(15, 51);
            label2.Name = "label2";
            label2.Size = new Size(225, 23);
            label2.TabIndex = 9;
            label2.Text = "Максимальная зарплата";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F);
            label3.Location = new Point(15, 85);
            label3.Name = "label3";
            label3.Size = new Size(219, 23);
            label3.TabIndex = 10;
            label3.Text = "Минимальная зарплата";
            // 
            // Stats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 609);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Stats";
            Text = "Stats";
            Load += Stats_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblAverageSalary;
        private Label lblMaxSalary;
        private Label lblMinSalary;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}