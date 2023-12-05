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
            bookAuthor = new Label();
            bookNumber = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bookTitle
            // 
            bookTitle.AutoSize = true;
            bookTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookTitle.ForeColor = SystemColors.ControlLightLight;
            bookTitle.Location = new Point(85, 0);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(90, 25);
            bookTitle.TabIndex = 0;
            bookTitle.Text = "Book Title";
            // 
            // bookAuthor
            // 
            bookAuthor.AutoSize = true;
            bookAuthor.ForeColor = SystemColors.ControlLightLight;
            bookAuthor.Location = new Point(85, 25);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(74, 20);
            bookAuthor.TabIndex = 0;
            bookAuthor.Text = "by Author";
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
            panel1.Size = new Size(79, 45);
            panel1.TabIndex = 2;
            // 
            // bookItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 80, 80);
            Controls.Add(panel1);
            Controls.Add(bookAuthor);
            Controls.Add(bookTitle);
            Name = "bookItem";
            Size = new Size(659, 45);
            Load += bookItem_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bookTitle;
        private Label bookAuthor;
        private Label bookNumber;
        private Panel panel1;
    }
}
