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
                        string getNextNumber = string.Format("SELECT COUNT(*) FROM books WHERE classification='{0}'", addBookCategory.Text);
                        using (SqlCommand cmd = new SqlCommand(getNextNumber, connection))
                        {
                            nextNumber = (int)cmd.ExecuteScalar() + 1;
                        }


                        string insertData = "INSERT INTO books " +
                            "(classification,number,title,author,borrowable,id) VALUES" +
                            string.Format("('{0}',{1},'{2}','{3}',{4},'{5}')",
                            addBookCategory.Text, nextNumber,
                            addBookTItle.Text,
                            addBookAuthor.Text,
                            addBookBorrow.Checked ? 1 : 0,
                        (addBookCategory.Text + nextNumber.ToString("D4"))
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
                    finally { connection.Close(); }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listView1.Controls.Add(new bookItem(textBox1.Text, "testicle monster", "A0001"));
        }

        private void listView1_ControlAdded(object sender, ControlEventArgs e)
        {
            results += 1;
            label4.Text = results.ToString();
        }
    }
}
