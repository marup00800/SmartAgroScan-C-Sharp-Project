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
            btnBack.Location = new Point(404, 402);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(117, 37);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 140);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 16;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 95);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 15;
            label2.Text = "Username :";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(134, 272);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(193, 29);
            btnCreateAccount.TabIndex = 14;
            btnCreateAccount.Text = "Create Account as Admin";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(153, 140);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(161, 27);
            txtPassword.TabIndex = 13;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(153, 92);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(161, 27);
            txtUsername.TabIndex = 12;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(171, 201);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 40);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Admin_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 451);
            Controls.Add(btnBack);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Name = "Admin_Login";
            Text = "Admin_Login";
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