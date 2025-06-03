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
    public partial class Plant_Dashboard : Form
    {
        public Plant_Dashboard()
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

        private void plantLoad()
        {
            string connectionString = @"Data Source=MARUP;Initial Catalog=PlantTest;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Plant";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds); // Fill the dataset with the results of the query
            DataTable dt = ds.Tables[0]; // Get the first table from the DataSet
            dataGridViewPalnt.AutoGenerateColumns = true; // Allow the DataGridView to automatically generate columns based on the DataTable
            dataGridViewPalnt.DataSource = dt; // Set the DataSource of the DataGridView to the DataTable
        }

        private void testValueLoad()
        {

            string connectionString = @"Data Source=MARUP;Initial Catalog=PlantTest;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM SoilTest";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds); // Fill the dataset with the results of the query
            DataTable dt = ds.Tables[0]; // Get the first table from the DataSet
            dataGridViewValues.AutoGenerateColumns = true; // Allow the DataGridView to automatically generate columns based on the DataTable
            dataGridViewValues.DataSource = dt; // Set the DataSource of the DataGridView to the DataTable

        }


        private void Plant_Dashboard_Load(object sender, EventArgs e)
        {
            plantLoad();
            testValueLoad();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
