using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarasaviLibMS.User_controls
{
    public partial class returnItem : UserControl
    {
        public returnItem(string book, string date)
        {
            InitializeComponent();
            label1.Text = book;
            label2.Text = date;

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Returns ret = this.Parent.Parent.Parent as Returns;
            if (ret != null && label1.Text.Length > 0)
            {
                ret.setBookText(label1.Text);
            }
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(52, 55, 63);
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(42, 45, 53);
        }
    }
}
