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
    public partial class UserManager : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\budd\source\repos\SarasaviLibMS\bin\Debug\library.mdf;Integrated Security=True;Connect Timeout=30");

        public UserManager()
        {
            InitializeComponent();
            refreshResults();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
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

                                flowLayoutPanel1.Controls.Add(new userItem(((int)row["number"]).ToString("D4"), row["name"].ToString()));

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

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addUserName.Text) ||
                string.IsNullOrWhiteSpace(addUserAddress.Text) ||
                string.IsNullOrWhiteSpace(addUserNIC.Text))
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
                        string getExistingUser = string.Format("SELECT COUNT(*) FROM members WHERE nic='{0}'", addUserNIC.Text);
                        using (SqlCommand cmd = new SqlCommand(getExistingUser, connection))
                        {
                            if ((int)cmd.ExecuteScalar() > 0)
                            {
                                MessageBox.Show("NIC is already registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        string insertData = "INSERT INTO members " +
                            "(name,nic,gender,address) VALUES" +
                            string.Format("('{0}',{1},'{2}','{3}')",
                            addUserName.Text,
                            addUserNIC.Text,
                            addUserGender.Text,
                            addUserAddress.Text
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
                    finally
                    {
                        connection.Close();
                        refreshResults();
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0)
            {
                noResults.Visible = true;
            }
            else
            {
                noResults.Visible = false;
            }
            refreshResults();

        }

        private void UserManager_Paint(object sender, PaintEventArgs e)
        {
            refreshResults();
        }
    }
}
