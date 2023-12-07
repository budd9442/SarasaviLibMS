namespace SarasaviLibMS.User_controls
{
    partial class UserManager
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
            pictureBox1 = new PictureBox();
            addUserName = new TextBox();
            noResults = new Label();
            panel3 = new Panel();
            addUserGender = new ComboBox();
            addUserBtn = new Button();
            addUserNIC = new TextBox();
            addUserAddress = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel4 = new Panel();
            panel5 = new Panel();
            textBox3 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.Add_User_Male;
            pictureBox1.InitialImage = Properties.Resources.Read;
            pictureBox1.Location = new Point(74, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // addUserName
            // 
            addUserName.Location = new Point(29, 299);
            addUserName.Name = "addUserName";
            addUserName.Size = new Size(288, 27);
            addUserName.TabIndex = 2;
            // 
            // noResults
            // 
            noResults.AutoSize = true;
            noResults.ForeColor = SystemColors.Control;
            noResults.Location = new Point(462, 15);
            noResults.Name = "noResults";
            noResults.Size = new Size(84, 20);
            noResults.TabIndex = 2;
            noResults.Text = "no results :(";
            noResults.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(addUserGender);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(addUserName);
            panel3.Controls.Add(addUserBtn);
            panel3.Controls.Add(addUserNIC);
            panel3.Controls.Add(addUserAddress);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(342, 685);
            panel3.TabIndex = 4;
            // 
            // addUserGender
            // 
            addUserGender.FormattingEnabled = true;
            addUserGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            addUserGender.Location = new Point(29, 458);
            addUserGender.Name = "addUserGender";
            addUserGender.Size = new Size(151, 28);
            addUserGender.TabIndex = 5;
            // 
            // addUserBtn
            // 
            addUserBtn.BackColor = SystemColors.WindowFrame;
            addUserBtn.FlatAppearance.BorderSize = 0;
            addUserBtn.FlatStyle = FlatStyle.Flat;
            addUserBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUserBtn.ForeColor = SystemColors.ButtonFace;
            addUserBtn.Location = new Point(98, 572);
            addUserBtn.Name = "addUserBtn";
            addUserBtn.Size = new Size(134, 58);
            addUserBtn.TabIndex = 1;
            addUserBtn.Text = "Add user";
            addUserBtn.UseVisualStyleBackColor = false;
            addUserBtn.Click += addUserBtn_Click;
            // 
            // addUserNIC
            // 
            addUserNIC.Location = new Point(29, 405);
            addUserNIC.Name = "addUserNIC";
            addUserNIC.Size = new Size(288, 27);
            addUserNIC.TabIndex = 2;
            // 
            // addUserAddress
            // 
            addUserAddress.Location = new Point(29, 352);
            addUserAddress.Name = "addUserAddress";
            addUserAddress.Size = new Size(288, 27);
            addUserAddress.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(29, 435);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 3;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(29, 382);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 3;
            label4.Text = "NIC Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(29, 276);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(29, 329);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Address";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 35, 43);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 685);
            panel2.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(42, 45, 53);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(342, 42);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 0, 10, 0);
            flowLayoutPanel1.Size = new Size(690, 643);
            flowLayoutPanel1.TabIndex = 9;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(342, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(690, 42);
            panel4.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(noResults);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(690, 42);
            panel5.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(32, 35, 43);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.Window;
            textBox3.Location = new Point(82, 6);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "    name, NIC number or address";
            textBox3.Size = new Size(364, 31);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(6, 8);
            label3.Name = "label3";
            label3.Size = new Size(70, 28);
            label3.TabIndex = 3;
            label3.Text = "Search";
            // 
            // UserManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 25, 33);
            Controls.Add(panel4);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Name = "UserManager";
            Size = new Size(1032, 685);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox addUserName;
        private Label noResults;
        private Panel panel3;
        private Button addUserBtn;
        private TextBox addUserAddress;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel2;
        private ComboBox addUserGender;
        private TextBox addUserNIC;
        private Label label5;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private TextBox textBox2;
        private Panel panel5;
        private TextBox textBox3;
        private Label label3;
    }
}
