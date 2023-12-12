namespace SarasaviLibMS.User_controls
{
    partial class Inquiries
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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel4 = new Panel();
            textBox1 = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            searchLabel = new Label();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            noCopiesLabel = new Label();
            label2 = new Label();
            titleLabel = new Label();
            label3 = new Label();
            dataTitle = new Label();
            dataPublisher = new Label();
            label5 = new Label();
            dataStatus = new Label();
            dataBookID = new Label();
            panel3 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 556);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(32, 35, 43);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 42);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(446, 474);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(27, 32, 38);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(446, 42);
            panel4.TabIndex = 7;
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
            label4.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 32, 38);
            panel2.Controls.Add(searchLabel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 516);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 40);
            panel2.TabIndex = 0;
            // 
            // searchLabel
            // 
            searchLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchLabel.ForeColor = SystemColors.ControlDark;
            searchLabel.Location = new Point(82, 3);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(308, 31);
            searchLabel.TabIndex = 3;
            searchLabel.Text = "Select a book to check status";
            searchLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Dock = DockStyle.Left;
            materialDivider1.Location = new Point(446, 0);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(10, 556);
            materialDivider1.TabIndex = 4;
            materialDivider1.Text = "materialDivider1";
            // 
            // noCopiesLabel
            // 
            noCopiesLabel.AutoSize = true;
            noCopiesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noCopiesLabel.ForeColor = SystemColors.ControlLightLight;
            noCopiesLabel.Location = new Point(574, 353);
            noCopiesLabel.Name = "noCopiesLabel";
            noCopiesLabel.Size = new Size(347, 28);
            noCopiesLabel.TabIndex = 3;
            noCopiesLabel.Text = "No extra copies available for this book";
            noCopiesLabel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(4, 191);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 3;
            label2.Text = "Publisher";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = SystemColors.ControlLightLight;
            titleLabel.Location = new Point(6, 51);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(49, 28);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(10, 233);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 3;
            label3.Text = "Status";
            // 
            // dataTitle
            // 
            dataTitle.BackColor = Color.FromArgb(52, 55, 63);
            dataTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataTitle.ForeColor = SystemColors.ControlDark;
            dataTitle.Location = new Point(118, 51);
            dataTitle.Name = "dataTitle";
            dataTitle.Size = new Size(439, 130);
            dataTitle.TabIndex = 3;
            // 
            // dataPublisher
            // 
            dataPublisher.BackColor = Color.FromArgb(52, 55, 63);
            dataPublisher.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataPublisher.ForeColor = SystemColors.ControlDark;
            dataPublisher.Location = new Point(118, 191);
            dataPublisher.Name = "dataPublisher";
            dataPublisher.Size = new Size(439, 32);
            dataPublisher.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(6, 8);
            label5.Name = "label5";
            label5.Size = new Size(81, 28);
            label5.TabIndex = 3;
            label5.Text = "Book ID";
            // 
            // dataStatus
            // 
            dataStatus.BackColor = Color.FromArgb(52, 55, 63);
            dataStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataStatus.ForeColor = SystemColors.ControlDark;
            dataStatus.Location = new Point(118, 233);
            dataStatus.Name = "dataStatus";
            dataStatus.Size = new Size(439, 33);
            dataStatus.TabIndex = 3;
            dataStatus.Click += dataStatus_Click;
            // 
            // dataBookID
            // 
            dataBookID.BackColor = Color.FromArgb(52, 55, 63);
            dataBookID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataBookID.ForeColor = SystemColors.ControlDark;
            dataBookID.Location = new Point(118, 8);
            dataBookID.Name = "dataBookID";
            dataBookID.Size = new Size(439, 33);
            dataBookID.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(titleLabel);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(dataBookID);
            panel3.Controls.Add(dataStatus);
            panel3.Controls.Add(dataPublisher);
            panel3.Controls.Add(dataTitle);
            panel3.Location = new Point(452, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(578, 269);
            panel3.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(456, 207);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(578, 349);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // Inquiries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 45, 53);
            Controls.Add(panel3);
            Controls.Add(noCopiesLabel);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(materialDivider1);
            Controls.Add(panel1);
            Name = "Inquiries";
            Size = new Size(1034, 556);
            Load += Inquiries_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private TextBox textBox1;
        private Label label4;
        private Label searchLabel;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Label noCopiesLabel;
        private Label label2;
        private Label titleLabel;
        private Label label3;
        private Label dataTitle;
        private Label dataPublisher;
        private Label label5;
        private Label dataStatus;
        private Label dataBookID;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
