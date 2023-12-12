using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SarasaviLibMS.User_controls
{
    public partial class Inquiries : UserControl
    {
        SqlConnection connection = new SqlConnection(Program.connectionString);
        public Inquiries()
        {
            InitializeComponent();
        }
        private void refreshResults()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            dataTitle.Text = "";
            dataStatus.Text = "";
            dataPublisher.Text = "";
            dataBookID.Text = "";
            noCopiesLabel.Visible = false;
            searchLabel.Text = "Select a book to check status";

            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string getData = string.Format
                        ("SELECT * FROM books WHERE  len(id)=5 AND (id LIKE '%{0}%' OR title LIKE '%{0}%' OR publisher LIKE '%{0}%')", textBox1.Text);
                    using (SqlCommand comm = new SqlCommand(getData, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(comm);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        //noResults.Text = table.Rows.Count.ToString() + " results";
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow row in table.Rows)
                            {

                                flowLayoutPanel1.Controls.Add(new bookItem2(row["title"].ToString(), row["publisher"].ToString(), row["id"].ToString()));

                            }

                        }
                        else
                        {
                            // noResults.Text = "no results :(";

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                //noResults.Visible = true;
            }
            else
            {
                //noResults.Visible = false;
            }
            refreshResults();
        }

        private void Inquiries_Load(object sender, EventArgs e)
        {
            refreshResults();
        }
        string getStatus(string id)
        {

            string output = "";
            string getLoans = string.Format("SELECT * FROM loans where book = '{0}'", id);
            using (SqlCommand comm = new SqlCommand(getLoans, connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    output += " Borrowed by " + int.Parse(table.Rows[0]["borrower"].ToString()).ToString("D4") + ". ";
                }
                else { output += " Not loaned"; }
            }
            string getReservations = string.Format("SELECT * FROM reservations where book = '{0}'", id);
            using (SqlCommand comm = new SqlCommand(getReservations, connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    output += " Reserved by " + int.Parse(table.Rows[0]["member"].ToString()).ToString("D4") + ". ";
                }
                else { output += " Not reserved"; }
            }
            return output;
        }

        public void setNumber(string number)
        {
            searchLabel.Text = number;
            flowLayoutPanel2.Controls.Clear();
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string getBookdata = string.Format("SELECT * FROM books where id = '{0}'", number);
                using (SqlCommand comm = new SqlCommand(getBookdata, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {

                        DataRow row = table.Rows[0];

                        if (row["status"].ToString().Contains("Available"))
                        {

                            if (row["borrowable"].ToString() == "y")
                            {
                                dataStatus.Text = "Available, Borrowable.";
                            }
                            else
                            {
                                dataStatus.Text = "Available, Reference only";
                            }
                        }
                        else
                        {
                            dataStatus.Text = getStatus(number);
                        }

                        dataTitle.Text = row["title"].ToString();
                        dataPublisher.Text = row["publisher"].ToString();
                        dataBookID.Text = row["id"].ToString();


                    }

                }
                //copies

                string getCopies = string.Format("SELECT * FROM books where id like '{0}%' AND len(id)=6", number);
                using (SqlCommand comm = new SqlCommand(getCopies, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        noCopiesLabel.Visible = false;
                        foreach (DataRow row in table.Rows)
                        {
                            string statusText = "";
                            if (row["status"].ToString().Contains("Available"))
                            {

                                if (row["borrowable"].ToString() == "y")
                                {
                                    statusText = "Available, Borrowable.";
                                }
                                else
                                {
                                    statusText = "Available, Reference only";
                                }
                            }
                            else
                            {
                                statusText = getStatus(row["id"].ToString());
                            }
                            flowLayoutPanel2.Controls.Add(
                                new copyItem(row["id"].ToString(), statusText));
                        }
                    }
                    else
                    {
                        noCopiesLabel.Visible = true;
                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally { connection.Close(); }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            refreshResults();
        }

        private void dataStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
