namespace AirlineBookingApp
{
    partial class Booking
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            label1 = new Label();
            flightBindingSource = new BindingSource(components);
            flightBindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            Adult = new NumericUpDown();
            Child = new NumericUpDown();
            Infant = new NumericUpDown();
            btnBook = new Button();
            label10 = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)flightBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flightBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Adult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Child).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Infant).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(425, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 54);
            label1.TabIndex = 1;
            label1.Text = "BOOKING";
            // 
            // flightBindingSource
            // 
            flightBindingSource.DataSource = typeof(WinForms.Flight);
            // 
            // flightBindingSource1
            // 
            flightBindingSource1.DataSource = typeof(WinForms.Flight);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(958, 468);
            dataGridView1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1013, 73);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 16;
            label3.Text = "Seat Class";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1013, 111);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(318, 33);
            comboBox1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1013, 167);
            label2.Name = "label2";
            label2.Size = new Size(261, 32);
            label2.TabIndex = 18;
            label2.Text = "Number of Passenger";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1013, 354);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 36);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1013, 288);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 36);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1013, 221);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 36);
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1055, 211);
            label4.Name = "label4";
            label4.Size = new Size(61, 28);
            label4.TabIndex = 22;
            label4.Text = "Adult";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1055, 236);
            label7.Name = "label7";
            label7.Size = new Size(134, 21);
            label7.TabIndex = 25;
            label7.Text = "(Age 12 and over)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1056, 303);
            label5.Name = "label5";
            label5.Size = new Size(92, 21);
            label5.TabIndex = 27;
            label5.Text = "(Age 2 - 11)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1056, 278);
            label6.Name = "label6";
            label6.Size = new Size(58, 28);
            label6.TabIndex = 26;
            label6.Text = "Child";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1056, 369);
            label8.Name = "label8";
            label8.Size = new Size(104, 21);
            label8.TabIndex = 29;
            label8.Text = "(Below age 2)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1056, 344);
            label9.Name = "label9";
            label9.Size = new Size(66, 28);
            label9.TabIndex = 28;
            label9.Text = "Infant";
            // 
            // Adult
            // 
            Adult.Location = new Point(1243, 226);
            Adult.Name = "Adult";
            Adult.Size = new Size(88, 31);
            Adult.TabIndex = 30;
            Adult.ValueChanged += Adult_ValueChanged;
            // 
            // Child
            // 
            Child.Location = new Point(1243, 288);
            Child.Name = "Child";
            Child.Size = new Size(88, 31);
            Child.TabIndex = 31;
            Child.ValueChanged += Child_ValueChanged;
            // 
            // Infant
            // 
            Infant.Location = new Point(1243, 354);
            Infant.Name = "Infant";
            Infant.Size = new Size(88, 31);
            Infant.TabIndex = 32;
            Infant.ValueChanged += Infant_ValueChanged;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(1131, 505);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(112, 34);
            btnBook.TabIndex = 33;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(1279, 426);
            label10.Name = "label10";
            label10.Size = new Size(52, 21);
            label10.TabIndex = 35;
            label10.Text = "Totals:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(1197, 447);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 32);
            lblTotal.TabIndex = 34;
            lblTotal.Click += lblTotalCost;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 581);
            Controls.Add(label10);
            Controls.Add(lblTotal);
            Controls.Add(btnBook);
            Controls.Add(Infant);
            Controls.Add(Child);
            Controls.Add(Adult);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Booking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking";
            ((System.ComponentModel.ISupportInitialize)flightBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)flightBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Adult).EndInit();
            ((System.ComponentModel.ISupportInitialize)Child).EndInit();
            ((System.ComponentModel.ISupportInitialize)Infant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private BindingSource flightBindingSource;
        private BindingSource flightBindingSource1;
        private DataGridView dataGridView1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private NumericUpDown Adult;
        private NumericUpDown Child;
        private NumericUpDown Infant;
        private Button btnBook;
        private Label label10;
        private Label lblTotal;
    }
}