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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plant_Management));
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
            dataGridView2 = new DataGridView();
            label5 = new Label();
            txtTestId = new TextBox();
            label9 = new Label();
            txtN = new TextBox();
            label10 = new Label();
            txtP = new TextBox();
            label11 = new Label();
            txtK = new TextBox();
            label12 = new Label();
            txtPh = new TextBox();
            label13 = new Label();
            txtMoisture = new TextBox();
            label14 = new Label();
            txtSoilCondition = new TextBox();
            label15 = new Label();
            label16 = new Label();
            btnDelete2 = new Button();
            btnUpdate2 = new Button();
            btnInsert2 = new Button();
            txtSearch2 = new TextBox();
            btnSearch2 = new Button();
            btnClear2 = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(75, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(847, 360);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(484, 633);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 92;
            label6.Text = "Harvest Tip";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 633);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 91;
            label7.Text = "Water Tip";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(272, 633);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 90;
            label8.Text = "Fertilizer Tip";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 578);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 89;
            label4.Text = "Recommended Soil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(600, 512);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 88;
            label3.Text = "Picture Path";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 509);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 87;
            label2.Text = "Plant Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 509);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 86;
            label1.Text = "Plant ID";
            // 
            // txtRecommendedSoil
            // 
            txtRecommendedSoil.Location = new Point(210, 578);
            txtRecommendedSoil.Name = "txtRecommendedSoil";
            txtRecommendedSoil.Size = new Size(203, 27);
            txtRecommendedSoil.TabIndex = 82;
            // 
            // txtPicturePath
            // 
            txtPicturePath.Location = new Point(692, 509);
            txtPicturePath.Name = "txtPicturePath";
            txtPicturePath.Size = new Size(230, 27);
            txtPicturePath.TabIndex = 81;
            // 
            // txtName
            // 
            txtName.Location = new Point(357, 506);
            txtName.Name = "txtName";
            txtName.Size = new Size(191, 27);
            txtName.TabIndex = 80;
            // 
            // txtPlantId
            // 
            txtPlantId.Location = new Point(142, 509);
            txtPlantId.Name = "txtPlantId";
            txtPlantId.Size = new Size(92, 27);
            txtPlantId.TabIndex = 79;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkGray;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnDelete.Location = new Point(331, 799);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 36);
            btnDelete.TabIndex = 98;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(619, 799);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(129, 27);
            txtSearch.TabIndex = 97;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkGray;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearch.Location = new Point(453, 799);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(160, 36);
            btnSearch.TabIndex = 96;
            btnSearch.Text = "Search by ID";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkGray;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnClear.Location = new Point(852, 799);
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
            btnUpdate.Location = new Point(200, 799);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 36);
            btnUpdate.TabIndex = 94;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.DarkGray;
            btnInsert.FlatStyle = FlatStyle.Popup;
            btnInsert.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnInsert.Location = new Point(75, 799);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 36);
            btnInsert.TabIndex = 93;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(747, 542);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 186);
            pictureBox1.TabIndex = 99;
            pictureBox1.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.BackColor = Color.DarkGray;
            btnChooseImage.FlatStyle = FlatStyle.Popup;
            btnChooseImage.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnChooseImage.Location = new Point(766, 734);
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
            txtWaterTip.Location = new Point(65, 656);
            txtWaterTip.Name = "txtWaterTip";
            txtWaterTip.Size = new Size(191, 99);
            txtWaterTip.TabIndex = 101;
            txtWaterTip.Text = "";
            // 
            // txtFertilizerTip
            // 
            txtFertilizerTip.Location = new Point(272, 656);
            txtFertilizerTip.Name = "txtFertilizerTip";
            txtFertilizerTip.Size = new Size(191, 99);
            txtFertilizerTip.TabIndex = 102;
            txtFertilizerTip.Text = "";
            // 
            // txtHarvestTip
            // 
            txtHarvestTip.Location = new Point(484, 656);
            txtHarvestTip.Name = "txtHarvestTip";
            txtHarvestTip.Size = new Size(191, 99);
            txtHarvestTip.TabIndex = 103;
            txtHarvestTip.Text = "";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(997, 110);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(847, 360);
            dataGridView2.TabIndex = 104;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(997, 516);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 106;
            label5.Text = "Test ID";
            // 
            // txtTestId
            // 
            txtTestId.Location = new Point(1057, 513);
            txtTestId.Name = "txtTestId";
            txtTestId.Size = new Size(92, 27);
            txtTestId.TabIndex = 105;
            // 
            // label9
            // 
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 118;
            // 
            // txtN
            // 
            txtN.Location = new Point(1062, 561);
            txtN.Name = "txtN";
            txtN.Size = new Size(92, 27);
            txtN.TabIndex = 107;
            txtN.TextChanged += textBox2_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1182, 564);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 110;
            label10.Text = "P";
            // 
            // txtP
            // 
            txtP.Location = new Point(1208, 561);
            txtP.Name = "txtP";
            txtP.Size = new Size(92, 27);
            txtP.TabIndex = 109;
            txtP.TextChanged += textBox2_TextChanged_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1330, 564);
            label11.Name = "label11";
            label11.Size = new Size(18, 20);
            label11.TabIndex = 112;
            label11.Text = "K";
            // 
            // txtK
            // 
            txtK.Location = new Point(1356, 561);
            txtK.Name = "txtK";
            txtK.Size = new Size(92, 27);
            txtK.TabIndex = 111;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1614, 568);
            label12.Name = "label12";
            label12.Size = new Size(67, 20);
            label12.TabIndex = 114;
            label12.Text = "Moisture";
            // 
            // txtPh
            // 
            txtPh.Location = new Point(1505, 564);
            txtPh.Name = "txtPh";
            txtPh.Size = new Size(92, 27);
            txtPh.TabIndex = 113;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1470, 567);
            label13.Name = "label13";
            label13.Size = new Size(29, 20);
            label13.TabIndex = 116;
            label13.Text = "pH";
            // 
            // txtMoisture
            // 
            txtMoisture.Location = new Point(1687, 565);
            txtMoisture.Name = "txtMoisture";
            txtMoisture.Size = new Size(92, 27);
            txtMoisture.TabIndex = 115;
            // 
            // label14
            // 
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(100, 23);
            label14.TabIndex = 0;
            // 
            // txtSoilCondition
            // 
            txtSoilCondition.Location = new Point(1138, 616);
            txtSoilCondition.Name = "txtSoilCondition";
            txtSoilCondition.Size = new Size(92, 27);
            txtSoilCondition.TabIndex = 117;
            txtSoilCondition.TextChanged += textBox6_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1002, 561);
            label15.Name = "label15";
            label15.Size = new Size(20, 20);
            label15.TabIndex = 119;
            label15.Text = "N";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1018, 623);
            label16.Name = "label16";
            label16.Size = new Size(103, 20);
            label16.TabIndex = 120;
            label16.Text = "Soil Condition";
            // 
            // btnDelete2
            // 
            btnDelete2.BackColor = Color.DarkGray;
            btnDelete2.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete2.FlatStyle = FlatStyle.Popup;
            btnDelete2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnDelete2.Location = new Point(1262, 693);
            btnDelete2.Name = "btnDelete2";
            btnDelete2.Size = new Size(94, 36);
            btnDelete2.TabIndex = 123;
            btnDelete2.Text = "Delete";
            btnDelete2.UseVisualStyleBackColor = false;
            btnDelete2.Click += btnDelete2_Click;
            // 
            // btnUpdate2
            // 
            btnUpdate2.BackColor = Color.DarkGray;
            btnUpdate2.FlatStyle = FlatStyle.Popup;
            btnUpdate2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnUpdate2.Location = new Point(1134, 693);
            btnUpdate2.Name = "btnUpdate2";
            btnUpdate2.Size = new Size(94, 36);
            btnUpdate2.TabIndex = 122;
            btnUpdate2.Text = "Update";
            btnUpdate2.UseVisualStyleBackColor = false;
            btnUpdate2.Click += btnUpdate2_Click;
            // 
            // btnInsert2
            // 
            btnInsert2.BackColor = Color.DarkGray;
            btnInsert2.FlatStyle = FlatStyle.Popup;
            btnInsert2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnInsert2.Location = new Point(1006, 693);
            btnInsert2.Name = "btnInsert2";
            btnInsert2.Size = new Size(94, 36);
            btnInsert2.TabIndex = 121;
            btnInsert2.Text = "Insert";
            btnInsert2.UseVisualStyleBackColor = false;
            btnInsert2.Click += btnInsert2_Click;
            // 
            // txtSearch2
            // 
            txtSearch2.Location = new Point(1172, 755);
            txtSearch2.Name = "txtSearch2";
            txtSearch2.Size = new Size(129, 27);
            txtSearch2.TabIndex = 126;
            // 
            // btnSearch2
            // 
            btnSearch2.BackColor = Color.DarkGray;
            btnSearch2.FlatStyle = FlatStyle.Popup;
            btnSearch2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSearch2.Location = new Point(1006, 749);
            btnSearch2.Name = "btnSearch2";
            btnSearch2.Size = new Size(160, 36);
            btnSearch2.TabIndex = 125;
            btnSearch2.Text = "Search by ID";
            btnSearch2.UseVisualStyleBackColor = false;
            btnSearch2.Click += btnSearch2_Click;
            // 
            // btnClear2
            // 
            btnClear2.BackColor = Color.DarkGray;
            btnClear2.FlatStyle = FlatStyle.Popup;
            btnClear2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnClear2.Location = new Point(1405, 749);
            btnClear2.Name = "btnClear2";
            btnClear2.Size = new Size(94, 36);
            btnClear2.TabIndex = 124;
            btnClear2.Text = "Clear";
            btnClear2.UseVisualStyleBackColor = false;
            btnClear2.Click += btnClear2_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkGray;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnBack.Location = new Point(1494, 897);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 36);
            btnBack.TabIndex = 127;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Plant_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1909, 1020);
            Controls.Add(btnBack);
            Controls.Add(txtSearch2);
            Controls.Add(btnSearch2);
            Controls.Add(btnClear2);
            Controls.Add(btnDelete2);
            Controls.Add(btnUpdate2);
            Controls.Add(btnInsert2);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(txtSoilCondition);
            Controls.Add(label13);
            Controls.Add(txtMoisture);
            Controls.Add(label12);
            Controls.Add(txtPh);
            Controls.Add(label11);
            Controls.Add(txtK);
            Controls.Add(label10);
            Controls.Add(txtP);
            Controls.Add(label9);
            Controls.Add(txtN);
            Controls.Add(label5);
            Controls.Add(txtTestId);
            Controls.Add(dataGridView2);
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
            DoubleBuffered = true;
            Name = "Plant_Management";
            Text = "Plant_Management";
            Load += Plant_Management_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private DataGridView dataGridView2;
        private Label label5;
        private TextBox txtTestId;
        private Label label9;
        private TextBox txtN;
        private Label label10;
        private TextBox txtP;
        private Label label11;
        private TextBox txtK;
        private Label label12;
        private TextBox txtPh;
        private Label label13;
        private TextBox txtMoisture;
        private Label label14;
        private TextBox txtSoilCondition;
        private Label label15;
        private Label label16;
        private Button btnDelete2;
        private Button btnUpdate2;
        private Button btnInsert2;
        private TextBox txtSearch2;
        private Button btnSearch2;
        private Button btnClear2;
        private Button btnBack;
    }
}