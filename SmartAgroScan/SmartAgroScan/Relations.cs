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
using System.Data.SqlClient;

namespace SmartAgroScan
{
    public partial class Relations : Form
    {

        string connectionString = "Data Source = Marup;Initial Catalog=PlantTest;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public Relations()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Relations_Load(object sender, EventArgs e)
        {
            loadData();
        }


        private void clear()
        {
            txtRecommendationId.Clear();
            txtPlantId.Clear();
            txtTestId.Clear();
            txtSearchRecommendationId.Clear();
            txtSearchId.Clear();
            txtSearchTestId.Clear();

        }
        private void loadData()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM PlantRecommendation"; // Adjust the query as needed
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dataTable;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                txtRecommendationId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPlantId.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTestId.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (txtRecommendationId.Text == "" ||
                txtPlantId.Text == "" ||
                txtTestId.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            else
            {

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "INSERT INTO PlantRecommendation (PlantId, TestId) VALUES (@PlantId, @TestId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PlantId", txtPlantId.Text);
                command.Parameters.AddWithValue("@TestId", txtTestId.Text);
                command.ExecuteNonQuery();
                loadData();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("User updated successfully!");
                    loadData();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtRecommendationId.Text == "" ||
                txtPlantId.Text == "" ||
                txtTestId.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            else
            {

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "UPDATE PlantRecommendation SET PlantId = @PlantId, TestId = @TestId WHERE RecommendationId = @RecommendationId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RecommendationId", txtRecommendationId.Text);
                command.Parameters.AddWithValue("@PlantId", txtPlantId.Text);
                command.Parameters.AddWithValue("@TestId", txtTestId.Text);
                command.ExecuteNonQuery();
                loadData();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("User updated successfully!");
                    loadData();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtRecommendationId.Text == "" ||
                txtPlantId.Text == "" ||
                txtTestId.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            else
            {

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "DELETE FROM PlantRecommendation WHERE RecommendationId = @RecommendationId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RecommendationId", txtRecommendationId.Text);
                command.ExecuteNonQuery();
                loadData();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("User updated successfully!");
                    loadData();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            loadData();
            clear();
        }

        private void btnSearchRecommendationId_Click(object sender, EventArgs e)
        {
            if (txtSearchRecommendationId.Text == "")
            {
                MessageBox.Show("Please enter a Recommendation ID to search.");
                return;
            }
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM PlantRecommendation WHERE RecommendationId = @RecommendationId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RecommendationId", txtSearchRecommendationId.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dataTable;

        }

        private void btnSearchTestId_Click(object sender, EventArgs e)
        {

            if (txtSearchTestId.Text == "")
            {
                MessageBox.Show("Please enter a Test ID to search.");
                return;
            }
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM PlantRecommendation WHERE TestId = @TestId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestId", txtSearchTestId.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dataTable;
        }

        private void btnSearchPlantId_Click(object sender, EventArgs e)
        {

            if (txtSearchId.Text == "")
            {
                MessageBox.Show("Please enter a Plant ID to search.");
                return;
            }
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM PlantRecommendation WHERE PlantId = @PlantId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PlantId", txtSearchId.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dataTable;
        }
    }
}
