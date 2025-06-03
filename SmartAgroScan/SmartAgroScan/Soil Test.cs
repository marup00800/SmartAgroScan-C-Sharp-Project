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
    public partial class Soil_Test : Form
    {
        public Soil_Test()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            double n = double.Parse(txtN.Text);
            double p = double.Parse(txtP.Text);
            double k = double.Parse(txtK.Text);
            double ph = double.Parse(txtPH.Text);
            double moisture = double.Parse(txtMoisture.Text);

            string connectionString = @"Data Source=MARUP;Initial Catalog=PlantTest;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = @"
                       SELECT 
                            st.SoilCondition,
                            p.PlantID,
                            p.Name,
                            p.PicturePath,
                            p.RecommendedSoil,
                            p.WaterTip,
                            p.FertilizerTip,
                            p.HarvestTip
                        FROM 
                            dbo.SoilTest AS st
                        INNER JOIN 
                            dbo.PlantRecommendation AS pr ON st.TestID = pr.TestID
                        INNER JOIN 
                            dbo.Plant AS p ON pr.PlantID = p.PlantID
                        WHERE 
                            st.N = @N 
                            AND st.P = @P 
                            AND st.K = @K 
                            AND st.pH = @pH 
                            AND st.Moisture = @Moisture";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@N", n);
            cmd.Parameters.AddWithValue("@P", p);
            cmd.Parameters.AddWithValue("@K", k);
            cmd.Parameters.AddWithValue("@pH", ph);
            cmd.Parameters.AddWithValue("@Moisture", moisture);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds); // Fill the dataset with the results of the query
            DataTable dt = ds.Tables[0]; // Get the first table from the DataSet

            txtSoilCondition.Text = dt.Rows[0]["SoilCondition"].ToString();
            txtRecomendedPlant.Text = dt.Rows[0]["Name"].ToString();
            txtRecomendedSoil.Text = dt.Rows[0]["RecommendedSoil"].ToString();
            txtWaterTip.Text = dt.Rows[0]["WaterTip"].ToString();
            txtFertilizerTip.Text = dt.Rows[0]["FertilizerTip"].ToString();
            txtHarvestTip.Text = dt.Rows[0]["HarvestTip"].ToString();


        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            User_Login userLogin = new User_Login();
            userLogin.ShowDialog();

        }

        private void grpOutput_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtSoilCondition_TextChanged(object sender, EventArgs e)
        {

        }

        private void Soil_Test_Load(object sender, EventArgs e)
        {

        } //Warning: Dont remove this method, it is required for the form to load properly.

        private void txtRecomendedPlant_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRecomendedSoil_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWaterTip_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFertilizerTip_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHarvestTip_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}