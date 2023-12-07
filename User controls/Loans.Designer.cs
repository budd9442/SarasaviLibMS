namespace SarasaviLibMS.User_controls
{
    partial class Loans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loans));
            borrowBookNum = new TextBox();
            confirmBtn = new Button();
            borrowUserNum = new TextBox();
            cancelBtn = new Button();
            bookNumLabel = new Label();
            userNumLabel = new Label();
            panel1 = new Panel();
            borrowDate = new Label();
            borrrowReturnDate = new Label();
            returnLabel = new Label();
            label2 = new Label();
            panel3 = new Panel();
            materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            label10 = new Label();
            button2 = new Button();
            userFilter = new TextBox();
            bookFilter = new TextBox();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            noResults = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // borrowBookNum
            // 
            borrowBookNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            borrowBookNum.ForeColor = SystemColors.ActiveCaptionText;
            borrowBookNum.Location = new Point(217, 23);
            borrowBookNum.Name = "borrowBookNum";
            borrowBookNum.PlaceholderText = "A0001";
            borrowBookNum.Size = new Size(109, 34);
            borrowBookNum.TabIndex = 0;
            borrowBookNum.Text = "C0002";
            borrowBookNum.TextAlign = HorizontalAlignment.Center;
            // 
            // confirmBtn
            // 
            confirmBtn.FlatAppearance.BorderSize = 0;
            confirmBtn.FlatStyle = FlatStyle.Flat;
            confirmBtn.Font = new Font("Segoe UI", 10.2F);
            confirmBtn.ForeColor = SystemColors.ControlLightLight;
            confirmBtn.Image = Properties.Resources.Done;
            confirmBtn.ImageAlign = ContentAlignment.MiddleLeft;
            confirmBtn.Location = new Point(806, 0);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(110, 122);
            confirmBtn.TabIndex = 3;
            confirmBtn.Text = "      Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // borrowUserNum
            // 
            borrowUserNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            borrowUserNum.ForeColor = SystemColors.ActiveCaptionText;
            borrowUserNum.Location = new Point(217, 65);
            borrowUserNum.Name = "borrowUserNum";
            borrowUserNum.PlaceholderText = "0001";
            borrowUserNum.Size = new Size(109, 34);
            borrowUserNum.TabIndex = 0;
            borrowUserNum.Text = "0005";
            borrowUserNum.TextAlign = HorizontalAlignment.Center;
            // 
            // cancelBtn
            // 
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 10.2F);
            cancelBtn.ForeColor = SystemColors.ControlLightLight;
            cancelBtn.Image = Properties.Resources.Close;
            cancelBtn.ImageAlign = ContentAlignment.MiddleLeft;
            cancelBtn.Location = new Point(922, 0);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(110, 122);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "      Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // bookNumLabel
            // 
            bookNumLabel.AutoSize = true;
            bookNumLabel.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookNumLabel.ForeColor = SystemColors.ControlLightLight;
            bookNumLabel.Location = new Point(28, 26);
            bookNumLabel.Name = "bookNumLabel";
            bookNumLabel.Size = new Size(181, 28);
            bookNumLabel.TabIndex = 1;
            bookNumLabel.Text = "Enter book number";
            // 
            // userNumLabel
            // 
            userNumLabel.AutoSize = true;
            userNumLabel.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNumLabel.ForeColor = SystemColors.ControlLightLight;
            userNumLabel.Location = new Point(30, 68);
            userNumLabel.Name = "userNumLabel";
            userNumLabel.Size = new Size(171, 28);
            userNumLabel.TabIndex = 1;
            userNumLabel.Text = "Enter user number";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 45, 53);
            panel1.Controls.Add(userNumLabel);
            panel1.Controls.Add(borrowDate);
            panel1.Controls.Add(borrrowReturnDate);
            panel1.Controls.Add(returnLabel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(bookNumLabel);
            panel1.Controls.Add(cancelBtn);
            panel1.Controls.Add(borrowUserNum);
            panel1.Controls.Add(confirmBtn);
            panel1.Controls.Add(borrowBookNum);
            panel1.Dock = DockStyle.Bottom;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 566);
            panel1.Name = "panel1";
            panel1.Size = new Size(1032, 119);
            panel1.TabIndex = 4;
            // 
            // borrowDate
            // 
            borrowDate.AutoSize = true;
            borrowDate.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            borrowDate.ForeColor = SystemColors.ControlLightLight;
            borrowDate.Location = new Point(614, 26);
            borrowDate.Name = "borrowDate";
            borrowDate.Size = new Size(105, 28);
            borrowDate.TabIndex = 1;
            borrowDate.Text = "12/6/2023";
            // 
            // borrrowReturnDate
            // 
            borrrowReturnDate.AutoSize = true;
            borrrowReturnDate.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            borrrowReturnDate.ForeColor = SystemColors.ControlLightLight;
            borrrowReturnDate.Location = new Point(614, 63);
            borrrowReturnDate.Name = "borrrowReturnDate";
            borrrowReturnDate.Size = new Size(105, 28);
            borrrowReturnDate.TabIndex = 1;
            borrrowReturnDate.Text = "12/6/2023";
            // 
            // returnLabel
            // 
            returnLabel.AutoSize = true;
            returnLabel.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnLabel.ForeColor = SystemColors.ControlLightLight;
            returnLabel.Location = new Point(435, 65);
            returnLabel.Name = "returnLabel";
            returnLabel.Size = new Size(115, 28);
            returnLabel.TabIndex = 1;
            returnLabel.Text = "Return Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(435, 26);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 1;
            label2.Text = "Loan Date";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(materialDivider3);
            panel3.Controls.Add(materialDivider4);
            panel3.Controls.Add(materialDivider2);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(userFilter);
            panel3.Controls.Add(bookFilter);
            panel3.Controls.Add(materialDivider1);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(483, 566);
            panel3.TabIndex = 7;
            // 
            // materialDivider3
            // 
            materialDivider3.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider3.Depth = 0;
            materialDivider3.Dock = DockStyle.Left;
            materialDivider3.Location = new Point(0, 10);
            materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider3.Name = "materialDivider3";
            materialDivider3.Size = new Size(10, 556);
            materialDivider3.TabIndex = 9;
            materialDivider3.Text = "materialDivider3";
            // 
            // materialDivider4
            // 
            materialDivider4.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider4.Depth = 0;
            materialDivider4.Dock = DockStyle.Top;
            materialDivider4.Location = new Point(0, 0);
            materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider4.Name = "materialDivider4";
            materialDivider4.Size = new Size(473, 10);
            materialDivider4.TabIndex = 8;
            materialDivider4.Text = "materialDivider2";
            // 
            // materialDivider2
            // 
            materialDivider2.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider2.Depth = 0;
            materialDivider2.Location = new Point(3, 418);
            materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider2.Name = "materialDivider2";
            materialDivider2.Size = new Size(480, 10);
            materialDivider2.TabIndex = 8;
            materialDivider2.Text = "materialDivider2";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(16, 163);
            label10.Name = "label10";
            label10.Size = new Size(433, 216);
            label10.TabIndex = 4;
            label10.Text = resources.GetString("label10.Text");
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(42, 45, 53);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.8F);
            button2.ForeColor = SystemColors.ControlDark;
            button2.Location = new Point(314, 489);
            button2.Name = "button2";
            button2.Size = new Size(135, 59);
            button2.TabIndex = 7;
            button2.Text = "Filter";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // userFilter
            // 
            userFilter.BackColor = Color.FromArgb(32, 35, 43);
            userFilter.BorderStyle = BorderStyle.None;
            userFilter.Font = new Font("Segoe UI", 10.8F);
            userFilter.ForeColor = SystemColors.Control;
            userFilter.Location = new Point(199, 520);
            userFilter.Name = "userFilter";
            userFilter.PlaceholderText = "0001";
            userFilter.Size = new Size(92, 24);
            userFilter.TabIndex = 6;
            userFilter.TextAlign = HorizontalAlignment.Center;
            // 
            // bookFilter
            // 
            bookFilter.BackColor = Color.FromArgb(32, 35, 43);
            bookFilter.BorderStyle = BorderStyle.None;
            bookFilter.Font = new Font("Segoe UI", 10.8F);
            bookFilter.ForeColor = SystemColors.Control;
            bookFilter.Location = new Point(199, 486);
            bookFilter.Name = "bookFilter";
            bookFilter.PlaceholderText = "A0001";
            bookFilter.Size = new Size(92, 24);
            bookFilter.TabIndex = 6;
            bookFilter.TextAlign = HorizontalAlignment.Center;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Dock = DockStyle.Right;
            materialDivider1.Location = new Point(473, 0);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(10, 566);
            materialDivider1.TabIndex = 0;
            materialDivider1.Text = "materialDivider1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(28, 520);
            label8.Name = "label8";
            label8.Size = new Size(124, 28);
            label8.TabIndex = 1;
            label8.Text = "User number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlDark;
            label9.Location = new Point(30, 449);
            label9.Name = "label9";
            label9.Size = new Size(64, 28);
            label9.TabIndex = 1;
            label9.Text = "Filters";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(28, 486);
            label7.Name = "label7";
            label7.Size = new Size(130, 28);
            label7.TabIndex = 1;
            label7.Text = "Book number";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(483, 123);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(549, 443);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(483, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(549, 40);
            panel2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(400, 9);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 1;
            label4.Text = "Return Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(250, 8);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 2;
            label3.Text = "Loan Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(114, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 3;
            label1.Text = "Borrower";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(19, 8);
            label5.Name = "label5";
            label5.Size = new Size(48, 23);
            label5.TabIndex = 4;
            label5.Text = "Book";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(673, 43);
            label6.Name = "label6";
            label6.Size = new Size(148, 31);
            label6.TabIndex = 4;
            label6.Text = "Recent Loans";
            // 
            // noResults
            // 
            noResults.BackColor = Color.FromArgb(32, 35, 43);
            noResults.BorderStyle = BorderStyle.None;
            noResults.Font = new Font("Segoe UI", 10.8F);
            noResults.ForeColor = SystemColors.Control;
            noResults.Location = new Point(636, 133);
            noResults.Name = "noResults";
            noResults.PlaceholderText = "no records match the filters";
            noResults.Size = new Size(229, 24);
            noResults.TabIndex = 6;
            noResults.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Literature;
            pictureBox1.Location = new Point(156, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Loans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 35, 43);
            Controls.Add(noResults);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Loans";
            Size = new Size(1032, 685);
            Load += Borrowals_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox borrowBookNum;
        private Button confirmBtn;
        private TextBox borrowUserNum;
        private Button cancelBtn;
        private Label bookNumLabel;
        private Label userNumLabel;
        private Panel panel1;
        private Label borrowDate;
        private Label borrrowReturnDate;
        private Label returnLabel;
        private Label label2;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label5;
        private Label label6;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private TextBox userFilter;
        private TextBox bookFilter;
        private Button button2;
        private TextBox noResults;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private Label label8;
        private Label label9;
        private Label label7;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private Label label10;
        private PictureBox pictureBox1;
    }
}
