using HobiTakip.Models;

namespace HobiTakip
{
    public partial class ProgressViewForm : Form
    {
        private Database database;
        private Hobby hobby;
        private List<Progress> progressList;

        public ProgressViewForm(Hobby hobby, Database database)
        {
            InitializeComponent();
            this.hobby = hobby;
            this.database = database;
            LoadProgressData();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = $"İlerleme Görüntüle - {hobby.Name}";
            lblHobbyName.Text = $"Hobi: {hobby.Name}";
            RefreshProgressList();
            LoadStatistics();
        }

        private void LoadProgressData()
        {
            progressList = database.GetHobbyProgress(hobby.Id);
        }

        private void RefreshProgressList()
        {
            listProgress.Items.Clear();

            foreach (var progress in progressList)
            {
                var item = new ListViewItem(progress.Date.ToString("dd.MM.yyyy"));
                item.SubItems.Add($"{progress.TimeSpent} dk");
                item.SubItems.Add($"{progress.Value} {progress.Unit}");
                item.SubItems.Add(GetRatingText(progress.Rating));
                item.SubItems.Add(string.IsNullOrEmpty(progress.Notes) ? "-" : progress.Notes);
                
                // Renk kodlaması rating'e göre
                if (progress.Rating >= 4)
                {
                    item.BackColor = Color.LightGreen;
                }
                else if (progress.Rating <= 2)
                {
                    item.BackColor = Color.LightCoral;
                }

                item.Tag = progress;
                listProgress.Items.Add(item);
            }
        }

        private string GetRatingText(int rating)
        {
            return rating switch
            {
                1 => "⭐ Çok Kötü",
                2 => "⭐⭐ Kötü",
                3 => "⭐⭐⭐ Orta",
                4 => "⭐⭐⭐⭐ İyi",
                5 => "⭐⭐⭐⭐⭐ Mükemmel",
                _ => "Belirsiz"
            };
        }

        private void LoadStatistics()
        {
            if (progressList.Count == 0)
            {
                lblTotalTime.Text = "Toplam Süre: 0 dakika";
                lblAvgRating.Text = "Ortalama Değerlendirme: -";
                lblTotalSessions.Text = "Toplam Oturum: 0";
                lblLastActivity.Text = "Son Aktivite: -";
                return;
            }

            var totalMinutes = progressList.Sum(p => p.TimeSpent);
            var totalHours = totalMinutes / 60.0;
            lblTotalTime.Text = $"Toplam Süre: {totalHours:F1} saat ({totalMinutes} dk)";

            var avgRating = progressList.Average(p => p.Rating);
            lblAvgRating.Text = $"Ortalama Değerlendirme: {avgRating:F1}/5 ⭐";

            lblTotalSessions.Text = $"Toplam Oturum: {progressList.Count}";

            var lastActivity = progressList.OrderByDescending(p => p.Date).First();
            lblLastActivity.Text = $"Son Aktivite: {lastActivity.Date:dd.MM.yyyy}";

            // Aylık istatistikler
            var thisMonth = progressList.Where(p => p.Date.Month == DateTime.Now.Month && p.Date.Year == DateTime.Now.Year);
            var monthlyMinutes = thisMonth.Sum(p => p.TimeSpent);
            var monthlyHours = monthlyMinutes / 60.0;
            lblMonthlyStats.Text = $"Bu Ay: {monthlyHours:F1} saat ({thisMonth.Count()} oturum)";

            // Haftalık istatistikler
            var thisWeek = progressList.Where(p => 
                p.Date >= DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek) &&
                p.Date < DateTime.Now.AddDays(7-(int)DateTime.Now.DayOfWeek));
            var weeklyMinutes = thisWeek.Sum(p => p.TimeSpent);
            var weeklyHours = weeklyMinutes / 60.0;
            lblWeeklyStats.Text = $"Bu Hafta: {weeklyHours:F1} saat ({thisWeek.Count()} oturum)";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listProgress_DoubleClick(object sender, EventArgs e)
        {
            if (listProgress.SelectedItems.Count > 0)
            {
                var selectedProgress = (Progress)listProgress.SelectedItems[0].Tag;
                var detailMessage = $"Tarih: {selectedProgress.Date:dd.MM.yyyy HH:mm}\n" +
                                  $"Süre: {selectedProgress.TimeSpent} dakika\n" +
                                  $"Yapılan İş: {selectedProgress.Value} {selectedProgress.Unit}\n" +
                                  $"Değerlendirme: {GetRatingText(selectedProgress.Rating)}\n" +
                                  $"Notlar: {(string.IsNullOrEmpty(selectedProgress.Notes) ? "Not yok" : selectedProgress.Notes)}";
                
                MessageBox.Show(detailMessage, "İlerleme Detayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProgressData();
            RefreshProgressList();
            LoadStatistics();
            MessageBox.Show("İlerleme verileri yenilendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProgressViewForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde verileri yenile
            RefreshProgressList();
        }
    }
}