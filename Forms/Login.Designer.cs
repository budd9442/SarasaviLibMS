namespace SarasaviLibMS.Forms
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            loginPasswd = new TextBox();
            loginUsername = new TextBox();
            loginButton = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 66);
            label1.Name = "label1";
            label1.Size = new Size(255, 20);
            label1.TabIndex = 0;
            label1.Text = "Sarasavi Library Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 172);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 247);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 49);
            panel1.TabIndex = 1;
            // 
            // loginPasswd
            // 
            loginPasswd.Font = new Font("Segoe UI", 11F);
            loginPasswd.Location = new Point(21, 270);
            loginPasswd.Name = "loginPasswd";
            loginPasswd.Size = new Size(388, 32);
            loginPasswd.TabIndex = 2;
            loginPasswd.Text = "1212";
            loginPasswd.UseSystemPasswordChar = true;
            // 
            // loginUsername
            // 
            loginUsername.Font = new Font("Segoe UI", 11F);
            loginUsername.Location = new Point(21, 195);
            loginUsername.Name = "loginUsername";
            loginUsername.Size = new Size(388, 32);
            loginUsername.TabIndex = 2;
            loginUsername.Text = "buddhika";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(121, 338);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(188, 73);
            loginButton.TabIndex = 4;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(275, 240);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(134, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 450);
            Controls.Add(checkBox1);
            Controls.Add(loginButton);
            Controls.Add(loginUsername);
            Controls.Add(loginPasswd);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button registerButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TextBox loginPasswd;
        private TextBox loginUsername;
        private Button loginButton;
        private CheckBox checkBox1;
    }
}