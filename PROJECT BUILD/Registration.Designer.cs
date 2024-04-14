namespace PROJECT_BUILD
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            groupBox3 = new GroupBox();
            Password3 = new TextBox();
            Eye = new Button();
            Password2 = new TextBox();
            loginbox = new TextBox();
            registration_button = new Button();
            label3 = new Label();
            label2 = new Label();
            Eye_slash = new Button();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.WhiteSmoke;
            groupBox3.Controls.Add(Password3);
            groupBox3.Controls.Add(Eye);
            groupBox3.Controls.Add(Password2);
            groupBox3.Controls.Add(loginbox);
            groupBox3.Controls.Add(registration_button);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(Eye_slash);
            groupBox3.Location = new Point(34, 70);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(486, 341);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // Password3
            // 
            Password3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Password3.Location = new Point(158, 110);
            Password3.Name = "Password3";
            Password3.Size = new Size(222, 29);
            Password3.TabIndex = 9;
            // 
            // Eye
            // 
            Eye.BackColor = Color.Transparent;
            Eye.BackgroundImage = (Image)resources.GetObject("Eye.BackgroundImage");
            Eye.BackgroundImageLayout = ImageLayout.Stretch;
            Eye.Image = (Image)resources.GetObject("Eye.Image");
            Eye.Location = new Point(386, 90);
            Eye.Name = "Eye";
            Eye.Size = new Size(29, 29);
            Eye.TabIndex = 7;
            Eye.UseVisualStyleBackColor = false;
            Eye.Click += Eye_Click;
            // 
            // Password2
            // 
            Password2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Password2.Location = new Point(158, 75);
            Password2.Name = "Password2";
            Password2.Size = new Size(222, 29);
            Password2.TabIndex = 6;
            // 
            // loginbox
            // 
            loginbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginbox.Location = new Point(158, 34);
            loginbox.Name = "loginbox";
            loginbox.Size = new Size(222, 29);
            loginbox.TabIndex = 5;
            // 
            // registration_button
            // 
            registration_button.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            registration_button.Location = new Point(158, 154);
            registration_button.Name = "registration_button";
            registration_button.Size = new Size(222, 60);
            registration_button.TabIndex = 1;
            registration_button.Text = "Зарегистрироваться ";
            registration_button.UseVisualStyleBackColor = true;
            registration_button.Click += registration_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.25F, FontStyle.Bold);
            label3.Location = new Point(58, 77);
            label3.Name = "label3";
            label3.Size = new Size(79, 22);
            label3.TabIndex = 3;
            label3.Text = "Пароль";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.25F, FontStyle.Bold);
            label2.Location = new Point(58, 34);
            label2.Name = "label2";
            label2.Size = new Size(68, 22);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Eye_slash
            // 
            Eye_slash.BackgroundImage = (Image)resources.GetObject("Eye_slash.BackgroundImage");
            Eye_slash.BackgroundImageLayout = ImageLayout.Stretch;
            Eye_slash.Location = new Point(386, 90);
            Eye_slash.Name = "Eye_slash";
            Eye_slash.Size = new Size(29, 29);
            Eye_slash.TabIndex = 8;
            Eye_slash.UseVisualStyleBackColor = true;
            Eye_slash.Click += Eye_slash_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 585);
            Controls.Add(groupBox3);
            Name = "Registration";
            Text = "Form2";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private TextBox Password3;
        private Button Eye;
        private TextBox Password2;
        private TextBox loginbox;
        private Button registration_button;
        private Label label3;
        private Label label2;
        private Button Eye_slash;
    }
}