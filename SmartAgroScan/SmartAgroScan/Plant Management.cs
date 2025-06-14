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
            dataGridView1.DataSource = dataTable;


        }
        private void Plant_Management_Load(object sender, EventArgs e)
        {
            LoadData();

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();

        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        
    }
}

