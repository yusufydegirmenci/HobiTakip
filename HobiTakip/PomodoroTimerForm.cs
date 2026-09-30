using HobiTakip.Models;
using System.Media;
using System.Linq;

namespace HobiTakip
{
    public partial class PomodoroTimerForm : Form
    {
        private Database database;
        private User currentUser;
        private UserSettings settings;
        private List<Hobby> hobbies;
        private System.Windows.Forms.Timer pomodoroTimer;
        private int totalSeconds;
        private int currentSeconds;
        private bool isWorkSession = true;
        private bool isRunning = false;
        private DateTime sessionStartTime;
        private Hobby? selectedHobby = null;

        public PomodoroTimerForm(User user, Database database)
        {
            InitializeComponent();
            this.currentUser = user;
            this.database = database;
            LoadSettings();
            LoadHobbies();
            SetupTimer();
            SetupForm();
        }

        private void LoadSettings()
        {
            settings = database.GetUserSettings(currentUser.Id);
        }

        private void LoadHobbies()
        {
            hobbies = database.GetUserHobbies(currentUser.Id);
        }

        private void SetupTimer()
        {
            pomodoroTimer = new System.Windows.Forms.Timer();
            pomodoroTimer.Interval = 1000; // 1 saniye
            pomodoroTimer.Tick += PomodoroTimer_Tick;
        }

        private void SetupForm()
        {
            this.Text = "🍅 Pomodoro Timer";
            lblUserName.Text = $"Merhaba, {currentUser.FullName}!";
            
            // Hobi seçeneklerini yükle
            cmbHobby.Items.Add("Hobi Seçiniz");
            foreach (var hobby in hobbies)
            {
                cmbHobby.Items.Add(hobby.Name);
            }
            cmbHobby.SelectedIndex = 0;

            // Ayarları forma yansıt
            numWorkMinutes.Value = settings.PomodoroWorkMinutes;
            numBreakMinutes.Value = settings.PomodoroBreakMinutes;
            chkSound.Checked = settings.PomodoroSoundEnabled;

            ResetTimer();
            UpdateDisplay();
        }

        private void ResetTimer()
        {
            isWorkSession = true;
            totalSeconds = settings.PomodoroWorkMinutes * 60;
            currentSeconds = totalSeconds;
            isRunning = false;
            pomodoroTimer.Stop();
            
            btnStart.Text = "▶️ Başla";
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnReset.Enabled = true;

            UpdateSessionInfo();
        }

        private void UpdateDisplay()
        {
            var minutes = currentSeconds / 60;
            var seconds = currentSeconds % 60;
            lblTimer.Text = $"{minutes:D2}:{seconds:D2}";

            // Progress bar güncelle
            var progress = (double)(totalSeconds - currentSeconds) / totalSeconds * 100;
            progressBar.Value = Math.Min((int)progress, 100);

            // Başlık güncelle
            this.Text = $"🍅 Pomodoro - {lblTimer.Text} ({(isWorkSession ? "Çalışma" : "Mola")})";
        }

        private void UpdateSessionInfo()
        {
            if (isWorkSession)
            {
                lblSessionType.Text = "🍅 ÇALIŞMA SEANSİ";
                lblSessionType.ForeColor = Color.FromArgb(231, 76, 60);
                lblSessionInfo.Text = $"Odaklanma zamanı! {settings.PomodoroWorkMinutes} dakika boyunca {(selectedHobby?.Name ?? "seçili hobinizle")} ilgilenin.";
                this.BackColor = Color.FromArgb(253, 245, 243);
            }
            else
            {
                lblSessionType.Text = "☕ MOLA SEANSİ";
                lblSessionType.ForeColor = Color.FromArgb(46, 204, 113);
                lblSessionInfo.Text = $"Mola zamanı! {settings.PomodoroBreakMinutes} dakika dinlenin ve gevşeyin.";
                this.BackColor = Color.FromArgb(245, 253, 247);
            }
        }

        private void PomodoroTimer_Tick(object sender, EventArgs e)
        {
            currentSeconds--;
            UpdateDisplay();

            if (currentSeconds <= 0)
            {
                // Seans tamamlandı
                CompleteSession();
            }
        }

        private void CompleteSession()
        {
            pomodoroTimer.Stop();
            isRunning = false;

            // Ses çal (varsa)
            if (settings.PomodoroSoundEnabled)
            {
                SystemSounds.Asterisk.Play();
            }

            if (isWorkSession)
            {
                // Çalışma seansı tamamlandı - mola başlat
                SaveWorkSession();
                StartBreakSession();
            }
            else
            {
                // Mola tamamlandı - yeni çalışma seansı başlat
                StartWorkSession();
            }
        }

        private void SaveWorkSession()
        {
            if (selectedHobby != null)
            {
                var progress = new Progress
                {
                    HobbyId = selectedHobby.Id,
                    Date = sessionStartTime,
                    TimeSpent = settings.PomodoroWorkMinutes,
                    Value = 1,
                    Unit = "pomodoro",
                    Notes = $"Pomodoro çalışma seansı - {settings.PomodoroWorkMinutes} dakika",
                    Rating = 4 // Varsayılan iyi rating
                };

                database.AddProgress(progress);
                
                // Başarıları kontrol et
                database.CheckAndUnlockAchievements(currentUser.Id);

                lblLastSession.Text = $"✅ Son seans: {selectedHobby.Name} - {settings.PomodoroWorkMinutes}dk ({DateTime.Now:HH:mm})";
                lblTotalSessions.Text = $"Bugün: {GetTodaySessionCount() + 1} seans";
            }
        }

        private void StartBreakSession()
        {
            isWorkSession = false;
            totalSeconds = settings.PomodoroBreakMinutes * 60;
            currentSeconds = totalSeconds;
            
            UpdateSessionInfo();
            UpdateDisplay();

            var result = MessageBox.Show($"🎉 Çalışma seansı tamamlandı!\n\n" +
                                       $"Şimdi {settings.PomodoroBreakMinutes} dakika mola yapın.\n\n" +
                                       $"Molayı otomatik başlatmak istiyor musunuz?", 
                                       "Seans Tamamlandı", 
                                       MessageBoxButtons.YesNo, 
                                       MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                StartTimer();
            }
            else
            {
                btnStart.Text = "▶️ Mola Başlat";
                btnStart.Enabled = true;
            }
        }

        private void StartWorkSession()
        {
            isWorkSession = true;
            totalSeconds = settings.PomodoroWorkMinutes * 60;
            currentSeconds = totalSeconds;
            
            UpdateSessionInfo();
            UpdateDisplay();

            MessageBox.Show($"☕ Mola tamamlandı!\n\n" +
                          $"Şimdi yeni bir {settings.PomodoroWorkMinutes} dakikalık çalışma seansına hazırlanın.", 
                          "Mola Bitti", 
                          MessageBoxButtons.OK, 
                          MessageBoxIcon.Information);

            btnStart.Text = "▶️ Çalışma Başlat";
            btnStart.Enabled = true;
        }

        private void StartTimer()
        {
            if (isWorkSession)
            {
                if (cmbHobby.SelectedIndex == 0)
                {
                    MessageBox.Show("Lütfen önce bir hobi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                selectedHobby = hobbies[cmbHobby.SelectedIndex - 1];
                sessionStartTime = DateTime.Now;
            }

            isRunning = true;
            pomodoroTimer.Start();

            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnReset.Enabled = true;
            cmbHobby.Enabled = !isWorkSession; // Çalışma sırasında hobi değiştirilemesin
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                pomodoroTimer.Stop();
                isRunning = false;
                btnStart.Enabled = true;
                btnPause.Enabled = false;
                btnStart.Text = "▶️ Devam Et";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Timer'ı sıfırlamak istediğinizden emin misiniz?", 
                                       "Sıfırla", 
                                       MessageBoxButtons.YesNo, 
                                       MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                ResetTimer();
                cmbHobby.Enabled = true;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm(currentUser, database);
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                LoadSettings();
                numWorkMinutes.Value = settings.PomodoroWorkMinutes;
                numBreakMinutes.Value = settings.PomodoroBreakMinutes;
                chkSound.Checked = settings.PomodoroSoundEnabled;
                
                if (!isRunning)
                {
                    ResetTimer();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                var result = MessageBox.Show("Timer çalışıyor. Kapatmak istediğinizden emin misiniz?", 
                                           "Uyarı", 
                                           MessageBoxButtons.YesNo, 
                                           MessageBoxIcon.Warning);
                
                if (result == DialogResult.No)
                    return;
            }

            this.Close();
        }

        private void numWorkMinutes_ValueChanged(object sender, EventArgs e)
        {
            if (!isRunning && isWorkSession)
            {
                totalSeconds = (int)numWorkMinutes.Value * 60;
                currentSeconds = totalSeconds;
                UpdateDisplay();
            }
        }

        private void numBreakMinutes_ValueChanged(object sender, EventArgs e)
        {
            if (!isRunning && !isWorkSession)
            {
                totalSeconds = (int)numBreakMinutes.Value * 60;
                currentSeconds = totalSeconds;
                UpdateDisplay();
            }
        }

        private int GetTodaySessionCount()
        {
            if (selectedHobby == null) return 0;
            
            var todayProgress = database.GetHobbyProgress(selectedHobby.Id)
                                      .Where(p => p.Date.Date == DateTime.Today && p.Unit == "pomodoro")
                                      .Sum(p => p.Value);
            return todayProgress;
        }

        private void PomodoroTimerForm_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this);
            LoadTodayStats();
        }

        private void LoadTodayStats()
        {
            var totalTodaySessions = 0;
            foreach (var hobby in hobbies)
            {
                var todaySessions = database.GetHobbyProgress(hobby.Id)
                                          .Where(p => p.Date.Date == DateTime.Today && p.Unit == "pomodoro")
                                          .Sum(p => p.Value);
                totalTodaySessions += todaySessions;
            }

            lblTotalSessions.Text = $"Bugün: {totalTodaySessions} seans";
        }

        private void PomodoroTimerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pomodoroTimer?.Stop();
            pomodoroTimer?.Dispose();
        }
    }
}