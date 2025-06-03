using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartAgroScan
{
    public partial class User_or_Admin : Form
    {
        public User_or_Admin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Plant_Dashboard plantDashboard = new Plant_Dashboard();
            plantDashboard.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Dashboard userDashboard = new User_Dashboard();
            userDashboard.ShowDialog();
        }

        private void User_or_Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login adminLogin = new Admin_Login();
            adminLogin.ShowDialog();
        }
    }
}
