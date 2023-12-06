using Microsoft.Data.SqlClient;
using SarasaviLibMS.Classes;
using SarasaviLibMS.Forms;
using SarasaviLibMS.User_controls;
using System.Data;
using System.Net.Http.Headers;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SarasaviLibMS
{
    public partial class Home : Form
    {
        string user = "";
        private bool mouseDown;
        private Point lastLocation;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\budd\source\repos\SarasaviLibMS\bin\Debug\library.mdf;Integrated Security=True;Connect Timeout=30");

        public Home(string username)
        {
            user = username;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelMouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelMouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panelMouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Login login = new Login();
            //login.ShowDialog();


        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void inquiryBtn_Click(object sender, EventArgs e)
        {
            inquiriesBtn.BackColor = Color.FromArgb(61, 61, 61);
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {

        }


        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            setButtonColors(false, true, true, true, true, true, true);
            materialTabControl1.SelectTab(0);
        }

        public void setButtonColors(bool a, bool b, bool c, bool d, bool e, bool f, bool g)
        {
            Color dark = Color.FromArgb(31, 31, 31);
            Color light = Color.FromArgb(61, 61, 61);
            dashboardBtn.BackColor = a ? dark : light;
            burrowalsBtn.BackColor = b ? dark : light;
            returnsBtn.BackColor = c ? dark : light;
            inquiriesBtn.BackColor = d ? dark : light;
            reservationsBtn.BackColor = e ? dark : light;
            usersBtn.BackColor = f ? dark : light;
            booksBtn.BackColor = g ? dark : light;
        }

        private void burrowalsBtn_Click(object sender, EventArgs e)
        {
            setButtonColors(true, false, true, true, true, true, true);
            materialTabControl1.SelectTab(1);
        }

        private void returnsBtn_Click(object sender, EventArgs e)
        {
            setButtonColors(true, true, false, true, true, true, true);
            materialTabControl1.SelectTab(2);
        }

        private void inquiriesBtn_Click(object sender, EventArgs e)
        {
            setButtonColors(true, true, true, false, true, true, true);
            materialTabControl1.SelectTab(3);
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            setButtonColors(true, true, true, true, true, false, true);
            materialTabControl1.SelectTab(5);
        }

        private void booksBtn_Click(object sender, EventArgs e)
        {
            setButtonColors(true, true, true, true, true, true, false);
            materialTabControl1.SelectTab(6);


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void reservationsBtn_Click(object sender, EventArgs e)
        {
            setButtonColors(true, true, true, true, false, true, true);
            materialTabControl1.SelectTab(4);

        }


        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
