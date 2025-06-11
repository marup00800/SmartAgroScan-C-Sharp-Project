namespace SmartAgroScan
{
    partial class Admin_Control_Panel
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(89, 179);
            button1.Name = "button1";
            button1.Size = new Size(183, 95);
            button1.TabIndex = 0;
            button1.Text = "User Management";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(344, 179);
            button2.Name = "button2";
            button2.Size = new Size(183, 95);
            button2.TabIndex = 1;
            button2.Text = "PlantManagementForm";
            button2.UseVisualStyleBackColor = true;
            // 
            // Admin_Control_Panel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 495);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Admin_Control_Panel";
            Text = "Admin_Control_Panel";
            Load += Admin_Control_Panel_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}