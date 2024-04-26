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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBox3 = new GroupBox();
            linkLabel1 = new LinkLabel();
            Password3 = new TextBox();
            Eye = new Button();
            Password2 = new TextBox();
            loginbox = new TextBox();
            registration_button = new Button();
            label3 = new Label();
            label2 = new Label();
            Eye_slash = new Button();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1 = new Panel();
            CloseButton = new Guna.UI2.WinForms.Guna2Button();
            minimizeButton = new Guna.UI2.WinForms.Guna2Button();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(90, 90, 90);
            groupBox3.Controls.Add(linkLabel1);
            groupBox3.Controls.Add(Password3);
            groupBox3.Controls.Add(Eye);
            groupBox3.Controls.Add(Password2);
            groupBox3.Controls.Add(loginbox);
            groupBox3.Controls.Add(registration_button);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(Eye_slash);
            groupBox3.Location = new Point(31, 84);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(486, 341);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel1.Location = new Point(192, 227);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(146, 25);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "К авторизации";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
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
            panel1.Size = new Size(555, 35);
            panel1.TabIndex = 9;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // CloseButton
            // 
            CloseButton.BackgroundImage = (Image)resources.GetObject("CloseButton.BackgroundImage");
            CloseButton.BackgroundImageLayout = ImageLayout.Stretch;
            CloseButton.CustomizableEdges = customizableEdges9;
            CloseButton.DisabledState.BorderColor = Color.DarkGray;
            CloseButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CloseButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CloseButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CloseButton.FillColor = Color.Empty;
            CloseButton.Font = new Font("Segoe UI", 9F);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(502, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            CloseButton.Size = new Size(30, 30);
            CloseButton.TabIndex = 23;
            CloseButton.Click += CloseButton_Click;
            // 
            // minimizeButton
            // 
            minimizeButton.BackgroundImage = (Image)resources.GetObject("minimizeButton.BackgroundImage");
            minimizeButton.BackgroundImageLayout = ImageLayout.Stretch;
            minimizeButton.CustomizableEdges = customizableEdges11;
            minimizeButton.DisabledState.BorderColor = Color.DarkGray;
            minimizeButton.DisabledState.CustomBorderColor = Color.DarkGray;
            minimizeButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            minimizeButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            minimizeButton.FillColor = Color.Empty;
            minimizeButton.Font = new Font("Segoe UI", 9F);
            minimizeButton.ForeColor = Color.White;
            minimizeButton.Location = new Point(466, 3);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            minimizeButton.Size = new Size(30, 30);
            minimizeButton.TabIndex = 22;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 80, 80);
            ClientSize = new Size(555, 585);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registration";
            Text = "Form2";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
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
        private LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button minimizeButton;
        private Guna.UI2.WinForms.Guna2Button CloseButton;
    }
}