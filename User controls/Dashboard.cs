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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SarasaviLibMS.User_controls
{
    public partial class Dashboard : UserControl
    {
        SqlConnection connection = new SqlConnection(Program.connectionString);
        public Dashboard()
        {

            InitializeComponent();




        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            refreshData();
            Home home = this.ParentForm as Home;
            if (home != null)
            {
                welcomeLabel.Text = string.Format("Welcome {0}!", home.user);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("t");
        }

        private void refreshData()
        {
            int books = 0;
            int members = 0;
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string getUsers = "SELECT COUNT(*) FROM members ";
                    using (SqlCommand cmd = new SqlCommand(getUsers, connection))
                    {
                        userLabel.Text = int.Parse(cmd.ExecuteScalar().ToString()).ToString("D2");
                    }
                    string getBooks = "SELECT COUNT(*) FROM books ";
                    using (SqlCommand cmd = new SqlCommand(getBooks, connection))
                    {
                        bookLabel.Text = int.Parse(cmd.ExecuteScalar().ToString()).ToString("D2");
                    }


                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                }

            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            refreshData();
        }
    }
}
