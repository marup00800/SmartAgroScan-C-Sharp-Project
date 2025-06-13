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
    public partial class Soil_Test_Request : Form
    {

        string connectionString = "Data Source = Marup;Initial Catalog=PlantTest;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public Soil_Test_Request()
        {
            InitializeComponent();
        }
 

        private void Soil_Test_Request_Load(object sender, EventArgs e)
        {
           


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

    }
}
