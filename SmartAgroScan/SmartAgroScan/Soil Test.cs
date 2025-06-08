using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        private string userName; // This is the username of the logged-in user
        private int userId; // This is the user ID of the logged-in user
        private GlobalChatService chatService; // This is the chat service instance for global chat functionality
        public Soil_Test(string username, int userId)
        {
            this.userName = username;
            this.userId = userId;
            this.chatService = new GlobalChatService(userId);
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }



        private void btnTest_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (txtN.Text == "" || txtP.Text == "" || txtK.Text == "" || txtPH.Text == "" || txtMoisture.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;

            }

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
                            AND st.Moisture = @Moisture";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@N", n);
            cmd.Parameters.AddWithValue("@P", p);
            cmd.Parameters.AddWithValue("@K", k);
            // cmd.Parameters.AddWithValue("@pH", ph);
            cmd.Parameters.AddWithValue("@Moisture", moisture);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                txtSoilCondition.Text = SoilCondition(ph);

                txtRecomendedPlant.Text = dt.Rows[0]["Name"].ToString();
                txtRecomendedSoil.Text = dt.Rows[0]["RecommendedSoil"].ToString();
                txtWaterTip.Text = dt.Rows[0]["WaterTip"].ToString();
                txtFertilizerTip.Text = dt.Rows[0]["FertilizerTip"].ToString();
                txtHarvestTip.Text = dt.Rows[0]["HarvestTip"].ToString();

                string picturePath = dt.Rows[0]["PicturePath"].ToString();

                string fullPath = Path.Combine(Application.StartupPath, picturePath); // picturePath = "images/tomato.jpg"

                if (File.Exists(fullPath))
                {
                    pictureBoxPlant.Image = Image.FromFile(fullPath);
                }
                else
                {
                    MessageBox.Show("Image file not found: " + fullPath);
                    pictureBoxPlant.Image = null; // Clear the image if not found
                }
            }
            else
            {
                MessageBox.Show("Sorry, Data is not found.");
                return;

            }
        }

        private string SoilCondition(double ph)
        {
            if (ph < 3.5)
                return "Extremely Acidic";
            else if (ph >= 3.5 && ph < 4.5)
                return "Very Strongly Acidic";
            else if (ph >= 4.5 && ph < 5.0)
                return "Strongly Acidic";
            else if (ph >= 5.0 && ph < 5.5)
                return "Moderately Acidic";
            else if (ph >= 5.5 && ph < 6.0)
                return "Slightly Acidic";
            else if (ph >= 6.0 && ph < 6.8)
                return "Nearly Neutral";
            else if (ph >= 6.8 && ph <= 7.3)
                return "Neutral";
            else if (ph > 7.3 && ph <= 7.8)
                return "Slightly Alkaline";
            else if (ph > 7.8 && ph <= 8.5)
                return "Moderately Alkaline";
            else if (ph > 8.5 && ph <= 9.0)
                return "Strongly Alkaline";
            else
                return "Extremely Alkaline";
        }


        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            User_Login userLogin = new User_Login();
            userLogin.ShowDialog();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            chatService.InsertMessage(userId, Wusername.Text, txtMessage.Text);
            chatService.LoadMessages(richTextBoxGlobalChat);

            richTextBoxGlobalChat.SelectionStart = richTextBoxGlobalChat.Text.Length;
            richTextBoxGlobalChat.ScrollToCaret();

            txtMessage.Clear();
            txtMessage.Focus();
        }



        private void Soil_Test_Load(object sender, EventArgs e)
        {
            Wusername.Text = userName; // Display the username in the label
            chatService.LoadMessages(richTextBoxGlobalChat);
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            chatService.LoadMessages(richTextBoxGlobalChat);

            richTextBoxGlobalChat.SelectionStart = richTextBoxGlobalChat.Text.Length;
            richTextBoxGlobalChat.ScrollToCaret();
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

        private void pictureBoxPlant_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void richTextBoxGlobalChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtMoisture_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtPH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Wusername_Click(object sender, EventArgs e)
        {

        }
    }
}