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
            listView1 = new ListView();
            addBookBorrow = new CheckBox();
            addBookRef = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            addBookCategory = new TextBox();
            addBookAuthor = new TextBox();
            addBookBtn = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            button3 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.Read;
            pictureBox1.InitialImage = Properties.Resources.Read;
            pictureBox1.Location = new Point(74, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // addBookTItle
            // 
            addBookTItle.Location = new Point(32, 400);
            addBookTItle.Name = "addBookTItle";
            addBookTItle.Size = new Size(288, 27);
            addBookTItle.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(70, 70, 70);
            listView1.BorderStyle = BorderStyle.None;
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(342, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(690, 685);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.ControlAdded += listView1_ControlAdded;
            // 
            // addBookBorrow
            // 
            addBookBorrow.AutoSize = true;
            addBookBorrow.ForeColor = SystemColors.ControlLightLight;
            addBookBorrow.Location = new Point(219, 538);
            addBookBorrow.Name = "addBookBorrow";
            addBookBorrow.Size = new Size(108, 24);
            addBookBorrow.TabIndex = 5;
            addBookBorrow.Text = "Borrowable";
            addBookBorrow.UseVisualStyleBackColor = true;
            // 
            // addBookRef
            // 
            addBookRef.AutoSize = true;
            addBookRef.ForeColor = SystemColors.ControlLightLight;
            addBookRef.Location = new Point(219, 508);
            addBookRef.Name = "addBookRef";
            addBookRef.Size = new Size(97, 24);
            addBookRef.TabIndex = 5;
            addBookRef.Text = "Reference";
            addBookRef.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(32, 508);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 3;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(32, 439);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(32, 377);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 3;
            label1.Text = "Book Title";
            // 
            // addBookCategory
            // 
            addBookCategory.Location = new Point(118, 505);
            addBookCategory.MaxLength = 1;
            addBookCategory.Name = "addBookCategory";
            addBookCategory.PlaceholderText = "A-Z";
            addBookCategory.Size = new Size(35, 27);
            addBookCategory.TabIndex = 2;
            // 
            // addBookAuthor
            // 
            addBookAuthor.Location = new Point(32, 462);
            addBookAuthor.Name = "addBookAuthor";
            addBookAuthor.Size = new Size(288, 27);
            addBookAuthor.TabIndex = 2;
            // 
            // addBookBtn
            // 
            addBookBtn.BackColor = SystemColors.WindowFrame;
            addBookBtn.FlatAppearance.BorderSize = 0;
            addBookBtn.FlatStyle = FlatStyle.Flat;
            addBookBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBookBtn.ForeColor = SystemColors.ButtonFace;
            addBookBtn.Location = new Point(95, 587);
            addBookBtn.Name = "addBookBtn";
            addBookBtn.Size = new Size(134, 58);
            addBookBtn.TabIndex = 1;
            addBookBtn.Text = "Add Book";
            addBookBtn.UseVisualStyleBackColor = false;
            addBookBtn.Click += addBookBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 61, 61);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(addBookBorrow);
            panel2.Controls.Add(addBookRef);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(addBookCategory);
            panel2.Controls.Add(addBookAuthor);
            panel2.Controls.Add(addBookBtn);
            panel2.Controls.Add(addBookTItle);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 685);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
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
            pictureBox2.Location = new Point(302, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(296, 34);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(41, 41, 41);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.Edit;
            button3.Location = new Point(214, 298);
            button3.Name = "button3";
            button3.Size = new Size(36, 32);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 63);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // BookManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listView1);
            Controls.Add(panel2);
            Name = "BookManager";
            Size = new Size(1032, 685);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox addBookTItle;
        private ListView listView1;
        private CheckBox addBookBorrow;
        private CheckBox addBookRef;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox addBookCategory;
        private TextBox addBookAuthor;
        private Button addBookBtn;
        private Panel panel2;
        private Button button3;
        private Panel panel1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Label label4;
    }
}
