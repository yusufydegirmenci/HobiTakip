using HobiTakip.Models;

namespace HobiTakip
{
    public partial class MainForm : Form
    {
        private Database database;
        private User currentUser;
        private UserSettings userSettings;
        private List<Hobby> hobbies;

        public MainForm(User user, Database db)
        {
            InitializeComponent();
            currentUser = user;
            database = db;
            LoadUserSettings();
            LoadHobbies();
            InitializeNotifications();
        }

        private void LoadUserSettings()
        {
            userSettings = database.GetUserSettings(currentUser.Id);
            ThemeManager.CurrentTheme = userSettings.Theme == "System" 
                ? (IsSystemDarkMode() ? "Dark" : "Light") 
                : userSettings.Theme;
        }

        private bool IsSystemDarkMode()
        {
            try
            {
                var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");
                var value = key?.GetValue("AppsUseLightTheme");
                return value != null && (int)value == 0;
            }
            catch
            {
                return false;
            }
        }

        private void InitializeNotifications()
        {
            NotificationManager.Initialize(database, currentUser);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Hoş geldin, {currentUser.FullName}!";
            LoadHobbies();
            CheckForNewAchievements();
            ApplyTheme();
        }

        private void CheckForNewAchievements()
        {
            // Başarıları kontrol et
            database.CheckAndUnlockAchievements(currentUser.Id);
            
            // Yeni rozetleri kontrol et
            var userAchievements = database.GetUserAchievements(currentUser.Id);
            var newAchievements = userAchievements.Where(ua => ua.IsNew).ToList();
            
            foreach (var newAchievement in newAchievements)
            {
                var achievement = database.GetAllAchievements().FirstOrDefault(a => a.Id == newAchievement.AchievementId);
                if (achievement != null)
                {
                    NotificationManager.ShowAchievementNotification(achievement.Name, achievement.Icon);
                    
                    // Yeni rozet işaretini kaldır
                    // TODO: Database'e MarkAchievementAsRead metodu eklenebilir
                }
            }
        }

        private void ApplyTheme()
        {
            ThemeManager.ApplyTheme(this);
            
            // Buton renklerini güncelle
            btnAddHobby.BackColor = ThemeManager.GetButtonColor("success");
            btnAddProgress.BackColor = ThemeManager.GetButtonColor("primary");
            btnViewGoals.BackColor = ThemeManager.GetButtonColor("secondary");
            btnViewProgress.BackColor = ThemeManager.GetButtonColor("warning");
#if true // Chart kütüphanesi sorunu çıkarırsa false yapın
            btnCharts.BackColor = ThemeManager.GetButtonColor("primary");
#else
            btnCharts.BackColor = Color.Gray; // Devre dışı gösterimi
            btnCharts.Text = "📊 Grafikler (Yakında)";
#endif
            btnAchievements.BackColor = ThemeManager.GetButtonColor("warning");
            btnPomodoro.BackColor = Color.FromArgb(231, 76, 60); // Pomodoro kırmızısı
            btnSettings.BackColor = ThemeManager.GetButtonColor("secondary");
            btnLogout.BackColor = ThemeManager.GetButtonColor("danger");
        }

        private void LoadHobbies()
        {
            hobbies = database.GetUserHobbies(currentUser.Id);
            RefreshHobbyList();
        }

        private void RefreshHobbyList()
        {
            listHobbies.Items.Clear();
            
            foreach (var hobby in hobbies)
            {
                var item = new ListViewItem(hobby.Name);
                item.SubItems.Add(hobby.Category);
                item.SubItems.Add(hobby.DifficultyLevel);
                item.SubItems.Add($"{hobby.TotalTimeSpent / 60:F1} saat");
                item.SubItems.Add(hobby.IsActive ? "Aktif" : "Pasif");
                item.Tag = hobby;
                listHobbies.Items.Add(item);
            }

            lblHobbyCount.Text = $"Toplam {hobbies.Count} hobi";
            var activeCount = hobbies.Count(h => h.IsActive);
            lblActiveHobbies.Text = $"{activeCount} aktif hobi";
        }

        private void btnAddHobby_Click(object sender, EventArgs e)
        {
            var addHobbyForm = new AddHobbyForm(currentUser.Id, database);
            if (addHobbyForm.ShowDialog() == DialogResult.OK)
            {
                LoadHobbies();
            }
        }

        private void btnAddProgress_Click(object sender, EventArgs e)
        {
            if (listHobbies.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen önce bir hobi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedHobby = (Hobby)listHobbies.SelectedItems[0].Tag;
            var progressForm = new AddProgressForm(selectedHobby, database);
            if (progressForm.ShowDialog() == DialogResult.OK)
            {
                LoadHobbies();
            }
        }

        private void btnViewGoals_Click(object sender, EventArgs e)
        {
            if (listHobbies.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen önce bir hobi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedHobby = (Hobby)listHobbies.SelectedItems[0].Tag;
            var goalsForm = new GoalsForm(selectedHobby, database);
            goalsForm.ShowDialog();
        }

        private void btnViewProgress_Click(object sender, EventArgs e)
        {
            if (listHobbies.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen önce bir hobi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedHobby = (Hobby)listHobbies.SelectedItems[0].Tag;
            var progressForm = new ProgressViewForm(selectedHobby, database);
            progressForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Çıkış", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void listHobbies_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool hasSelection = listHobbies.SelectedItems.Count > 0;
            btnAddProgress.Enabled = hasSelection;
            btnViewGoals.Enabled = hasSelection;
            btnViewProgress.Enabled = hasSelection;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NotificationManager.StopReminderService();
            Application.Exit();
        }
        
        private void btnCharts_Click(object sender, EventArgs e)
        {
#if true // Chart kütüphanesi sorunu çıkarırsa false yapın
            var chartsForm = new ChartForm(currentUser, database);
            chartsForm.ShowDialog();
#else
            MessageBox.Show("Grafikler özelliği geçici olarak devre dışı bırakıldı.\n\nChart kütüphanesi kurulum sonrası aktif edilecek!", 
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif
        }
        
        private void btnAchievements_Click(object sender, EventArgs e)
        {
            var achievementsForm = new AchievementsForm(currentUser, database);
            achievementsForm.ShowDialog();
        }
        
        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            var pomodoroForm = new PomodoroTimerForm(currentUser, database);
            pomodoroForm.ShowDialog();
            
            // Pomodoro sonrası verileri yenile
            LoadHobbies();
            CheckForNewAchievements();
        }
        
        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm(currentUser, database);
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                // Ayarlar değiştiğinde formu yenile
                LoadUserSettings();
                ApplyTheme();
                
                // Bildirimleri yeniden başlat
                NotificationManager.StopReminderService();
                InitializeNotifications();
            }
        }
    }
}