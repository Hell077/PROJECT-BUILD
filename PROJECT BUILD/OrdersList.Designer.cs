namespace PROJECT_BUILD
{
    partial class OrdersList
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
            label4 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(280, 35);
            label4.TabIndex = 12;
            label4.Text = "Активные заказы";
            // 
            // button1
            // 
            button1.Location = new Point(746, 190);
            button1.Name = "button1";
            button1.Size = new Size(216, 48);
            button1.TabIndex = 13;
            button1.Text = "Удалить выбранный заказ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(728, 568);
            dataGridView1.TabIndex = 14;
            // 
            // button3
            // 
            button3.Location = new Point(746, 244);
            button3.Name = "button3";
            button3.Size = new Size(216, 48);
            button3.TabIndex = 16;
            button3.Text = "Поменять статус";
            button3.UseVisualStyleBackColor = true;
            // 
            // OrdersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 627);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label4);
            Name = "OrdersList";
            Text = "OrdersList";
            Load += OrdersList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button3;
    }
}