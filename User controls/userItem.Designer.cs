namespace SarasaviLibMS.User_controls
{
    partial class userItem
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
            nameLabel = new Label();
            userIdLabel = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = SystemColors.ControlLightLight;
            nameLabel.Location = new Point(110, 8);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 25);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userIdLabel.ForeColor = SystemColors.ControlLightLight;
            userIdLabel.Location = new Point(3, 8);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new Size(77, 25);
            userIdLabel.TabIndex = 4;
            userIdLabel.Text = "USER ID";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.More;
            pictureBox1.Location = new Point(629, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(584, 8);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 4;
            label1.Text = "0/5";
            // 
            // userItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 80, 80);
            Controls.Add(pictureBox1);
            Controls.Add(nameLabel);
            Controls.Add(label1);
            Controls.Add(userIdLabel);
            Name = "userItem";
            Size = new Size(679, 40);
            Load += userItem_Load;
            MouseEnter += userItem_MouseEnter;
            MouseLeave += userItem_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label userIdLabel;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
