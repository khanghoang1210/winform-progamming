using System.Drawing;
using System.Windows.Forms;

namespace Laptop_LINQ
{
    partial class AddEdit
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.txtProcessor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbHdd = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbRam = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnChooseImg = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbImgName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbTitle.Location = new System.Drawing.Point(195, 17);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(201, 32);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Add new Laptop";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(231, 84);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 26);
            this.txtName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "LaptopName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "LaptopType";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(231, 132);
            this.cbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(164, 28);
            this.cbType.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "ProductDate";
            // 
            // dpDate
            // 
            this.dpDate.Location = new System.Drawing.Point(231, 176);
            this.dpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(265, 26);
            this.dpDate.TabIndex = 8;
            // 
            // txtProcessor
            // 
            this.txtProcessor.Location = new System.Drawing.Point(231, 220);
            this.txtProcessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProcessor.Name = "txtProcessor";
            this.txtProcessor.Size = new System.Drawing.Size(164, 26);
            this.txtProcessor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Processor";
            // 
            // cbHdd
            // 
            this.cbHdd.FormattingEnabled = true;
            this.cbHdd.Location = new System.Drawing.Point(231, 266);
            this.cbHdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHdd.Name = "cbHdd";
            this.cbHdd.Size = new System.Drawing.Size(164, 28);
            this.cbHdd.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "HDD";
            // 
            // cbRam
            // 
            this.cbRam.FormattingEnabled = true;
            this.cbRam.Location = new System.Drawing.Point(231, 315);
            this.cbRam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRam.Name = "cbRam";
            this.cbRam.Size = new System.Drawing.Size(164, 28);
            this.cbRam.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "RAM";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(231, 361);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(164, 26);
            this.txtPrice.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Price";
            // 
            // btnChooseImg
            // 
            this.btnChooseImg.Location = new System.Drawing.Point(231, 404);
            this.btnChooseImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseImg.Name = "btnChooseImg";
            this.btnChooseImg.Size = new System.Drawing.Size(101, 27);
            this.btnChooseImg.TabIndex = 17;
            this.btnChooseImg.Text = "Choose";
            this.btnChooseImg.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "ImageName";
            // 
            // lbImgName
            // 
            this.lbImgName.AutoSize = true;
            this.lbImgName.Location = new System.Drawing.Point(347, 408);
            this.lbImgName.Name = "lbImgName";
            this.lbImgName.Size = new System.Drawing.Size(60, 20);
            this.lbImgName.TabIndex = 19;
            this.lbImgName.Text = "label11";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(255, 457);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 27);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // AddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 539);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbImgName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnChooseImg);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbRam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbHdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProcessor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddEdit";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitle;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private ComboBox cbType;
        private Label label5;
        private DateTimePicker dpDate;
        private TextBox txtProcessor;
        private Label label6;
        private ComboBox cbHdd;
        private Label label7;
        private ComboBox cbRam;
        private Label label8;
        private TextBox txtPrice;
        private Label label9;
        private Button btnChooseImg;
        private Label label10;
        private Label lbImgName;
        private Button btnAdd;
    }
}