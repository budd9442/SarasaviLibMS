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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            switch (status)
            {
                case "Reserved":
                    panel1.BackColor =Color.FromArgb(2, 138, 15);
                    statLabel.Text = "Available";
                    return;
                
                //case "Available:
                default:
                    panel1.BackColor = Color.FromArgb(4, 146, 194);
                    statLabel.Text = "Pending";
                    return;
            }
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
                        string nextStatus;
                        connection.Open();
                        string delete = string.Format("DELETE FROM reservations WHERE book = '{0}'", bookLabel.Text);
                        using (SqlCommand cmd = new SqlCommand(delete, connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        string checkIfLoaned = string.Format("SELECT COUNT(*) FROM loans WHERE book = '{0}'", bookLabel.Text);
                        using (SqlCommand cmd = new SqlCommand(checkIfLoaned, connection))
                        {
                            nextStatus = (int)cmd.ExecuteScalar() > 0 ? "loaned" : "Available";
                        }

                        string updateBook = string.Format("UPDATE books SET status ='{0}' WHERE id = '{1}'", nextStatus, bookLabel.Text);
                        using (SqlCommand cmd3 = new SqlCommand(updateBook, connection))
                        {
                            cmd3.ExecuteNonQuery();
                            MessageBox.Show("upDateBook");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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
