using SarasaviLibMS.Forms;

namespace SarasaviLibMS
{
    public partial class Home : Form
    {
        string user = "";
        public Home(string username)
        {
            user = username;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Login login = new Login();
            //login.ShowDialog();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(0);
        }

        private void inquiryBtn_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(1);
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
