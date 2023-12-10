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
            panel1 = new Panel();
            burrowalsBtn = new Button();
            booksBtn = new Button();
            usersBtn = new Button();
            returnsBtn = new Button();
            reservationsBtn = new Button();
            inquiriesBtn = new Button();
            dashboardBtn = new Button();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            minimize = new PictureBox();
            exit = new PictureBox();
            tabPage2 = new TabPage();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            borrowals1 = new User_controls.Loans();
            tabPage3 = new TabPage();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            returns1 = new User_controls.Returns();
            tabPage4 = new TabPage();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            tabPage5 = new TabPage();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            reservations1 = new User_controls.Reservations();
            tabPage6 = new TabPage();
            pictureBox3 = new PictureBox();
            pictureBox6 = new PictureBox();
            userManager1 = new User_controls.UserManager();
            tabPage7 = new TabPage();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            bookManager1 = new User_controls.BookManager();
            panel1.SuspendLayout();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 25, 33);
            panel1.Controls.Add(burrowalsBtn);
            panel1.Controls.Add(booksBtn);
            panel1.Controls.Add(usersBtn);
            panel1.Controls.Add(returnsBtn);
            panel1.Controls.Add(reservationsBtn);
            panel1.Controls.Add(inquiriesBtn);
            panel1.Controls.Add(dashboardBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 718);
            panel1.TabIndex = 1;
            panel1.MouseDown += panelMouseDown;
            panel1.MouseMove += panelMouseMove;
            panel1.MouseUp += panelMouseUp;
            // 
            // burrowalsBtn
            // 
            burrowalsBtn.AutoEllipsis = true;
            burrowalsBtn.BackColor = Color.FromArgb(31, 31, 31);
            burrowalsBtn.FlatAppearance.BorderSize = 0;
            burrowalsBtn.FlatStyle = FlatStyle.Flat;
            burrowalsBtn.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            burrowalsBtn.ForeColor = SystemColors.ButtonHighlight;
            burrowalsBtn.Image = Properties.Resources._1;
            burrowalsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            burrowalsBtn.Location = new Point(11, 94);
            burrowalsBtn.Name = "burrowalsBtn";
            burrowalsBtn.Padding = new Padding(0, 0, 16, 0);
            burrowalsBtn.Size = new Size(231, 76);
            burrowalsBtn.TabIndex = 0;
            burrowalsBtn.Text = "Book Loans";
            burrowalsBtn.TextAlign = ContentAlignment.MiddleRight;
            burrowalsBtn.UseVisualStyleBackColor = false;
            burrowalsBtn.Click += burrowalsBtn_Click;
            // 
            // booksBtn
            // 
            booksBtn.AutoEllipsis = true;
            booksBtn.BackColor = Color.FromArgb(31, 31, 31);
            booksBtn.FlatAppearance.BorderSize = 0;
            booksBtn.FlatStyle = FlatStyle.Flat;
            booksBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            booksBtn.ForeColor = SystemColors.ButtonFace;
            booksBtn.ImageAlign = ContentAlignment.MiddleLeft;
            booksBtn.Location = new Point(12, 659);
            booksBtn.Name = "booksBtn";
            booksBtn.Size = new Size(234, 50);
            booksBtn.TabIndex = 0;
            booksBtn.Text = "Manage Books";
            booksBtn.UseVisualStyleBackColor = false;
            booksBtn.Click += booksBtn_Click;
            // 
            // usersBtn
            // 
            usersBtn.AutoEllipsis = true;
            usersBtn.BackColor = Color.FromArgb(31, 31, 31);
            usersBtn.FlatAppearance.BorderSize = 0;
            usersBtn.FlatStyle = FlatStyle.Flat;
            usersBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usersBtn.ForeColor = SystemColors.ButtonFace;
            usersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            usersBtn.Location = new Point(12, 603);
            usersBtn.Name = "usersBtn";
            usersBtn.Size = new Size(234, 50);
            usersBtn.TabIndex = 0;
            usersBtn.Text = "Manage Users";
            usersBtn.UseVisualStyleBackColor = false;
            usersBtn.Click += usersBtn_Click;
            // 
            // returnsBtn
            // 
            returnsBtn.AutoEllipsis = true;
            returnsBtn.BackColor = Color.FromArgb(31, 31, 31);
            returnsBtn.FlatAppearance.BorderSize = 0;
            returnsBtn.FlatStyle = FlatStyle.Flat;
            returnsBtn.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnsBtn.ForeColor = SystemColors.ButtonHighlight;
            returnsBtn.Image = Properties.Resources._2;
            returnsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            returnsBtn.Location = new Point(11, 176);
            returnsBtn.Name = "returnsBtn";
            returnsBtn.Padding = new Padding(0, 0, 48, 0);
            returnsBtn.Size = new Size(231, 76);
            returnsBtn.TabIndex = 0;
            returnsBtn.Text = "Returns";
            returnsBtn.TextAlign = ContentAlignment.MiddleRight;
            returnsBtn.UseVisualStyleBackColor = false;
            returnsBtn.Click += returnsBtn_Click;
            // 
            // reservationsBtn
            // 
            reservationsBtn.AutoEllipsis = true;
            reservationsBtn.BackColor = Color.FromArgb(31, 31, 31);
            reservationsBtn.FlatAppearance.BorderSize = 0;
            reservationsBtn.FlatStyle = FlatStyle.Flat;
            reservationsBtn.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reservationsBtn.ForeColor = SystemColors.ButtonHighlight;
            reservationsBtn.Image = Properties.Resources._5;
            reservationsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            reservationsBtn.Location = new Point(11, 340);
            reservationsBtn.Name = "reservationsBtn";
            reservationsBtn.Size = new Size(231, 76);
            reservationsBtn.TabIndex = 0;
            reservationsBtn.Text = "Reservations";
            reservationsBtn.TextAlign = ContentAlignment.MiddleRight;
            reservationsBtn.UseVisualStyleBackColor = false;
            reservationsBtn.Click += reservationsBtn_Click;
            // 
            // inquiriesBtn
            // 
            inquiriesBtn.AutoEllipsis = true;
            inquiriesBtn.BackColor = Color.FromArgb(31, 31, 31);
            inquiriesBtn.FlatAppearance.BorderSize = 0;
            inquiriesBtn.FlatStyle = FlatStyle.Flat;
            inquiriesBtn.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inquiriesBtn.ForeColor = SystemColors.ButtonHighlight;
            inquiriesBtn.Image = Properties.Resources._4;
            inquiriesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            inquiriesBtn.Location = new Point(11, 258);
            inquiriesBtn.Name = "inquiriesBtn";
            inquiriesBtn.Padding = new Padding(0, 0, 35, 0);
            inquiriesBtn.Size = new Size(231, 76);
            inquiriesBtn.TabIndex = 0;
            inquiriesBtn.Text = "Inquiries";
            inquiriesBtn.TextAlign = ContentAlignment.MiddleRight;
            inquiriesBtn.UseVisualStyleBackColor = false;
            inquiriesBtn.Click += inquiriesBtn_Click;
            // 
            // dashboardBtn
            // 
            dashboardBtn.AutoEllipsis = true;
            dashboardBtn.BackColor = Color.FromArgb(61, 61, 61);
            dashboardBtn.FlatAppearance.BorderSize = 0;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardBtn.ForeColor = SystemColors.ButtonHighlight;
            dashboardBtn.Image = Properties.Resources._3;
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(11, 12);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(231, 76);
            dashboardBtn.TabIndex = 0;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.TextAlign = ContentAlignment.MiddleRight;
            dashboardBtn.UseVisualStyleBackColor = false;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Controls.Add(tabPage4);
            materialTabControl1.Controls.Add(tabPage5);
            materialTabControl1.Controls.Add(tabPage6);
            materialTabControl1.Controls.Add(tabPage7);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Location = new Point(248, 0);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1040, 718);
            materialTabControl1.TabIndex = 2;
            materialTabControl1.SelectedIndexChanged += materialTabControl1_TabIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(25, 25, 33);
            tabPage1.Controls.Add(minimize);
            tabPage1.Controls.Add(exit);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1032, 685);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // minimize
            // 
            minimize.BackColor = Color.FromArgb(22, 25, 33);
            minimize.Image = Properties.Resources.Minus;
            minimize.Location = new Point(960, 0);
            minimize.Name = "minimize";
            minimize.Size = new Size(40, 33);
            minimize.SizeMode = PictureBoxSizeMode.CenterImage;
            minimize.TabIndex = 3;
            minimize.TabStop = false;
            minimize.Click += minimize_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.FromArgb(22, 25, 33);
            exit.Image = Properties.Resources.Close;
            exit.Location = new Point(996, 0);
            exit.Name = "exit";
            exit.Size = new Size(40, 33);
            exit.SizeMode = PictureBoxSizeMode.CenterImage;
            exit.TabIndex = 4;
            exit.TabStop = false;
            exit.Click += exit_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(32, 35, 43);
            tabPage2.Controls.Add(pictureBox13);
            tabPage2.Controls.Add(pictureBox14);
            tabPage2.Controls.Add(borrowals1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 67);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.FromArgb(32, 35, 43);
            pictureBox13.Image = Properties.Resources.Minus;
            pictureBox13.Location = new Point(960, 0);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(40, 33);
            pictureBox13.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox13.TabIndex = 6;
            pictureBox13.TabStop = false;
            pictureBox13.Click += minimize_Click;
            // 
            // pictureBox14
            // 
            pictureBox14.BackColor = Color.FromArgb(32, 35, 43);
            pictureBox14.Image = Properties.Resources.Close;
            pictureBox14.Location = new Point(996, 0);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(40, 33);
            pictureBox14.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox14.TabIndex = 7;
            pictureBox14.TabStop = false;
            pictureBox14.Click += exit_Click;
            // 
            // borrowals1
            // 
            borrowals1.BackColor = Color.FromArgb(32, 35, 43);
            borrowals1.Dock = DockStyle.Fill;
            borrowals1.ForeColor = Color.LightGray;
            borrowals1.Location = new Point(3, 3);
            borrowals1.Name = "borrowals1";
            borrowals1.Size = new Size(186, 61);
            borrowals1.TabIndex = 5;
            borrowals1.MouseDown += panelMouseDown;
            borrowals1.MouseMove += panelMouseMove;
            borrowals1.MouseUp += panelMouseUp;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(61, 61, 61);
            tabPage3.Controls.Add(pictureBox11);
            tabPage3.Controls.Add(pictureBox12);
            tabPage3.Controls.Add(returns1);
            tabPage3.Location = new Point(4, 54);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(192, 42);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.FromArgb(32, 35, 43);
            pictureBox11.Image = Properties.Resources.Minus;
            pictureBox11.Location = new Point(960, 0);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(40, 33);
            pictureBox11.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox11.TabIndex = 6;
            pictureBox11.TabStop = false;
            pictureBox11.Click += minimize_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.FromArgb(32, 35, 43);
            pictureBox12.Image = Properties.Resources.Close;
            pictureBox12.Location = new Point(996, 0);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(40, 33);
            pictureBox12.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox12.TabIndex = 7;
            pictureBox12.TabStop = false;
            pictureBox12.Click += exit_Click;
            // 
            // returns1
            // 
            returns1.BackColor = Color.FromArgb(32, 35, 43);
            returns1.Dock = DockStyle.Fill;
            returns1.Location = new Point(0, 0);
            returns1.Name = "returns1";
            returns1.Size = new Size(192, 42);
            returns1.TabIndex = 5;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(61, 61, 61);
            tabPage4.Controls.Add(pictureBox9);
            tabPage4.Controls.Add(pictureBox10);
            tabPage4.Location = new Point(4, 54);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(192, 42);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(22, 25, 33);
            pictureBox9.Image = Properties.Resources.Minus;
            pictureBox9.Location = new Point(960, 0);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(40, 33);
            pictureBox9.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox9.TabIndex = 3;
            pictureBox9.TabStop = false;
            pictureBox9.Click += minimize_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(22, 25, 33);
            pictureBox10.Image = Properties.Resources.Close;
            pictureBox10.Location = new Point(996, 0);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(40, 33);
            pictureBox10.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox10.TabIndex = 4;
            pictureBox10.TabStop = false;
            pictureBox10.Click += exit_Click;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.FromArgb(61, 61, 61);
            tabPage5.Controls.Add(pictureBox7);
            tabPage5.Controls.Add(pictureBox8);
            tabPage5.Controls.Add(reservations1);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1032, 685);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(32, 35, 43);
            pictureBox7.Image = Properties.Resources.Minus;
            pictureBox7.Location = new Point(960, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(40, 33);
            pictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox7.TabIndex = 4;
            pictureBox7.TabStop = false;
            pictureBox7.Click += minimize_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(32, 35, 43);
            pictureBox8.Image = Properties.Resources.Close;
            pictureBox8.Location = new Point(996, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(40, 33);
            pictureBox8.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox8.TabIndex = 5;
            pictureBox8.TabStop = false;
            pictureBox8.Click += exit_Click;
            // 
            // reservations1
            // 
            reservations1.BackColor = Color.FromArgb(32, 35, 43);
            reservations1.Dock = DockStyle.Fill;
            reservations1.Location = new Point(0, 0);
            reservations1.Name = "reservations1";
            reservations1.Size = new Size(1032, 685);
            reservations1.TabIndex = 3;
            reservations1.MouseDown += panelMouseMove;
            reservations1.MouseMove += panelMouseMove;
            reservations1.MouseUp += panelMouseUp;
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.FromArgb(61, 61, 61);
            tabPage6.Controls.Add(pictureBox3);
            tabPage6.Controls.Add(pictureBox6);
            tabPage6.Controls.Add(userManager1);
            tabPage6.Location = new Point(4, 79);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(192, 17);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(22, 25, 33);
            pictureBox3.Image = Properties.Resources.Minus;
            pictureBox3.Location = new Point(960, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += minimize_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(22, 25, 33);
            pictureBox6.Image = Properties.Resources.Close;
            pictureBox6.Location = new Point(996, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(40, 33);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            pictureBox6.Click += exit_Click;
            // 
            // userManager1
            // 
            userManager1.BackColor = Color.FromArgb(32, 35, 43);
            userManager1.Dock = DockStyle.Fill;
            userManager1.Location = new Point(0, 0);
            userManager1.Margin = new Padding(3, 40, 3, 3);
            userManager1.Name = "userManager1";
            userManager1.Size = new Size(192, 17);
            userManager1.TabIndex = 0;
            userManager1.MouseDown += panelMouseDown;
            userManager1.MouseMove += panelMouseMove;
            userManager1.MouseUp += panelMouseUp;
            // 
            // tabPage7
            // 
            tabPage7.BackColor = Color.FromArgb(42, 45, 53);
            tabPage7.Controls.Add(pictureBox4);
            tabPage7.Controls.Add(pictureBox5);
            tabPage7.Controls.Add(bookManager1);
            tabPage7.Location = new Point(4, 104);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(192, 0);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "tabPage7";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(22, 25, 33);
            pictureBox4.Image = Properties.Resources.Minus;
            pictureBox4.Location = new Point(960, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            pictureBox4.Click += minimize_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(22, 25, 33);
            pictureBox5.Image = Properties.Resources.Close;
            pictureBox5.Location = new Point(996, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 33);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            pictureBox5.Click += exit_Click;
            // 
            // bookManager1
            // 
            bookManager1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            bookManager1.BackColor = Color.FromArgb(32, 35, 43);
            bookManager1.Dock = DockStyle.Fill;
            bookManager1.Location = new Point(0, 0);
            bookManager1.Name = "bookManager1";
            bookManager1.Size = new Size(192, 0);
            bookManager1.TabIndex = 0;
            bookManager1.MouseDown += panelMouseDown;
            bookManager1.MouseMove += panelMouseMove;
            bookManager1.MouseUp += panelMouseUp;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 25, 33);
            ClientSize = new Size(1288, 718);
            Controls.Add(materialTabControl1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Home";
            Text = "SarasaviLibMS";
            FormClosed += Home_FormClosed;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button dashboardBtn;
        private Button burrowalsBtn;
        private Button inquiriesBtn;
        private Button booksBtn;
        private Button usersBtn;
        private Button returnsBtn;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Button reservationsBtn;
        private TabPage tabPage7;
        private User_controls.BookManager bookManager1;
        private User_controls.UserManager userManager1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox minimize;
        private PictureBox exit;
        private User_controls.Loans borrowals1;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private User_controls.Reservations reservations1;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private User_controls.Returns returns1;
    }
}
