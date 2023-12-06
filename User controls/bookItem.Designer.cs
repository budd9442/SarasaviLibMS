namespace SarasaviLibMS.User_controls
{
    partial class bookItem
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
            bookTitle = new Label();
            bookNumber = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // bookTitle
            // 
            bookTitle.AutoSize = true;
            bookTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookTitle.ForeColor = SystemColors.ControlLightLight;
            bookTitle.Location = new Point(14, 9);
            bookTitle.MaximumSize = new Size(580, 0);
            bookTitle.MinimumSize = new Size(580, 0);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(580, 25);
            bookTitle.TabIndex = 0;
            bookTitle.Text = "Book Title";
            // 
            // bookNumber
            // 
            bookNumber.AutoSize = true;
            bookNumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookNumber.ForeColor = SystemColors.ControlLightLight;
            bookNumber.Location = new Point(3, 9);
            bookNumber.Name = "bookNumber";
            bookNumber.Size = new Size(123, 25);
            bookNumber.TabIndex = 1;
            bookNumber.Text = "Book Number";
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(bookNumber);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(79, 115);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(bookTitle);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(79, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 0, 20);
            panel2.Size = new Size(597, 115);
            panel2.TabIndex = 3;
            // 
            // bookItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(80, 80, 80);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "bookItem";
            Size = new Size(676, 115);
            Load += bookItem_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bookTitle;
        private Label bookNumber;
        private Panel panel1;
        private Panel panel2;
    }
}
