using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SarasaviLibMS.User_controls
{
    public partial class Loans : UserControl
    {
        SqlConnection connection = new SqlConnection(Program.connectionString);

        public Loans()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Borrowals_Load(object sender, EventArgs e)
        {
            borrowDate.Text = DateTime.Now.ToShortDateString();
            borrrowReturnDate.Text = DateTime.Now.AddDays(14).ToShortDateString();
            refreshResults();
        }

        private void bookCheckBtn_Click(object sender, EventArgs e)
        {


        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (borrowBookNum.Text.Length < 5 || borrowBookNum.Text.Length > 6)
            {
                MessageBox.Show("Please enter a valid book number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();
                        bool bookExists = false;
                        bool borrowable = false;
                        bool available = false;
                        bool alreadyReserved = false;
                        bool userExists = false;
                        bool usercanBorrow = false;

                        string checkBookNumber = string.Format("SELECT COUNT(*) FROM books WHERE id= '{0}'", borrowBookNum.Text.ToUpper());
                        using (SqlCommand cmd = new SqlCommand(checkBookNumber, connection))
                        {
                            bookExists = (int)cmd.ExecuteScalar() > 0 ? true : false;

                        }
                        string checkBookAvailability = string.Format("SELECT COUNT(*) FROM books WHERE id='{0}' AND status='Available'", borrowBookNum.Text.ToUpper().Trim());
                        using (SqlCommand cmd = new SqlCommand(checkBookAvailability, connection))
                        {
                            available = (int)cmd.ExecuteScalar() > 0 ? true : false;

                        }
                        if (!available)
                        {
                            string checkReservedUser = string.Format("SELECT member FROM reservations WHERE book='{0}'",borrowBookNum.Text.ToUpper().Trim());
                            using (SqlCommand cmd = new SqlCommand(checkReservedUser, connection))
                            {
                                object? output = cmd.ExecuteScalar();
                                if(output != null)
                                {
                                    if( output.ToString() == borrowUserNum.Text )
                                    {
                                        available = true;
                                    }
                                    else
                                    {
                                        alreadyReserved = true;
                                    }
                                }
                            }
                        }
                        
                        string checkBookBorrowable = string.Format("SELECT COUNT(*) FROM books WHERE id='{0}' AND borrowable='y'", borrowBookNum.Text.ToUpper().Trim());
                        using (SqlCommand cmd = new SqlCommand(checkBookBorrowable, connection))
                        {
                            borrowable = (int)cmd.ExecuteScalar() > 0 ? true : false;

                        }
                        string checkUserNumber = string.Format("SELECT COUNT(*) FROM members WHERE number= {0}", borrowUserNum.Text.Trim());
                        using (SqlCommand cmd = new SqlCommand(checkUserNumber, connection))
                        {
                            userExists = (int)cmd.ExecuteScalar() > 0 ? true : false;

                        }
                        string checkBorrowedBooks = string.Format("SELECT COUNT(*) FROM loans WHERE borrower= {0}", borrowUserNum.Text.Trim());
                        using (SqlCommand cmd = new SqlCommand(checkBorrowedBooks, connection))
                        {
                            usercanBorrow = (int)cmd.ExecuteScalar() < 5 ? true : false;

                        }

                        if (!bookExists)
                        {
                            MessageBox.Show("Invalid book id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                            return;
                        }
                        if (!userExists)
                        {
                            MessageBox.Show("Invalid user id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                            return;
                        }
                        if (!borrowable)
                        {
                            MessageBox.Show("Book not borrowable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                            return;
                        }

                        if (alreadyReserved)
                        {
                            MessageBox.Show("This book is not available and have been reserved by another user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                            return;
                        }

                        if (!available)
                        {
                            DialogResult dResult = MessageBox.Show("Book not available. Add a reservation instead?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (dResult == DialogResult.Yes)
                            {
                                Home home = this.ParentForm as Home;
                                if (home != null)
                                {
                                    home.switchToReservations();
                                }
                            }
                            connection.Close();
                            return;
                        }
                        if (!usercanBorrow)
                        {
                            MessageBox.Show("User must return borrowed books before borrowing another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                            return;
                        }

                        string getTitle = string.Format("SELECT title FROM books WHERE id = '{0}'", borrowBookNum.Text.ToUpper().Trim());
                        string getName = string.Format("SELECT name FROM members where number = '{0}'", borrowUserNum.Text.Trim());
                        string title;
                        string name;
                        using (SqlCommand cmd = new SqlCommand(getTitle, connection))
                        {
                            title = (string)cmd.ExecuteScalar();
                        }
                        using (SqlCommand cmd = new SqlCommand(getName, connection))
                        {
                            name = (string)cmd.ExecuteScalar();
                        }

                        DialogResult result = MessageBox.Show(
                            "Book : " + title + "\n\n" +
                            "Borrower : " + name + "\n\n" +
                            "Return : " + borrrowReturnDate.Text,
                            "Confirm loan",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            string insertData = string.Format("INSERT INTO loans (borrower,book,loanDate,returnDate) VALUES({0},'{1}','{2}','{3}')",
                                borrowUserNum.Text.Trim(),
                                borrowBookNum.Text.ToUpper().Trim(),
                                DateTime.Now.ToShortDateString(),
                                DateTime.Now.AddDays(14).ToShortDateString()
                                );
                            using (SqlCommand command = new SqlCommand(insertData, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                            string deleteReservation = string.Format("DELETE FROM reservations WHERE book = '{0}'", borrowBookNum.Text.ToUpper());
                            using (SqlCommand command = new SqlCommand(deleteReservation, connection))
                            {
                                if (command.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Reservation for book " + borrowBookNum.Text + " has been deleted","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }
                            string updadeBook = string.Format("UPDATE books SET status = 'loaned' WHERE id = '{0}'", borrowBookNum.Text.ToUpper());
                            using (SqlCommand command = new SqlCommand(updadeBook, connection))
                            {
                                command.ExecuteNonQuery();
                                MessageBox.Show("Book succesfully loaned", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                connection.Close();
                                refreshResults();
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            borrowBookNum.Clear();
            borrowUserNum.Clear();
        }

        private void refreshResults()
        {
            flowLayoutPanel1.Controls.Clear();
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string getData = string.Format
                        ("SELECT * FROM loans WHERE borrower LIKE '%{0}%' AND book LIKE '%{1}%' ", userFilter.Text, bookFilter.Text.ToUpper());
                    using (SqlCommand comm = new SqlCommand(getData, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(comm);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        noResults.Text = table.Rows.Count.ToString() + " results";
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow row in table.Rows)
                            {

                                flowLayoutPanel1.Controls.Add(
                                    new loanItem(
                                        row["book"].ToString(),
                                        row["borrower"].ToString(),
                                        DateTime.Parse(row["loanDate"].ToString()).ToShortDateString(),
                                        DateTime.Parse(row["returnDate"].ToString()).ToShortDateString()));

                            }

                        }
                        else
                        {
                            noResults.Text = "no records match the filters";

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

        private void button2_Click(object sender, EventArgs e)
        {
            refreshResults();
        }

        private void Loans_Paint(object sender, PaintEventArgs e)
        {
            refreshResults();
        }
    }
}
