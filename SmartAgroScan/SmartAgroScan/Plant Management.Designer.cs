namespace SmartAgroScan
{
    partial class Plant_Management
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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtRecommendedSoil = new TextBox();
            txtPicturePath = new TextBox();
            txtName = new TextBox();
            txtPlantId = new TextBox();
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            pictureBox1 = new PictureBox();
            btnChooseImage = new Button();
            openFileDialog1 = new OpenFileDialog();
            txtWaterTip = new RichTextBox();
            txtFertilizerTip = new RichTextBox();
            txtHarvestTip = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(835, 333);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(900, 512);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 92;
            label6.Text = "Harvest Tip";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(916, 338);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 91;
            label7.Text = "Water Tip";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(898, 439);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 90;
            label8.Text = "Fertilizer Tip";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(866, 282);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 89;
            label4.Text = "Recommended Soil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(898, 223);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 88;
            label3.Text = "Picture Path";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(898, 165);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 87;
            label2.Text = "Plant Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(898, 109);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 86;
            label1.Text = "Plant ID";
            // 
            // txtRecommendedSoil
            // 
            txtRecommendedSoil.Location = new Point(1020, 279);
            txtRecommendedSoil.Name = "txtRecommendedSoil";
            txtRecommendedSoil.Size = new Size(191, 27);
            txtRecommendedSoil.TabIndex = 82;
            // 
            // txtPicturePath
            // 
            txtPicturePath.Location = new Point(1020, 220);
            txtPicturePath.Name = "txtPicturePath";
            txtPicturePath.Size = new Size(191, 27);
            txtPicturePath.TabIndex = 81;
            // 
            // txtName
            // 
            txtName.Location = new Point(1020, 162);
            txtName.Name = "txtName";
            txtName.Size = new Size(191, 27);
            txtName.TabIndex = 80;
            // 
            // txtPlantId
            // 
            txtPlantId.Location = new Point(1020, 103);
            txtPlantId.Name = "txtPlantId";
            txtPlantId.Size = new Size(191, 27);
            txtPlantId.TabIndex = 79;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkGray;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnDelete.Location = new Point(590, 503);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 36);
            btnDelete.TabIndex = 98;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(56, 509);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(191, 27);
            txtSearch.TabIndex = 97;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkGray;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearch.Location = new Point(87, 542);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(160, 36);
            btnSearch.TabIndex = 96;
            btnSearch.Text = "Search by ID";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkGray;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnClear.Location = new Point(39, 467);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 36);
            btnClear.TabIndex = 95;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkGray;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnUpdate.Location = new Point(590, 449);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 36);
            btnUpdate.TabIndex = 94;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.DarkGray;
            btnInsert.FlatStyle = FlatStyle.Popup;
            btnInsert.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnInsert.Location = new Point(165, 467);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 36);
            btnInsert.TabIndex = 93;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(116, 643);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 139);
            pictureBox1.TabIndex = 99;
            pictureBox1.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.BackColor = Color.DarkGray;
            btnChooseImage.FlatStyle = FlatStyle.Popup;
            btnChooseImage.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnChooseImage.Location = new Point(103, 601);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(144, 36);
            btnChooseImage.TabIndex = 100;
            btnChooseImage.Text = "Choose Image";
            btnChooseImage.UseVisualStyleBackColor = false;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // txtWaterTip
            // 
            txtWaterTip.Location = new Point(1020, 335);
            txtWaterTip.Name = "txtWaterTip";
            txtWaterTip.Size = new Size(191, 81);
            txtWaterTip.TabIndex = 101;
            txtWaterTip.Text = "";
            // 
            // txtFertilizerTip
            // 
            txtFertilizerTip.Location = new Point(1020, 422);
            txtFertilizerTip.Name = "txtFertilizerTip";
            txtFertilizerTip.Size = new Size(191, 81);
            txtFertilizerTip.TabIndex = 102;
            txtFertilizerTip.Text = "";
            // 
            // txtHarvestTip
            // 
            txtHarvestTip.Location = new Point(1020, 509);
            txtHarvestTip.Name = "txtHarvestTip";
            txtHarvestTip.Size = new Size(191, 81);
            txtHarvestTip.TabIndex = 103;
            txtHarvestTip.Text = "";
            // 
            // Plant_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(txtHarvestTip);
            Controls.Add(txtFertilizerTip);
            Controls.Add(txtWaterTip);
            Controls.Add(btnChooseImage);
            Controls.Add(pictureBox1);
            Controls.Add(btnDelete);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRecommendedSoil);
            Controls.Add(txtPicturePath);
            Controls.Add(txtName);
            Controls.Add(txtPlantId);
            Controls.Add(dataGridView1);
            Name = "Plant_Management";
            Text = "Plant_Management";
            Load += Plant_Management_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtRecommendedSoil;
        private TextBox txtPicturePath;
        private TextBox txtName;
        private TextBox txtPlantId;
        private Button btnDelete;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnInsert;
        private PictureBox pictureBox1;
        private Button btnChooseImage;
        private OpenFileDialog openFileDialog1;
        private RichTextBox txtWaterTip;
        private RichTextBox txtFertilizerTip;
        private RichTextBox txtHarvestTip;
    }
}