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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Registration adminRegistration = new Admin_Registration();
            adminRegistration.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   
            this.Hide();
            Admin_Control_Panel admin_Control_Panel = new Admin_Control_Panel();
            admin_Control_Panel.ShowDialog();

        }
    }
}
