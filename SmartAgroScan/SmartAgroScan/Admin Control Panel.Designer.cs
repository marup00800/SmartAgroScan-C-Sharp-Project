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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Control_Panel));
            button1 = new Button();
            button2 = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(338, 334);
            button1.Name = "button1";
            button1.Size = new Size(323, 141);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(783, 341);
            button2.Name = "button2";
            button2.Size = new Size(323, 134);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Location = new Point(1190, 703);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 39);
            btnBack.TabIndex = 44;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Admin_Control_Panel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1394, 849);
            Controls.Add(btnBack);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_Control_Panel";
            Text = "Admin_Control_Panel";
            Load += Admin_Control_Panel_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnBack;
    }
}