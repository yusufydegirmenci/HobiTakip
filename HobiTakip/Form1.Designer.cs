namespace HobiTakip
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
            this.lblTitle = new Label();
            this.lblUsername = new Label();
            this.txtUsername = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.btnRegister = new Button();
            this.panelMain = new Panel();
            this.lblWelcome = new Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblTitle.Location = new Point(80, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(240, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOBİ TAKİP";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = Color.Gray;
            this.lblWelcome.Location = new Point(90, 75);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new Size(220, 19);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Hobilerinizi takip edin, hedeflerinize ulaşın";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new Font("Segoe UI", 10F);
            this.lblUsername.Location = new Point(30, 130);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new Size(84, 19);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Kullanıcı Adı:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new Font("Segoe UI", 12F);
            this.txtUsername.Location = new Point(30, 155);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(340, 29);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.KeyPress += txtUsername_KeyPress;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new Font("Segoe UI", 10F);
            this.lblPassword.Location = new Point(30, 200);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(42, 19);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Şifre:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new Font("Segoe UI", 12F);
            this.txtPassword.Location = new Point(30, 225);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new Size(340, 29);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = Color.FromArgb(41, 128, 185);
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.Location = new Point(30, 280);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(340, 45);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "GİRİŞ YAP";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = Color.FromArgb(46, 204, 113);
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.Font = new Font("Segoe UI", 10F);
            this.btnRegister.ForeColor = Color.White;
            this.btnRegister.Location = new Point(30, 340);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new Size(340, 35);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "YENİ HESAP OLUŞTUR";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += btnRegister_Click;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = Color.White;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.btnRegister);
            this.panelMain.Controls.Add(this.lblWelcome);
            this.panelMain.Controls.Add(this.btnLogin);
            this.panelMain.Controls.Add(this.lblUsername);
            this.panelMain.Controls.Add(this.txtPassword);
            this.panelMain.Controls.Add(this.txtUsername);
            this.panelMain.Controls.Add(this.lblPassword);
            this.panelMain.Location = new Point(50, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new Size(400, 400);
            this.panelMain.TabIndex = 8;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(500, 500);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Hobi Takip - Giriş";
            this.Load += LoginForm_Load;
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Panel panelMain;
        private Label lblWelcome;
    }
}