namespace SarasaviLibMS.User_controls
{
    partial class Returns
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
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            userTextbox = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            bookTextBox = new TextBox();
            materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            panel3 = new Panel();
            button2 = new Button();
            bookLabel = new Label();
            nameLabel = new Label();
            label4 = new Label();
            label3 = new Label();
            confirmBtn = new Button();
            materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Dock = DockStyle.Left;
            materialDivider1.Location = new Point(0, 0);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(10, 685);
            materialDivider1.TabIndex = 1;
            materialDivider1.Text = "materialDivider1";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(userTextbox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(10, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 685);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Literature;
            pictureBox3.Location = new Point(85, 376);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(146, 128);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(78, 180);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 2;
            label1.Text = "Select User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Forward_Button;
            pictureBox1.Location = new Point(247, 207);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // userTextbox
            // 
            userTextbox.BackColor = Color.FromArgb(42, 45, 53);
            userTextbox.BorderStyle = BorderStyle.None;
            userTextbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTextbox.ForeColor = SystemColors.ControlLightLight;
            userTextbox.Location = new Point(78, 221);
            userTextbox.Multiline = true;
            userTextbox.Name = "userTextbox";
            userTextbox.PlaceholderText = "0001";
            userTextbox.Size = new Size(153, 39);
            userTextbox.TabIndex = 0;
            userTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 55, 63);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(bookTextBox);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(350, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 685);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(62, 180);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 2;
            label2.Text = "Select Book";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(42, 305);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(258, 293);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Enabled = false;
            pictureBox2.Image = Properties.Resources.Forward_Button;
            pictureBox2.Location = new Point(227, 207);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // bookTextBox
            // 
            bookTextBox.BackColor = Color.FromArgb(62, 65, 73);
            bookTextBox.BorderStyle = BorderStyle.None;
            bookTextBox.Enabled = false;
            bookTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookTextBox.ForeColor = SystemColors.ControlLightLight;
            bookTextBox.Location = new Point(62, 221);
            bookTextBox.Multiline = true;
            bookTextBox.Name = "bookTextBox";
            bookTextBox.PlaceholderText = "A0001";
            bookTextBox.Size = new Size(153, 39);
            bookTextBox.TabIndex = 0;
            bookTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // materialDivider2
            // 
            materialDivider2.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider2.Depth = 0;
            materialDivider2.Dock = DockStyle.Left;
            materialDivider2.Location = new Point(340, 0);
            materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider2.Name = "materialDivider2";
            materialDivider2.Size = new Size(10, 685);
            materialDivider2.TabIndex = 3;
            materialDivider2.Text = "materialDivider2";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(32, 35, 43);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(bookLabel);
            panel3.Controls.Add(nameLabel);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(confirmBtn);
            panel3.Dock = DockStyle.Bottom;
            panel3.ImeMode = ImeMode.NoControl;
            panel3.Location = new Point(690, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(342, 643);
            panel3.TabIndex = 6;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 45, 53);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Image = Properties.Resources.Cancel;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(59, 537);
            button2.Name = "button2";
            button2.Size = new Size(214, 72);
            button2.TabIndex = 0;
            button2.Text = "           Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // bookLabel
            // 
            bookLabel.BackColor = Color.FromArgb(42, 45, 53);
            bookLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookLabel.ForeColor = SystemColors.ControlLight;
            bookLabel.Location = new Point(33, 221);
            bookLabel.Name = "bookLabel";
            bookLabel.Size = new Size(273, 172);
            bookLabel.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.BackColor = Color.FromArgb(42, 45, 53);
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = SystemColors.ControlLight;
            nameLabel.Location = new Point(33, 107);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(273, 61);
            nameLabel.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(33, 69);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 2;
            label4.Text = "Borrower :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(33, 180);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 2;
            label3.Text = "Book : ";
            label3.Click += label3_Click;
            // 
            // confirmBtn
            // 
            confirmBtn.FlatAppearance.BorderSize = 0;
            confirmBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 45, 53);
            confirmBtn.FlatStyle = FlatStyle.Flat;
            confirmBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmBtn.ForeColor = SystemColors.ControlLightLight;
            confirmBtn.Image = Properties.Resources.Ok;
            confirmBtn.ImageAlign = ContentAlignment.MiddleLeft;
            confirmBtn.Location = new Point(59, 459);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(214, 72);
            confirmBtn.TabIndex = 0;
            confirmBtn.Text = "           Confirm Return";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Visible = false;
            confirmBtn.Click += button1_Click;
            // 
            // materialDivider3
            // 
            materialDivider3.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider3.Depth = 0;
            materialDivider3.Dock = DockStyle.Left;
            materialDivider3.Location = new Point(680, 0);
            materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider3.Name = "materialDivider3";
            materialDivider3.Size = new Size(10, 685);
            materialDivider3.TabIndex = 5;
            materialDivider3.Text = "materialDivider3";
            // 
            // Returns
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 35, 43);
            Controls.Add(panel3);
            Controls.Add(materialDivider3);
            Controls.Add(panel2);
            Controls.Add(materialDivider2);
            Controls.Add(panel1);
            Controls.Add(materialDivider1);
            Name = "Returns";
            Size = new Size(1032, 685);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Panel panel1;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private PictureBox pictureBox1;
        private TextBox userTextbox;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox bookTextBox;
        private PictureBox pictureBox3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button confirmBtn;
        private Label label4;
        private Label label3;
        private Label bookLabel;
        private Label nameLabel;
    }
}
