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

        string connectionString = "Data Source = Marup;Initial Catalog=PlantTest;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public User_Management()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void User_Management_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadUserActivityData();
            LoadGlobalChatData();

        }


        ///////////////////////////////////////////////////////////////////////////// User Tab ////////////////////////////////////////////////
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

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Users";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            dataGridViewUser.AutoGenerateColumns = true;
            dataGridViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        // Search button click event handler
        private void button1_Click(object sender, EventArgs e)
        {


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



        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
               "If you delete this user, all the user relation data will be deleted an the deleted data can not be restore. Are you sure you want to delete this user?",
               "Confirm Deletion",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

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





        ////////////////////////////////////////////////////////////////////////// User Activity Tab ////////////////////////////////////////////////


        public void userActivityClear()
        {
            txtActivityId.Text = "";
            txtUserId2.Text = "";
            txtTestId.Text = "";
            txtActivityType.Text = "";
            txtActivityTime.Text = "";
            txtSearch2.Text = "";
            txtSearch3.Text = "";
            txtSearch4.Text = "";
        }

        public void LoadUserActivityData()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM UserActivity";
            SqlCommand cmd = new SqlCommand(query, conn); // Execute the query to retrieve data
            SqlDataAdapter da = new SqlDataAdapter(cmd); // Create a SqlDataAdapter to fill the DataSet
            DataSet ds = new DataSet(); // Create a new DataSet to hold the results
            da.Fill(ds); // Fill the dataset with the results of the query
            DataTable dt = ds.Tables[0]; // Get the first table from the DataSet
            dataGridView1.AutoGenerateColumns = true; // Allow the DataGridView to automatically generate columns based on the DataTable
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // 🟢 Make columns stretch to fill the view
            dataGridView1.DataSource = dt; // Set the DataSource of the DataGridView to the DataTable


            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query2 = "SELECT * FROM SoilTestRequest";
            SqlCommand command = new SqlCommand(query2, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            dataGridView2.AutoGenerateColumns = true; // Automatically generate columns based on the data source
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = dataTable; // Set the DataSource of the DataGridView to the DataTable
        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
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

            txtActivityId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUserId2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTestId.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtActivityType.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtActivityTime.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSearch4.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void btnInsert2_Click(object sender, EventArgs e)
        {
            if (txtUserId2.Text == "" ||
                txtActivityType.Text == "" ||
                txtActivityTime.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "INSERT INTO UserActivity (TestID, UserID,ActivityType, ActivityTime) " +
                               "VALUES (@TestID, @UserID, @ActivityType, @ActivityTime)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", txtUserId2.Text);
                cmd.Parameters.AddWithValue("@TestID", txtTestId.Text);
                cmd.Parameters.AddWithValue("@ActivityType", txtActivityType.Text);
                cmd.Parameters.AddWithValue("@ActivityTime", txtActivityTime.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User activity added successfully!");
                    LoadUserActivityData();
                    userActivityClear();
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

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            if (txtActivityId.Text == "" ||
                txtUserId2.Text == "" ||
                txtTestId.Text == "" ||
                txtActivityType.Text == "" ||
                txtActivityTime.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "UPDATE UserActivity SET [TestID] = @TestID, [UserID] = @UserID,  [ActivityType] = @ActivityType, [ActivityTime] = @ActivityTime WHERE [ActivityID] = @ActivityID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", txtUserId2.Text);
                cmd.Parameters.AddWithValue("@TestID", txtTestId.Text);
                cmd.Parameters.AddWithValue("@ActivityType", txtActivityType.Text);
                cmd.Parameters.AddWithValue("@ActivityTime", txtActivityTime.Text);
                cmd.Parameters.AddWithValue("@ActivityID", txtActivityId.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User activity updated successfully.");
                LoadUserActivityData();
                userActivityClear();
            }

        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM UserActivity WHERE ActivityID = @ActivityID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ActivityID", txtActivityId.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User activity deleted successfully.");
            LoadUserActivityData();
            userActivityClear();
        }


        private void btnSearch2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM UserActivity WHERE ActivityID LIKE '" + txtSearch2.Text + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;

        }


        private void btnSearch3_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM SoilTestRequest WHERE RequestID LIKE '" + txtSearch3.Text + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = dt;

        }


        private void btnSearch4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM SoilTestRequest WHERE UserID LIKE '" + txtSearch4.Text + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = dt;
        }
        private void btnClear2_Click(object sender, EventArgs e)
        {
            userActivityClear();
            LoadUserActivityData();
        }



        private void btnBack2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Control_Panel adminControlPanelForm = new Admin_Control_Panel();
            adminControlPanelForm.ShowDialog();

        }


        ////////////////////////////////////////////////////////////////////////// Global Chat Tab //////////////////////////////////////////////////////////

        public void clearGlobalChat()
        {
            txtSearch5.Text = "";
            txtSearch6.Text = "";
        }


        public void LoadGlobalChatData()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM GlobalChat";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            dataGridView4.AutoGenerateColumns = true; // Automatically generate columns based on the data source
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Make columns stretch to fill the view
            dataGridView4.DataSource = dataTable; // Set the DataSource of the DataGridView to the DataTable
        }

        private void btnSearch6_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM GlobalChat WHERE UserID LIKE '" + txtSearch6.Text + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView4.AutoGenerateColumns = true;
            dataGridView4.DataSource = dt;

        }

        private void btnSearch5_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM GlobalChat WHERE ChatID LIKE '%" + txtSearch5.Text + "%'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView4.AutoGenerateColumns = true;
            dataGridView4.DataSource = dt;

        }

        private void btnDelete3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM GlobalChat WHERE ChatID = @ChatID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ChatID", txtSearch5.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Chat message deleted successfully.");
            LoadGlobalChatData();
            clearGlobalChat();

        }

        private void btnRefresh3_Click(object sender, EventArgs e)
        {
            LoadGlobalChatData();
            clearGlobalChat();

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            txtSearch5.Text = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSearch6.Text = dataGridView4.Rows[e.RowIndex].Cells[4].Value.ToString();


        }



        private void btnBack3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Control_Panel adminControlPanelForm = new Admin_Control_Panel();
            adminControlPanelForm.ShowDialog();

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void tabPageUserActivity_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDateofBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch5_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
