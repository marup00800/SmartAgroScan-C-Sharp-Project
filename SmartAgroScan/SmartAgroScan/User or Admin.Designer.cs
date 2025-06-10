namespace SmartAgroScan
{
    partial class User_or_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPlantDasboard = new Button();
            btnUserDashboard = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnPlantDasboard
            // 
            btnPlantDasboard.Location = new Point(241, 165);
            btnPlantDasboard.Name = "btnPlantDasboard";
            btnPlantDasboard.Size = new Size(170, 102);
            btnPlantDasboard.TabIndex = 5;
            btnPlantDasboard.Text = "Plant Dashboard";
            btnPlantDasboard.UseVisualStyleBackColor = true;
            btnPlantDasboard.Click += btnAdmin_Click;
            // 
            // btnUserDashboard
            // 
            btnUserDashboard.Location = new Point(38, 165);
            btnUserDashboard.Name = "btnUserDashboard";
            btnUserDashboard.Size = new Size(170, 102);
            btnUserDashboard.TabIndex = 4;
            btnUserDashboard.Text = "User Dashboard";
            btnUserDashboard.UseVisualStyleBackColor = true;
            btnUserDashboard.Click += btnUser_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(371, 400);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(105, 38);
            btnBack.TabIndex = 44;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // User_or_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(585, 484);
            Controls.Add(btnBack);
            Controls.Add(btnPlantDasboard);
            Controls.Add(btnUserDashboard);
            DoubleBuffered = true;
            Name = "User_or_Admin";
            Text = "User_or_Admin";
            Load += User_or_Admin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlantDasboard;
        private Button btnUserDashboard;
        private Button btnBack;
    }
}