namespace SarasaviLibMS.User_controls
{
    partial class copyItem
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
            panel2 = new Panel();
            statusLabel = new Label();
            numberLabel = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(70, 70, 70);
            panel2.Controls.Add(statusLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(107, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 0, 20);
            panel2.Size = new Size(471, 49);
            panel2.TabIndex = 6;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabel.ForeColor = SystemColors.ControlLight;
            statusLabel.Location = new Point(18, 15);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(96, 23);
            statusLabel.TabIndex = 0;
            statusLabel.Text = "borrowable";
            // 
            // numberLabel
            // 
            numberLabel.BackColor = Color.FromArgb(60, 60, 60);
            numberLabel.Dock = DockStyle.Left;
            numberLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberLabel.ForeColor = SystemColors.ControlLight;
            numberLabel.Location = new Point(0, 0);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(107, 49);
            numberLabel.TabIndex = 5;
            numberLabel.Text = "A00011";
            numberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // copyItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(numberLabel);
            Name = "copyItem";
            Size = new Size(578, 49);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label statusLabel;
        private Label numberLabel;
    }
}
