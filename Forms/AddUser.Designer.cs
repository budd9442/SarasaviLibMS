namespace SarasaviLibMS.Forms
{
    partial class AddUser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            regName = new TextBox();
            regNIC = new TextBox();
            regAddr = new TextBox();
            regGender = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(11, 75);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(10, 107);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 1;
            label2.Text = "NIC Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(11, 179);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 1;
            label3.Text = "Gender";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(11, 142);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 1;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 18);
            label5.Name = "label5";
            label5.Size = new Size(212, 31);
            label5.TabIndex = 1;
            label5.Text = "Register a new user";
            // 
            // regName
            // 
            regName.Location = new Point(129, 72);
            regName.Name = "regName";
            regName.Size = new Size(454, 27);
            regName.TabIndex = 2;
            // 
            // regNIC
            // 
            regNIC.Location = new Point(129, 105);
            regNIC.Name = "regNIC";
            regNIC.Size = new Size(454, 27);
            regNIC.TabIndex = 2;
            // 
            // regAddr
            // 
            regAddr.Location = new Point(129, 142);
            regAddr.Name = "regAddr";
            regAddr.Size = new Size(454, 27);
            regAddr.TabIndex = 2;
            // 
            // regGender
            // 
            regGender.FormattingEnabled = true;
            regGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            regGender.Location = new Point(129, 179);
            regGender.Name = "regGender";
            regGender.Size = new Size(151, 28);
            regGender.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(350, 12);
            button1.Name = "button1";
            button1.Size = new Size(116, 47);
            button1.TabIndex = 4;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(472, 12);
            button2.Name = "button2";
            button2.Size = new Size(116, 47);
            button2.TabIndex = 4;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 228);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(regGender);
            Controls.Add(regAddr);
            Controls.Add(regNIC);
            Controls.Add(regName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUser";
            Text = "AddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox regName;
        private TextBox regNIC;
        private TextBox regAddr;
        private ComboBox regGender;
        private Button button1;
        private Button button2;
    }
}