namespace PROJECT_BUILD
{
    partial class LoginListForm
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
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(512, 561);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.25F);
            label1.Location = new Point(14, 8);
            label1.Name = "label1";
            label1.Size = new Size(198, 22);
            label1.TabIndex = 1;
            label1.Text = "Логины пользователей";
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(530, 249);
            button1.Name = "button1";
            button1.Size = new Size(99, 58);
            button1.TabIndex = 2;
            button1.Text = "Удалить пользователя из базы";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 612);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "LoginListForm";
            Text = "LoginListForm";
            Load += LoginListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
    }
}