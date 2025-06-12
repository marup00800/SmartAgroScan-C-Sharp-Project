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
    public partial class User_Management : Form
    {
        public User_Management()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void clear()
        {

            txtUserId.Text = "";
            txtFullName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtGender.Text = "";
            txtRole.Text = "";
            txtAge.Text = "";
            txtDateofBirth.Text = "";

        }


        private void LoadData()
        {
            string connectionString = "Data Source=DESKTOP-FGFOKG6;Initial Catalog=PlantTest;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Users";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            dataGridViewUser.AutoGenerateColumns = true;
            dataGridViewUser.DataSource = dataTable;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "" ||
                txtFullName.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                txtGender.Text == "" ||
                txtRole.Text == "" ||
                txtAge.Text == "" ||
                txtDateofBirth.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else
            {
                string connectionString = "Data Source=DESKTOP-FGFOKG6;Initial Catalog=PlantTest;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "UPDATE Users SET [FullName] = '" + txtFullName.Text + "', [Username] = '" + txtUsername.Text + "', [Password] = '" + txtPassword.Text + "', [Gender] = '" + txtGender.Text + "', [Role] = '" + txtRole.Text + "', [Age] = '" + txtAge.Text + "', [DOB] = '" + txtDateofBirth.Text + "' WHERE [UserID] = '" + txtUserId.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("User updated successfully.");

                LoadData();
                clear();
            }

        }


        private void btnInsert_Click(object sender, EventArgs e)
        {


            if (
                txtFullName.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                txtGender.Text == "" ||
                txtRole.Text == "" ||
                txtAge.Text == "" ||
                txtDateofBirth.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;

            }
            else
            {
                string connectionString = @"Data Source=DESKTOP-FGFOKG6;Initial Catalog=PlantTest;Integrated Security=True;Trust Server Certificate=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "INSERT INTO Users (FullName, Username, Password, Gender, Role, Age, DOB) " +
                               "VALUES (@FullName, @Username, @Password, @Gender, @Role, @Age, @DOB)";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@Role", txtRole.Text);
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                cmd.Parameters.AddWithValue("@DOB", txtDateofBirth.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User added successfully!");
                    LoadData();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-FGFOKG6;Initial Catalog=PlantTest;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Users WHERE UserID LIKE '" + txtSearch.Text + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridViewUser.AutoGenerateColumns = true;
            dataGridViewUser.DataSource = dt;

        }

        private void User_Management_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
               "If you delete this user, all the user relation data will be deleted an the deleted data can not be restore. Are you sure you want to delete this user?",
               "Confirm Deletion",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string connectionString = "Data Source=DESKTOP-FGFOKG6;Initial Catalog=PlantTest;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string deleteChatQuery = "DELETE FROM GlobalChat WHERE UserID = @UserID";
                SqlCommand cmdChat = new SqlCommand(deleteChatQuery, connection);
                cmdChat.Parameters.AddWithValue("@UserID", txtUserId.Text);
                cmdChat.ExecuteNonQuery();


                string query = "DELETE FROM Users WHERE UserID = '" + txtUserId.Text + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User deleted successfully.");
                LoadData();
                clear();
            }
            else
            {
                MessageBox.Show("User deletion cancelled.");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Hide();
            Admin_Control_Panel adminControlPanelForm = new Admin_Control_Panel();
            adminControlPanelForm.ShowDialog();

        }



        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex < 0) return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row: " + ex.Message);
                return;
            }

            txtUserId.Text = dataGridViewUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFullName.Text = dataGridViewUser.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtUsername.Text = dataGridViewUser.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dataGridViewUser.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGender.Text = dataGridViewUser.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtRole.Text = dataGridViewUser.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtAge.Text = dataGridViewUser.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtDateofBirth.Text = dataGridViewUser.Rows[e.RowIndex].Cells[7].Value.ToString();



        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
