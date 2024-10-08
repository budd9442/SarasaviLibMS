﻿using Microsoft.Data.SqlClient;
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
    public partial class Returns : UserControl
    {
        SqlConnection connection = new SqlConnection(Program.connectionString);

        public Returns()
        {
            InitializeComponent();
            emptyBookList();
        }

        void emptyBookList()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < 5; i++)
            {
                flowLayoutPanel1.Controls.Add(new returnItem("", ""));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (userTextbox.Text.Length == 0 || userTextbox.Text.Length > 4)
            {
                MessageBox.Show("Invalid user number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return;
            }
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string checkUserNumber = string.Format("SELECT COUNT(*) FROM members WHERE number= {0}", userTextbox.Text.Trim());
                    using (SqlCommand cmd = new SqlCommand(checkUserNumber, connection))
                    {
                        if ((int)cmd.ExecuteScalar() == 0)
                        {
                            MessageBox.Show("User does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                            return;
                        }
                        else
                        {
                            

                            string getLoans = string.Format("SELECT book,returnDate FROM loans WHERE borrower = {0}", int.Parse(userTextbox.Text));
                            using (SqlCommand comm = new SqlCommand(getLoans, connection))
                            {
                                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                                DataTable table = new DataTable();
                                adapter.Fill(table);
                                //MessageBox.Show(table.Rows.Count.ToString());
                                if (table.Rows.Count > 0)
                                {
                                    flowLayoutPanel1.Controls.Clear();
                                    foreach (DataRow row in table.Rows)
                                    {

                                        flowLayoutPanel1.Controls.Add(
                                            new returnItem(
                                                row["book"].ToString(),
                                                DateTime.Parse(row["returnDate"].ToString()).ToShortDateString()));

                                    }
                                    userTextbox.Enabled = false;
                                    bookTextBox.Enabled = true;
                                    pictureBox2.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("User hasn't borrowed any books", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    connection.Close();
                                    return;

                                }
                            }
                            string getUserName = string.Format("SELECT name FROM members WHERE number = {0}", userTextbox.Text);
                            using(SqlCommand comm = new SqlCommand(getUserName, connection))
                            {
                                nameLabel.Text = comm.ExecuteScalar().ToString();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bookTextBox.Text)) 
            {
              
                return;
            }
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string getUserName = string.Format("SELECT title FROM books WHERE id = '{0}'", bookTextBox.Text.ToUpper().Trim());
                    using (SqlCommand comm = new SqlCommand(getUserName, connection))
                    {
                        Object? title = comm.ExecuteScalar();
                        if (title != null)
                        {
                            bookLabel.Text = title.ToString();
                            pictureBox2.Enabled = false;
                            bookTextBox.Enabled = false;
                            confirmBtn.Visible = true; 
                        }
                        else
                        {
                            MessageBox.Show("Invalid book number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button2_Click(object sender, EventArgs e)
        {
            bookTextBox.Text = "";
            userTextbox.Text = "";
            nameLabel.Text = "";
            bookLabel.Text = "";
            bookTextBox.Enabled = false;
            userTextbox.Enabled = true;
            pictureBox2.Enabled = false;
            pictureBox1.Enabled = true;
            confirmBtn.Visible = false;
            emptyBookList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {

                    connection.Open();
                    //MessageBox.Show(connection.State.ToString());
                    string checkBookNumber = string.Format("SELECT COUNT(*) FROM loans WHERE book= '{0}' AND borrower = {1} ", bookTextBox.Text.Trim(), userTextbox.Text);
                    using (SqlCommand cmd = new SqlCommand(checkBookNumber, connection))
                    {
                        if ((int)cmd.ExecuteScalar() == 0)
                        {
                            MessageBox.Show("User hasn't borrowed this book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                            return;
                        }
                        else
                        {
                            bookTextBox.Enabled = false;
                            string deleteLoanRecord = string.Format("DELETE FROM loans WHERE book='{0}' AND borrower={1}", bookTextBox.Text.Trim(), userTextbox.Text);
                            using (SqlCommand cmd1 = new SqlCommand(deleteLoanRecord, connection))
                            {
                                cmd1.ExecuteNonQuery();
                                //MessageBox.Show("deleteLoanRecord");
                            }
                            string checkReservations = string.Format("SELECT COUNT(*) FROM reservations WHERE book='{0}' AND member={1}", bookTextBox.Text.Trim(), userTextbox.Text);
                            using (SqlCommand cmd2 = new SqlCommand(checkReservations, connection))
                            {
                                string status = (int)cmd2.ExecuteScalar() == 0 ? "Available" : "Reserved";
                                //MessageBox.Show("checkReservations");
                                string updateBook = string.Format("UPDATE books SET status ='{0}' WHERE id = '{1}'", status, bookTextBox.Text.ToUpper().Trim());
                                using (SqlCommand cmd3 = new SqlCommand(updateBook, connection))
                                {
                                    cmd3.ExecuteNonQuery();
                                    //MessageBox.Show("upDateBook");
                                }

                                MessageBox.Show(
                                "Book : " + bookLabel.Text + "\n\n" +
                                "Borrower : " + nameLabel.Text + "\n\n" +
                                "Return : Success " + DateTime.Now.ToShortDateString() + "\n\n" +
                                "Status : " + status,
                                "Confirmation",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                bookTextBox.Text = "";
                                userTextbox.Text = "";
                                nameLabel.Text = "";
                                bookLabel.Text = "";
                                bookTextBox.Enabled = false;
                                userTextbox.Enabled = true;
                                pictureBox2.Enabled = false;
                                pictureBox1.Enabled = true;
                                confirmBtn.Visible = false;
                                emptyBookList();



                            }

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void setBookText(string text)
        {


            bookTextBox.Text = text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
