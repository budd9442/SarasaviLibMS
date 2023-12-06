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
    public partial class userItem : UserControl
    {
        public userItem(string id="", string name="")
        {
            InitializeComponent();
            userIdLabel.Text = id;
            nameLabel.Text = name;
        }

        private void userItem_Load(object sender, EventArgs e)
        {

        }

        private void userItem_Click(object sender, EventArgs e)
        {

        }

        private void userItem_MouseEnter(object sender, EventArgs e)
        {
            this.Height = 100;
        }

        private void userItem_MouseLeave(object sender, EventArgs e)
        {
            this.Height = 40;
        }
    }
}
