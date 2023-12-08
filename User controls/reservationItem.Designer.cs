namespace SarasaviLibMS.User_controls
{
    partial class reservationItem
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
            panel1 = new Panel();
            statLabel = new Label();
            userLabel = new Label();
            bookLabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(151, 188, 255);
            panel1.Controls.Add(statLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(104, 38);
            panel1.TabIndex = 0;
            // 
            // statLabel
            // 
            statLabel.AutoSize = true;
            statLabel.Location = new Point(16, 10);
            statLabel.Name = "statLabel";
            statLabel.Size = new Size(62, 20);
            statLabel.TabIndex = 0;
            statLabel.Text = "Pending";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLabel.ForeColor = SystemColors.ControlLightLight;
            userLabel.Location = new Point(145, 8);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(46, 23);
            userLabel.TabIndex = 0;
            userLabel.Text = "0001";
            // 
            // bookLabel
            // 
            bookLabel.AutoSize = true;
            bookLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookLabel.ForeColor = SystemColors.ControlLightLight;
            bookLabel.Location = new Point(262, 7);
            bookLabel.Name = "bookLabel";
            bookLabel.Size = new Size(57, 23);
            bookLabel.TabIndex = 0;
            bookLabel.Text = "A0001";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Delete;
            pictureBox1.Location = new Point(447, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Notification;
            pictureBox2.Location = new Point(396, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // reservationItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 45, 53);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(bookLabel);
            Controls.Add(userLabel);
            Controls.Add(panel1);
            Name = "reservationItem";
            Size = new Size(512, 38);
            Load += reservationItem_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label statLabel;
        private Label userLabel;
        private Label bookLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
