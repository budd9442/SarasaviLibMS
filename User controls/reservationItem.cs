using Microsoft.Data.SqlClient;
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
    public partial class reservationItem : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\budd\source\repos\SarasaviLibMS\bin\Debug\library.mdf;Integrated Security=True;Connect Timeout=30");

        public reservationItem(string book, string user, string status)
        {
            InitializeComponent();
            bookLabel.Text = book;
            userLabel.Text = user;
            statLabel.Text = status == "loaned" ? "Pending" : "Available";
            panel1.BackColor = status == "loaned" ? Color.FromArgb(151, 188, 255) : Color.FromArgb(80, 200, 120);
        }

        private void reservationItem_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete this reservation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();
                        string checkIfReserved = string.Format("DELETE FROM reservations WHERE book = '{0}'", bookLabel.Text);
                        using (SqlCommand cmd = new SqlCommand(checkIfReserved, connection))
                        { 
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        connection.Close();
                        Reservations main = this.Parent.Parent as Reservations;
                        if (main != null)
                        {
                            main.refreshResults();
                        }

                    }
                }
            }
        }
    }
}
