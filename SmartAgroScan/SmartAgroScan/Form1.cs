namespace SmartAgroScan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login adminLogin = new Admin_Login();
            adminLogin.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Login userLogin = new User_Login();
            userLogin.ShowDialog();
        }
    }
}
