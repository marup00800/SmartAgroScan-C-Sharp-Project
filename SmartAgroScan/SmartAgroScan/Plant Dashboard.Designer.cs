namespace SmartAgroScan
{
    partial class Plant_Dashboard
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
            dataGridViewPalnt = new DataGridView();
            btnBack = new Button();
            dataGridViewValues = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPalnt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewValues).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPalnt
            // 
            dataGridViewPalnt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPalnt.Location = new Point(12, 361);
            dataGridViewPalnt.Name = "dataGridViewPalnt";
            dataGridViewPalnt.RowHeadersWidth = 51;
            dataGridViewPalnt.Size = new Size(704, 245);
            dataGridViewPalnt.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1414, 448);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(117, 37);
            btnBack.TabIndex = 19;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dataGridViewValues
            // 
            dataGridViewValues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewValues.Location = new Point(12, 65);
            dataGridViewValues.Name = "dataGridViewValues";
            dataGridViewValues.RowHeadersWidth = 51;
            dataGridViewValues.Size = new Size(1062, 245);
            dataGridViewValues.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 338);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 45;
            label1.Text = "Plant";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 42);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 46;
            label2.Text = "Test Values";
            // 
            // Plant_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1748, 715);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewValues);
            Controls.Add(btnBack);
            Controls.Add(dataGridViewPalnt);
            Name = "Plant_Dashboard";
            Text = "Plant_Dashboard_for_ADMIN";
            Load += Plant_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPalnt).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewValues).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPalnt;
        private Button btnBack;
        private DataGridView dataGridViewValues;
        private Label label1;
        private Label label2;
    }
}