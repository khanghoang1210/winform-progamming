namespace WinForms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            label1 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 610);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(441, 305);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 29);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Remember";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(536, 44);
            label1.Name = "label1";
            label1.Size = new Size(152, 60);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            // 
            // txtUserName
            // 
            txtUserName.ForeColor = SystemColors.WindowFrame;
            txtUserName.Location = new Point(441, 161);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(304, 31);
            txtUserName.TabIndex = 3;
            txtUserName.TextChanged += textUserName;
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = SystemColors.WindowFrame;
            txtPassword.Location = new Point(441, 236);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(304, 31);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(441, 356);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(304, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(441, 413);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(229, 25);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "You don't have an account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(441, 133);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 8;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 208);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 571);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private CheckBox checkBox1;
        private Label label1;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label3;
    }
}