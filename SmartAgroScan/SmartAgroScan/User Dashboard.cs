using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace SmartAgroScan
{
    public partial class User_Dashboard : Form
    {
        public User_Dashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_or_Admin userOrAdmin = new User_or_Admin();
            userOrAdmin.ShowDialog();
        }

        private void User_Dashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            // Data Source = MARUP; Initial Catalog = PlantTest; Integrated Security = True; Trust Server Certificate = True
            string connectionString = @"Data Source=MARUP;Initial Catalog=PlantTest;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Users";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds); // Fill the dataset with the results of the query
            DataTable dt = ds.Tables[0]; // Get the first table from the DataSet
            dataGridView1.AutoGenerateColumns = true; // Allow the DataGridView to automatically generate columns based on the DataTable
            dataGridView1.DataSource = dt; // Set the DataSource of the DataGridView to the DataTable


        }

    }
}
