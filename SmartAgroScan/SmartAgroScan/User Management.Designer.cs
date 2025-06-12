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
            tabPageUserActivity = new TabPage();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtActivityTime = new TextBox();
            txtActivityType = new TextBox();
            txtTestId = new TextBox();
            txtUserId2 = new TextBox();
            txtActivityId = new TextBox();
            btnDelete2 = new Button();
            txtSearch2 = new TextBox();
            btnSearch2 = new Button();
            btnClear2 = new Button();
            btnUpdate2 = new Button();
            btnInsert2 = new Button();
            tabPage3 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            tabControl1.SuspendLayout();
            tabPageUser.SuspendLayout();
            tabPageUserActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabControl1.Controls.Add(tabPageUserActivity);
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
            tabPageUser.Location = new Point(4, 32);
            tabPageUser.Name = "tabPageUser";
            tabPageUser.Padding = new Padding(3);
            tabPageUser.Size = new Size(1917, 1009);
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
            btnDelete.Location = new Point(780, 631);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 36);
            btnDelete.TabIndex = 84;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(948, 606);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(191, 36);
            txtSearch.TabIndex = 83;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkGray;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearch.Location = new Point(978, 653);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(160, 36);
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
            btnClear.Location = new Point(733, 479);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 36);
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
            btnUpdate.Location = new Point(987, 479);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 36);
            btnUpdate.TabIndex = 80;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1136, 493);
            label5.Name = "label5";
            label5.Size = new Size(58, 30);
            label5.TabIndex = 79;
            label5.Text = "DOB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1136, 434);
            label6.Name = "label6";
            label6.Size = new Size(52, 30);
            label6.TabIndex = 78;
            label6.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1136, 320);
            label7.Name = "label7";
            label7.Size = new Size(85, 30);
            label7.TabIndex = 77;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1166, 382);
            label8.Name = "label8";
            label8.Size = new Size(55, 30);
            label8.TabIndex = 76;
            label8.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1136, 264);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 75;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1136, 205);
            label3.Name = "label3";
            label3.Size = new Size(111, 30);
            label3.TabIndex = 74;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1136, 147);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 73;
            label2.Text = "Full Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1136, 91);
            label1.Name = "label1";
            label1.Size = new Size(84, 30);
            label1.TabIndex = 72;
            label1.Text = "User ID";
            label1.Click += label1_Click;
            // 
            // txtDateofBirth
            // 
            txtDateofBirth.Location = new Point(1258, 493);
            txtDateofBirth.Name = "txtDateofBirth";
            txtDateofBirth.Size = new Size(191, 36);
            txtDateofBirth.TabIndex = 71;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(1258, 437);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(191, 36);
            txtAge.TabIndex = 70;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(1258, 379);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(191, 36);
            txtRole.TabIndex = 69;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(1258, 320);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(191, 36);
            txtGender.TabIndex = 68;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(1258, 261);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(191, 36);
            txtPassword.TabIndex = 67;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(1258, 202);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(191, 36);
            txtUsername.TabIndex = 66;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(1258, 144);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(191, 36);
            txtFullName.TabIndex = 65;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(1258, 85);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(191, 36);
            txtUserId.TabIndex = 64;
            txtUserId.TextChanged += txtUserId_TextChanged;
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
            btnBack.Location = new Point(1341, 736);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 36);
            btnBack.TabIndex = 62;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // tabPageUserActivity
            // 
            tabPageUserActivity.Controls.Add(dataGridView1);
            tabPageUserActivity.Controls.Add(label9);
            tabPageUserActivity.Controls.Add(label10);
            tabPageUserActivity.Controls.Add(label11);
            tabPageUserActivity.Controls.Add(label12);
            tabPageUserActivity.Controls.Add(label13);
            tabPageUserActivity.Controls.Add(txtActivityTime);
            tabPageUserActivity.Controls.Add(txtActivityType);
            tabPageUserActivity.Controls.Add(txtTestId);
            tabPageUserActivity.Controls.Add(txtUserId2);
            tabPageUserActivity.Controls.Add(txtActivityId);
            tabPageUserActivity.Controls.Add(btnDelete2);
            tabPageUserActivity.Controls.Add(txtSearch2);
            tabPageUserActivity.Controls.Add(btnSearch2);
            tabPageUserActivity.Controls.Add(btnClear2);
            tabPageUserActivity.Controls.Add(btnUpdate2);
            tabPageUserActivity.Controls.Add(btnInsert2);
            tabPageUserActivity.Font = new Font("Segoe UI", 13F);
            tabPageUserActivity.Location = new Point(4, 32);
            tabPageUserActivity.Name = "tabPageUserActivity";
            tabPageUserActivity.Padding = new Padding(3);
            tabPageUserActivity.Size = new Size(1917, 1009);
            tabPageUserActivity.TabIndex = 1;
            tabPageUserActivity.Text = "User Activity";
            tabPageUserActivity.UseVisualStyleBackColor = true;
            tabPageUserActivity.Click += tabPageUserActivity_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1164, 315);
            dataGridView1.TabIndex = 101;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1263, 351);
            label9.Name = "label9";
            label9.Size = new Size(137, 30);
            label9.TabIndex = 100;
            label9.Text = "Activity Time";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1264, 295);
            label10.Name = "label10";
            label10.Size = new Size(136, 30);
            label10.TabIndex = 99;
            label10.Text = "Activity Type";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1290, 233);
            label11.Name = "label11";
            label11.Size = new Size(78, 30);
            label11.TabIndex = 98;
            label11.Text = "Test ID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1290, 175);
            label12.Name = "label12";
            label12.Size = new Size(84, 30);
            label12.TabIndex = 97;
            label12.Text = "User ID";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1290, 119);
            label13.Name = "label13";
            label13.Size = new Size(110, 30);
            label13.TabIndex = 96;
            label13.Text = "Activity ID";
            // 
            // txtActivityTime
            // 
            txtActivityTime.Location = new Point(1412, 348);
            txtActivityTime.Name = "txtActivityTime";
            txtActivityTime.Size = new Size(191, 36);
            txtActivityTime.TabIndex = 95;
            // 
            // txtActivityType
            // 
            txtActivityType.Location = new Point(1412, 289);
            txtActivityType.Name = "txtActivityType";
            txtActivityType.Size = new Size(191, 36);
            txtActivityType.TabIndex = 94;
            // 
            // txtTestId
            // 
            txtTestId.Location = new Point(1412, 230);
            txtTestId.Name = "txtTestId";
            txtTestId.Size = new Size(191, 36);
            txtTestId.TabIndex = 93;
            // 
            // txtUserId2
            // 
            txtUserId2.Location = new Point(1412, 172);
            txtUserId2.Name = "txtUserId2";
            txtUserId2.Size = new Size(191, 36);
            txtUserId2.TabIndex = 92;
            // 
            // txtActivityId
            // 
            txtActivityId.Location = new Point(1412, 113);
            txtActivityId.Name = "txtActivityId";
            txtActivityId.Size = new Size(191, 36);
            txtActivityId.TabIndex = 91;
            // 
            // btnDelete2
            // 
            btnDelete2.BackColor = Color.DarkGray;
            btnDelete2.FlatStyle = FlatStyle.Popup;
            btnDelete2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnDelete2.Location = new Point(693, 655);
            btnDelete2.Name = "btnDelete2";
            btnDelete2.Size = new Size(94, 36);
            btnDelete2.TabIndex = 90;
            btnDelete2.Text = "Delete";
            btnDelete2.UseVisualStyleBackColor = false;
            btnDelete2.Click += btnDelete2_Click;
            // 
            // txtSearch2
            // 
            txtSearch2.Location = new Point(861, 630);
            txtSearch2.Name = "txtSearch2";
            txtSearch2.Size = new Size(191, 36);
            txtSearch2.TabIndex = 89;
            // 
            // btnSearch2
            // 
            btnSearch2.BackColor = Color.DarkGray;
            btnSearch2.FlatStyle = FlatStyle.Popup;
            btnSearch2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearch2.Location = new Point(891, 677);
            btnSearch2.Name = "btnSearch2";
            btnSearch2.Size = new Size(160, 36);
            btnSearch2.TabIndex = 88;
            btnSearch2.Text = "Search by ID";
            btnSearch2.UseVisualStyleBackColor = false;
            btnSearch2.Click += btnSearch2_Click;
            // 
            // btnClear2
            // 
            btnClear2.BackColor = Color.DarkGray;
            btnClear2.FlatStyle = FlatStyle.Popup;
            btnClear2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnClear2.Location = new Point(646, 503);
            btnClear2.Name = "btnClear2";
            btnClear2.Size = new Size(94, 36);
            btnClear2.TabIndex = 87;
            btnClear2.Text = "Clear";
            btnClear2.UseVisualStyleBackColor = false;
            btnClear2.Click += btnClear2_Click;
            // 
            // btnUpdate2
            // 
            btnUpdate2.BackColor = Color.DarkGray;
            btnUpdate2.FlatStyle = FlatStyle.Popup;
            btnUpdate2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnUpdate2.Location = new Point(900, 503);
            btnUpdate2.Name = "btnUpdate2";
            btnUpdate2.Size = new Size(94, 36);
            btnUpdate2.TabIndex = 86;
            btnUpdate2.Text = "Update";
            btnUpdate2.UseVisualStyleBackColor = false;
            btnUpdate2.Click += btnUpdate2_Click;
            // 
            // btnInsert2
            // 
            btnInsert2.BackColor = Color.DarkGray;
            btnInsert2.FlatStyle = FlatStyle.Popup;
            btnInsert2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnInsert2.Location = new Point(772, 503);
            btnInsert2.Name = "btnInsert2";
            btnInsert2.Size = new Size(94, 36);
            btnInsert2.TabIndex = 85;
            btnInsert2.Text = "Insert";
            btnInsert2.UseVisualStyleBackColor = false;
            btnInsert2.Click += btnInsert2_Click;
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
            tabPage3.Click += tabPage3_Click;
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
            tabPageUserActivity.ResumeLayout(false);
            tabPageUserActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUser;
        private TabControl tabControl1;
        private TabPage tabPageUser;
        private TabPage tabPageUserActivity;
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
        private Button btnDelete2;
        private TextBox txtSearch2;
        private Button btnSearch2;
        private Button btnClear2;
        private Button btnUpdate2;
        private Button btnInsert2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtActivityTime;
        private TextBox txtActivityType;
        private TextBox txtTestId;
        private TextBox txtUserId2;
        private TextBox txtActivityId;
        private DataGridView dataGridView1;
    }
}