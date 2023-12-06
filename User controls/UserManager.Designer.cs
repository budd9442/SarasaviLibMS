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
            textBox1 = new TextBox();
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
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(40, 0);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "                      Search";
            textBox1.Size = new Size(300, 34);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.Add_User_Male;
            pictureBox1.InitialImage = Properties.Resources.Read;
            pictureBox1.Location = new Point(80, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // addUserName
            // 
            addUserName.Location = new Point(25, 210);
            addUserName.Name = "addUserName";
            addUserName.Size = new Size(288, 27);
            addUserName.TabIndex = 2;
            // 
            // noResults
            // 
            noResults.AutoSize = true;
            noResults.ForeColor = SystemColors.Control;
            noResults.Location = new Point(144, 63);
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
            panel3.Location = new Point(0, 111);
            panel3.Name = "panel3";
            panel3.Size = new Size(342, 574);
            panel3.TabIndex = 4;
            panel3.Visible = false;
            // 
            // addUserGender
            // 
            addUserGender.FormattingEnabled = true;
            addUserGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            addUserGender.Location = new Point(25, 369);
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
            addUserBtn.Location = new Point(94, 483);
            addUserBtn.Name = "addUserBtn";
            addUserBtn.Size = new Size(134, 58);
            addUserBtn.TabIndex = 1;
            addUserBtn.Text = "Add user";
            addUserBtn.UseVisualStyleBackColor = false;
            addUserBtn.Click += addUserBtn_Click;
            // 
            // addUserNIC
            // 
            addUserNIC.Location = new Point(25, 316);
            addUserNIC.Name = "addUserNIC";
            addUserNIC.Size = new Size(288, 27);
            addUserNIC.TabIndex = 2;
            // 
            // addUserAddress
            // 
            addUserAddress.Location = new Point(25, 263);
            addUserAddress.Name = "addUserAddress";
            addUserAddress.Size = new Size(288, 27);
            addUserAddress.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(25, 346);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 3;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(25, 293);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 3;
            label4.Text = "NIC Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(25, 187);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(25, 240);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Address";
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = Properties.Resources.Add_User_Male;
            pictureBox3.Image = Properties.Resources.Add_Book;
            pictureBox3.Location = new Point(97, 314);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(119, 107);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(noResults);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 111);
            panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Search;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 35, 43);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(panel1);
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
            flowLayoutPanel1.Location = new Point(342, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 40, 10, 0);
            flowLayoutPanel1.Size = new Size(690, 685);
            flowLayoutPanel1.TabIndex = 9;
            flowLayoutPanel1.WrapContents = false;
            // 
            // UserManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 25, 33);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Name = "UserManager";
            Size = new Size(1032, 685);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private PictureBox pictureBox1;
        private TextBox addUserName;
        private Label noResults;
        private Panel panel3;
        private Button addUserBtn;
        private TextBox addUserAddress;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private ComboBox addUserGender;
        private TextBox addUserNIC;
        private Label label5;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
