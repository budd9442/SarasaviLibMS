namespace SarasaviLibMS
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inquiryBtn = new Button();
            borrowalsBtn = new Button();
            returnsBtn = new Button();
            userManagerBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // inquiryBtn
            // 
            inquiryBtn.Location = new Point(12, 80);
            inquiryBtn.Name = "inquiryBtn";
            inquiryBtn.Size = new Size(172, 62);
            inquiryBtn.TabIndex = 0;
            inquiryBtn.Text = "Inquaries ";
            inquiryBtn.UseVisualStyleBackColor = true;
            // 
            // borrowalsBtn
            // 
            borrowalsBtn.Location = new Point(12, 148);
            borrowalsBtn.Name = "borrowalsBtn";
            borrowalsBtn.Size = new Size(172, 62);
            borrowalsBtn.TabIndex = 0;
            borrowalsBtn.Text = "Borrowals";
            borrowalsBtn.UseVisualStyleBackColor = true;
            // 
            // returnsBtn
            // 
            returnsBtn.Location = new Point(12, 216);
            returnsBtn.Name = "returnsBtn";
            returnsBtn.Size = new Size(172, 62);
            returnsBtn.TabIndex = 0;
            returnsBtn.Text = "Returns";
            returnsBtn.UseVisualStyleBackColor = true;
            // 
            // userManagerBtn
            // 
            userManagerBtn.Location = new Point(12, 406);
            userManagerBtn.Name = "userManagerBtn";
            userManagerBtn.Size = new Size(172, 62);
            userManagerBtn.TabIndex = 0;
            userManagerBtn.Text = "User Management";
            userManagerBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 474);
            button1.Name = "button1";
            button1.Size = new Size(172, 62);
            button1.TabIndex = 0;
            button1.Text = "Book Management";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 284);
            button2.Name = "button2";
            button2.Size = new Size(172, 62);
            button2.TabIndex = 0;
            button2.Text = "Reservations";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(172, 62);
            button3.TabIndex = 0;
            button3.Text = "Dashboard";
            button3.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 556);
            Controls.Add(button1);
            Controls.Add(userManagerBtn);
            Controls.Add(button2);
            Controls.Add(returnsBtn);
            Controls.Add(borrowalsBtn);
            Controls.Add(button3);
            Controls.Add(inquiryBtn);
            Name = "Home";
            Text = "SarasaviLibMS";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button inquiryBtn;
        private Button borrowalsBtn;
        private Button returnsBtn;
        private Button userManagerBtn;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
