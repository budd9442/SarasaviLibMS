namespace SarasaviLibMS.User_controls
{
    partial class loanItem
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
            bookNumber = new Label();
            userNumber = new Label();
            date = new Label();
            returnDate = new Label();
            SuspendLayout();
            // 
            // bookNumber
            // 
            bookNumber.AutoSize = true;
            bookNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookNumber.ForeColor = SystemColors.Control;
            bookNumber.Location = new Point(30, 10);
            bookNumber.Name = "bookNumber";
            bookNumber.Size = new Size(57, 23);
            bookNumber.TabIndex = 0;
            bookNumber.Text = "A0001";
            // 
            // userNumber
            // 
            userNumber.AutoSize = true;
            userNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNumber.ForeColor = SystemColors.Control;
            userNumber.Location = new Point(130, 9);
            userNumber.Name = "userNumber";
            userNumber.Size = new Size(46, 23);
            userNumber.TabIndex = 0;
            userNumber.Text = "0001";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date.ForeColor = SystemColors.Control;
            date.Location = new Point(250, 9);
            date.Name = "date";
            date.Size = new Size(87, 23);
            date.TabIndex = 0;
            date.Text = "7/12/2023";
            // 
            // returnDate
            // 
            returnDate.AutoSize = true;
            returnDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnDate.ForeColor = SystemColors.Control;
            returnDate.Location = new Point(407, 9);
            returnDate.Name = "returnDate";
            returnDate.Size = new Size(87, 23);
            returnDate.TabIndex = 0;
            returnDate.Text = "7/12/2023";
            // 
            // loanItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 45, 53);
            Controls.Add(returnDate);
            Controls.Add(date);
            Controls.Add(userNumber);
            Controls.Add(bookNumber);
            Name = "loanItem";
            Size = new Size(549, 40);
            Load += loanItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bookNumber;
        private Label userNumber;
        private Label date;
        private Label returnDate;
    }
}
