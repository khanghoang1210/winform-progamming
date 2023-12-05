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
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(532, 38);
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
            pictureBox1.Size = new Size(440, 575);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel1.Location = new Point(526, 519);
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
            textBox1.Location = new Point(506, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 31);
            textBox1.TabIndex = 3;
            textBox1.Text = "User Name";
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.WindowFrame;
            textBox2.Location = new Point(506, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 31);
            textBox2.TabIndex = 4;
            textBox2.Text = "Full Name";
            // 
            // textBox3
            // 
            textBox3.ForeColor = SystemColors.WindowFrame;
            textBox3.Location = new Point(506, 251);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(248, 31);
            textBox3.TabIndex = 5;
            textBox3.Text = "Date Of Birth";
            // 
            // textBox4
            // 
            textBox4.ForeColor = SystemColors.WindowFrame;
            textBox4.Location = new Point(510, 305);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(244, 31);
            textBox4.TabIndex = 6;
            textBox4.Text = "Passport Number";
            // 
            // textBox5
            // 
            textBox5.ForeColor = SystemColors.WindowFrame;
            textBox5.Location = new Point(510, 357);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(244, 31);
            textBox5.TabIndex = 7;
            textBox5.Text = "Nationality";
            // 
            // textBox6
            // 
            textBox6.ForeColor = SystemColors.WindowFrame;
            textBox6.Location = new Point(510, 405);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(244, 31);
            textBox6.TabIndex = 8;
            textBox6.Text = "Avatar";
            // 
            // button1
            // 
            button1.Location = new Point(539, 462);
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
            textBox7.Location = new Point(510, 204);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(244, 31);
            textBox7.TabIndex = 10;
            textBox7.Text = "Password";
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 566);
            Controls.Add(textBox7);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
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
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private TextBox textBox7;
    }
}