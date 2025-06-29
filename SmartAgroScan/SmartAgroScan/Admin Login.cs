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

namespace SmartAgroScan
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Registration adminRegistration = new Admin_Registration();
            adminRegistration.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string connectionString = @"Data Source=MARUP;Initial Catalog=PlantTest;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT UserID FROM Users WHERE Username = @Username AND Password = @Password AND Role = 'Admin'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int userId = (int)reader["UserID"];
                MessageBox.Show("Login successful!");
                this.Hide();
                Admin_Control_Panel adminControlPanel = new Admin_Control_Panel();
                adminControlPanel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");


            }
        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
