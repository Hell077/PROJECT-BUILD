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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            Eye = new Button();
            linkLabel1 = new LinkLabel();
            passwordbox = new TextBox();
            loginbox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Eye_slash = new Button();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1 = new Panel();
            minimizeButton = new Button();
            CloseButton = new Button();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            panel1.SuspendLayout();
            guna2GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 12.25F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(95, 0);
            label1.Name = "label1";
            label1.Size = new Size(252, 84);
            label1.TabIndex = 0;
            label1.Text = "Для продолжения работы \r\nпожалуйста авторизуйтесь\r\n\r\n   ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.Transparent;
            guna2Button1.BorderRadius = 10;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Silver;
            guna2Button1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(109, 252);
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
            Eye.Location = new Point(337, 176);
            Eye.Name = "Eye";
            Eye.Size = new Size(29, 29);
            Eye.TabIndex = 7;
            Eye.UseVisualStyleBackColor = false;
            Eye.Click += Eye_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Tahoma", 16F);
            linkLabel1.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel1.Location = new Point(118, 334);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(202, 27);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Еще нет аккаунта?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // passwordbox
            // 
            passwordbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordbox.Location = new Point(109, 199);
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(222, 29);
            passwordbox.TabIndex = 6;
            // 
            // loginbox
            // 
            loginbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginbox.Location = new Point(109, 164);
            loginbox.Name = "loginbox";
            loginbox.Size = new Size(222, 29);
            loginbox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 13.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(24, 206);
            label3.Name = "label3";
            label3.Size = new Size(79, 22);
            label3.TabIndex = 3;
            label3.Text = "Пароль";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 13.25F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(35, 166);
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
            Eye_slash.Location = new Point(337, 176);
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
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(minimizeButton);
            panel1.Controls.Add(CloseButton);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 35);
            panel1.TabIndex = 5;
            panel1.MouseDown += panel1_MouseDown_1;
            panel1.MouseMove += panel1_MouseMove_1;
            panel1.MouseUp += panel1_MouseUp_1;
            // 
            // minimizeButton
            // 
            minimizeButton.BackgroundImage = (Image)resources.GetObject("minimizeButton.BackgroundImage");
            minimizeButton.BackgroundImageLayout = ImageLayout.Stretch;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Location = new Point(371, 3);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(29, 29);
            minimizeButton.TabIndex = 28;
            minimizeButton.UseVisualStyleBackColor = true;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackgroundImage = (Image)resources.GetObject("CloseButton.BackgroundImage");
            CloseButton.BackgroundImageLayout = ImageLayout.Stretch;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(406, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(29, 29);
            CloseButton.TabIndex = 27;
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.BorderColor = Color.White;
            guna2GroupBox1.BorderRadius = 20;
            guna2GroupBox1.Controls.Add(label1);
            guna2GroupBox1.Controls.Add(label3);
            guna2GroupBox1.Controls.Add(guna2Button1);
            guna2GroupBox1.Controls.Add(label2);
            guna2GroupBox1.Controls.Add(linkLabel1);
            guna2GroupBox1.Controls.Add(Eye);
            guna2GroupBox1.Controls.Add(loginbox);
            guna2GroupBox1.Controls.Add(passwordbox);
            guna2GroupBox1.Controls.Add(Eye_slash);
            guna2GroupBox1.CustomizableEdges = customizableEdges3;
            guna2GroupBox1.Font = new Font("Tahoma", 14F);
            guna2GroupBox1.ForeColor = Color.DimGray;
            guna2GroupBox1.Location = new Point(12, 38);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GroupBox1.Size = new Size(423, 450);
            guna2GroupBox1.TabIndex = 9;
            // 
            // Identification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(447, 495);
            Controls.Add(guna2GroupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Identification";
            Text = "Identification";
            panel1.ResumeLayout(false);
            guna2GroupBox1.ResumeLayout(false);
            guna2GroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox passwordbox;
        private TextBox loginbox;
        private Button Eye_slash;
        private Button Eye;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Button CloseButton;
        private Button minimizeButton;
    }
}
