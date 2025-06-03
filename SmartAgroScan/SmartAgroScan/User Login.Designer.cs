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
            btnBack = new Button();
            label3 = new Label();
            label2 = new Label();
            btnCreateAccount = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(373, 401);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(117, 37);
            btnBack.TabIndex = 24;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 137);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 23;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 92);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 22;
            label2.Text = "Username :";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(142, 269);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(193, 29);
            btnCreateAccount.TabIndex = 21;
            btnCreateAccount.Text = "Create Account as User";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(161, 137);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(161, 27);
            txtPassword.TabIndex = 20;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(161, 89);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(161, 27);
            txtUsername.TabIndex = 19;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(179, 198);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 40);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // User_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 450);
            Controls.Add(btnBack);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Name = "User_Login";
            Text = "User_Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label3;
        private Label label2;
        private Button btnCreateAccount;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
    }
}