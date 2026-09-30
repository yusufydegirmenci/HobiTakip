using HobiTakip.Models;

namespace HobiTakip
{
    public partial class AchievementsForm : Form
    {
        private Database database;
        private User currentUser;
        private List<Achievement> allAchievements;
        private List<UserAchievement> userAchievements;

        public AchievementsForm(User user, Database database)
        {
            InitializeComponent();
            this.currentUser = user;
            this.database = database;
            LoadAchievements();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = $"Başarılar - {currentUser.FullName}";
            lblUserName.Text = $"🏆 {currentUser.FullName}'in Başarıları";
            RefreshAchievementsList();
            LoadStatistics();
        }

        private void LoadAchievements()
        {
            allAchievements = database.GetAllAchievements();
            userAchievements = database.GetUserAchievements(currentUser.Id);
        }

        private void RefreshAchievementsList()
        {
            listAchievements.Items.Clear();
            var unlockedIds = userAchievements.Select(ua => ua.AchievementId).ToHashSet();

            foreach (var achievement in allAchievements)
            {
                var isUnlocked = unlockedIds.Contains(achievement.Id);
                var item = new ListViewItem(achievement.Icon);
                item.SubItems.Add(achievement.Name);
                item.SubItems.Add(achievement.Category);
                item.SubItems.Add(achievement.Description);
                item.SubItems.Add(isUnlocked ? "✅ Kazanıldı" : "🔒 Kilitli");

                if (isUnlocked)
                {
                    var userAchievement = userAchievements.First(ua => ua.AchievementId == achievement.Id);
                    item.SubItems.Add(userAchievement.UnlockedDate.ToString("dd.MM.yyyy"));
                    item.BackColor = Color.LightGreen;
                }
                else
                {
                    item.SubItems.Add("-");
                    item.BackColor = Color.LightGray;
                    item.ForeColor = Color.DarkGray;
                }

                item.Tag = achievement;
                listAchievements.Items.Add(item);
            }
        }

        private void LoadStatistics()
        {
            var unlockedCount = userAchievements.Count;
            var totalCount = allAchievements.Count;
            var percentage = totalCount > 0 ? (double)unlockedCount / totalCount * 100 : 0;

            lblTotalAchievements.Text = $"Toplam Rozet: {totalCount}";
            lblUnlockedAchievements.Text = $"Kazanılan: {unlockedCount}";
            lblPercentage.Text = $"Tamamlanma: %{percentage:F1}";

            progressBar.Maximum = totalCount;
            progressBar.Value = unlockedCount;

            // Kategori bazında istatistikler
            var categories = allAchievements.GroupBy(a => a.Category).ToList();
            var categoryStats = "";
            
            foreach (var category in categories)
            {
                var categoryTotal = category.Count();
                var categoryUnlocked = category.Count(a => userAchievements.Any(ua => ua.AchievementId == a.Id));
                categoryStats += $"{category.Key}: {categoryUnlocked}/{categoryTotal}\n";
            }

            lblCategoryStats.Text = categoryStats.TrimEnd();

            // Son kazanılan rozet
            if (userAchievements.Count > 0)
            {
                var lastAchievement = userAchievements.OrderByDescending(ua => ua.UnlockedDate).First();
                var achievement = allAchievements.First(a => a.Id == lastAchievement.AchievementId);
                lblLastAchievement.Text = $"Son Kazanılan: {achievement.Icon} {achievement.Name} ({lastAchievement.UnlockedDate:dd.MM.yyyy})";
            }
            else
            {
                lblLastAchievement.Text = "Henüz hiç rozet kazanılmadı";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Önce rozetleri kontrol et
            database.CheckAndUnlockAchievements(currentUser.Id);
            
            // Sonra yenile
            LoadAchievements();
            RefreshAchievementsList();
            LoadStatistics();

            MessageBox.Show("Rozetler kontrol edildi ve güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listAchievements_DoubleClick(object sender, EventArgs e)
        {
            if (listAchievements.SelectedItems.Count > 0)
            {
                var selectedAchievement = (Achievement)listAchievements.SelectedItems[0].Tag;
                var isUnlocked = userAchievements.Any(ua => ua.AchievementId == selectedAchievement.Id);

                string message = $"{selectedAchievement.Icon} {selectedAchievement.Name}\n\n" +
                               $"Kategori: {selectedAchievement.Category}\n" +
                               $"Açıklama: {selectedAchievement.Description}\n" +
                               $"Gereksinim: {GetRequirementText(selectedAchievement)}\n\n";

                if (isUnlocked)
                {
                    var userAchievement = userAchievements.First(ua => ua.AchievementId == selectedAchievement.Id);
                    message += $"✅ Kazanıldı: {userAchievement.UnlockedDate:dd.MM.yyyy HH:mm}";
                }
                else
                {
                    message += "🔒 Henüz kazanılmadı";
                }

                MessageBox.Show(message, "Rozet Detayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GetRequirementText(Achievement achievement)
        {
            return achievement.RequirementType switch
            {
                "FirstHobby" => "İlk hobinizi ekleyin",
                "FirstProgress" => "İlk ilerlemenizi kaydedin",
                "FirstGoal" => "İlk hedefinizi belirleyin",
                "TotalMinutes" => $"{achievement.RequiredValue / 60} saat hobi yapın",
                "HobbyCount" => $"{achievement.RequiredValue} farklı hobi ekleyin",
                "CompletedGoals" => $"{achievement.RequiredValue} hedef tamamlayın",
                "FiveStarRatings" => $"{achievement.RequiredValue} kez 5 yıldız verin",
                "Streak" => $"{achievement.RequiredValue} gün üst üste ilerleme kaydedin",
                "MonthlyMinutes" => $"Bir ayda {achievement.RequiredValue / 60} saat hobi yapın",
                _ => "Bilinmeyen gereksinim"
            };
        }

        private void AchievementsForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde tema uygula
            ThemeManager.ApplyTheme(this);
        }
    }
}