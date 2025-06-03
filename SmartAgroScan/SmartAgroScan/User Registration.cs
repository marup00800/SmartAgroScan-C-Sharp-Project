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
    public partial class User_Registration : Form
    {
        public User_Registration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void User_Registration_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Login userLogin = new User_Login();
            userLogin.ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Login userLogin = new User_Login();
            userLogin.ShowDialog();

            String connectionString = @"Data Source=MARUP;Initial Catalog=PlantTest;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO Users [UserID], [FullName], [Username], [Password], [Gender], [Role], [Age], [DOB]" +
                "VALUES (@FullName, @Username, @Password, @Occupation, @Gender, @DOB)";

            SqlCommand cmd = new SqlCommand(query, connection);
            
            string gender = groupBoxGender.Controls.OfType<RadioButton>()
               .First(r => r.Checked).Text;

            cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Role", radioButtonAdmin);
            cmd.Parameters.AddWithValue("@Age", txtAge.Text);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker.Value.ToString("yyyy-MM-dd"));
        }
    }
}
