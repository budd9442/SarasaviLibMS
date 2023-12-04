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
using Microsoft.Data;
using Microsoft.IdentityModel.Tokens;
using System.DirectoryServices.ActiveDirectory;


namespace SarasaviLibMS.Forms
{
    public partial class Register : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\budd\source\repos\SarasaviLibMS\bin\Debug\library.mdf;Integrated Security=True;Connect Timeout=30");
        public Register()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(regUsername.Text) ||
                string.IsNullOrWhiteSpace(regGender.Text) ||
                string.IsNullOrWhiteSpace(regNIC.Text) ||
                string.IsNullOrWhiteSpace(regPasswd.Text) ||
                string.IsNullOrWhiteSpace(regAddr.Text))
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
                        string checkUsername = "SELECT COUNT(*) FROM users WHERE username=@username";
                        using (SqlCommand cmd = new SqlCommand(checkUsername, connection))
                        {
                            cmd.Parameters.AddWithValue("username", regUsername.Text.Trim());
                            int count = (int)cmd.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("Username is taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = string.Format("INSERT INTO users ( userName, password, NIC , address ) " +
                                    "values('{0}','{1}','{2}','{3}')", regUsername.Text, regPasswd.Text, regNIC.Text, regAddr.Text);
                                using (SqlCommand insertCmd = new SqlCommand(insertData, connection))
                                {
                                    insertCmd.ExecuteNonQuery();
                                    MessageBox.Show("Registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Login login = new Login();
                                    login.Show();
                                    this.Close();
                                }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            regPasswd.UseSystemPasswordChar = checkBox1.Checked ? false : true;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
