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
        }

        private void clear()
        {

            txtUserId.Clear();
            txtFullName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtGender.Clear();
            txtRole.Clear();
            txtAge.Clear();
            txtDateofBirth.Clear();

        }


        private void LoadData()
        {
            string connectionString = "Data Source=MARUP;Initial Catalog=PlantTest;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
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
                string connectionString = "Data Source=MARUP;Initial Catalog=PlantTest;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
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

            SqlConnection connection = new SqlConnection("Data Source=MARUP;Initial Catalog=PlantTest;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            connection.Open();

        }


        private void User_Management_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Hide();
            Admin_Control_Panel adminControlPanelForm = new Admin_Control_Panel();
            adminControlPanelForm.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
