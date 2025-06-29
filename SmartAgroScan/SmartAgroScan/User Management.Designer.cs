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
            btnDelete4 = new Button();
            btnClear3 = new Button();
            richTextBox1 = new RichTextBox();
            btnBack2 = new Button();
            txtSearch4 = new TextBox();
            btnSearch4 = new Button();
            txtSearch3 = new TextBox();
            btnSearch3 = new Button();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            txtActivityTime = new TextBox();
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
            btnRefresh3 = new Button();
            btnBack3 = new Button();
            btnDelete3 = new Button();
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
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnBack.Location = new Point(35, 821);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(81, 31);
            btnBack.TabIndex = 62;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // tabPageUserActivity
            // 
            tabPageUserActivity.BackgroundImage = (Image)resources.GetObject("tabPageUserActivity.BackgroundImage");
            tabPageUserActivity.Controls.Add(btnDelete4);
            tabPageUserActivity.Controls.Add(btnClear3);
            tabPageUserActivity.Controls.Add(richTextBox1);
            tabPageUserActivity.Controls.Add(btnBack2);
            tabPageUserActivity.Controls.Add(txtSearch4);
            tabPageUserActivity.Controls.Add(btnSearch4);
            tabPageUserActivity.Controls.Add(txtSearch3);
            tabPageUserActivity.Controls.Add(btnSearch3);
            tabPageUserActivity.Controls.Add(dataGridView2);
            tabPageUserActivity.Controls.Add(dataGridView1);
            tabPageUserActivity.Controls.Add(txtActivityTime);
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
            // btnDelete4
            // 
            btnDelete4.BackColor = Color.Transparent;
            btnDelete4.FlatStyle = FlatStyle.Popup;
            btnDelete4.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnDelete4.Location = new Point(1164, 770);
            btnDelete4.Name = "btnDelete4";
            btnDelete4.Size = new Size(112, 36);
            btnDelete4.TabIndex = 114;
            btnDelete4.UseVisualStyleBackColor = false;
            btnDelete4.Click += btnDelete4_Click;
            // 
            // btnClear3
            // 
            btnClear3.BackColor = Color.Transparent;
            btnClear3.FlatStyle = FlatStyle.Popup;
            btnClear3.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnClear3.Location = new Point(1025, 770);
            btnClear3.Name = "btnClear3";
            btnClear3.Size = new Size(112, 36);
            btnClear3.TabIndex = 113;
            btnClear3.UseVisualStyleBackColor = false;
            btnClear3.Click += btnClear3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(0, 150, 158);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(111, 583);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(295, 84);
            richTextBox1.TabIndex = 112;
            richTextBox1.Text = "";
            // 
            // btnBack2
            // 
            btnBack2.BackColor = Color.Transparent;
            btnBack2.FlatStyle = FlatStyle.Popup;
            btnBack2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnBack2.ForeColor = Color.Black;
            btnBack2.Location = new Point(1762, 878);
            btnBack2.Name = "btnBack2";
            btnBack2.Size = new Size(92, 33);
            btnBack2.TabIndex = 111;
            btnBack2.Text = "Back";
            btnBack2.UseVisualStyleBackColor = false;
            btnBack2.Click += btnBack2_Click;
            // 
            // txtSearch4
            // 
            txtSearch4.BackColor = Color.FromArgb(134, 205, 211);
            txtSearch4.BorderStyle = BorderStyle.None;
            txtSearch4.Location = new Point(1333, 750);
            txtSearch4.Name = "txtSearch4";
            txtSearch4.Size = new Size(224, 29);
            txtSearch4.TabIndex = 107;
            // 
            // btnSearch4
            // 
            btnSearch4.BackColor = Color.Transparent;
            btnSearch4.FlatStyle = FlatStyle.Popup;
            btnSearch4.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearch4.Location = new Point(1315, 798);
            btnSearch4.Name = "btnSearch4";
            btnSearch4.Size = new Size(261, 35);
            btnSearch4.TabIndex = 106;
            btnSearch4.UseVisualStyleBackColor = false;
            btnSearch4.Click += btnSearch4_Click;
            // 
            // txtSearch3
            // 
            txtSearch3.BackColor = Color.FromArgb(134, 205, 211);
            txtSearch3.BorderStyle = BorderStyle.None;
            txtSearch3.Location = new Point(1616, 746);
            txtSearch3.Name = "txtSearch3";
            txtSearch3.Size = new Size(221, 29);
            txtSearch3.TabIndex = 105;
            // 
            // btnSearch3
            // 
            btnSearch3.BackColor = Color.Transparent;
            btnSearch3.FlatStyle = FlatStyle.Popup;
            btnSearch3.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearch3.Location = new Point(1615, 795);
            btnSearch3.Name = "btnSearch3";
            btnSearch3.Size = new Size(221, 35);
            btnSearch3.TabIndex = 104;
            btnSearch3.UseVisualStyleBackColor = false;
            btnSearch3.Click += btnSearch3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(70, 152, 156);
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(990, 151);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(847, 521);
            dataGridView2.TabIndex = 103;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(70, 152, 156);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(89, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(827, 348);
            dataGridView1.TabIndex = 101;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_3;
            // 
            // txtActivityTime
            // 
            txtActivityTime.BackColor = Color.FromArgb(0, 150, 158);
            txtActivityTime.BorderStyle = BorderStyle.None;
            txtActivityTime.Font = new Font("Segoe UI", 12F);
            txtActivityTime.Location = new Point(617, 614);
            txtActivityTime.Name = "txtActivityTime";
            txtActivityTime.Size = new Size(297, 27);
            txtActivityTime.TabIndex = 95;
            // 
            // txtTestId
            // 
            txtTestId.BackColor = Color.FromArgb(0, 150, 158);
            txtTestId.BorderStyle = BorderStyle.None;
            txtTestId.Font = new Font("Segoe UI", 11F);
            txtTestId.Location = new Point(791, 528);
            txtTestId.Name = "txtTestId";
            txtTestId.Size = new Size(125, 25);
            txtTestId.TabIndex = 93;
            // 
            // txtUserId2
            // 
            txtUserId2.BackColor = Color.FromArgb(0, 150, 158);
            txtUserId2.BorderStyle = BorderStyle.None;
            txtUserId2.Font = new Font("Segoe UI", 11F);
            txtUserId2.Location = new Point(517, 528);
            txtUserId2.Name = "txtUserId2";
            txtUserId2.Size = new Size(125, 25);
            txtUserId2.TabIndex = 92;
            // 
            // txtActivityId
            // 
            txtActivityId.BackColor = Color.FromArgb(0, 150, 158);
            txtActivityId.BorderStyle = BorderStyle.None;
            txtActivityId.Font = new Font("Segoe UI", 11F);
            txtActivityId.Location = new Point(233, 530);
            txtActivityId.Name = "txtActivityId";
            txtActivityId.Size = new Size(125, 25);
            txtActivityId.TabIndex = 91;
            // 
            // btnDelete2
            // 
            btnDelete2.BackColor = Color.Transparent;
            btnDelete2.FlatStyle = FlatStyle.Popup;
            btnDelete2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnDelete2.Location = new Point(527, 770);
            btnDelete2.Name = "btnDelete2";
            btnDelete2.Size = new Size(112, 36);
            btnDelete2.TabIndex = 90;
            btnDelete2.UseVisualStyleBackColor = false;
            btnDelete2.Click += btnDelete2_Click;
            // 
            // txtSearch2
            // 
            txtSearch2.BackColor = Color.FromArgb(134, 205, 211);
            txtSearch2.BorderStyle = BorderStyle.None;
            txtSearch2.Font = new Font("Segoe UI", 12F);
            txtSearch2.Location = new Point(685, 747);
            txtSearch2.Name = "txtSearch2";
            txtSearch2.Size = new Size(219, 27);
            txtSearch2.TabIndex = 89;
            // 
            // btnSearch2
            // 
            btnSearch2.BackColor = Color.Transparent;
            btnSearch2.FlatStyle = FlatStyle.Popup;
            btnSearch2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearch2.Location = new Point(685, 790);
            btnSearch2.Name = "btnSearch2";
            btnSearch2.Size = new Size(219, 36);
            btnSearch2.TabIndex = 88;
            btnSearch2.UseVisualStyleBackColor = false;
            btnSearch2.Click += btnSearch2_Click;
            // 
            // btnClear2
            // 
            btnClear2.BackColor = Color.Transparent;
            btnClear2.FlatStyle = FlatStyle.Popup;
            btnClear2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnClear2.Location = new Point(386, 770);
            btnClear2.Name = "btnClear2";
            btnClear2.Size = new Size(112, 36);
            btnClear2.TabIndex = 87;
            btnClear2.UseVisualStyleBackColor = false;
            btnClear2.Click += btnClear2_Click;
            // 
            // btnUpdate2
            // 
            btnUpdate2.BackColor = Color.Transparent;
            btnUpdate2.FlatStyle = FlatStyle.Popup;
            btnUpdate2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnUpdate2.Location = new Point(246, 770);
            btnUpdate2.Name = "btnUpdate2";
            btnUpdate2.Size = new Size(112, 36);
            btnUpdate2.TabIndex = 86;
            btnUpdate2.UseVisualStyleBackColor = false;
            btnUpdate2.Click += btnUpdate2_Click;
            // 
            // btnInsert2
            // 
            btnInsert2.BackColor = Color.Transparent;
            btnInsert2.FlatStyle = FlatStyle.Popup;
            btnInsert2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnInsert2.Location = new Point(107, 770);
            btnInsert2.Name = "btnInsert2";
            btnInsert2.Size = new Size(112, 36);
            btnInsert2.TabIndex = 85;
            btnInsert2.UseVisualStyleBackColor = false;
            btnInsert2.Click += btnInsert2_Click;
            // 
            // tabPageGlobalChat
            // 
            tabPageGlobalChat.BackgroundImage = (Image)resources.GetObject("tabPageGlobalChat.BackgroundImage");
            tabPageGlobalChat.Controls.Add(btnRefresh3);
            tabPageGlobalChat.Controls.Add(btnBack3);
            tabPageGlobalChat.Controls.Add(btnDelete3);
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
            // btnRefresh3
            // 
            btnRefresh3.BackColor = Color.Transparent;
            btnRefresh3.FlatStyle = FlatStyle.Popup;
            btnRefresh3.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnRefresh3.Location = new Point(576, 790);
            btnRefresh3.Name = "btnRefresh3";
            btnRefresh3.Size = new Size(109, 36);
            btnRefresh3.TabIndex = 117;
            btnRefresh3.UseVisualStyleBackColor = false;
            btnRefresh3.Click += btnRefresh3_Click;
            // 
            // btnBack3
            // 
            btnBack3.BackColor = Color.Transparent;
            btnBack3.FlatStyle = FlatStyle.Popup;
            btnBack3.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnBack3.Location = new Point(1512, 896);
            btnBack3.Name = "btnBack3";
            btnBack3.Size = new Size(92, 36);
            btnBack3.TabIndex = 116;
            btnBack3.Text = "Back";
            btnBack3.UseVisualStyleBackColor = false;
            btnBack3.Click += btnBack3_Click;
            // 
            // btnDelete3
            // 
            btnDelete3.BackColor = Color.Transparent;
            btnDelete3.FlatStyle = FlatStyle.Popup;
            btnDelete3.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnDelete3.Location = new Point(716, 790);
            btnDelete3.Name = "btnDelete3";
            btnDelete3.Size = new Size(108, 36);
            btnDelete3.TabIndex = 115;
            btnDelete3.UseVisualStyleBackColor = false;
            btnDelete3.Click += btnDelete3_Click;
            // 
            // txtSearch6
            // 
            txtSearch6.BackColor = Color.FromArgb(134, 205, 211);
            txtSearch6.BorderStyle = BorderStyle.None;
            txtSearch6.Location = new Point(883, 770);
            txtSearch6.Name = "txtSearch6";
            txtSearch6.Size = new Size(224, 29);
            txtSearch6.TabIndex = 112;
            txtSearch6.TextChanged += txtSearch6_TextChanged;
            // 
            // btnSearch6
            // 
            btnSearch6.BackColor = Color.Transparent;
            btnSearch6.FlatStyle = FlatStyle.Popup;
            btnSearch6.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearch6.Location = new Point(866, 816);
            btnSearch6.Name = "btnSearch6";
            btnSearch6.Size = new Size(257, 36);
            btnSearch6.TabIndex = 111;
            btnSearch6.UseVisualStyleBackColor = false;
            btnSearch6.Click += btnSearch6_Click;
            // 
            // txtSearch5
            // 
            txtSearch5.BackColor = Color.FromArgb(134, 205, 211);
            txtSearch5.BorderStyle = BorderStyle.None;
            txtSearch5.Location = new Point(1165, 765);
            txtSearch5.Name = "txtSearch5";
            txtSearch5.Size = new Size(221, 29);
            txtSearch5.TabIndex = 110;
            txtSearch5.TextChanged += txtSearch5_TextChanged;
            // 
            // btnSearch5
            // 
            btnSearch5.BackColor = Color.Transparent;
            btnSearch5.FlatStyle = FlatStyle.Popup;
            btnSearch5.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearch5.Location = new Point(1165, 816);
            btnSearch5.Name = "btnSearch5";
            btnSearch5.Size = new Size(221, 36);
            btnSearch5.TabIndex = 109;
            btnSearch5.UseVisualStyleBackColor = false;
            btnSearch5.Click += btnSearch5_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = Color.FromArgb(70, 152, 156);
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(540, 102);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(846, 584);
            dataGridView4.TabIndex = 0;
            dataGridView4.CellContentClick += dataGridView3_CellContentClick;
            // 
            // User_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1031);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private TextBox txtActivityTime;
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
        private DataGridView dataGridView4;
        private TextBox txtSearch6;
        private Button btnSearch6;
        private TextBox txtSearch5;
        private Button btnSearch5;
        private Button btnDelete3;
        private Button btnBack2;
        private Button btnBack3;
        private Button btnRefresh3;
        private RichTextBox richTextBox1;
        private Button btnDelete4;
        private Button btnClear3;
    }
}