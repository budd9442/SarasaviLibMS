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
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\budd\source\repos\SarasaviLibMS\bin\Debug\library.mdf;Integrated Security=True;Connect Timeout=30");

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
                        bool borrowable = false;
                        bool available = false;
                        bool userExists = false;
                        bool usercanBorrow = false;

                        string checkBookAvailability = string.Format("SELECT COUNT(*) FROM books WHERE id='{0}' AND status='Available'", borrowBookNum.Text.ToUpper().Trim());
                        using (SqlCommand cmd = new SqlCommand(checkBookAvailability, connection))
                        {
                            available = (int)cmd.ExecuteScalar() > 0 ? true : false;

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
                        string checkBorrowedBooks = string.Format("SELECT COUNT(*) FROM loans WHERE borrower= {0}",borrowUserNum.Text.Trim());
                        using (SqlCommand cmd = new SqlCommand(checkBorrowedBooks, connection))
                        {
                            usercanBorrow = (int)cmd.ExecuteScalar() < 5 ? true : false;

                        }

                        if (!borrowable)
                        {
                            MessageBox.Show("Book not borrowable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                            return;
                        }
                        if (!usercanBorrow)
                        {
                            MessageBox.Show("User must return borrowed books before borrowing another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close (); 
                            return;
                        }


                        if (borrowable && available && userExists && usercanBorrow)
                        {
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
                                    DateTime.Now.ToString("yyyy-MM-dd"),
                                    DateTime.Now.AddDays(14).ToString("yyyy-MM-dd")
                                    );
                                using (SqlCommand command = new SqlCommand(insertData, connection))
                                {
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("success");
                                }

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
                        ("SELECT * FROM members WHERE name LIKE '%{0}%' OR address LIKE '%{0}%' OR nic LIKE '%{0}%'", textBox3.Text);
                   




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally { connection.Close(); }
            }
        }
    }
}
