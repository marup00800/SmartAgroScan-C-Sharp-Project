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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Management));
            dataGridViewUser = new DataGridView();
            tabControl1 = new TabControl();
            tabPageUser = new TabPage();
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
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
            btnBack2 = new Button();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            txtSearch4 = new TextBox();
            btnSearch4 = new Button();
            txtSearch3 = new TextBox();
            btnSearch3 = new Button();
            dataGridView2 = new DataGridView();
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
            tabPageGlobalChat = new TabPage();
            btnBack3 = new Button();
            btnDelete3 = new Button();
            btnClear3 = new Button();
            label17 = new Label();
            txtSearch6 = new TextBox();
            btnSearch6 = new Button();
            txtSearch5 = new TextBox();
            btnSearch5 = new Button();
            dataGridView4 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            tabControl1.SuspendLayout();
            tabPageUser.SuspendLayout();
            tabPageUserActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageGlobalChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.BackgroundColor = Color.FromArgb(70, 152, 156);
            dataGridViewUser.BorderStyle = BorderStyle.None;
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.GridColor = Color.FromArgb(61, 96, 119);
            dataGridViewUser.Location = new Point(679, 206);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowHeadersWidth = 51;
            dataGridViewUser.Size = new Size(1148, 627);
            dataGridViewUser.TabIndex = 0;
            dataGridViewUser.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageUser);
            tabControl1.Controls.Add(tabPageUserActivity);
            tabControl1.Controls.Add(tabPageGlobalChat);
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(-5, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1939, 1044);
            tabControl1.TabIndex = 1;
            // 
            // tabPageUser
            // 
            tabPageUser.BackColor = Color.FromArgb(36, 55, 68);
            tabPageUser.BackgroundImage = (Image)resources.GetObject("tabPageUser.BackgroundImage");
            tabPageUser.BackgroundImageLayout = ImageLayout.Center;
            tabPageUser.Controls.Add(btnDelete);
            tabPageUser.Controls.Add(txtSearch);
            tabPageUser.Controls.Add(btnSearch);
            tabPageUser.Controls.Add(btnClear);
            tabPageUser.Controls.Add(btnUpdate);
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
            tabPageUser.Size = new Size(1931, 1008);
            tabPageUser.TabIndex = 0;
            tabPageUser.Text = "Users";
            tabPageUser.Click += tabPage1_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnDelete.Location = new Point(505, 680);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 41);
            btnDelete.TabIndex = 84;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(136, 196, 203);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(242, 752);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(218, 32);
            txtSearch.TabIndex = 83;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearch.Location = new Point(239, 800);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(224, 34);
            btnSearch.TabIndex = 82;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Transparent;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnClear.Location = new Point(364, 680);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 41);
            btnClear.TabIndex = 81;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Transparent;
            btnUpdate.Location = new Point(224, 683);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 38);
            btnUpdate.TabIndex = 80;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtDateofBirth
            // 
            txtDateofBirth.BackColor = Color.FromArgb(12, 113, 122);
            txtDateofBirth.BorderStyle = BorderStyle.None;
            txtDateofBirth.Font = new Font("Segoe UI", 15F);
            txtDateofBirth.Location = new Point(332, 583);
            txtDateofBirth.Name = "txtDateofBirth";
            txtDateofBirth.Size = new Size(242, 34);
            txtDateofBirth.TabIndex = 71;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.FromArgb(12, 113, 122);
            txtAge.BorderStyle = BorderStyle.None;
            txtAge.Font = new Font("Segoe UI", 15F);
            txtAge.Location = new Point(332, 532);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(242, 34);
            txtAge.TabIndex = 70;
            // 
            // txtRole
            // 
            txtRole.BackColor = Color.FromArgb(12, 113, 122);
            txtRole.BorderStyle = BorderStyle.None;
            txtRole.Font = new Font("Segoe UI", 15F);
            txtRole.Location = new Point(332, 478);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(242, 34);
            txtRole.TabIndex = 69;
            // 
            // txtGender
            // 
            txtGender.BackColor = Color.FromArgb(12, 113, 122);
            txtGender.BorderStyle = BorderStyle.None;
            txtGender.Font = new Font("Segoe UI", 15F);
            txtGender.Location = new Point(332, 425);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(242, 34);
            txtGender.TabIndex = 68;
            txtGender.TextChanged += txtGender_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(12, 113, 122);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 15F);
            txtPassword.Location = new Point(332, 372);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(242, 34);
            txtPassword.TabIndex = 67;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(12, 113, 122);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 15F);
            txtUsername.Location = new Point(332, 319);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(242, 34);
            txtUsername.TabIndex = 66;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(12, 113, 122);
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Font = new Font("Segoe UI", 15F);
            txtFullName.Location = new Point(332, 267);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(242, 34);
            txtFullName.TabIndex = 65;
            // 
            // txtUserId
            // 
            txtUserId.BackColor = Color.FromArgb(12, 113, 122);
            txtUserId.BorderStyle = BorderStyle.None;
            txtUserId.Font = new Font("Segoe UI", 15F);
            txtUserId.Location = new Point(332, 214);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(242, 34);
            txtUserId.TabIndex = 64;
            txtUserId.TextChanged += txtUserId_TextChanged;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Transparent;
            btnInsert.FlatStyle = FlatStyle.Popup;
            btnInsert.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnInsert.ForeColor = Color.Transparent;
            btnInsert.Location = new Point(85, 683);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(115, 38);
            btnInsert.TabIndex = 63;
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkGray;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnBack.Location = new Point(579, 873);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 36);
            btnBack.TabIndex = 62;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // tabPageUserActivity
            // 
            tabPageUserActivity.Controls.Add(btnBack2);
            tabPageUserActivity.Controls.Add(label16);
            tabPageUserActivity.Controls.Add(label15);
            tabPageUserActivity.Controls.Add(label14);
            tabPageUserActivity.Controls.Add(txtSearch4);
            tabPageUserActivity.Controls.Add(btnSearch4);
            tabPageUserActivity.Controls.Add(txtSearch3);
            tabPageUserActivity.Controls.Add(btnSearch3);
            tabPageUserActivity.Controls.Add(dataGridView2);
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
            tabPageUserActivity.Size = new Size(1931, 1008);
            tabPageUserActivity.TabIndex = 1;
            tabPageUserActivity.Text = "User Activity";
            tabPageUserActivity.UseVisualStyleBackColor = true;
            tabPageUserActivity.Click += tabPageUserActivity_Click;
            // 
            // btnBack2
            // 
            btnBack2.BackColor = Color.DarkGray;
            btnBack2.FlatStyle = FlatStyle.Popup;
            btnBack2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnBack2.Location = new Point(1228, 643);
            btnBack2.Name = "btnBack2";
            btnBack2.Size = new Size(94, 36);
            btnBack2.TabIndex = 111;
            btnBack2.Text = "Back";
            btnBack2.UseVisualStyleBackColor = false;
            btnBack2.Click += btnBack2_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(309, 483);
            label16.Name = "label16";
            label16.Size = new Size(175, 30);
            label16.TabIndex = 110;
            label16.Text = "Soil Test Request";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(309, 63);
            label15.Name = "label15";
            label15.Size = new Size(133, 30);
            label15.TabIndex = 109;
            label15.Text = "User Activity";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(321, 834);
            label14.Name = "label14";
            label14.Size = new Size(179, 30);
            label14.TabIndex = 108;
            label14.Text = "Search by useID :";
            // 
            // txtSearch4
            // 
            txtSearch4.Location = new Point(506, 831);
            txtSearch4.Name = "txtSearch4";
            txtSearch4.Size = new Size(191, 36);
            txtSearch4.TabIndex = 107;
            // 
            // btnSearch4
            // 
            btnSearch4.BackColor = Color.DarkGray;
            btnSearch4.FlatStyle = FlatStyle.Popup;
            btnSearch4.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearch4.Location = new Point(537, 873);
            btnSearch4.Name = "btnSearch4";
            btnSearch4.Size = new Size(160, 36);
            btnSearch4.TabIndex = 106;
            btnSearch4.Text = "Search by ID";
            btnSearch4.UseVisualStyleBackColor = false;
            btnSearch4.Click += btnSearch4_Click;
            // 
            // txtSearch3
            // 
            txtSearch3.Location = new Point(742, 831);
            txtSearch3.Name = "txtSearch3";
            txtSearch3.Size = new Size(191, 36);
            txtSearch3.TabIndex = 105;
            // 
            // btnSearch3
            // 
            btnSearch3.BackColor = Color.DarkGray;
            btnSearch3.FlatStyle = FlatStyle.Popup;
            btnSearch3.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearch3.Location = new Point(773, 873);
            btnSearch3.Name = "btnSearch3";
            btnSearch3.Size = new Size(160, 36);
            btnSearch3.TabIndex = 104;
            btnSearch3.Text = "Search by ID";
            btnSearch3.UseVisualStyleBackColor = false;
            btnSearch3.Click += btnSearch3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 516);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(927, 298);
            dataGridView2.TabIndex = 103;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 96);
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
            btnDelete2.Location = new Point(467, 419);
            btnDelete2.Name = "btnDelete2";
            btnDelete2.Size = new Size(94, 36);
            btnDelete2.TabIndex = 90;
            btnDelete2.Text = "Delete";
            btnDelete2.UseVisualStyleBackColor = false;
            btnDelete2.Click += btnDelete2_Click;
            // 
            // txtSearch2
            // 
            txtSearch2.Location = new Point(979, 417);
            txtSearch2.Name = "txtSearch2";
            txtSearch2.Size = new Size(191, 36);
            txtSearch2.TabIndex = 89;
            // 
            // btnSearch2
            // 
            btnSearch2.BackColor = Color.DarkGray;
            btnSearch2.FlatStyle = FlatStyle.Popup;
            btnSearch2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearch2.Location = new Point(1010, 459);
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
            btnClear2.Location = new Point(603, 419);
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
            btnUpdate2.Location = new Point(857, 419);
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
            btnInsert2.Location = new Point(729, 419);
            btnInsert2.Name = "btnInsert2";
            btnInsert2.Size = new Size(94, 36);
            btnInsert2.TabIndex = 85;
            btnInsert2.Text = "Insert";
            btnInsert2.UseVisualStyleBackColor = false;
            btnInsert2.Click += btnInsert2_Click;
            // 
            // tabPageGlobalChat
            // 
            tabPageGlobalChat.Controls.Add(btnBack3);
            tabPageGlobalChat.Controls.Add(btnDelete3);
            tabPageGlobalChat.Controls.Add(btnClear3);
            tabPageGlobalChat.Controls.Add(label17);
            tabPageGlobalChat.Controls.Add(txtSearch6);
            tabPageGlobalChat.Controls.Add(btnSearch6);
            tabPageGlobalChat.Controls.Add(txtSearch5);
            tabPageGlobalChat.Controls.Add(btnSearch5);
            tabPageGlobalChat.Controls.Add(dataGridView4);
            tabPageGlobalChat.Font = new Font("Segoe UI", 13F);
            tabPageGlobalChat.Location = new Point(4, 32);
            tabPageGlobalChat.Name = "tabPageGlobalChat";
            tabPageGlobalChat.Padding = new Padding(3);
            tabPageGlobalChat.Size = new Size(1931, 1008);
            tabPageGlobalChat.TabIndex = 2;
            tabPageGlobalChat.Text = "Global Chat";
            tabPageGlobalChat.UseVisualStyleBackColor = true;
            tabPageGlobalChat.Click += tabPage3_Click;
            // 
            // btnBack3
            // 
            btnBack3.BackColor = Color.DarkGray;
            btnBack3.FlatStyle = FlatStyle.Popup;
            btnBack3.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnBack3.Location = new Point(899, 817);
            btnBack3.Name = "btnBack3";
            btnBack3.Size = new Size(94, 36);
            btnBack3.TabIndex = 116;
            btnBack3.Text = "Back";
            btnBack3.UseVisualStyleBackColor = false;
            btnBack3.Click += btnBack3_Click;
            // 
            // btnDelete3
            // 
            btnDelete3.BackColor = Color.DarkGray;
            btnDelete3.FlatStyle = FlatStyle.Popup;
            btnDelete3.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnDelete3.Location = new Point(609, 746);
            btnDelete3.Name = "btnDelete3";
            btnDelete3.Size = new Size(94, 36);
            btnDelete3.TabIndex = 115;
            btnDelete3.Text = "Delete";
            btnDelete3.UseVisualStyleBackColor = false;
            btnDelete3.Click += btnDelete3_Click;
            // 
            // btnClear3
            // 
            btnClear3.BackColor = Color.DarkGray;
            btnClear3.FlatStyle = FlatStyle.Popup;
            btnClear3.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnClear3.Location = new Point(748, 746);
            btnClear3.Name = "btnClear3";
            btnClear3.Size = new Size(94, 36);
            btnClear3.TabIndex = 114;
            btnClear3.Text = "Clear";
            btnClear3.UseVisualStyleBackColor = false;
            btnClear3.Click += btnClear3_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(327, 626);
            label17.Name = "label17";
            label17.Size = new Size(179, 30);
            label17.TabIndex = 113;
            label17.Text = "Search by useID :";
            // 
            // txtSearch6
            // 
            txtSearch6.Location = new Point(512, 623);
            txtSearch6.Name = "txtSearch6";
            txtSearch6.Size = new Size(191, 36);
            txtSearch6.TabIndex = 112;
            // 
            // btnSearch6
            // 
            btnSearch6.BackColor = Color.DarkGray;
            btnSearch6.FlatStyle = FlatStyle.Popup;
            btnSearch6.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearch6.Location = new Point(543, 665);
            btnSearch6.Name = "btnSearch6";
            btnSearch6.Size = new Size(160, 36);
            btnSearch6.TabIndex = 111;
            btnSearch6.Text = "Search by ID";
            btnSearch6.UseVisualStyleBackColor = false;
            btnSearch6.Click += btnSearch6_Click;
            // 
            // txtSearch5
            // 
            txtSearch5.Location = new Point(748, 623);
            txtSearch5.Name = "txtSearch5";
            txtSearch5.Size = new Size(191, 36);
            txtSearch5.TabIndex = 110;
            // 
            // btnSearch5
            // 
            btnSearch5.BackColor = Color.DarkGray;
            btnSearch5.FlatStyle = FlatStyle.Popup;
            btnSearch5.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearch5.Location = new Point(748, 665);
            btnSearch5.Name = "btnSearch5";
            btnSearch5.Size = new Size(160, 36);
            btnSearch5.TabIndex = 109;
            btnSearch5.Text = "Search by ID";
            btnSearch5.UseVisualStyleBackColor = false;
            btnSearch5.Click += btnSearch5_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(29, 79);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(910, 538);
            dataGridView4.TabIndex = 0;
            dataGridView4.CellContentClick += dataGridView3_CellContentClick;
            // 
            // User_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1031);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageGlobalChat.ResumeLayout(false);
            tabPageGlobalChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUser;
        private TabControl tabControl1;
        private TabPage tabPageUser;
        private TabPage tabPageGlobalChat;
        private Button btnBack;
        private TextBox txtFullName;
        private TextBox txtUserId;
        private Button btnInsert;
        private TextBox txtDateofBirth;
        private TextBox txtAge;
        private TextBox txtRole;
        private TextBox txtGender;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnUpdate;
        private Button btnClear;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnDelete;
        private TabPage tabPageUserActivity;
        private TextBox txtSearch3;
        private Button btnSearch3;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
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
        private Button btnDelete2;
        private TextBox txtSearch2;
        private Button btnSearch2;
        private Button btnClear2;
        private Button btnUpdate2;
        private Button btnInsert2;
        private TextBox txtSearch4;
        private Button btnSearch4;
        private Label label14;
        private Label label15;
        private Label label16;
        private DataGridView dataGridView4;
        private Label label17;
        private TextBox txtSearch6;
        private Button btnSearch6;
        private TextBox txtSearch5;
        private Button btnSearch5;
        private Button btnClear3;
        private Button btnDelete3;
        private Button btnBack2;
        private Button btnBack3;
    }
}