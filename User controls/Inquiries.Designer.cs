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
            noResults = new Label();
            titleLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
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
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(32, 35, 43);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 42);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(446, 389);
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 32, 38);
            panel2.Controls.Add(searchLabel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 431);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 125);
            panel2.TabIndex = 0;
            // 
            // searchLabel
            // 
            searchLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchLabel.ForeColor = SystemColors.ControlDark;
            searchLabel.Location = new Point(72, 44);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(308, 31);
            searchLabel.TabIndex = 3;
            searchLabel.Text = "Select a book to check status";
            searchLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // noResults
            // 
            noResults.AutoSize = true;
            noResults.ForeColor = SystemColors.Control;
            noResults.Location = new Point(487, 63);
            noResults.Name = "noResults";
            noResults.Size = new Size(84, 20);
            noResults.TabIndex = 2;
            noResults.Text = "no results :(";
            noResults.Visible = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = SystemColors.ControlDark;
            titleLabel.Location = new Point(522, 14);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(49, 28);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(522, 123);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 3;
            label2.Text = "Publisher";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(522, 178);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 3;
            label3.Text = "Status";
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
            // Inquiries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 45, 53);
            Controls.Add(noResults);
            Controls.Add(materialDivider1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(titleLabel);
            Name = "Inquiries";
            Size = new Size(1034, 556);
            Load += Inquiries_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Label noResults;
        private TextBox textBox1;
        private Label label4;
        private Label searchLabel;
        private Label titleLabel;
        private Label label2;
        private Label label3;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}
