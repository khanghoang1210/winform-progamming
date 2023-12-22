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
            picAvatar = new PictureBox();
            linkLabel1 = new LinkLabel();
            txtUserName = new TextBox();
            txtFullname = new TextBox();
            txtPassport = new TextBox();
            txtNation = new TextBox();
            btnRegiser = new Button();
            txtPassword = new TextBox();
            txtCPassword = new TextBox();
            btnBrowse = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateDOB = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(356, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 54);
            label1.TabIndex = 0;
            label1.Text = "REGISTER";
            // 
            // picAvatar
            // 
            picAvatar.Image = (Image)resources.GetObject("picAvatar.Image");
            picAvatar.Location = new Point(80, 123);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(250, 250);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 1;
            picAvatar.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel1.Location = new Point(366, 528);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(213, 25);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have an account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtUserName
            // 
            txtUserName.ForeColor = SystemColors.WindowFrame;
            txtUserName.Location = new Point(402, 114);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(210, 31);
            txtUserName.TabIndex = 3;
            // 
            // txtFullname
            // 
            txtFullname.ForeColor = SystemColors.WindowFrame;
            txtFullname.Location = new Point(636, 114);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(210, 31);
            txtFullname.TabIndex = 4;
            // 
            // txtPassport
            // 
            txtPassport.ForeColor = SystemColors.WindowFrame;
            txtPassport.Location = new Point(636, 342);
            txtPassport.Name = "txtPassport";
            txtPassport.Size = new Size(210, 31);
            txtPassport.TabIndex = 6;
            // 
            // txtNation
            // 
            txtNation.ForeColor = SystemColors.WindowFrame;
            txtNation.Location = new Point(401, 342);
            txtNation.Name = "txtNation";
            txtNation.Size = new Size(210, 31);
            txtNation.TabIndex = 7;
            // 
            // btnRegiser
            // 
            btnRegiser.Location = new Point(378, 481);
            btnRegiser.Name = "btnRegiser";
            btnRegiser.Size = new Size(184, 34);
            btnRegiser.TabIndex = 9;
            btnRegiser.Text = "Register";
            btnRegiser.UseVisualStyleBackColor = true;
            btnRegiser.Click += btnRegiser_Click;
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = SystemColors.WindowFrame;
            txtPassword.Location = new Point(402, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(210, 31);
            txtPassword.TabIndex = 10;
            // 
            // txtCPassword
            // 
            txtCPassword.ForeColor = SystemColors.WindowFrame;
            txtCPassword.Location = new Point(636, 185);
            txtCPassword.Name = "txtCPassword";
            txtCPassword.PasswordChar = '*';
            txtCPassword.Size = new Size(210, 31);
            txtCPassword.TabIndex = 11;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(127, 379);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(144, 34);
            btnBrowse.TabIndex = 12;
            btnBrowse.Text = "Choose avatar";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 86);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 14;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(636, 86);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 15;
            label4.Text = "Full name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 157);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 16;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(636, 157);
            label6.Name = "label6";
            label6.Size = new Size(158, 25);
            label6.TabIndex = 17;
            label6.Text = "Confirm password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(402, 232);
            label7.Name = "label7";
            label7.Size = new Size(115, 25);
            label7.TabIndex = 18;
            label7.Text = "Date Of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(401, 314);
            label8.Name = "label8";
            label8.Size = new Size(97, 25);
            label8.TabIndex = 19;
            label8.Text = "Nationality";
            // 
            // dateDOB
            // 
            dateDOB.Location = new Point(402, 260);
            dateDOB.Name = "dateDOB";
            dateDOB.Size = new Size(300, 31);
            dateDOB.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(636, 314);
            label9.Name = "label9";
            label9.Size = new Size(147, 25);
            label9.TabIndex = 21;
            label9.Text = "Passport number";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(80, 86);
            label10.Name = "label10";
            label10.Size = new Size(63, 25);
            label10.TabIndex = 22;
            label10.Text = "Avatar";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 586);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dateDOB);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnBrowse);
            Controls.Add(txtCPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnRegiser);
            Controls.Add(txtNation);
            Controls.Add(txtPassport);
            Controls.Add(txtFullname);
            Controls.Add(txtUserName);
            Controls.Add(linkLabel1);
            Controls.Add(picAvatar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox picAvatar;
        private LinkLabel linkLabel1;
        private TextBox txtUserName;
        private TextBox txtFullname;
        private TextBox txtPassport;
        private TextBox txtNation;
        private Button btnRegiser;
        private TextBox txtPassword;
        private TextBox txtCPassword;
        private Button btnBrowse;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dateDOB;
        private Label label9;
        private Label label10;
    }
}