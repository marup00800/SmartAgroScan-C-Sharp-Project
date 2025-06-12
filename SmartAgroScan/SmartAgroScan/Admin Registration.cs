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


namespace SmartAgroScan
{
    public partial class Admin_Registration : Form
    {

        string connectionString = @"Data Source=Marup;Initial Catalog=PlantTest;Integrated Security=True;Trust Server Certificate=True";
        public Admin_Registration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login adminLogin = new Admin_Login();
            adminLogin.ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO Users (FullName, Username, Password, Gender, Role, Age, DOB) " +
                           "VALUES (@FullName, @Username, @Password, @Gender, @Role, @Age, @DOB)";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Gender", groupBoxGender.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked)?.Text ?? "Not Specified");
            cmd.Parameters.AddWithValue("@Role", "Admin");
            cmd.Parameters.AddWithValue("@Age", txtAge.Text);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker.Value);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration successful!");
                this.Hide();
                Admin_Login adminLogin = new Admin_Login();
                adminLogin.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during registration: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Admin_Registration_Load(object sender, EventArgs e)
        {

        }

       
    }
}
