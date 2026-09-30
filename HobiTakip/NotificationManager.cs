using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using HobiTakip.Models;
using System.Linq;

namespace HobiTakip
{
    public static class NotificationManager
    {
        private static System.Windows.Forms.Timer? reminderTimer;
        private static Database? database;
        private static User? currentUser;

        public static void Initialize(Database db, User user)
        {
            database = db;
            currentUser = user;
            StartReminderService();
        }

        public static void StartReminderService()
        {
            if (database == null || currentUser == null) return;

            reminderTimer?.Stop();
            reminderTimer?.Dispose();

            reminderTimer = new System.Windows.Forms.Timer();
            reminderTimer.Interval = 60000; // Her dakika kontrol et
            reminderTimer.Tick += CheckReminders;
            reminderTimer.Start();
        }

        public static void StopReminderService()
        {
            reminderTimer?.Stop();
            reminderTimer?.Dispose();
            reminderTimer = null;
        }

        private static void CheckReminders(object? sender, EventArgs e)
        {
            if (database == null || currentUser == null) return;

            try
            {
                var settings = database.GetUserSettings(currentUser.Id);
                
                if (!settings.NotificationsEnabled) return;

                var timeSinceLastReminder = DateTime.Now - settings.LastReminderSent;
                var reminderIntervalHours = settings.ReminderFrequency;

                if (timeSinceLastReminder.TotalHours >= reminderIntervalHours)
                {
                    SendHobbyReminder();
                    UpdateLastReminderTime();
                }
            }
            catch (Exception ex)
            {
                // Log error but don't crash the app
                Console.WriteLine($"Reminder check error: {ex.Message}");
            }
        }

        private static void SendHobbyReminder()
        {
            if (database == null || currentUser == null) return;

            var hobbies = database.GetUserHobbies(currentUser.Id);
            var activeHobbies = hobbies.Where(h => h.IsActive).ToList();

            if (activeHobbies.Count == 0)
            {
                ShowNotification(
                    "Hobi Takip Hatırlatması",
                    "Henüz aktif hobiniz yok. Yeni bir hobi eklemeyi düşünün! 🎯",
                    8000);
                return;
            }

            // Random bir hobi seç
            var random = new Random();
            var selectedHobby = activeHobbies[random.Next(activeHobbies.Count)];

            // Son aktivite kontrolü
            var recentProgress = database.GetHobbyProgress(selectedHobby.Id)
                                        .Where(p => p.Date >= DateTime.Now.AddDays(-7))
                                        .OrderByDescending(p => p.Date)
                                        .FirstOrDefault();

            string message;
            if (recentProgress != null)
            {
                var daysSinceActivity = (DateTime.Now - recentProgress.Date).Days;
                message = daysSinceActivity switch
                {
                    0 => $"Bugün {selectedHobby.Name} ile ilgilendiniz! Devam edin! 🔥",
                    1 => $"Dün {selectedHobby.Name} ile ilgilenmiştiniz. Bugün de devam etmeye ne dersiniz? 💪",
                    _ => $"{selectedHobby.Name} hobiniz {daysSinceActivity} gündür bekliyor. Biraz zaman ayırmaya ne dersiniz? ⏰"
                };
            }
            else
            {
                message = $"{selectedHobby.Name} hobinizle ilgili bir süredir ilerleme kaydedilmedi. Başlamak için harika bir zaman! 🚀";
            }

            ShowNotification("Hobi Hatırlatması 🎯", message, 10000);
        }

        public static void ShowNotification(string title, string message, int duration = 5000)
        {
            try
            {
                // Windows bildirim sistemi kullan
                var notification = new NotificationWindow(title, message, duration);
                notification.Show();
            }
            catch (Exception ex)
            {
                // Fallback: MessageBox kullan
                MessageBox.Show($"{title}\n\n{message}", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static void UpdateLastReminderTime()
        {
            if (database == null || currentUser == null) return;

            try
            {
                var settings = database.GetUserSettings(currentUser.Id);
                settings.LastReminderSent = DateTime.Now;
                database.UpdateUserSettings(settings);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating reminder time: {ex.Message}");
            }
        }

        public static void ShowAchievementNotification(string achievementName, string achievementIcon)
        {
            ShowNotification(
                "🏆 Yeni Başarı Kazandınız!",
                $"{achievementIcon} {achievementName}\n\nTebrikler! Yeni bir rozet kazandınız!",
                8000);

            // Başarı sesi çal
            try
            {
                SystemSounds.Exclamation.Play();
            }
            catch { }
        }

        public static void ShowGoalCompletedNotification(string goalTitle, string hobbyName)
        {
            ShowNotification(
                "🎯 Hedef Tamamlandı!",
                $"'{goalTitle}' hedefiniz tamamlandı!\n\nHobi: {hobbyName}\n\nTebrikler! 🎉",
                8000);

            try
            {
                SystemSounds.Asterisk.Play();
            }
            catch { }
        }
    }

    // Özel bildirim penceresi
    public partial class NotificationWindow : Form
    {
        private System.Windows.Forms.Timer fadeTimer;
        private int duration;
        private double opacity = 1.0;

        public NotificationWindow(string title, string message, int duration = 5000)
        {
            InitializeComponent();
            this.duration = duration;
            
            lblTitle.Text = title;
            lblMessage.Text = message;
            
            SetupWindow();
            SetupTimer();
        }

        private void SetupWindow()
        {
            // Pencere ayarları
            this.Size = new Size(350, 120);
            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.ShowInTaskbar = false;
            
            // Ekranın sağ alt köşesine yerleştir
            var workingArea = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(
                workingArea.Right - this.Width - 10,
                workingArea.Bottom - this.Height - 10
            );

            // Tema uygula
            ThemeManager.ApplyTheme(this);
        }

        private void SetupTimer()
        {
            fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = 50;
            fadeTimer.Tick += FadeTimer_Tick;
            
            // Belirtilen süre sonra fade out başlat
            var delayTimer = new System.Windows.Forms.Timer();
            delayTimer.Interval = duration;
            delayTimer.Tick += (s, e) =>
            {
                delayTimer.Stop();
                delayTimer.Dispose();
                if (!IsDisposed)
                {
                    fadeTimer.Start();
                }
            };
            delayTimer.Start();
        }

        private void FadeTimer_Tick(object? sender, EventArgs e)
        {
            opacity -= 0.05;
            if (opacity <= 0)
            {
                fadeTimer.Stop();
                this.Close();
            }
            else
            {
                this.Opacity = opacity;
            }
        }

        private void NotificationWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            fadeTimer?.Stop();
            fadeTimer?.Dispose();
            base.OnFormClosed(e);
        }
    }
}