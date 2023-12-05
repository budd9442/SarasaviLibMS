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
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            bookManager1 = new User_controls.BookManager();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            materialTabControl1.SuspendLayout();
            tabPage7.SuspendLayout();
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
            burrowalsBtn.Text = "Borrowals";
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
            materialTabControl1.MouseDown += panelMouseDown;
            materialTabControl1.MouseMove += panelMouseMove;
            materialTabControl1.MouseUp += panelMouseUp;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(25, 25, 33);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1032, 685);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.MouseDown += panelMouseDown;
            tabPage1.MouseMove += panelMouseMove;
            tabPage1.MouseUp += panelMouseUp;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(61, 61, 61);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1032, 685);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.MouseDown += panelMouseDown;
            tabPage2.MouseMove += panelMouseMove;
            tabPage2.MouseUp += panelMouseUp;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(61, 61, 61);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1032, 685);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.MouseDown += panelMouseDown;
            tabPage3.MouseMove += panelMouseMove;
            tabPage3.MouseUp += panelMouseUp;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(61, 61, 61);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1032, 685);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.MouseDown += panelMouseDown;
            tabPage4.MouseMove += panelMouseMove;
            tabPage4.MouseUp += panelMouseUp;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.FromArgb(61, 61, 61);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1032, 685);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.MouseDown += panelMouseDown;
            tabPage5.MouseMove += panelMouseMove;
            tabPage5.MouseUp += panelMouseUp;
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.FromArgb(61, 61, 61);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1032, 685);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            tabPage6.MouseDown += panelMouseDown;
            tabPage6.MouseMove += panelMouseMove;
            tabPage6.MouseUp += panelMouseUp;
            // 
            // tabPage7
            // 
            tabPage7.BackColor = Color.FromArgb(41, 41, 41);
            tabPage7.Controls.Add(bookManager1);
            tabPage7.Controls.Add(panel2);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1032, 685);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "tabPage7";
            tabPage7.Click += tabPage7_Click;
            tabPage7.MouseDown += panelMouseDown;
            tabPage7.MouseMove += panelMouseMove;
            tabPage7.MouseUp += panelMouseUp;
            // 
            // bookManager1
            // 
            bookManager1.Dock = DockStyle.Fill;
            bookManager1.Location = new Point(0, 36);
            bookManager1.Name = "bookManager1";
            bookManager1.Size = new Size(1032, 649);
            bookManager1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1032, 36);
            panel2.TabIndex = 1;
            panel2.MouseDown += panelMouseDown;
            panel2.MouseMove += panelMouseMove;
            panel2.MouseUp += panelMouseUp;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.FromArgb(41, 41, 41);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.Close;
            button1.Location = new Point(1250, -1);
            button1.Name = "button1";
            button1.Size = new Size(39, 36);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = Color.FromArgb(41, 41, 41);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.Minus;
            button2.Location = new Point(1211, -1);
            button2.Name = "button2";
            button2.Size = new Size(39, 36);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 718);
            Controls.Add(button2);
            Controls.Add(button1);
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
            tabPage7.ResumeLayout(false);
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
        private Button button1;
        private Button button2;
        private Button reservationsBtn;
        private TabPage tabPage7;
        private User_controls.BookManager bookManager1;
        private Panel panel2;
    }
}
