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
    public partial class User_Login : Form
    {
        public User_Login()
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
            User_Registration userRegistration = new User_Registration();
            userRegistration.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string connectionString = @"Data Source=MARUP;Initial Catalog=PlantTest;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                Soil_Test soilTestForm = new Soil_Test(username);
                soilTestForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }


        }

        private void User_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
