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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Identification));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            Eye = new Button();
            linkLabel1 = new LinkLabel();
            passwordbox = new TextBox();
            loginbox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Eye_slash = new Button();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            minimizeButton = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            CloseButton = new Guna.UI2.WinForms.Guna2Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.WindowFrame;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(12, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(715, 506);
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
            groupBox3.BackColor = Color.FromArgb(74, 74, 74);
            groupBox3.Controls.Add(guna2Button1);
            groupBox3.Controls.Add(Eye);
            groupBox3.Controls.Add(linkLabel1);
            groupBox3.Controls.Add(passwordbox);
            groupBox3.Controls.Add(loginbox);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(Eye_slash);
            groupBox3.Location = new Point(120, 106);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(486, 238);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Silver;
            guna2Button1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(158, 123);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(222, 60);
            guna2Button1.TabIndex = 8;
            guna2Button1.Text = "Авторизоваться";
            guna2Button1.Click += authorization_button_Click;
            // 
            // Eye
            // 
            Eye.BackColor = Color.Transparent;
            Eye.BackgroundImage = (Image)resources.GetObject("Eye.BackgroundImage");
            Eye.BackgroundImageLayout = ImageLayout.Stretch;
            Eye.Image = (Image)resources.GetObject("Eye.Image");
            Eye.Location = new Point(386, 76);
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
            label3.ForeColor = Color.WhiteSmoke;
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
            label2.ForeColor = Color.WhiteSmoke;
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
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 30;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
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
            minimizeButton.Location = new Point(643, 4);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            minimizeButton.Size = new Size(30, 30);
            minimizeButton.TabIndex = 19;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(minimizeButton);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(12, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(715, 34);
            panel1.TabIndex = 5;
            panel1.MouseDown += panel1_MouseDown_1;
            panel1.MouseMove += panel1_MouseMove_1;
            panel1.MouseUp += panel1_MouseUp_1;
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
            CloseButton.Location = new Point(679, 4);
            CloseButton.Name = "CloseButton";
            CloseButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CloseButton.Size = new Size(30, 30);
            CloseButton.TabIndex = 20;
            CloseButton.Click += CloseButton_Click;
            // 
            // Identification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 74, 74);
            ClientSize = new Size(739, 551);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Identification";
            Text = "Identification";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
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
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button minimizeButton;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button CloseButton;
    }
}
