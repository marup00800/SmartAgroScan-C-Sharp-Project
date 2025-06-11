namespace SmartAgroScan
{
    partial class User_Management
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
            dataGridViewUser = new DataGridView();
            tabControl1 = new TabControl();
            tabPageUser = new TabPage();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDateofBirth = new TextBox();
            txtAge = new TextBox();
            txtRole = new TextBox();
            txtGender = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtFullName = new TextBox();
            txtUserId = new TextBox();
            btnInsert = new Button();
            btnBack = new Button();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            tabControl1.SuspendLayout();
            tabPageUser.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Location = new Point(49, 142);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowHeadersWidth = 51;
            dataGridViewUser.Size = new Size(1066, 291);
            dataGridViewUser.TabIndex = 0;
            dataGridViewUser.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageUser);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(2, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1925, 1045);
            tabControl1.TabIndex = 1;
            // 
            // tabPageUser
            // 
            tabPageUser.BackgroundImageLayout = ImageLayout.None;
            tabPageUser.Controls.Add(btnUpdate);
            tabPageUser.Controls.Add(label5);
            tabPageUser.Controls.Add(label6);
            tabPageUser.Controls.Add(label7);
            tabPageUser.Controls.Add(label8);
            tabPageUser.Controls.Add(label4);
            tabPageUser.Controls.Add(label3);
            tabPageUser.Controls.Add(label2);
            tabPageUser.Controls.Add(label1);
            tabPageUser.Controls.Add(txtDateofBirth);
            tabPageUser.Controls.Add(txtAge);
            tabPageUser.Controls.Add(txtRole);
            tabPageUser.Controls.Add(txtGender);
            tabPageUser.Controls.Add(txtPassword);
            tabPageUser.Controls.Add(txtUsername);
            tabPageUser.Controls.Add(txtFullName);
            tabPageUser.Controls.Add(txtUserId);
            tabPageUser.Controls.Add(btnInsert);
            tabPageUser.Controls.Add(btnBack);
            tabPageUser.Controls.Add(dataGridViewUser);
            tabPageUser.Font = new Font("Segoe UI", 13F);
            tabPageUser.Location = new Point(4, 32);
            tabPageUser.Name = "tabPageUser";
            tabPageUser.Padding = new Padding(3);
            tabPageUser.Size = new Size(1917, 1009);
            tabPageUser.TabIndex = 0;
            tabPageUser.Text = "Users";
            tabPageUser.UseVisualStyleBackColor = true;
            tabPageUser.Click += tabPage1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1258, 496);
            label5.Name = "label5";
            label5.Size = new Size(58, 30);
            label5.TabIndex = 79;
            label5.Text = "DOB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1258, 437);
            label6.Name = "label6";
            label6.Size = new Size(52, 30);
            label6.TabIndex = 78;
            label6.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1258, 323);
            label7.Name = "label7";
            label7.Size = new Size(85, 30);
            label7.TabIndex = 77;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1287, 385);
            label8.Name = "label8";
            label8.Size = new Size(55, 30);
            label8.TabIndex = 76;
            label8.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1258, 267);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 75;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1258, 208);
            label3.Name = "label3";
            label3.Size = new Size(111, 30);
            label3.TabIndex = 74;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1258, 150);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 73;
            label2.Text = "Full Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1258, 94);
            label1.Name = "label1";
            label1.Size = new Size(84, 30);
            label1.TabIndex = 72;
            label1.Text = "User ID";
            label1.Click += label1_Click;
            // 
            // txtDateofBirth
            // 
            txtDateofBirth.Location = new Point(1380, 499);
            txtDateofBirth.Name = "txtDateofBirth";
            txtDateofBirth.Size = new Size(191, 36);
            txtDateofBirth.TabIndex = 71;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(1380, 440);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(191, 36);
            txtAge.TabIndex = 70;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(1380, 382);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(191, 36);
            txtRole.TabIndex = 69;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(1380, 323);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(191, 36);
            txtGender.TabIndex = 68;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(1380, 264);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(191, 36);
            txtPassword.TabIndex = 67;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(1380, 205);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(191, 36);
            txtUsername.TabIndex = 66;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(1380, 147);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(191, 36);
            txtFullName.TabIndex = 65;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(1380, 88);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(191, 36);
            txtUserId.TabIndex = 64;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.DarkGray;
            btnInsert.FlatStyle = FlatStyle.Popup;
            btnInsert.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnInsert.Location = new Point(859, 479);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 36);
            btnInsert.TabIndex = 63;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkGray;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnBack.Location = new Point(966, 629);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 36);
            btnBack.TabIndex = 62;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // tabPage2
            // 
            tabPage2.Font = new Font("Segoe UI", 13F);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1917, 1009);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Font = new Font("Segoe UI", 13F);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1917, 1009);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkGray;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnUpdate.Location = new Point(987, 479);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 36);
            btnUpdate.TabIndex = 80;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // User_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(tabControl1);
            Name = "User_Management";
            Text = "User_Management";
            Load += User_Management_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageUser.ResumeLayout(false);
            tabPageUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUser;
        private TabControl tabControl1;
        private TabPage tabPageUser;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnBack;
        private TextBox txtFullName;
        private TextBox txtUserId;
        private Button btnInsert;
        private Label label1;
        private TextBox txtDateofBirth;
        private TextBox txtAge;
        private TextBox txtRole;
        private TextBox txtGender;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnUpdate;
    }
}