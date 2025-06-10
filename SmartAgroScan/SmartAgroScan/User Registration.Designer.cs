namespace SmartAgroScan
{
    partial class User_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Registration));
            btnConfirm = new Button();
            dateTimePicker = new DateTimePicker();
            radioButtonUser = new RadioButton();
            groupBoxGender = new GroupBox();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            txtAge = new TextBox();
            textBox3 = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtFullName = new TextBox();
            btnBack = new Button();
            groupBoxGender.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(98, 172, 115);
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnConfirm.Location = new Point(611, 723);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(179, 38);
            btnConfirm.TabIndex = 78;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarMonthBackground = SystemColors.WindowFrame;
            dateTimePicker.CalendarTitleForeColor = Color.Black;
            dateTimePicker.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dateTimePicker.Location = new Point(492, 575);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(227, 25);
            dateTimePicker.TabIndex = 77;
            // 
            // radioButtonUser
            // 
            radioButtonUser.AutoSize = true;
            radioButtonUser.BackColor = Color.Transparent;
            radioButtonUser.Checked = true;
            radioButtonUser.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            radioButtonUser.Location = new Point(491, 491);
            radioButtonUser.Name = "radioButtonUser";
            radioButtonUser.Size = new Size(73, 29);
            radioButtonUser.TabIndex = 76;
            radioButtonUser.TabStop = true;
            radioButtonUser.Text = "User";
            radioButtonUser.UseVisualStyleBackColor = false;
            // 
            // groupBoxGender
            // 
            groupBoxGender.BackColor = Color.Transparent;
            groupBoxGender.Controls.Add(radioButtonMale);
            groupBoxGender.Controls.Add(radioButtonFemale);
            groupBoxGender.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxGender.Location = new Point(485, 434);
            groupBoxGender.Name = "groupBoxGender";
            groupBoxGender.Size = new Size(219, 45);
            groupBoxGender.TabIndex = 75;
            groupBoxGender.TabStop = false;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(6, 16);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(76, 29);
            radioButtonMale.TabIndex = 15;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(118, 16);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(95, 29);
            radioButtonFemale.TabIndex = 16;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            radioButtonFemale.CheckedChanged += radioButtonFemale_CheckedChanged;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.FromArgb(70, 152, 156);
            txtAge.BorderStyle = BorderStyle.None;
            txtAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtAge.ForeColor = Color.White;
            txtAge.Location = new Point(489, 538);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(78, 20);
            txtAge.TabIndex = 74;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(70, 152, 156);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(489, 411);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 20);
            textBox3.TabIndex = 73;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(70, 152, 156);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(489, 372);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(182, 20);
            txtPassword.TabIndex = 72;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(70, 152, 156);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(489, 330);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(182, 20);
            txtUsername.TabIndex = 71;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(70, 152, 156);
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtFullName.ForeColor = Color.White;
            txtFullName.Location = new Point(489, 287);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(182, 20);
            txtFullName.TabIndex = 70;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(98, 172, 115);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnBack.Location = new Point(1173, 765);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 36);
            btnBack.TabIndex = 61;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // User_Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1427, 886);
            Controls.Add(btnConfirm);
            Controls.Add(dateTimePicker);
            Controls.Add(radioButtonUser);
            Controls.Add(groupBoxGender);
            Controls.Add(txtAge);
            Controls.Add(textBox3);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtFullName);
            Controls.Add(btnBack);
            DoubleBuffered = true;
            Name = "User_Registration";
            Text = "User_Registration";
            Load += User_Registration_Load;
            groupBoxGender.ResumeLayout(false);
            groupBoxGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private DateTimePicker dateTimePicker;
        private RadioButton radioButtonUser;
        private GroupBox groupBoxGender;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private TextBox txtAge;
        private TextBox textBox3;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtFullName;
        private Button btnBack;
    }
}