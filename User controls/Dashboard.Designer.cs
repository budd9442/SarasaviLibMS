namespace SarasaviLibMS.User_controls
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            label2 = new Label();
            label5 = new Label();
            timeLabel = new Label();
            welcomeLabel = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 10.2F);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(121, 185);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 1;
            label2.Text = "Books";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(33, 138);
            label5.Name = "label5";
            label5.Size = new Size(99, 81);
            label5.TabIndex = 2;
            label5.Text = "69";
            label5.Click += label5_Click;
            // 
            // timeLabel
            // 
            timeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timeLabel.AutoSize = true;
            timeLabel.BackColor = Color.Transparent;
            timeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = SystemColors.AppWorkspace;
            timeLabel.Location = new Point(821, 48);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(83, 41);
            timeLabel.TabIndex = 3;
            timeLabel.Text = "Time";
            // 
            // welcomeLabel
            // 
            welcomeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = SystemColors.AppWorkspace;
            welcomeLabel.Location = new Point(708, 118);
            welcomeLabel.Margin = new Padding(0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(219, 41);
            welcomeLabel.TabIndex = 3;
            welcomeLabel.Text = "Welcome User!";
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            welcomeLabel.Click += label9_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(202, 138);
            label4.Name = "label4";
            label4.Size = new Size(99, 81);
            label4.TabIndex = 2;
            label4.Text = "69";
            label4.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Nirmala UI", 10.2F);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(284, 185);
            label6.Name = "label6";
            label6.Size = new Size(81, 23);
            label6.TabIndex = 1;
            label6.Text = "Members";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.AppWorkspace;
            label7.Location = new Point(22, 48);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(535, 41);
            label7.TabIndex = 3;
            label7.Text = "SARASAVI Library Management System";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label9_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1032, 597);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 35, 43);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label7);
            Controls.Add(welcomeLabel);
            Controls.Add(timeLabel);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Dashboard";
            Size = new Size(1032, 685);
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label5;
        private Label timeLabel;
        private Label welcomeLabel;
        private Label label4;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
