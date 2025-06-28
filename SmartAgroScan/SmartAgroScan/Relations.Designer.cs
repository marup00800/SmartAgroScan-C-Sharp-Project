namespace SmartAgroScan
{
    partial class Relations
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
            dataGridView1 = new DataGridView();
            label15 = new Label();
            txtRecommendationId = new TextBox();
            label1 = new Label();
            txtTestId = new TextBox();
            label2 = new Label();
            txtPlantId = new TextBox();
            txtSearchId = new TextBox();
            btnDelete = new Button();
            txtSearchTestId = new TextBox();
            btnSearchTestId = new Button();
            txtSearchRecommendationId = new TextBox();
            btnSearchRecommendationId = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            btnRefresh = new Button();
            btnSearchPlantId = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(423, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(458, 464);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(49, 186);
            label15.Name = "label15";
            label15.Size = new Size(153, 20);
            label15.TabIndex = 121;
            label15.Text = "Recommendation ID :";
            // 
            // txtRecommendationId
            // 
            txtRecommendationId.Location = new Point(208, 183);
            txtRecommendationId.Name = "txtRecommendationId";
            txtRecommendationId.Size = new Size(125, 27);
            txtRecommendationId.TabIndex = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 245);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 123;
            label1.Text = "Test ID :";
            // 
            // txtTestId
            // 
            txtTestId.Location = new Point(208, 242);
            txtTestId.Name = "txtTestId";
            txtTestId.Size = new Size(125, 27);
            txtTestId.TabIndex = 122;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 307);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 125;
            label2.Text = "Plant ID :";
            // 
            // txtPlantId
            // 
            txtPlantId.Location = new Point(208, 304);
            txtPlantId.Name = "txtPlantId";
            txtPlantId.Size = new Size(125, 27);
            txtPlantId.TabIndex = 124;
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(740, 511);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.Size = new Size(141, 27);
            txtSearchId.TabIndex = 129;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkGray;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnDelete.Location = new Point(289, 490);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 36);
            btnDelete.TabIndex = 127;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearchTestId
            // 
            txtSearchTestId.Location = new Point(584, 511);
            txtSearchTestId.Name = "txtSearchTestId";
            txtSearchTestId.Size = new Size(141, 27);
            txtSearchTestId.TabIndex = 131;
            // 
            // btnSearchTestId
            // 
            btnSearchTestId.BackColor = Color.DarkGray;
            btnSearchTestId.FlatStyle = FlatStyle.Popup;
            btnSearchTestId.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearchTestId.Location = new Point(584, 544);
            btnSearchTestId.Name = "btnSearchTestId";
            btnSearchTestId.Size = new Size(141, 66);
            btnSearchTestId.TabIndex = 130;
            btnSearchTestId.Text = "Search by Test ID";
            btnSearchTestId.UseVisualStyleBackColor = false;
            btnSearchTestId.Click += btnSearchTestId_Click;
            // 
            // txtSearchRecommendationId
            // 
            txtSearchRecommendationId.Location = new Point(423, 511);
            txtSearchRecommendationId.Name = "txtSearchRecommendationId";
            txtSearchRecommendationId.Size = new Size(141, 27);
            txtSearchRecommendationId.TabIndex = 133;
            // 
            // btnSearchRecommendationId
            // 
            btnSearchRecommendationId.BackColor = Color.DarkGray;
            btnSearchRecommendationId.FlatStyle = FlatStyle.Popup;
            btnSearchRecommendationId.Font = new Font("Segoe UI Emoji", 8F, FontStyle.Bold);
            btnSearchRecommendationId.Location = new Point(423, 544);
            btnSearchRecommendationId.Name = "btnSearchRecommendationId";
            btnSearchRecommendationId.Size = new Size(141, 66);
            btnSearchRecommendationId.TabIndex = 132;
            btnSearchRecommendationId.Text = "Search by Recommendation ID";
            btnSearchRecommendationId.UseVisualStyleBackColor = false;
            btnSearchRecommendationId.Click += btnSearchRecommendationId_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkGray;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnUpdate.Location = new Point(166, 490);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 36);
            btnUpdate.TabIndex = 135;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.DarkGray;
            btnInsert.FlatStyle = FlatStyle.Popup;
            btnInsert.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnInsert.Location = new Point(38, 490);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 36);
            btnInsert.TabIndex = 134;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DarkGray;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnRefresh.Location = new Point(166, 558);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 36);
            btnRefresh.TabIndex = 136;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearchPlantId
            // 
            btnSearchPlantId.BackColor = Color.DarkGray;
            btnSearchPlantId.FlatStyle = FlatStyle.Popup;
            btnSearchPlantId.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearchPlantId.Location = new Point(740, 543);
            btnSearchPlantId.Name = "btnSearchPlantId";
            btnSearchPlantId.Size = new Size(141, 66);
            btnSearchPlantId.TabIndex = 137;
            btnSearchPlantId.Text = "Search by Plant ID";
            btnSearchPlantId.UseVisualStyleBackColor = false;
            btnSearchPlantId.Click += btnSearchPlantId_Click;
            // 
            // Relations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 655);
            Controls.Add(btnSearchPlantId);
            Controls.Add(btnRefresh);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtSearchRecommendationId);
            Controls.Add(btnSearchRecommendationId);
            Controls.Add(txtSearchTestId);
            Controls.Add(btnSearchTestId);
            Controls.Add(txtSearchId);
            Controls.Add(btnDelete);
            Controls.Add(label2);
            Controls.Add(txtPlantId);
            Controls.Add(label1);
            Controls.Add(txtTestId);
            Controls.Add(label15);
            Controls.Add(txtRecommendationId);
            Controls.Add(dataGridView1);
            Name = "Relations";
            Text = "Relations";
            Load += Relations_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label15;
        private TextBox txtRecommendationId;
        private Label label1;
        private TextBox txtTestId;
        private Label label2;
        private TextBox txtPlantId;
        private TextBox txtSearchId;
        private Button btnDelete;
        private TextBox txtSearchTestId;
        private Button btnSearchTestId;
        private TextBox txtSearchRecommendationId;
        private Button btnSearchRecommendationId;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnRefresh;
        private Button btnSearchPlantId;
    }
}