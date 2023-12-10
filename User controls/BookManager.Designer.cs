namespace SarasaviLibMS.User_controls
{
    partial class BookManager
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
            addBookTItle = new TextBox();
            addBookBorrow = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            addBookCategory = new TextBox();
            addBookPublisher = new TextBox();
            addBookBtn = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            noResults = new Label();
            panel4 = new Panel();
            textBox1 = new TextBox();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.Add_Book;
            pictureBox1.InitialImage = Properties.Resources.Read;
            pictureBox1.Location = new Point(79, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // addBookTItle
            // 
            addBookTItle.Location = new Point(31, 296);
            addBookTItle.Multiline = true;
            addBookTItle.Name = "addBookTItle";
            addBookTItle.Size = new Size(288, 83);
            addBookTItle.TabIndex = 2;
            // 
            // addBookBorrow
            // 
            addBookBorrow.AutoSize = true;
            addBookBorrow.ForeColor = SystemColors.ControlLightLight;
            addBookBorrow.Location = new Point(211, 464);
            addBookBorrow.Name = "addBookBorrow";
            addBookBorrow.Size = new Size(108, 24);
            addBookBorrow.TabIndex = 5;
            addBookBorrow.Text = "Borrowable";
            addBookBorrow.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(31, 465);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 3;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(31, 396);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Publisher";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(31, 273);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 3;
            label1.Text = "Book Title";
            // 
            // addBookCategory
            // 
            addBookCategory.Location = new Point(117, 462);
            addBookCategory.MaxLength = 1;
            addBookCategory.Name = "addBookCategory";
            addBookCategory.PlaceholderText = "A-Z";
            addBookCategory.Size = new Size(35, 27);
            addBookCategory.TabIndex = 2;
            // 
            // addBookPublisher
            // 
            addBookPublisher.Location = new Point(31, 419);
            addBookPublisher.Name = "addBookPublisher";
            addBookPublisher.Size = new Size(288, 27);
            addBookPublisher.TabIndex = 2;
            // 
            // addBookBtn
            // 
            addBookBtn.BackColor = SystemColors.WindowFrame;
            addBookBtn.FlatAppearance.BorderSize = 0;
            addBookBtn.FlatStyle = FlatStyle.Flat;
            addBookBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBookBtn.ForeColor = SystemColors.ButtonFace;
            addBookBtn.Location = new Point(94, 544);
            addBookBtn.Name = "addBookBtn";
            addBookBtn.Size = new Size(134, 58);
            addBookBtn.TabIndex = 1;
            addBookBtn.Text = "Add Book";
            addBookBtn.UseVisualStyleBackColor = false;
            addBookBtn.Click += addBookBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 35, 43);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 685);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(addBookTItle);
            panel3.Controls.Add(addBookBorrow);
            panel3.Controls.Add(addBookBtn);
            panel3.Controls.Add(addBookPublisher);
            panel3.Controls.Add(addBookCategory);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(342, 685);
            panel3.TabIndex = 4;
            // 
            // noResults
            // 
            noResults.AutoSize = true;
            noResults.ForeColor = SystemColors.Control;
            noResults.Location = new Point(467, 15);
            noResults.Name = "noResults";
            noResults.Size = new Size(84, 20);
            noResults.TabIndex = 2;
            noResults.Text = "no results :(";
            noResults.Visible = false;
            noResults.Click += noResults_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(noResults);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(342, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(690, 42);
            panel4.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(32, 35, 43);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(82, 6);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "    title, book number or publisher ";
            textBox1.Size = new Size(364, 31);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(6, 8);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 3;
            label4.Text = "Search";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(42, 45, 53);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(342, 42);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(690, 643);
            flowLayoutPanel1.TabIndex = 6;
            flowLayoutPanel1.WrapContents = false;
            // 
            // BookManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(42, 45, 53);
            Controls.Add(panel4);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Name = "BookManager";
            Size = new Size(1032, 685);
            Paint += BookManager_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox addBookTItle;
        private CheckBox addBookBorrow;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox addBookCategory;
        private TextBox addBookAuthor;
        private Button addBookBtn;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Label noResults;
        private TextBox addBookPublisher;
        private TextBox textBox1;
        private Panel panel4;
        private Label label4;
    }
}
