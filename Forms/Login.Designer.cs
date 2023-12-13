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
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            label7 = new Label();
            loginPasswd = new TextBox();
            loginUsername = new TextBox();
            loginButton = new Button();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 311);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 386);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 25, 33);
            panel1.Controls.Add(pictureBox15);
            panel1.Controls.Add(pictureBox16);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 49);
            panel1.TabIndex = 1;
            // 
            // pictureBox15
            // 
            pictureBox15.BackColor = Color.FromArgb(22, 25, 33);
            pictureBox15.Image = Properties.Resources.Minus;
            pictureBox15.Location = new Point(372, 7);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(40, 33);
            pictureBox15.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox15.TabIndex = 10;
            pictureBox15.TabStop = false;
            pictureBox15.Click += pictureBox15_Click;
            // 
            // pictureBox16
            // 
            pictureBox16.BackColor = Color.FromArgb(22, 25, 33);
            pictureBox16.Image = Properties.Resources.Close;
            pictureBox16.Location = new Point(408, 7);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(40, 33);
            pictureBox16.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox16.TabIndex = 11;
            pictureBox16.TabStop = false;
            pictureBox16.Click += pictureBox16_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(9, 9);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(340, 31);
            label7.TabIndex = 6;
            label7.Text = "SARASAVI Library Management ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginPasswd
            // 
            loginPasswd.Font = new Font("Segoe UI", 11F);
            loginPasswd.Location = new Point(30, 409);
            loginPasswd.Name = "loginPasswd";
            loginPasswd.Size = new Size(388, 32);
            loginPasswd.TabIndex = 2;
            loginPasswd.Text = "admin";
            loginPasswd.UseSystemPasswordChar = true;
            // 
            // loginUsername
            // 
            loginUsername.Font = new Font("Segoe UI", 11F);
            loginUsername.Location = new Point(30, 334);
            loginUsername.Name = "loginUsername";
            loginUsername.Size = new Size(388, 32);
            loginUsername.TabIndex = 2;
            loginUsername.Text = "admin";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(42, 45, 53);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.Location = new Point(130, 477);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(188, 73);
            loginButton.TabIndex = 4;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(284, 379);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(134, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.w;
            pictureBox1.Location = new Point(70, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(313, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 35, 43);
            ClientSize = new Size(448, 565);
            Controls.Add(checkBox1);
            Controls.Add(loginButton);
            Controls.Add(loginUsername);
            Controls.Add(loginPasswd);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlDark;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button registerButton;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TextBox loginPasswd;
        private TextBox loginUsername;
        private Button loginButton;
        private CheckBox checkBox1;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
    }
}