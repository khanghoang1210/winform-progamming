namespace LaptopManagement
{
    partial class LaptopManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaptopManagement));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtSearch = new TextBox();
            cbSearch = new ComboBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExcel = new Button();
            btnSql = new Button();
            btnUpdateData = new Button();
            dgvLaptop = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLaptop).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(177, 42);
            label1.Name = "label1";
            label1.Size = new Size(341, 45);
            label1.TabIndex = 0;
            label1.Text = "Laptop Management ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-7, -35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1110, 106);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(219, 31);
            txtSearch.TabIndex = 2;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(929, 106);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(175, 33);
            cbSearch.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1335, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(930, 82);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 6;
            label2.Text = "Search by";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(1110, 82);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 7;
            label3.Text = "Enter information";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.HotTrack;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(177, 106);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.No;
            btnAdd.Size = new Size(98, 47);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = SystemColors.HotTrack;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.Location = new Point(310, 106);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.RightToLeft = RightToLeft.No;
            btnUpdate.Size = new Size(115, 47);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Red;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(453, 106);
            btnDelete.Name = "btnDelete";
            btnDelete.RightToLeft = RightToLeft.No;
            btnDelete.Size = new Size(104, 47);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.White;
            btnExcel.BackgroundImageLayout = ImageLayout.Zoom;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.ForeColor = SystemColors.ControlText;
            btnExcel.Image = (Image)resources.GetObject("btnExcel.Image");
            btnExcel.Location = new Point(1126, 169);
            btnExcel.Name = "btnExcel";
            btnExcel.RightToLeft = RightToLeft.No;
            btnExcel.Size = new Size(239, 47);
            btnExcel.TabIndex = 12;
            btnExcel.Text = "Load Data from Excel";
            btnExcel.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnSql
            // 
            btnSql.BackColor = Color.White;
            btnSql.BackgroundImageLayout = ImageLayout.Zoom;
            btnSql.FlatStyle = FlatStyle.Flat;
            btnSql.ForeColor = SystemColors.ControlText;
            btnSql.Image = (Image)resources.GetObject("btnSql.Image");
            btnSql.Location = new Point(1126, 236);
            btnSql.Name = "btnSql";
            btnSql.RightToLeft = RightToLeft.No;
            btnSql.Size = new Size(239, 47);
            btnSql.TabIndex = 13;
            btnSql.Text = "Load Data from SQL";
            btnSql.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSql.UseVisualStyleBackColor = false;
            // 
            // btnUpdateData
            // 
            btnUpdateData.BackColor = Color.White;
            btnUpdateData.BackgroundImageLayout = ImageLayout.Zoom;
            btnUpdateData.FlatStyle = FlatStyle.Flat;
            btnUpdateData.ForeColor = SystemColors.ControlText;
            btnUpdateData.Image = (Image)resources.GetObject("btnUpdateData.Image");
            btnUpdateData.Location = new Point(1126, 314);
            btnUpdateData.Name = "btnUpdateData";
            btnUpdateData.RightToLeft = RightToLeft.No;
            btnUpdateData.Size = new Size(239, 47);
            btnUpdateData.TabIndex = 14;
            btnUpdateData.Text = "Update to DataSource";
            btnUpdateData.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUpdateData.UseVisualStyleBackColor = false;
            // 
            // dgvLaptop
            // 
            dgvLaptop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaptop.Location = new Point(25, 169);
            dgvLaptop.Name = "dgvLaptop";
            dgvLaptop.RowHeadersWidth = 62;
            dgvLaptop.RowTemplate.Height = 33;
            dgvLaptop.Size = new Size(1079, 413);
            dgvLaptop.TabIndex = 8;
            dgvLaptop.SelectionChanged += DgvLaptop_SelectionChanged;
            // 
            // LaptopManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1394, 611);
            Controls.Add(btnUpdateData);
            Controls.Add(btnSql);
            Controls.Add(btnExcel);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvLaptop);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(txtSearch);
            Controls.Add(cbSearch);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LaptopManagement";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLaptop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtSearch;
        private ComboBox cbSearch;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExcel;
        private Button btnSql;
        private Button btnUpdateData;
        private DataGridView dgvLaptop;
    }
}