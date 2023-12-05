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
    public partial class BookManager : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\budd\source\repos\SarasaviLibMS\bin\Debug\library.mdf;Integrated Security=True;Connect Timeout=30");
        private int results;

        public BookManager()
        {
            InitializeComponent();
            refreshResults();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addBookTItle.Text) ||
                string.IsNullOrWhiteSpace(addBookCategory.Text) ||
                string.IsNullOrWhiteSpace(addBookAuthor.Text))
            {
                MessageBox.Show("Please fill in all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();
                        int nextNumber = 0;
                        int copies = 0;
                        string? mainCopyid = "";
                        string getNextNumber = string.Format("SELECT COUNT(*) FROM books WHERE classification='{0}'", addBookCategory.Text);
                        using (SqlCommand cmd = new SqlCommand(getNextNumber, connection))
                        {
                            nextNumber = (int)cmd.ExecuteScalar() + 1;
                        }
                        string getNextCopy = string.Format("SELECT COUNT(*) FROM books WHERE title='{0}'", addBookTItle.Text);
                        using (SqlCommand cmd = new SqlCommand(getNextCopy, connection))
                        {
                            copies = (int)cmd.ExecuteScalar();
                            if (copies > 0) {
                                string getMainCopyId = string.Format("SELECT id FROM books WHERE title='{0}'", addBookTItle.Text);
                                using (SqlCommand cmd2 = new SqlCommand(getMainCopyId, connection))
                                {
                                    mainCopyid = cmd2.ExecuteScalar().ToString();
                                    MessageBox.Show(mainCopyid);
                                }
                            }
                        }
                        


                        string insertData = "INSERT INTO books " +
                            "(classification,number,title,author,borrowable,id) VALUES" +
                            string.Format("('{0}',{1},'{2}','{3}',{4},'{5}')",
                            addBookCategory.Text, nextNumber,
                            addBookTItle.Text,
                            addBookAuthor.Text,
                            addBookBorrow.Checked ? 1 : 0,
                            copies == 0 ? addBookCategory.Text + nextNumber.ToString("D4") : mainCopyid + (copies).ToString() // if nextcopy != 0, maincopyid is never null
                            );
                        using (SqlCommand command = new SqlCommand(insertData, connection))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("succes");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally { 
                        connection.Close(); 
                        refreshResults();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls.Add(new bookItem(textBox1.Text, "testicle monster", "A0001"));
            
            if(textBox1.Text.Length > 0) {
                noResults.Visible = true;
            }
            else
            {
                noResults.Visible=false;
            }
            refreshResults();
            


        }

        private void listView1_ControlAdded(object sender, ControlEventArgs e)
        {
            results += 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox3.Visible = false;
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
                        ("SELECT * FROM books WHERE id LIKE '%{0}%' OR title LIKE '%{0}%' OR author LIKE '%{0}%'", textBox1.Text);
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
                                #pragma warning disable CS8604
                                flowLayoutPanel1.Controls.Add(new bookItem(row["title"].ToString(), row["author"].ToString(), row["id"].ToString()));
                                #pragma warning restore CS8604 
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
    }
}
