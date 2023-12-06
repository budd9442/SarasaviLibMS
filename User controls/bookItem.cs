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
    public partial class bookItem : UserControl
    {
        string title = "";
        string author = "";
        string bookNum = "";
        string status = "";
        public bookItem(string title, string author, string bookNum, string status="1" )
        {
            this.title = title;
            this.author = author;
            this.bookNum = bookNum;
            this.status = status;
            InitializeComponent();
        }

        private void bookItem_Load(object sender, EventArgs e)
        {
            bookTitle.Text = title + "\nPublished by " + author;
            bookNumber.Text = bookNum;
           
        }
    }
}
