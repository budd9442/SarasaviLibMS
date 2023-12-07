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
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
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
            bookNumLabel.Location = new Point(30, 26);
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
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(materialDivider1);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(483, 566);
            panel3.TabIndex = 7;
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
            label5.Location = new Point(36, 9);
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
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(32, 35, 43);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.Window;
            textBox3.Location = new Point(42, 466);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Book number";
            textBox3.Size = new Size(146, 31);
            textBox3.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(32, 35, 43);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(42, 503);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "User number";
            textBox1.Size = new Size(146, 31);
            textBox1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(17, 419);
            label7.Name = "label7";
            label7.Size = new Size(75, 31);
            label7.TabIndex = 4;
            label7.Text = "Filters";
            // 
            // Loans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 35, 43);
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
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label7;
    }
}
