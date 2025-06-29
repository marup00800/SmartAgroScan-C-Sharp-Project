namespace SmartAgroScan
{
    partial class Admin_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login));
            btnBack = new Button();
            btnCreateAccount = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(1153, 780);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(83, 34);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.Transparent;
            btnCreateAccount.FlatStyle = FlatStyle.Popup;
            btnCreateAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCreateAccount.ForeColor = SystemColors.ButtonHighlight;
            btnCreateAccount.Location = new Point(553, 689);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(248, 34);
            btnCreateAccount.TabIndex = 14;
            btnCreateAccount.Text = "Create Account as Admin";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(70, 152, 156);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(648, 509);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(222, 25);
            txtPassword.TabIndex = 13;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(70, 152, 156);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(648, 443);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(222, 25);
            txtUsername.TabIndex = 12;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(622, 614);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(108, 34);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Admin_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1382, 1020);
            Controls.Add(btnBack);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_Login";
            Text = "Admin_Login";
            Load += Admin_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnCreateAccount;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
    }
}