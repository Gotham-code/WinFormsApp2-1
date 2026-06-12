namespace WinFormsApp2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblusername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblpassword = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.BackColor = Color.Transparent;
            lblusername.Location = new Point(251, 205);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(75, 20);
            lblusername.TabIndex = 0;
            lblusername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Location = new Point(251, 228);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(223, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(251, 307);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(223, 27);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblpassword
            // 
            lblpassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblpassword.AutoSize = true;
            lblpassword.BackColor = Color.Transparent;
            lblpassword.Location = new Point(251, 284);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(70, 20);
            lblpassword.TabIndex = 3;
            lblpassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Location = new Point(325, 354);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(79, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(695, 450);
            Controls.Add(btnLogin);
            Controls.Add(lblpassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblusername);
            DoubleBuffered = true;
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblusername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblpassword;
        private Button btnLogin;
    }
}
