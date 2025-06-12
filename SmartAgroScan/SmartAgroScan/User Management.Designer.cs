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
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            tabControl1.SuspendLayout();
            tabPageUser.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Location = new Point(61, 178);
            dataGridViewUser.Margin = new Padding(4);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowHeadersWidth = 51;
            dataGridViewUser.Size = new Size(1332, 364);
            dataGridViewUser.TabIndex = 0;
            dataGridViewUser.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageUser);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(2, 15);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2406, 1306);
            tabControl1.TabIndex = 1;
            // 
            // tabPageUser
            // 
            tabPageUser.BackgroundImageLayout = ImageLayout.None;
            tabPageUser.Controls.Add(btnDelete);
            tabPageUser.Controls.Add(txtSearch);
            tabPageUser.Controls.Add(btnSearch);
            tabPageUser.Controls.Add(btnClear);
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
            tabPageUser.Location = new Point(4, 37);
            tabPageUser.Margin = new Padding(4);
            tabPageUser.Name = "tabPageUser";
            tabPageUser.Padding = new Padding(4);
            tabPageUser.Size = new Size(2398, 1265);
            tabPageUser.TabIndex = 0;
            tabPageUser.Text = "Users";
            tabPageUser.UseVisualStyleBackColor = true;
            tabPageUser.Click += tabPage1_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkGray;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnDelete.Location = new Point(975, 789);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 45);
            btnDelete.TabIndex = 84;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1185, 757);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(238, 42);
            txtSearch.TabIndex = 83;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkGray;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearch.Location = new Point(1223, 816);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(200, 45);
            btnSearch.TabIndex = 82;
            btnSearch.Text = "Search by ID";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkGray;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnClear.Location = new Point(916, 599);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 45);
            btnClear.TabIndex = 81;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkGray;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnUpdate.Location = new Point(1234, 599);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 45);
            btnUpdate.TabIndex = 80;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1420, 616);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 36);
            label5.TabIndex = 79;
            label5.Text = "DOB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1420, 542);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(61, 36);
            label6.TabIndex = 78;
            label6.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1420, 400);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 36);
            label7.TabIndex = 77;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1457, 477);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(65, 36);
            label8.TabIndex = 76;
            label8.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1420, 330);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 36);
            label4.TabIndex = 75;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1420, 256);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 36);
            label3.TabIndex = 74;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1420, 184);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 36);
            label2.TabIndex = 73;
            label2.Text = "Full Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1420, 114);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 36);
            label1.TabIndex = 72;
            label1.Text = "User ID";
            label1.Click += label1_Click;
            // 
            // txtDateofBirth
            // 
            txtDateofBirth.Location = new Point(1573, 616);
            txtDateofBirth.Margin = new Padding(4);
            txtDateofBirth.Name = "txtDateofBirth";
            txtDateofBirth.Size = new Size(238, 42);
            txtDateofBirth.TabIndex = 71;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(1573, 546);
            txtAge.Margin = new Padding(4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(238, 42);
            txtAge.TabIndex = 70;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(1573, 474);
            txtRole.Margin = new Padding(4);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(238, 42);
            txtRole.TabIndex = 69;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(1573, 400);
            txtGender.Margin = new Padding(4);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(238, 42);
            txtGender.TabIndex = 68;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(1573, 326);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(238, 42);
            txtPassword.TabIndex = 67;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(1573, 252);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(238, 42);
            txtUsername.TabIndex = 66;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(1573, 180);
            txtFullName.Margin = new Padding(4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(238, 42);
            txtFullName.TabIndex = 65;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(1573, 106);
            txtUserId.Margin = new Padding(4);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(238, 42);
            txtUserId.TabIndex = 64;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.DarkGray;
            btnInsert.FlatStyle = FlatStyle.Popup;
            btnInsert.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnInsert.Location = new Point(1074, 599);
            btnInsert.Margin = new Padding(4);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(118, 45);
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
            btnBack.Location = new Point(1676, 920);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 45);
            btnBack.TabIndex = 62;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // tabPage2
            // 
            tabPage2.Font = new Font("Segoe UI", 13F);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(2398, 1265);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Font = new Font("Segoe UI", 13F);
            tabPage3.Location = new Point(4, 37);
            tabPage3.Margin = new Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4);
            tabPage3.Size = new Size(2398, 1265);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // User_Management
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(tabControl1);
            Margin = new Padding(4);
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
        private Button btnClear;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnDelete;
    }
}