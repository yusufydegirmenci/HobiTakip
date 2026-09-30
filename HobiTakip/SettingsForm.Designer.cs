namespace HobiTakip
{
    partial class SettingsForm
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
            this.lblUserName = new Label();
            this.groupTheme = new GroupBox();
            this.rbLightTheme = new RadioButton();
            this.rbDarkTheme = new RadioButton();
            this.rbSystemTheme = new RadioButton();
            this.groupNotifications = new GroupBox();
            this.chkNotifications = new CheckBox();
            this.lblReminderHours = new Label();
            this.numReminderHours = new NumericUpDown();
            this.lblHours = new Label();
            this.btnTestNotification = new Button();
            this.lblLastReminder = new Label();
            this.groupPomodoro = new GroupBox();
            this.chkPomodoroSound = new CheckBox();
            this.lblWorkMinutes = new Label();
            this.numWorkMinutes = new NumericUpDown();
            this.lblBreakMinutes = new Label();
            this.numBreakMinutes = new NumericUpDown();
            this.lblMinutes1 = new Label();
            this.lblMinutes2 = new Label();
            this.groupUserInfo = new GroupBox();
            this.lblEmail = new Label();
            this.lblMemberSince = new Label();
            this.btnExportData = new Button();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.btnResetSettings = new Button();
            this.panelMain = new Panel();
            this.groupTheme.SuspendLayout();
            this.groupNotifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReminderHours)).BeginInit();
            this.groupPomodoro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakMinutes)).BeginInit();
            this.groupUserInfo.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(52, 152, 219);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(120, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "⚙️ AYARLAR";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblUserName.ForeColor = Color.FromArgb(46, 204, 113);
            this.lblUserName.Location = new Point(20, 55);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new Size(150, 21);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "👤 Kullanıcı Adı";
            // 
            // groupTheme
            // 
            this.groupTheme.Controls.Add(this.rbLightTheme);
            this.groupTheme.Controls.Add(this.rbDarkTheme);
            this.groupTheme.Controls.Add(this.rbSystemTheme);
            this.groupTheme.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupTheme.ForeColor = Color.FromArgb(52, 73, 94);
            this.groupTheme.Location = new Point(20, 90);
            this.groupTheme.Name = "groupTheme";
            this.groupTheme.Size = new Size(200, 120);
            this.groupTheme.TabIndex = 2;
            this.groupTheme.TabStop = false;
            this.groupTheme.Text = "🎨 Tema";
            // 
            // rbLightTheme
            // 
            this.rbLightTheme.AutoSize = true;
            this.rbLightTheme.Checked = true;
            this.rbLightTheme.Font = new Font("Segoe UI", 10F);
            this.rbLightTheme.Location = new Point(15, 30);
            this.rbLightTheme.Name = "rbLightTheme";
            this.rbLightTheme.Size = new Size(95, 23);
            this.rbLightTheme.TabIndex = 0;
            this.rbLightTheme.TabStop = true;
            this.rbLightTheme.Text = "☀️ Açık Tema";
            this.rbLightTheme.UseVisualStyleBackColor = true;
            this.rbLightTheme.CheckedChanged += rbTheme_CheckedChanged;
            // 
            // rbDarkTheme
            // 
            this.rbDarkTheme.AutoSize = true;
            this.rbDarkTheme.Font = new Font("Segoe UI", 10F);
            this.rbDarkTheme.Location = new Point(15, 60);
            this.rbDarkTheme.Name = "rbDarkTheme";
            this.rbDarkTheme.Size = new Size(105, 23);
            this.rbDarkTheme.TabIndex = 1;
            this.rbDarkTheme.Text = "🌙 Koyu Tema";
            this.rbDarkTheme.UseVisualStyleBackColor = true;
            this.rbDarkTheme.CheckedChanged += rbTheme_CheckedChanged;
            // 
            // rbSystemTheme
            // 
            this.rbSystemTheme.AutoSize = true;
            this.rbSystemTheme.Font = new Font("Segoe UI", 10F);
            this.rbSystemTheme.Location = new Point(15, 90);
            this.rbSystemTheme.Name = "rbSystemTheme";
            this.rbSystemTheme.Size = new Size(108, 23);
            this.rbSystemTheme.TabIndex = 2;
            this.rbSystemTheme.Text = "🖥️ Sistem Ayarı";
            this.rbSystemTheme.UseVisualStyleBackColor = true;
            this.rbSystemTheme.CheckedChanged += rbTheme_CheckedChanged;
            // 
            // groupNotifications
            // 
            this.groupNotifications.Controls.Add(this.chkNotifications);
            this.groupNotifications.Controls.Add(this.lblReminderHours);
            this.groupNotifications.Controls.Add(this.numReminderHours);
            this.groupNotifications.Controls.Add(this.lblHours);
            this.groupNotifications.Controls.Add(this.btnTestNotification);
            this.groupNotifications.Controls.Add(this.lblLastReminder);
            this.groupNotifications.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupNotifications.ForeColor = Color.FromArgb(52, 73, 94);
            this.groupNotifications.Location = new Point(240, 90);
            this.groupNotifications.Name = "groupNotifications";
            this.groupNotifications.Size = new Size(240, 160);
            this.groupNotifications.TabIndex = 3;
            this.groupNotifications.TabStop = false;
            this.groupNotifications.Text = "📱 Bildirimler";
            // 
            // chkNotifications
            // 
            this.chkNotifications.AutoSize = true;
            this.chkNotifications.Checked = true;
            this.chkNotifications.CheckState = CheckState.Checked;
            this.chkNotifications.Font = new Font("Segoe UI", 10F);
            this.chkNotifications.Location = new Point(15, 30);
            this.chkNotifications.Name = "chkNotifications";
            this.chkNotifications.Size = new Size(130, 23);
            this.chkNotifications.TabIndex = 0;
            this.chkNotifications.Text = "Bildirimleri Aktif Et";
            this.chkNotifications.UseVisualStyleBackColor = true;
            this.chkNotifications.CheckedChanged += chkNotifications_CheckedChanged;
            // 
            // lblReminderHours
            // 
            this.lblReminderHours.AutoSize = true;
            this.lblReminderHours.Font = new Font("Segoe UI", 9F);
            this.lblReminderHours.Location = new Point(15, 60);
            this.lblReminderHours.Name = "lblReminderHours";
            this.lblReminderHours.Size = new Size(95, 15);
            this.lblReminderHours.TabIndex = 1;
            this.lblReminderHours.Text = "Hatırlatma Sıklığı:";
            // 
            // numReminderHours
            // 
            this.numReminderHours.Font = new Font("Segoe UI", 10F);
            this.numReminderHours.Location = new Point(15, 80);
            this.numReminderHours.Maximum = new decimal(new int[] { 168, 0, 0, 0 });
            this.numReminderHours.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numReminderHours.Name = "numReminderHours";
            this.numReminderHours.Size = new Size(60, 25);
            this.numReminderHours.TabIndex = 2;
            this.numReminderHours.Value = new decimal(new int[] { 24, 0, 0, 0 });
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new Font("Segoe UI", 9F);
            this.lblHours.Location = new Point(85, 85);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new Size(32, 15);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "saat";
            // 
            // btnTestNotification
            // 
            this.btnTestNotification.BackColor = Color.FromArgb(52, 152, 219);
            this.btnTestNotification.FlatAppearance.BorderSize = 0;
            this.btnTestNotification.FlatStyle = FlatStyle.Flat;
            this.btnTestNotification.Font = new Font("Segoe UI", 9F);
            this.btnTestNotification.ForeColor = Color.White;
            this.btnTestNotification.Location = new Point(140, 78);
            this.btnTestNotification.Name = "btnTestNotification";
            this.btnTestNotification.Size = new Size(80, 28);
            this.btnTestNotification.TabIndex = 4;
            this.btnTestNotification.Text = "Test Et";
            this.btnTestNotification.UseVisualStyleBackColor = false;
            this.btnTestNotification.Click += btnTestNotification_Click;
            // 
            // lblLastReminder
            // 
            this.lblLastReminder.Font = new Font("Segoe UI", 8F);
            this.lblLastReminder.Location = new Point(15, 115);
            this.lblLastReminder.Name = "lblLastReminder";
            this.lblLastReminder.Size = new Size(200, 35);
            this.lblLastReminder.TabIndex = 5;
            this.lblLastReminder.Text = "Son hatırlatma: -";
            // 
            // groupPomodoro
            // 
            this.groupPomodoro.Controls.Add(this.chkPomodoroSound);
            this.groupPomodoro.Controls.Add(this.lblWorkMinutes);
            this.groupPomodoro.Controls.Add(this.numWorkMinutes);
            this.groupPomodoro.Controls.Add(this.lblBreakMinutes);
            this.groupPomodoro.Controls.Add(this.numBreakMinutes);
            this.groupPomodoro.Controls.Add(this.lblMinutes1);
            this.groupPomodoro.Controls.Add(this.lblMinutes2);
            this.groupPomodoro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupPomodoro.ForeColor = Color.FromArgb(52, 73, 94);
            this.groupPomodoro.Location = new Point(20, 230);
            this.groupPomodoro.Name = "groupPomodoro";
            this.groupPomodoro.Size = new Size(200, 140);
            this.groupPomodoro.TabIndex = 4;
            this.groupPomodoro.TabStop = false;
            this.groupPomodoro.Text = "🍅 Pomodoro";
            // 
            // chkPomodoroSound
            // 
            this.chkPomodoroSound.AutoSize = true;
            this.chkPomodoroSound.Checked = true;
            this.chkPomodoroSound.CheckState = CheckState.Checked;
            this.chkPomodoroSound.Font = new Font("Segoe UI", 10F);
            this.chkPomodoroSound.Location = new Point(15, 30);
            this.chkPomodoroSound.Name = "chkPomodoroSound";
            this.chkPomodoroSound.Size = new Size(108, 23);
            this.chkPomodoroSound.TabIndex = 0;
            this.chkPomodoroSound.Text = "🔊 Ses bildirimi";
            this.chkPomodoroSound.UseVisualStyleBackColor = true;
            // 
            // lblWorkMinutes
            // 
            this.lblWorkMinutes.AutoSize = true;
            this.lblWorkMinutes.Font = new Font("Segoe UI", 9F);
            this.lblWorkMinutes.Location = new Point(15, 65);
            this.lblWorkMinutes.Name = "lblWorkMinutes";
            this.lblWorkMinutes.Size = new Size(83, 15);
            this.lblWorkMinutes.TabIndex = 1;
            this.lblWorkMinutes.Text = "Çalışma süresi:";
            // 
            // numWorkMinutes
            // 
            this.numWorkMinutes.Font = new Font("Segoe UI", 10F);
            this.numWorkMinutes.Location = new Point(15, 85);
            this.numWorkMinutes.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            this.numWorkMinutes.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            this.numWorkMinutes.Name = "numWorkMinutes";
            this.numWorkMinutes.Size = new Size(60, 25);
            this.numWorkMinutes.TabIndex = 2;
            this.numWorkMinutes.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // lblBreakMinutes
            // 
            this.lblBreakMinutes.AutoSize = true;
            this.lblBreakMinutes.Font = new Font("Segoe UI", 9F);
            this.lblBreakMinutes.Location = new Point(100, 65);
            this.lblBreakMinutes.Name = "lblBreakMinutes";
            this.lblBreakMinutes.Size = new Size(71, 15);
            this.lblBreakMinutes.TabIndex = 3;
            this.lblBreakMinutes.Text = "Mola süresi:";
            // 
            // numBreakMinutes
            // 
            this.numBreakMinutes.Font = new Font("Segoe UI", 10F);
            this.numBreakMinutes.Location = new Point(100, 85);
            this.numBreakMinutes.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            this.numBreakMinutes.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            this.numBreakMinutes.Name = "numBreakMinutes";
            this.numBreakMinutes.Size = new Size(60, 25);
            this.numBreakMinutes.TabIndex = 4;
            this.numBreakMinutes.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblMinutes1
            // 
            this.lblMinutes1.AutoSize = true;
            this.lblMinutes1.Font = new Font("Segoe UI", 8F);
            this.lblMinutes1.Location = new Point(15, 115);
            this.lblMinutes1.Name = "lblMinutes1";
            this.lblMinutes1.Size = new Size(37, 13);
            this.lblMinutes1.TabIndex = 5;
            this.lblMinutes1.Text = "dakika";
            // 
            // lblMinutes2
            // 
            this.lblMinutes2.AutoSize = true;
            this.lblMinutes2.Font = new Font("Segoe UI", 8F);
            this.lblMinutes2.Location = new Point(100, 115);
            this.lblMinutes2.Name = "lblMinutes2";
            this.lblMinutes2.Size = new Size(37, 13);
            this.lblMinutes2.TabIndex = 6;
            this.lblMinutes2.Text = "dakika";
            // 
            // groupUserInfo
            // 
            this.groupUserInfo.Controls.Add(this.lblEmail);
            this.groupUserInfo.Controls.Add(this.lblMemberSince);
            this.groupUserInfo.Controls.Add(this.btnExportData);
            this.groupUserInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupUserInfo.ForeColor = Color.FromArgb(52, 73, 94);
            this.groupUserInfo.Location = new Point(240, 270);
            this.groupUserInfo.Name = "groupUserInfo";
            this.groupUserInfo.Size = new Size(240, 100);
            this.groupUserInfo.TabIndex = 5;
            this.groupUserInfo.TabStop = false;
            this.groupUserInfo.Text = "👤 Kullanıcı Bilgileri";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new Font("Segoe UI", 9F);
            this.lblEmail.Location = new Point(15, 25);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(62, 15);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-posta: -";
            // 
            // lblMemberSince
            // 
            this.lblMemberSince.AutoSize = true;
            this.lblMemberSince.Font = new Font("Segoe UI", 9F);
            this.lblMemberSince.Location = new Point(15, 45);
            this.lblMemberSince.Name = "lblMemberSince";
            this.lblMemberSince.Size = new Size(56, 15);
            this.lblMemberSince.TabIndex = 1;
            this.lblMemberSince.Text = "Üyelik: -";
            // 
            // btnExportData
            // 
            this.btnExportData.BackColor = Color.FromArgb(155, 89, 182);
            this.btnExportData.FlatAppearance.BorderSize = 0;
            this.btnExportData.FlatStyle = FlatStyle.Flat;
            this.btnExportData.Font = new Font("Segoe UI", 9F);
            this.btnExportData.ForeColor = Color.White;
            this.btnExportData.Location = new Point(15, 70);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new Size(100, 25);
            this.btnExportData.TabIndex = 2;
            this.btnExportData.Text = "📤 Veri Dışa Aktar";
            this.btnExportData.UseVisualStyleBackColor = false;
            this.btnExportData.Click += btnExportData_Click;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = Color.FromArgb(46, 204, 113);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.Location = new Point(280, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(100, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "💾 Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new Font("Segoe UI", 11F);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.Location = new Point(390, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(90, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "❌ İptal";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += btnCancel_Click;
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.BackColor = Color.FromArgb(230, 126, 34);
            this.btnResetSettings.FlatAppearance.BorderSize = 0;
            this.btnResetSettings.FlatStyle = FlatStyle.Flat;
            this.btnResetSettings.Font = new Font("Segoe UI", 10F);
            this.btnResetSettings.ForeColor = Color.White;
            this.btnResetSettings.Location = new Point(20, 390);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new Size(120, 40);
            this.btnResetSettings.TabIndex = 8;
            this.btnResetSettings.Text = "🔄 Varsayılana Dön";
            this.btnResetSettings.UseVisualStyleBackColor = false;
            this.btnResetSettings.Click += btnResetSettings_Click;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = Color.White;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.lblUserName);
            this.panelMain.Controls.Add(this.groupTheme);
            this.panelMain.Controls.Add(this.groupNotifications);
            this.panelMain.Controls.Add(this.groupPomodoro);
            this.panelMain.Controls.Add(this.groupUserInfo);
            this.panelMain.Controls.Add(this.btnSave);
            this.panelMain.Controls.Add(this.btnCancel);
            this.panelMain.Controls.Add(this.btnResetSettings);
            this.panelMain.Location = new Point(15, 15);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new Size(500, 450);
            this.panelMain.TabIndex = 9;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(530, 480);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Ayarlar";
            this.Load += SettingsForm_Load;
            this.groupTheme.ResumeLayout(false);
            this.groupTheme.PerformLayout();
            this.groupNotifications.ResumeLayout(false);
            this.groupNotifications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReminderHours)).EndInit();
            this.groupPomodoro.ResumeLayout(false);
            this.groupPomodoro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakMinutes)).EndInit();
            this.groupUserInfo.ResumeLayout(false);
            this.groupUserInfo.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }

        private Label lblTitle;
        private Label lblUserName;
        private GroupBox groupTheme;
        private RadioButton rbLightTheme;
        private RadioButton rbDarkTheme;
        private RadioButton rbSystemTheme;
        private GroupBox groupNotifications;
        private CheckBox chkNotifications;
        private Label lblReminderHours;
        private NumericUpDown numReminderHours;
        private Label lblHours;
        private Button btnTestNotification;
        private Label lblLastReminder;
        private GroupBox groupPomodoro;
        private CheckBox chkPomodoroSound;
        private Label lblWorkMinutes;
        private NumericUpDown numWorkMinutes;
        private Label lblBreakMinutes;
        private NumericUpDown numBreakMinutes;
        private Label lblMinutes1;
        private Label lblMinutes2;
        private GroupBox groupUserInfo;
        private Label lblEmail;
        private Label lblMemberSince;
        private Button btnExportData;
        private Button btnSave;
        private Button btnCancel;
        private Button btnResetSettings;
        private Panel panelMain;
    }
}