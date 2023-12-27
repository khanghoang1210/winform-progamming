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
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExcel = new Button();
            btnSql = new Button();
            btnUpdateData = new Button();
            dgvLaptop = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            btnAdd.Click += btnAdd_Click;
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
            btnUpdate.Click += btnUpdate_Click;
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
            btnDelete.Click += btnDelete_Click;
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
            btnExcel.Click += btnExcel_Click;
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
            btnSql.Click += btnSql_Click;
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
            btnUpdateData.Click += btnUpdateData_Click;
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
            dgvLaptop.EditingControlShowing += dgvLaptop_EditingControlShowing;
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
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LaptopManagement";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLaptop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExcel;
        private Button btnSql;
        private Button btnUpdateData;
        private DataGridView dgvLaptop;
    }
}