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
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            dashboard1 = new User_controls.Dashboard();
            tabPage2 = new TabPage();
            inquiries1 = new User_controls.Inquiries();
            tabPage3 = new TabPage();
            userManager1 = new User_controls.UserManager();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
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
            materialTabControl1.Dock = DockStyle.Top;
            materialTabControl1.Location = new Point(0, 60);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1288, 600);
            materialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(dashboard1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1280, 567);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dashboard";
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(3, 3);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1076, 621);
            dashboard1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(inquiries1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1280, 567);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Inquiries";
            // 
            // inquiries1
            // 
            inquiries1.Dock = DockStyle.Fill;
            inquiries1.Location = new Point(3, 3);
            inquiries1.Name = "inquiries1";
            inquiries1.Size = new Size(1274, 561);
            inquiries1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Controls.Add(userManager1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1280, 567);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Borrowals";
            // 
            // userManager1
            // 
            userManager1.Dock = DockStyle.Fill;
            userManager1.Location = new Point(0, 0);
            userManager1.Name = "userManager1";
            userManager1.Size = new Size(1280, 567);
            userManager1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.White;
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1280, 567);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Returns";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.White;
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1280, 567);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Reservations";
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.White;
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1280, 567);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "User Management";
            // 
            // tabPage7
            // 
            tabPage7.BackColor = Color.White;
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1280, 567);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Book Management";
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = materialTabControl1;
            materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Dock = DockStyle.Top;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.Location = new Point(0, 0);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(1288, 60);
            materialTabSelector1.TabIndex = 3;
            materialTabSelector1.Text = "materialTabSelector1";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 660);
            Controls.Add(materialTabControl1);
            Controls.Add(materialTabSelector1);
            Name = "Home";
            Text = "SarasaviLibMS";
            FormClosed += Home_FormClosed;
            Load += Form1_Load;
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private User_controls.Dashboard dashboard1;
        private User_controls.Inquiries inquiries1;
        private TabPage tabPage3;
        private User_controls.UserManager userManager1;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    }
}
