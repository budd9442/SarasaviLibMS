namespace SarasaviLibMS.User_controls
{
    partial class bookItem2
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
            numberLabel = new Label();
            panel2 = new Panel();
            titleLabel = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // numberLabel
            // 
            numberLabel.BackColor = Color.FromArgb(60, 60, 60);
            numberLabel.Dock = DockStyle.Left;
            numberLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberLabel.ForeColor = SystemColors.ControlLight;
            numberLabel.Location = new Point(0, 0);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(59, 54);
            numberLabel.TabIndex = 0;
            numberLabel.Text = "A0001";
            numberLabel.TextAlign = ContentAlignment.MiddleLeft;
            numberLabel.Click += titleLabel_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(titleLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(59, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 0, 20);
            panel2.Size = new Size(400, 54);
            panel2.TabIndex = 4;
            panel2.Click += titleLabel_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = SystemColors.ControlLightLight;
            titleLabel.Location = new Point(14, 9);
            titleLabel.MaximumSize = new Size(360, 0);
            titleLabel.MinimumSize = new Size(360, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(360, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Book Title";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            titleLabel.Click += titleLabel_Click;
            // 
            // bookItem2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(70, 70, 70);
            Controls.Add(panel2);
            Controls.Add(numberLabel);
            Name = "bookItem2";
            Size = new Size(459, 54);
            Load += bookItem2_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numberLabel;
        private Panel panel2;
        private Label titleLabel;
    }
}
