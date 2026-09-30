using HobiTakip.Models;

namespace HobiTakip
{
    public partial class SettingsForm : Form
    {
        private Database database;
        private User currentUser;
        private UserSettings settings;

        public SettingsForm(User user, Database database)
        {
            InitializeComponent();
            this.currentUser = user;
            this.database = database;
            LoadSettings();
            SetupForm();
        }

        private void LoadSettings()
        {
            settings = database.GetUserSettings(currentUser.Id);
        }

        private void SetupForm()
        {
            this.Text = $"Ayarlar - {currentUser.FullName}";
            lblUserName.Text = $"👤 {currentUser.FullName}";

            // Tema ayarları
            switch (settings.Theme)
            {
                case "Light":
                    rbLightTheme.Checked = true;
                    break;
                case "Dark":
                    rbDarkTheme.Checked = true;
                    break;
                case "System":
                    rbSystemTheme.Checked = true;
                    break;
            }

            // Bildirim ayarları
            chkNotifications.Checked = settings.NotificationsEnabled;
            numReminderHours.Value = settings.ReminderFrequency;

            // Pomodoro ayarları
            chkPomodoroSound.Checked = settings.PomodoroSoundEnabled;
            numWorkMinutes.Value = settings.PomodoroWorkMinutes;
            numBreakMinutes.Value = settings.PomodoroBreakMinutes;

            // Son bildirim tarihi
            if (settings.LastReminderSent != DateTime.MinValue)
            {
                lblLastReminder.Text = $"Son hatırlatma: {settings.LastReminderSent:dd.MM.yyyy HH:mm}";
            }
            else
            {
                lblLastReminder.Text = "Henüz hatırlatma gönderilmedi";
            }

            // Kullanıcı bilgileri
            lblEmail.Text = $"E-posta: {currentUser.Email}";
            lblMemberSince.Text = $"Üyelik: {currentUser.CreatedDate:dd.MM.yyyy}";

            // Tema önizlemesi
            ApplyThemePreview();
        }

        private void ApplyThemePreview()
        {
            string selectedTheme = GetSelectedTheme();
            ThemeManager.ApplyTheme(this, selectedTheme);
        }

        private string GetSelectedTheme()
        {
            if (rbDarkTheme.Checked) return "Dark";
            if (rbSystemTheme.Checked) return "System";
            return "Light";
        }

        private void rbTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                ApplyThemePreview();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Ayarları güncelle
                settings.Theme = GetSelectedTheme();
                settings.NotificationsEnabled = chkNotifications.Checked;
                settings.ReminderFrequency = (int)numReminderHours.Value;
                settings.PomodoroSoundEnabled = chkPomodoroSound.Checked;
                settings.PomodoroWorkMinutes = (int)numWorkMinutes.Value;
                settings.PomodoroBreakMinutes = (int)numBreakMinutes.Value;

                database.UpdateUserSettings(settings);

                // Global tema ayarını güncelle
                ThemeManager.CurrentTheme = settings.Theme == "System" 
                    ? (IsSystemDarkMode() ? "Dark" : "Light") 
                    : settings.Theme;

                MessageBox.Show("Ayarlar başarıyla kaydedildi!", "Başarılı", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ayarlar kaydedilirken hata oluştu: {ex.Message}", "Hata", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnTestNotification_Click(object sender, EventArgs e)
        {
            try
            {
                NotificationManager.ShowNotification(
                    "Test Bildirimi", 
                    "Bu bir test bildirimidir. Bildirimler düzgün çalışıyor! 🎉",
                    5000);

                MessageBox.Show("Test bildirimi gönderildi!", "Bilgi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bildirim gönderilemedi: {ex.Message}", "Hata", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetSettings_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Tüm ayarları varsayılan değerlere sıfırlamak istediğinizden emin misiniz?", 
                "Ayarları Sıfırla", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Varsayılan ayarları yükle
                rbLightTheme.Checked = true;
                chkNotifications.Checked = true;
                numReminderHours.Value = 24;
                chkPomodoroSound.Checked = true;
                numWorkMinutes.Value = 25;
                numBreakMinutes.Value = 5;

                ApplyThemePreview();
                
                MessageBox.Show("Ayarlar varsayılan değerlere sıfırlandı. Kaydetmeyi unutmayın!", 
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            try
            {
                var saveDialog = new SaveFileDialog
                {
                    Filter = "JSON Dosyası (*.json)|*.json|Tüm Dosyalar (*.*)|*.*",
                    DefaultExt = "json",
                    FileName = $"HobiTakipVeri_{currentUser.Username}_{DateTime.Now:yyyyMMdd}.json"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    DataExporter.ExportUserData(currentUser.Id, database, saveDialog.FileName);
                    MessageBox.Show($"Verileriniz başarıyla dışa aktarıldı!\n\nDosya: {saveDialog.FileName}", 
                        "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri dışa aktarımında hata: {ex.Message}", "Hata", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsSystemDarkMode()
        {
            // Windows 10/11 sistem teması kontrolü
            try
            {
                var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");
                var value = key?.GetValue("AppsUseLightTheme");
                return value != null && (int)value == 0;
            }
            catch
            {
                return false; // Varsayılan light theme
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde tema uygula
            ApplyThemePreview();
        }

        private void chkNotifications_CheckedChanged(object sender, EventArgs e)
        {
            numReminderHours.Enabled = chkNotifications.Checked;
            btnTestNotification.Enabled = chkNotifications.Checked;
        }
    }
}