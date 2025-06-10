namespace SmartAgroScan
{
    partial class User_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Login));
            btnBack = new Button();
            btnCreateAccount = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(98, 172, 115);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnBack.Location = new Point(1775, 932);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 42);
            btnBack.TabIndex = 24;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(98, 172, 115);
            btnCreateAccount.FlatStyle = FlatStyle.Popup;
            btnCreateAccount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCreateAccount.Location = new Point(833, 751);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(247, 42);
            btnCreateAccount.TabIndex = 21;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(70, 152, 156);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtPassword.Location = new Point(919, 529);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(255, 32);
            txtPassword.TabIndex = 20;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(70, 152, 156);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtUsername.Location = new Point(919, 451);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(255, 32);
            txtUsername.TabIndex = 19;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(98, 172, 115);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLogin.Location = new Point(881, 659);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 42);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // User_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 172, 115);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1918, 1015);
            Controls.Add(btnBack);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            DoubleBuffered = true;
            Name = "User_Login";
            Text = "User_Login";
            Load += User_Login_Load;
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