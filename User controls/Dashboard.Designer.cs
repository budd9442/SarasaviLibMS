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
            bookLabel = new Label();
            timeLabel = new Label();
            userLabel = new Label();
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
            // bookLabel
            // 
            bookLabel.AutoSize = true;
            bookLabel.BackColor = Color.Transparent;
            bookLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookLabel.ForeColor = SystemColors.ControlLight;
            bookLabel.Location = new Point(33, 138);
            bookLabel.Name = "bookLabel";
            bookLabel.Size = new Size(99, 81);
            bookLabel.TabIndex = 2;
            bookLabel.Text = "69";
            bookLabel.Click += label5_Click;
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
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.BackColor = Color.Transparent;
            userLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLabel.ForeColor = SystemColors.ControlLight;
            userLabel.Location = new Point(202, 138);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(99, 81);
            userLabel.TabIndex = 2;
            userLabel.Text = "69";
            userLabel.Click += label5_Click;
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
            pictureBox1.Paint += pictureBox1_Paint;
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
            Controls.Add(timeLabel);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(userLabel);
            Controls.Add(bookLabel);
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
        private Label bookLabel;
        private Label timeLabel;
        private Label userLabel;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
