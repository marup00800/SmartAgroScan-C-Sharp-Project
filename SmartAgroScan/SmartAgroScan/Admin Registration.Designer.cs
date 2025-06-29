namespace SmartAgroScan
{
    partial class Admin_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Registration));
            btnConfirm = new Button();
            dateTimePicker = new DateTimePicker();
            radioButtonAdmin = new RadioButton();
            groupBoxGender = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            txtAge = new TextBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtFullName = new TextBox();
            btnBack = new Button();
            groupBoxGender.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Transparent;
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(863, 833);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(199, 43);
            btnConfirm.TabIndex = 60;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(718, 674);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(278, 27);
            dateTimePicker.TabIndex = 59;
            // 
            // radioButtonAdmin
            // 
            radioButtonAdmin.AutoSize = true;
            radioButtonAdmin.BackColor = Color.Transparent;
            radioButtonAdmin.Checked = true;
            radioButtonAdmin.Location = new Point(722, 583);
            radioButtonAdmin.Name = "radioButtonAdmin";
            radioButtonAdmin.Size = new Size(74, 24);
            radioButtonAdmin.TabIndex = 58;
            radioButtonAdmin.TabStop = true;
            radioButtonAdmin.Text = "Admin";
            radioButtonAdmin.UseVisualStyleBackColor = false;
            // 
            // groupBoxGender
            // 
            groupBoxGender.BackColor = Color.Transparent;
            groupBoxGender.Controls.Add(radioButton2);
            groupBoxGender.Controls.Add(radioButton3);
            groupBoxGender.Location = new Point(713, 523);
            groupBoxGender.Name = "groupBoxGender";
            groupBoxGender.Size = new Size(250, 44);
            groupBoxGender.TabIndex = 57;
            groupBoxGender.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(9, 16);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 24);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Male";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(136, 15);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(78, 24);
            radioButton3.TabIndex = 16;
            radioButton3.TabStop = true;
            radioButton3.Text = "Female";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.FromArgb(70, 152, 156);
            txtAge.BorderStyle = BorderStyle.None;
            txtAge.Location = new Point(717, 632);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(98, 20);
            txtAge.TabIndex = 56;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(70, 152, 156);
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Location = new Point(718, 492);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(210, 20);
            txtConfirmPassword.TabIndex = 55;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(70, 152, 156);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(718, 447);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 20);
            txtPassword.TabIndex = 54;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(70, 152, 156);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(717, 400);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 20);
            txtUsername.TabIndex = 53;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(70, 152, 156);
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Location = new Point(717, 355);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(210, 20);
            txtFullName.TabIndex = 52;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1503, 880);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 44);
            btnBack.TabIndex = 43;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Admin_Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnConfirm);
            Controls.Add(dateTimePicker);
            Controls.Add(radioButtonAdmin);
            Controls.Add(groupBoxGender);
            Controls.Add(txtAge);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtFullName);
            Controls.Add(btnBack);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_Registration";
            Text = "Admin_Registration";
            Load += Admin_Registration_Load;
            groupBoxGender.ResumeLayout(false);
            groupBoxGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private DateTimePicker dateTimePicker;
        private RadioButton radioButtonAdmin;
        private GroupBox groupBoxGender;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox txtAge;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtFullName;
        private Button btnBack;
    }
}