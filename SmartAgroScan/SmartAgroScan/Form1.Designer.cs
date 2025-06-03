namespace SmartAgroScan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdmin = new Button();
            btnUser = new Button();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(69, 146);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(170, 102);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "Join as ADMIN";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnUser
            // 
            btnUser.Location = new Point(288, 146);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(170, 102);
            btnUser.TabIndex = 2;
            btnUser.Text = "Join as USER";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 423);
            Controls.Add(btnAdmin);
            Controls.Add(btnUser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdmin;
        private Button btnUser;
    }
}
