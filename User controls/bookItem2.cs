using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarasaviLibMS.User_controls
{
    public partial class bookItem2 : UserControl
    {
        string title = "";
        string author = "";
        string bookNum = "";
        string status = "";
        public bookItem2(string title, string author, string bookNum, string status = "1")
        {
            this.title = title;
            this.author = author;
            this.bookNum = bookNum;
            this.status = status;
            InitializeComponent();
        }

        private void bookItem2_Load(object sender, EventArgs e)
        {
            titleLabel.Text = title + "\nPublished by " + author;
            numberLabel.Text = bookNum;

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            try
            {
                Inquiries inquiries = this.Parent.Parent.Parent as Inquiries; // :(
                if (inquiries != null)
                {
                    inquiries.setNumber(bookNum);
                }
            }catch(Exception ex)
            {
                //tbi
            }
            
        }
    }
}
