namespace SmartAgroScan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAdmin = new Button();
            btnUser = new Button();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(130, 212, 216);
            btnAdmin.FlatStyle = FlatStyle.Popup;
            btnAdmin.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnAdmin.ForeColor = Color.FromArgb(7, 67, 73);
            btnAdmin.Location = new Point(307, 350);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(155, 63);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "ADMIN";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.FromArgb(7, 67, 73);
            btnUser.FlatStyle = FlatStyle.Popup;
            btnUser.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.FromArgb(130, 212, 216);
            btnUser.Location = new Point(561, 351);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(153, 62);
            btnUser.TabIndex = 2;
            btnUser.Text = "USER";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1037, 705);
            Controls.Add(btnAdmin);
            Controls.Add(btnUser);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdmin;
        private Button btnUser;
    }
}
