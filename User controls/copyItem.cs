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
    public partial class copyItem : UserControl
    {
        public copyItem(string number, string status)
        {
            InitializeComponent();
            numberLabel.Text = number;
            statusLabel.Text = status;
        }
    }
}
