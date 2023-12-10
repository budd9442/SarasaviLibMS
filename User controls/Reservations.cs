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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SarasaviLibMS.User_controls
{
    public partial class Reservations : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\budd\source\repos\SarasaviLibMS\bin\Debug\library.mdf;Integrated Security=True;Connect Timeout=30");

        public Reservations()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void refreshResults()
        {
            flowLayoutPanel1.Controls.Clear();
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string getData = string.Format
                        ("SELECT * FROM reservations WHERE user LIKE '%{0}%' AND book LIKE '%{1}%' ", userFilter.Text, bookFilter.Text.ToUpper());
                    using (SqlCommand comm = new SqlCommand(getData, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(comm);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow row in table.Rows)
                            {

                                string checkBookStatus = String.Format("SELECT status from books where id='{0}'", row["book"]);
                                string status;
                                using (SqlCommand cmd = new SqlCommand(checkBookStatus, connection))
                                {
                                    status = cmd.ExecuteScalar().ToString();

                                }
                                flowLayoutPanel1.Controls.Add(new reservationItem(row["book"].ToString(), row["member"].ToString(), status));



                            }

                        }
                        else
                        {

                        }
                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally { connection.Close(); }
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string checkIfReserved = string.Format("SELECT COUNT(*) FROM reservations WHERE book= '{0}'", borrowBookNum.Text.ToUpper());
                    using (SqlCommand cmd = new SqlCommand(checkIfReserved, connection))
                    {
                        if ((int)cmd.ExecuteScalar() != 0)
                        {
                            MessageBox.Show("Book already reserved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                            return;
                        }

                    }
                    string checkUserNumber = string.Format("SELECT COUNT(*) FROM members WHERE number= {0}", borrowUserNum.Text.Trim());
                    using (SqlCommand cmd = new SqlCommand(checkUserNumber, connection))
                    {
                        if ((int)cmd.ExecuteScalar() == 0)
                        {
                            MessageBox.Show("User does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                            return;
                        }

                    }
                    string checkBookNumber = string.Format("SELECT COUNT(*) FROM books WHERE id= '{0}'", borrowBookNum.Text.ToUpper());
                    using (SqlCommand cmd = new SqlCommand(checkBookNumber, connection))
                    {
                        if ((int)cmd.ExecuteScalar() == 0)
                        {
                            MessageBox.Show("Book does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                            return;
                        }

                    }
                    string checkBookAvailability = string.Format("SELECT COUNT(*) FROM books WHERE id='{0}' AND status='Available'", borrowBookNum.Text.ToUpper().Trim());
                    using (SqlCommand cmd = new SqlCommand(checkBookAvailability, connection))
                    {
                        if ((int)cmd.ExecuteScalar() != 0)
                        {
                            DialogResult dResult = MessageBox.Show("Book is already available. Borrow instead?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (dResult == DialogResult.Yes)
                            {
                                Home home = this.ParentForm as Home;
                                if (home != null)
                                {
                                    home.switchToLoans();
                                }
                            }
                            connection.Close();
                            return;
                        }

                    }
                    string insertData = string.Format("INSERT INTO reservations (member,book,reserved_on) VALUES('{0}','{1}','{2}')",
                                borrowUserNum.Text.Trim(),
                                borrowBookNum.Text.ToUpper().Trim(),
                                DateTime.Now.ToShortDateString()
                                );
                    using (SqlCommand command = new SqlCommand(insertData, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("success");
                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connection.Close();
                    refreshResults();
                }
            }
        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            refreshResults();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refreshResults();
        }

        private void Reservations_Paint(object sender, PaintEventArgs e)
        {
            refreshResults();
        }
    }
}
