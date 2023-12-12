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
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string getData = string.Format
                        ("SELECT * FROM books WHERE id LIKE '%{0}%' OR title LIKE '%{0}%' OR publisher LIKE '%{0}%'", textBox1.Text);
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

                                flowLayoutPanel1.Controls.Add(new bookItem2(row["title"].ToString(), row["publisher"].ToString(), row["id"].ToString()));

                            }

                        }
                        else
                        {
                            noResults.Text = "no results :(";

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
                noResults.Visible = true;
            }
            else
            {
                noResults.Visible = false;
            }
            refreshResults();
        }

        private void Inquiries_Load(object sender, EventArgs e)
        {
            refreshResults();
        }

        public void setNumber(string number)
        {
            searchLabel.Text = number;
        }
    }
}
