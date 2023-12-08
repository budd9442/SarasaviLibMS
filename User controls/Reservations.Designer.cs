namespace SarasaviLibMS.User_controls
{
    partial class Reservations
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
            label1 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            reservationItem1 = new reservationItem();
            materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            cancelBtn = new Button();
            borrowUserNum = new TextBox();
            confirmBtn = new Button();
            borrowBookNum = new TextBox();
            button2 = new Button();
            userFilter = new TextBox();
            bookFilter = new TextBox();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            userNumLabel = new Label();
            bookNumLabel = new Label();
            panel1 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(261, 10);
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
            label5.Location = new Point(178, 9);
            label5.Name = "label5";
            label5.Size = new Size(48, 23);
            label5.TabIndex = 4;
            label5.Text = "Book";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(520, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(512, 40);
            panel2.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(reservationItem1);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(520, 189);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(512, 496);
            flowLayoutPanel1.TabIndex = 14;
            flowLayoutPanel1.WrapContents = false;
            // 
            // reservationItem1
            // 
            reservationItem1.BackColor = Color.FromArgb(42, 45, 53);
            reservationItem1.Location = new Point(3, 3);
            reservationItem1.Name = "reservationItem1";
            reservationItem1.Size = new Size(512, 38);
            reservationItem1.TabIndex = 0;
            // 
            // materialDivider3
            // 
            materialDivider3.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider3.Depth = 0;
            materialDivider3.Dock = DockStyle.Left;
            materialDivider3.Location = new Point(0, 10);
            materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider3.Name = "materialDivider3";
            materialDivider3.Size = new Size(10, 544);
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
            materialDivider4.Size = new Size(510, 10);
            materialDivider4.TabIndex = 8;
            materialDivider4.Text = "materialDivider2";
            // 
            // materialDivider2
            // 
            materialDivider2.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider2.Depth = 0;
            materialDivider2.Dock = DockStyle.Bottom;
            materialDivider2.Location = new Point(0, 675);
            materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider2.Name = "materialDivider2";
            materialDivider2.Size = new Size(510, 10);
            materialDivider2.TabIndex = 8;
            materialDivider2.Text = "materialDivider2";
            // 
            // cancelBtn
            // 
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 10.2F);
            cancelBtn.ForeColor = SystemColors.ControlLightLight;
            cancelBtn.Image = Properties.Resources.Close;
            cancelBtn.ImageAlign = ContentAlignment.MiddleLeft;
            cancelBtn.Location = new Point(301, 386);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(110, 77);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "      Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // borrowUserNum
            // 
            borrowUserNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            borrowUserNum.ForeColor = SystemColors.ActiveCaptionText;
            borrowUserNum.Location = new Point(320, 289);
            borrowUserNum.Name = "borrowUserNum";
            borrowUserNum.PlaceholderText = "0001";
            borrowUserNum.Size = new Size(109, 34);
            borrowUserNum.TabIndex = 0;
            borrowUserNum.Text = "0005";
            borrowUserNum.TextAlign = HorizontalAlignment.Center;
            // 
            // confirmBtn
            // 
            confirmBtn.FlatAppearance.BorderSize = 0;
            confirmBtn.FlatStyle = FlatStyle.Flat;
            confirmBtn.Font = new Font("Segoe UI", 10.2F);
            confirmBtn.ForeColor = SystemColors.ControlLightLight;
            confirmBtn.Image = Properties.Resources.Done;
            confirmBtn.ImageAlign = ContentAlignment.MiddleLeft;
            confirmBtn.Location = new Point(141, 383);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(110, 77);
            confirmBtn.TabIndex = 3;
            confirmBtn.Text = "      Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // borrowBookNum
            // 
            borrowBookNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            borrowBookNum.ForeColor = SystemColors.ActiveCaptionText;
            borrowBookNum.Location = new Point(320, 338);
            borrowBookNum.Name = "borrowBookNum";
            borrowBookNum.PlaceholderText = "A0001";
            borrowBookNum.Size = new Size(109, 34);
            borrowBookNum.TabIndex = 0;
            borrowBookNum.Text = "C0002";
            borrowBookNum.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(52, 55, 63);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.8F);
            button2.ForeColor = SystemColors.ControlDark;
            button2.Location = new Point(387, 47);
            button2.Name = "button2";
            button2.Size = new Size(105, 58);
            button2.TabIndex = 7;
            button2.Text = "Filter";
            button2.UseVisualStyleBackColor = false;
            // 
            // userFilter
            // 
            userFilter.BackColor = Color.FromArgb(32, 35, 43);
            userFilter.BorderStyle = BorderStyle.None;
            userFilter.Font = new Font("Segoe UI", 10.8F);
            userFilter.ForeColor = SystemColors.Control;
            userFilter.Location = new Point(152, 84);
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
            bookFilter.Location = new Point(152, 50);
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
            materialDivider1.Location = new Point(510, 0);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(10, 685);
            materialDivider1.TabIndex = 0;
            materialDivider1.Text = "materialDivider1";
            // 
            // userNumLabel
            // 
            userNumLabel.AutoSize = true;
            userNumLabel.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNumLabel.ForeColor = SystemColors.ControlLightLight;
            userNumLabel.Location = new Point(120, 292);
            userNumLabel.Name = "userNumLabel";
            userNumLabel.Size = new Size(171, 28);
            userNumLabel.TabIndex = 1;
            userNumLabel.Text = "Enter user number";
            // 
            // bookNumLabel
            // 
            bookNumLabel.AutoSize = true;
            bookNumLabel.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookNumLabel.ForeColor = SystemColors.ControlLightLight;
            bookNumLabel.Location = new Point(120, 341);
            bookNumLabel.Name = "bookNumLabel";
            bookNumLabel.Size = new Size(181, 28);
            bookNumLabel.TabIndex = 1;
            bookNumLabel.Text = "Enter book number";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 45, 53);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(bookFilter);
            panel1.Controls.Add(userFilter);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Bottom;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 554);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 121);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = SystemColors.ControlDarkDark;
            checkBox2.Location = new Point(271, 81);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(84, 24);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Pending";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ControlDarkDark;
            checkBox1.Location = new Point(271, 47);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(93, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Available";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(18, 47);
            label7.Name = "label7";
            label7.Size = new Size(130, 28);
            label7.TabIndex = 1;
            label7.Text = "Book number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlDark;
            label9.Location = new Point(20, 10);
            label9.Name = "label9";
            label9.Size = new Size(64, 28);
            label9.TabIndex = 1;
            label9.Text = "Filters";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(18, 81);
            label8.Name = "label8";
            label8.Size = new Size(124, 28);
            label8.TabIndex = 1;
            label8.Text = "User number";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(userNumLabel);
            panel3.Controls.Add(materialDivider3);
            panel3.Controls.Add(materialDivider4);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(materialDivider2);
            panel3.Controls.Add(bookNumLabel);
            panel3.Controls.Add(cancelBtn);
            panel3.Controls.Add(materialDivider1);
            panel3.Controls.Add(borrowUserNum);
            panel3.Controls.Add(confirmBtn);
            panel3.Controls.Add(borrowBookNum);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(520, 685);
            panel3.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Bookmark;
            pictureBox1.Location = new Point(198, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Reservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 35, 43);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Name = "Reservations";
            Size = new Size(1032, 685);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label5;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private Button cancelBtn;
        private TextBox borrowUserNum;
        private Button confirmBtn;
        private TextBox borrowBookNum;
        private Button button2;
        private TextBox userFilter;
        private TextBox bookFilter;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Label userNumLabel;
        private Label bookNumLabel;
        private Panel panel1;
        private Label label8;
        private Label label9;
        private Panel panel3;
        private Label label7;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private PictureBox pictureBox1;
        private reservationItem reservationItem1;
    }
}
