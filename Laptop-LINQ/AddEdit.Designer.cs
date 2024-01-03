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
            lbTitle = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cbType = new ComboBox();
            label5 = new Label();
            dpDate = new DateTimePicker();
            txtProcessor = new TextBox();
            label6 = new Label();
            cbHdd = new ComboBox();
            label7 = new Label();
            cbRam = new ComboBox();
            label8 = new Label();
            txtPrice = new TextBox();
            label9 = new Label();
            btnChooseImg = new Button();
            label10 = new Label();
            lbImgName = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(217, 21);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(201, 32);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Add new Laptop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 82);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "LaptopID";
            // 
            // txtId
            // 
            txtId.Location = new Point(236, 76);
            txtId.Name = "txtId";
            txtId.Size = new Size(182, 31);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(236, 137);
            txtName.Name = "txtName";
            txtName.Size = new Size(182, 31);
            txtName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 143);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 3;
            label3.Text = "LaptopName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 205);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 5;
            label4.Text = "LaptopType";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(236, 197);
            cbType.Name = "cbType";
            cbType.Size = new Size(182, 33);
            cbType.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 259);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 7;
            label5.Text = "ProductDate";
            // 
            // dpDate
            // 
            dpDate.Location = new Point(236, 253);
            dpDate.Name = "dpDate";
            dpDate.Size = new Size(294, 31);
            dpDate.TabIndex = 8;
            // 
            // txtProcessor
            // 
            txtProcessor.Location = new Point(236, 307);
            txtProcessor.Name = "txtProcessor";
            txtProcessor.Size = new Size(182, 31);
            txtProcessor.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 313);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 9;
            label6.Text = "Processor";
            // 
            // cbHdd
            // 
            cbHdd.FormattingEnabled = true;
            cbHdd.Location = new Point(236, 365);
            cbHdd.Name = "cbHdd";
            cbHdd.Size = new Size(182, 33);
            cbHdd.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 373);
            label7.Name = "label7";
            label7.Size = new Size(51, 25);
            label7.TabIndex = 11;
            label7.Text = "HDD";
            // 
            // cbRam
            // 
            cbRam.FormattingEnabled = true;
            cbRam.Location = new Point(236, 426);
            cbRam.Name = "cbRam";
            cbRam.Size = new Size(182, 33);
            cbRam.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(72, 434);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 13;
            label8.Text = "RAM";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(236, 484);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(182, 31);
            txtPrice.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(72, 490);
            label9.Name = "label9";
            label9.Size = new Size(49, 25);
            label9.TabIndex = 15;
            label9.Text = "Price";
            // 
            // btnChooseImg
            // 
            btnChooseImg.Location = new Point(236, 538);
            btnChooseImg.Name = "btnChooseImg";
            btnChooseImg.Size = new Size(112, 34);
            btnChooseImg.TabIndex = 17;
            btnChooseImg.Text = "Choose";
            btnChooseImg.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(72, 547);
            label10.Name = "label10";
            label10.Size = new Size(109, 25);
            label10.TabIndex = 18;
            label10.Text = "ImageName";
            // 
            // lbImgName
            // 
            lbImgName.AutoSize = true;
            lbImgName.Location = new Point(365, 543);
            lbImgName.Name = "lbImgName";
            lbImgName.Size = new Size(69, 25);
            lbImgName.TabIndex = 19;
            lbImgName.Text = "label11";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(262, 604);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 674);
            Controls.Add(btnAdd);
            Controls.Add(lbImgName);
            Controls.Add(label10);
            Controls.Add(btnChooseImg);
            Controls.Add(txtPrice);
            Controls.Add(label9);
            Controls.Add(cbRam);
            Controls.Add(label8);
            Controls.Add(cbHdd);
            Controls.Add(label7);
            Controls.Add(txtProcessor);
            Controls.Add(label6);
            Controls.Add(dpDate);
            Controls.Add(label5);
            Controls.Add(cbType);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(lbTitle);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label label2;
        private TextBox txtId;
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