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
    public partial class loanItem : UserControl
    {
        public loanItem( string a, string b, string c, string d)
        {
            InitializeComponent();
            bookNumber.Text = a;
            userNumber.Text = int.Parse(b).ToString("d4");
            date.Text = c;
            returnDate.Text = d;
        }

        private void loanItem_Load(object sender, EventArgs e)
        {

        }
    }
}
