namespace HobiTakip
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblUsername = new Label();
            this.txtUsername = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.lblPasswordConfirm = new Label();
            this.txtPasswordConfirm = new TextBox();
            this.lblFullName = new Label();
            this.txtFullName = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.btnRegister = new Button();
            this.btnCancel = new Button();
            this.panelMain = new Panel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblTitle.Location = new Point(120, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(160, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "YENİ HESAP";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new Font("Segoe UI", 10F);
            this.lblUsername.Location = new Point(30, 70);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new Size(84, 19);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Kullanıcı Adı:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new Font("Segoe UI", 11F);
            this.txtUsername.Location = new Point(30, 95);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(340, 27);
            this.txtUsername.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new Font("Segoe UI", 10F);
            this.lblFullName.Location = new Point(30, 135);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new Size(67, 19);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Ad Soyad:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new Font("Segoe UI", 11F);
            this.txtFullName.Location = new Point(30, 160);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new Size(340, 27);
            this.txtFullName.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new Font("Segoe UI", 10F);
            this.lblEmail.Location = new Point(30, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(92, 19);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-posta (opsiyonel):";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new Font("Segoe UI", 11F);
            this.txtEmail.Location = new Point(30, 225);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(340, 27);
            this.txtEmail.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new Font("Segoe UI", 10F);
            this.lblPassword.Location = new Point(30, 265);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(42, 19);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Şifre:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new Font("Segoe UI", 11F);
            this.txtPassword.Location = new Point(30, 290);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new Size(340, 27);
            this.txtPassword.TabIndex = 8;
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.AutoSize = true;
            this.lblPasswordConfirm.Font = new Font("Segoe UI", 10F);
            this.lblPasswordConfirm.Location = new Point(30, 330);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new Size(84, 19);
            this.lblPasswordConfirm.TabIndex = 9;
            this.lblPasswordConfirm.Text = "Şifre Tekrar:";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Font = new Font("Segoe UI", 11F);
            this.txtPasswordConfirm.Location = new Point(30, 355);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '*';
            this.txtPasswordConfirm.Size = new Size(340, 27);
            this.txtPasswordConfirm.TabIndex = 10;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = Color.FromArgb(46, 204, 113);
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnRegister.ForeColor = Color.White;
            this.btnRegister.Location = new Point(30, 400);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new Size(160, 40);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "KAYIT OL";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new Font("Segoe UI", 11F);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.Location = new Point(210, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(160, 40);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "İPTAL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += btnCancel_Click;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = Color.White;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.btnCancel);
            this.panelMain.Controls.Add(this.lblUsername);
            this.panelMain.Controls.Add(this.btnRegister);
            this.panelMain.Controls.Add(this.txtUsername);
            this.panelMain.Controls.Add(this.txtPasswordConfirm);
            this.panelMain.Controls.Add(this.lblFullName);
            this.panelMain.Controls.Add(this.lblPasswordConfirm);
            this.panelMain.Controls.Add(this.txtFullName);
            this.panelMain.Controls.Add(this.txtPassword);
            this.panelMain.Controls.Add(this.lblEmail);
            this.panelMain.Controls.Add(this.lblPassword);
            this.panelMain.Controls.Add(this.txtEmail);
            this.panelMain.Location = new Point(30, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new Size(400, 460);
            this.panelMain.TabIndex = 13;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(460, 520);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Yeni Hesap Oluştur";
            this.Load += RegisterForm_Load;
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblPasswordConfirm;
        private TextBox txtPasswordConfirm;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnRegister;
        private Button btnCancel;
        private Panel panelMain;
    }
}