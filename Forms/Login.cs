using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SarasaviLibMS.Forms
{
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\budd\source\repos\SarasaviLibMS\bin\Debug\library.mdf;Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            loginPasswd.UseSystemPasswordChar = checkBox1.Checked ? false : true;
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            Register regform = new Register();
            this.Hide();
            regform.Show();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginUsername.Text) ||
                string.IsNullOrWhiteSpace(loginPasswd.Text) )
            {
                MessageBox.Show("Please fill in all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connection.State != ConnectionState.Open)
                {
                    try { 
                        connection.Open();
                        string getData = string.Format
                            ("SELECT * FROM users WHERE userName = '{0}' AND password='{1}'",loginUsername.Text,loginPasswd.Text);
                        using (SqlCommand comm = new SqlCommand(getData, connection))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(comm);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Logged in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show("Username or password incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                            
                        


                    } catch (Exception ex) 
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally { connection.Close(); }
                }
            }
        }
    }
}
