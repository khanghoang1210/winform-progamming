using System.Drawing;
using System.Windows.Forms;

namespace Laptop_LINQ
{
    partial class LaptopLinq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaptopLinq));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnSql = new System.Windows.Forms.Button();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.dgvLaptop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(159, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laptop Management ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Location = new System.Drawing.Point(159, 85);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(88, 38);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Location = new System.Drawing.Point(279, 85);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(104, 38);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(408, 85);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(94, 38);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(0, 0);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(68, 18);
            this.btnExcel.TabIndex = 15;
            // 
            // btnSql
            // 
            this.btnSql.BackColor = System.Drawing.Color.White;
            this.btnSql.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSql.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSql.Location = new System.Drawing.Point(1013, 189);
            this.btnSql.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSql.Name = "btnSql";
            this.btnSql.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSql.Size = new System.Drawing.Size(215, 38);
            this.btnSql.TabIndex = 13;
            this.btnSql.Text = "Load Data from SQL";
            this.btnSql.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSql.UseVisualStyleBackColor = false;
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.BackColor = System.Drawing.Color.White;
            this.btnUpdateData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateData.Location = new System.Drawing.Point(1013, 251);
            this.btnUpdateData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdateData.Size = new System.Drawing.Size(215, 38);
            this.btnUpdateData.TabIndex = 14;
            this.btnUpdateData.Text = "Update to DataSource";
            this.btnUpdateData.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdateData.UseVisualStyleBackColor = false;
            // 
            // dgvLaptop
            // 
            this.dgvLaptop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaptop.Location = new System.Drawing.Point(22, 135);
            this.dgvLaptop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLaptop.Name = "dgvLaptop";
            this.dgvLaptop.RowHeadersWidth = 62;
            this.dgvLaptop.RowTemplate.Height = 33;
            this.dgvLaptop.Size = new System.Drawing.Size(971, 330);
            this.dgvLaptop.TabIndex = 8;
            // 
            // LaptopLinq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1255, 489);
            this.Controls.Add(this.btnUpdateData);
            this.Controls.Add(this.btnSql);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvLaptop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LaptopLinq";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

