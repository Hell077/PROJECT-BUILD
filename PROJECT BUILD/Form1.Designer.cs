namespace PROJECT_BUILD
{
    partial class Identification
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Identification));
            authorization_button = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            Eye = new Button();
            linkLabel1 = new LinkLabel();
            passwordbox = new TextBox();
            loginbox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Eye_slash = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // authorization_button
            // 
            authorization_button.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            authorization_button.Location = new Point(158, 125);
            authorization_button.Name = "authorization_button";
            authorization_button.Size = new Size(222, 60);
            authorization_button.TabIndex = 1;
            authorization_button.Text = "Авторизоваться";
            authorization_button.UseVisualStyleBackColor = true;
            authorization_button.Click += authorization_button_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(715, 482);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 12.25F, FontStyle.Bold);
            label1.Location = new Point(248, 19);
            label1.Name = "label1";
            label1.Size = new Size(252, 84);
            label1.TabIndex = 0;
            label1.Text = "Для продолжения работы \r\nпожалуйста авторизуйтесь\r\n\r\n   ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.WhiteSmoke;
            groupBox3.Controls.Add(Eye);
            groupBox3.Controls.Add(linkLabel1);
            groupBox3.Controls.Add(passwordbox);
            groupBox3.Controls.Add(loginbox);
            groupBox3.Controls.Add(authorization_button);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(Eye_slash);
            groupBox3.Location = new Point(120, 106);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(486, 238);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            // 
            // Eye
            // 
            Eye.BackColor = Color.Transparent;
            Eye.BackgroundImage = (Image)resources.GetObject("Eye.BackgroundImage");
            Eye.BackgroundImageLayout = ImageLayout.Stretch;
            Eye.Image = (Image)resources.GetObject("Eye.Image");
            Eye.Location = new Point(386, 75);
            Eye.Name = "Eye";
            Eye.Size = new Size(29, 29);
            Eye.TabIndex = 7;
            Eye.UseVisualStyleBackColor = false;
            Eye.Click += Eye_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel1.Location = new Point(174, 199);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(178, 25);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Еще нет аккаунта?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // passwordbox
            // 
            passwordbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordbox.Location = new Point(158, 75);
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(222, 29);
            passwordbox.TabIndex = 6;
            // 
            // loginbox
            // 
            loginbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginbox.Location = new Point(158, 34);
            loginbox.Name = "loginbox";
            loginbox.Size = new Size(222, 29);
            loginbox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.25F, FontStyle.Bold);
            label3.Location = new Point(47, 77);
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
            Eye_slash.Location = new Point(386, 75);
            Eye_slash.Name = "Eye_slash";
            Eye_slash.Size = new Size(29, 29);
            Eye_slash.TabIndex = 8;
            Eye_slash.UseVisualStyleBackColor = true;
            Eye_slash.Click += Eye_slash_Click;
            // 
            // Identification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(739, 506);
            Controls.Add(groupBox1);
            Name = "Identification";
            Text = "Identification";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button authorization_button;
        private GroupBox groupBox1;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label3;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox passwordbox;
        private TextBox loginbox;
        private Button Eye_slash;
        private Button Eye;
    }
}
