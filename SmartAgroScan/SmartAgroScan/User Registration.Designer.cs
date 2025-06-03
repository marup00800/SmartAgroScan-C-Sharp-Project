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
            btnConfirm = new Button();
            dateTimePicker = new DateTimePicker();
            radioButtonAdmin = new RadioButton();
            groupBoxGender = new GroupBox();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            txtAge = new TextBox();
            textBox3 = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtFullName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBack = new Button();
            groupBoxGender.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(277, 378);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(180, 38);
            btnConfirm.TabIndex = 78;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(277, 317);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(265, 27);
            dateTimePicker.TabIndex = 77;
            // 
            // radioButtonAdmin
            // 
            radioButtonAdmin.AutoSize = true;
            radioButtonAdmin.Checked = true;
            radioButtonAdmin.Location = new Point(286, 234);
            radioButtonAdmin.Name = "radioButtonAdmin";
            radioButtonAdmin.Size = new Size(74, 24);
            radioButtonAdmin.TabIndex = 76;
            radioButtonAdmin.TabStop = true;
            radioButtonAdmin.Text = "Admin";
            radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBoxGender
            // 
            groupBoxGender.Controls.Add(radioButtonMale);
            groupBoxGender.Controls.Add(radioButtonFemale);
            groupBoxGender.Location = new Point(280, 178);
            groupBoxGender.Name = "groupBoxGender";
            groupBoxGender.Size = new Size(177, 44);
            groupBoxGender.TabIndex = 75;
            groupBoxGender.TabStop = false;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(6, 15);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(63, 24);
            radioButtonMale.TabIndex = 15;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(90, 15);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(78, 24);
            radioButtonFemale.TabIndex = 16;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(277, 277);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(180, 27);
            txtAge.TabIndex = 74;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(277, 145);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 27);
            textBox3.TabIndex = 73;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(277, 109);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(180, 27);
            txtPassword.TabIndex = 72;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(277, 70);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(180, 27);
            txtUsername.TabIndex = 71;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(277, 35);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(180, 27);
            txtFullName.TabIndex = 70;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(170, 322);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 69;
            label8.Text = "Date of Birth :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(228, 277);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 68;
            label7.Text = "Age :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(225, 236);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 67;
            label6.Text = "Role :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 197);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 66;
            label5.Text = "Gender :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 145);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 65;
            label4.Text = "Confirm Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 109);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 64;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 70);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 63;
            label2.Text = "Username :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 35);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 62;
            label1.Text = "Full Name :";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(558, 378);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(105, 38);
            btnBack.TabIndex = 61;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // User_Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirm);
            Controls.Add(dateTimePicker);
            Controls.Add(radioButtonAdmin);
            Controls.Add(groupBoxGender);
            Controls.Add(txtAge);
            Controls.Add(textBox3);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtFullName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
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
        private RadioButton radioButtonAdmin;
        private GroupBox groupBoxGender;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private TextBox txtAge;
        private TextBox textBox3;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtFullName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBack;
    }
}