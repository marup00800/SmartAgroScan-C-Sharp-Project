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
    public partial class Plant_Management : Form
    {

        string connectionString = "Data Source = Marup;Initial Catalog=PlantTest;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public Plant_Management()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Plant_Management_Load(object sender, EventArgs e)
        {
            LoadData();
            loadSoilData();
        }

        private void clear()
        {
            txtPlantId.Clear();
            txtName.Clear();
            txtPicturePath.Clear();
            txtRecommendedSoil.Clear();
            txtWaterTip.Clear();
            txtFertilizerTip.Clear();
            txtHarvestTip.Clear();
            pictureBox1.Image = null;
        }
        private void LoadData()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Plant";
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
                MessageBox.Show("Error selecting row: " + ex.Message);
                return;
            }
            txtPlantId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPicturePath.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRecommendedSoil.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtWaterTip.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtFertilizerTip.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtHarvestTip.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            try
            {
                string imagePath = Path.Combine(Application.StartupPath, txtPicturePath.Text); // like bin\Debug\images\mango.jpg
                if (File.Exists(imagePath))
                {
                    pictureBox1.Image = new Bitmap(imagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox1.Image = null;
                    MessageBox.Show("Image not found: " + imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO Plant (Name, PicturePath, RecommendedSoil, WaterTip, FertilizerTip, HarvestTip) " +
                           "VALUES (@Name, @PicturePath, @RecommendedSoil, @WaterTip, @FertilizerTip, @HarvestTip)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@PicturePath", txtPicturePath.Text);
            cmd.Parameters.AddWithValue("@RecommendedSoil", txtRecommendedSoil.Text);
            cmd.Parameters.AddWithValue("@WaterTip", txtWaterTip.Text);
            cmd.Parameters.AddWithValue("@FertilizerTip", txtFertilizerTip.Text);
            cmd.Parameters.AddWithValue("@HarvestTip", txtHarvestTip.Text);

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

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string oldPath = openFileDialog1.FileName;
                string fileName = Path.GetFileName(oldPath);

                // 📁 bin > Debug > net8.0-windows > images
                string imageFolder = Path.Combine(Application.StartupPath, "images");
                Directory.CreateDirectory(imageFolder); // create if not exists

                string newPath = Path.Combine(imageFolder, fileName);

                File.Copy(oldPath, newPath, true); // 📥 copy image

                pictureBox1.Image = new Bitmap(newPath); // 🖼 show in pictureBox
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                txtPicturePath.Text = "images/" + fileName; // 📝 store relative path
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "UPDATE Plant SET Name = @Name, PicturePath = @PicturePath, RecommendedSoil = @RecommendedSoil, " +
                           "WaterTip = @WaterTip, FertilizerTip = @FertilizerTip, HarvestTip = @HarvestTip WHERE PlantId = @PlantId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PlantId", txtPlantId.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@PicturePath", txtPicturePath.Text);
            cmd.Parameters.AddWithValue("@RecommendedSoil", txtRecommendedSoil.Text);
            cmd.Parameters.AddWithValue("@WaterTip", txtWaterTip.Text);
            cmd.Parameters.AddWithValue("@FertilizerTip", txtFertilizerTip.Text);
            cmd.Parameters.AddWithValue("@HarvestTip", txtHarvestTip.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("User updated successfully!");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM Plant WHERE PlantId = @PlantId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PlantId", txtPlantId.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("User deleted successfully!");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        ////////////////////////////////////////////// SOIL TESTING /////////////////////////////////////////////////////////
        ///

        private void clearSoilFields()
        {
            txtTestId.Clear();
            txtN.Clear();
            txtP.Clear();
            txtK.Clear();
            txtPh.Clear();
            txtMoisture.Clear();
            txtSoilCondition.Clear();
        }
        private void loadSoilData()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM SoilTest";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = dataTable;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            txtTestId.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtN.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtP.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtK.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPh.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtMoisture.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtSoilCondition.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void btnInsert2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO SoilTest (N, P, K, Ph, Moisture, DateTested, SoilCondition) " +
               "VALUES (@N, @P, @K, @Ph, @Moisture, @DateTested, @SoilCondition)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@N", txtN.Text);
            cmd.Parameters.AddWithValue("@P", txtP.Text);
            cmd.Parameters.AddWithValue("@K", txtK.Text);
            cmd.Parameters.AddWithValue("@Ph", txtPh.Text);
            cmd.Parameters.AddWithValue("@Moisture", txtMoisture.Text);
            cmd.Parameters.AddWithValue("@DateTested", DateTime.Now);
            cmd.Parameters.AddWithValue("@SoilCondition", txtSoilCondition.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Soil test added successfully!");
                loadSoilData();
                clearSoilFields();
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

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "UPDATE SoilTest SET N = @N, P = @P, K = @K, Ph = @Ph, Moisture = @Moisture, SoilCondition = @SoilCondition WHERE TestId = @TestId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TestId", txtTestId.Text);
            cmd.Parameters.AddWithValue("@N", txtN.Text);
            cmd.Parameters.AddWithValue("@P", txtP.Text);
            cmd.Parameters.AddWithValue("@K", txtK.Text);
            cmd.Parameters.AddWithValue("@Ph", txtPh.Text);
            cmd.Parameters.AddWithValue("@Moisture", txtMoisture.Text);
            cmd.Parameters.AddWithValue("@SoilCondition", txtSoilCondition.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Soil test updated successfully!");
                loadSoilData();
                clearSoilFields();
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

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM SoilTest WHERE TestId = @TestId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TestId", txtTestId.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Soil test deleted successfully!");
                loadSoilData();
                clearSoilFields();
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

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM SoilTest WHERE TestID LIKE '" + txtSearch2.Text + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = dt;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Control_Panel adminControlPanel = new Admin_Control_Panel();
            adminControlPanel.Show();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            clear();

        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            loadSoilData();
            clearSoilFields();

        }

        private void btnRelations_Click(object sender, EventArgs e)
        {
            Relations relationsForm = new Relations();
            relationsForm.ShowDialog();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

