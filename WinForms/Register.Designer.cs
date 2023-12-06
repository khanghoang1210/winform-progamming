namespace WinForms
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(613, 25);
            label1.Name = "label1";
            label1.Size = new Size(191, 54);
            label1.TabIndex = 0;
            label1.Text = "REGISTER";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(440, 593);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel1.Location = new Point(601, 530);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(213, 25);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have an account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(475, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.WindowFrame;
            textBox2.Location = new Point(709, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.ForeColor = SystemColors.WindowFrame;
            textBox4.Location = new Point(709, 334);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(210, 31);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.ForeColor = SystemColors.WindowFrame;
            textBox5.Location = new Point(474, 334);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(210, 31);
            textBox5.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(613, 483);
            button1.Name = "button1";
            button1.Size = new Size(184, 34);
            button1.TabIndex = 9;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox7
            // 
            textBox7.ForeColor = SystemColors.WindowFrame;
            textBox7.Location = new Point(475, 185);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(210, 31);
            textBox7.TabIndex = 10;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox8
            // 
            textBox8.ForeColor = SystemColors.WindowFrame;
            textBox8.Location = new Point(709, 185);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(210, 31);
            textBox8.TabIndex = 11;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(474, 411);
            button2.Name = "button2";
            button2.Size = new Size(144, 34);
            button2.TabIndex = 12;
            button2.Text = "Choose image";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(626, 416);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 13;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 86);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 14;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(709, 86);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 15;
            label4.Text = "Full name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(475, 157);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 16;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(709, 157);
            label6.Name = "label6";
            label6.Size = new Size(158, 25);
            label6.TabIndex = 17;
            label6.Text = "Confirm password";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(475, 232);
            label7.Name = "label7";
            label7.Size = new Size(115, 25);
            label7.TabIndex = 18;
            label7.Text = "Date Of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(474, 306);
            label8.Name = "label8";
            label8.Size = new Size(97, 25);
            label8.TabIndex = 19;
            label8.Text = "Nationality";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(475, 260);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(709, 306);
            label9.Name = "label9";
            label9.Size = new Size(147, 25);
            label9.TabIndex = 21;
            label9.Text = "Passport number";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(475, 383);
            label10.Name = "label10";
            label10.Size = new Size(63, 25);
            label10.TabIndex = 22;
            label10.Text = "Avatar";
            label10.Click += label10_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 586);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private Label label10;
    }
}