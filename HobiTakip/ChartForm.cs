#if true // Chart kütüphanesi sorunu çıkarırsa false yapın
using HobiTakip.Models;
using System.Windows.Forms.DataVisualization.Charting;

namespace HobiTakip
{
    public partial class ChartForm : Form
    {
        private Database database;
        private User currentUser;
        private List<Hobby> hobbies;

        public ChartForm(User user, Database database)
        {
            InitializeComponent();
            this.currentUser = user;
            this.database = database;
            LoadData();
            SetupForm();
        }

        private void LoadData()
        {
            hobbies = database.GetUserHobbies(currentUser.Id);
        }

        private void SetupForm()
        {
            this.Text = $"Görsel Raporlar - {currentUser.FullName}";
            lblUserName.Text = $"📊 {currentUser.FullName}'in Hobi Raporları";

            // Combo box'a grafik türlerini ekle
            cmbChartType.Items.Add("Hobi Süre Dağılımı (Pasta)");
            cmbChartType.Items.Add("Aylık İlerleme Trendi");
            cmbChartType.Items.Add("Haftalık Aktivite");
            cmbChartType.Items.Add("Değerlendirme Dağılımı");
            cmbChartType.Items.Add("Hedef Tamamlanma Oranları");
            cmbChartType.Items.Add("Kategori Bazında Zaman");
            
            cmbChartType.SelectedIndex = 0;
            
            // İlk grafiği göster
            ShowChart();
        }

        private void ShowChart()
        {
            if (hobbies.Count == 0)
            {
                ShowNoDataMessage();
                return;
            }

            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.ChartAreas.Add(new ChartArea("MainArea"));

            switch (cmbChartType.SelectedIndex)
            {
                case 0:
                    ShowHobbyTimeDistribution();
                    break;
                case 1:
                    ShowMonthlyProgressTrend();
                    break;
                case 2:
                    ShowWeeklyActivity();
                    break;
                case 3:
                    ShowRatingDistribution();
                    break;
                case 4:
                    ShowGoalCompletionRates();
                    break;
                case 5:
                    ShowCategoryTimeDistribution();
                    break;
            }

            // Tema uygula
            ApplyChartTheme();
        }

        private void ShowHobbyTimeDistribution()
        {
            var series = new Series("Hobi Süreleri")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                LabelFormat = "#.#'%'"
            };

            var totalMinutes = hobbies.Sum(h => h.TotalTimeSpent);
            if (totalMinutes == 0)
            {
                ShowNoDataMessage();
                return;
            }

            foreach (var hobby in hobbies.Where(h => h.TotalTimeSpent > 0))
            {
                var percentage = (double)hobby.TotalTimeSpent / totalMinutes * 100;
                var point = series.Points.Add(percentage);
                point.LegendText = $"{hobby.Name} ({hobby.TotalTimeSpent / 60.0:F1} saat)";
                point.Label = $"{percentage:F1}%";
            }

            chart.Series.Add(series);
            chart.Titles.Clear();
            chart.Titles.Add("Hobi Süre Dağılımı");
        }

        private void ShowMonthlyProgressTrend()
        {
            var series = new Series("Aylık İlerleme")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8
            };

            var last6Months = new List<DateTime>();
            for (int i = 5; i >= 0; i--)
            {
                last6Months.Add(DateTime.Now.AddMonths(-i));
            }

            foreach (var month in last6Months)
            {
                var monthlyMinutes = 0;
                foreach (var hobby in hobbies)
                {
                    var progressList = database.GetHobbyProgress(hobby.Id);
                    monthlyMinutes += progressList
                        .Where(p => p.Date.Year == month.Year && p.Date.Month == month.Month)
                        .Sum(p => p.TimeSpent);
                }
                
                var hours = monthlyMinutes / 60.0;
                var point = series.Points.Add(hours);
                point.AxisLabel = month.ToString("MMM yyyy");
            }

            chart.Series.Add(series);
            chart.ChartAreas[0].AxisX.Title = "Ay";
            chart.ChartAreas[0].AxisY.Title = "Saat";
            chart.Titles.Clear();
            chart.Titles.Add("Son 6 Ay İlerleme Trendi");
        }

        private void ShowWeeklyActivity()
        {
            var series = new Series("Haftalık Aktivite")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            var dayNames = new[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            var dailyMinutes = new int[7];

            foreach (var hobby in hobbies)
            {
                var progressList = database.GetHobbyProgress(hobby.Id);
                var last30Days = progressList.Where(p => p.Date >= DateTime.Now.AddDays(-30));

                foreach (var progress in last30Days)
                {
                    var dayIndex = ((int)progress.Date.DayOfWeek + 6) % 7; // Pazartesi = 0
                    dailyMinutes[dayIndex] += progress.TimeSpent;
                }
            }

            for (int i = 0; i < 7; i++)
            {
                var hours = dailyMinutes[i] / 60.0;
                var point = series.Points.Add(hours);
                point.AxisLabel = dayNames[i];
                point.Label = $"{hours:F1}h";
            }

            chart.Series.Add(series);
            chart.ChartAreas[0].AxisX.Title = "Gün";
            chart.ChartAreas[0].AxisY.Title = "Saat";
            chart.Titles.Clear();
            chart.Titles.Add("Haftalık Aktivite Dağılımı (Son 30 Gün)");
        }

        private void ShowRatingDistribution()
        {
            var series = new Series("Değerlendirme Dağılımı")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            var ratingCounts = new int[6]; // 0-5 yıldız

            foreach (var hobby in hobbies)
            {
                var progressList = database.GetHobbyProgress(hobby.Id);
                foreach (var progress in progressList)
                {
                    if (progress.Rating >= 0 && progress.Rating <= 5)
                    {
                        ratingCounts[progress.Rating]++;
                    }
                }
            }

            for (int i = 1; i <= 5; i++)
            {
                var point = series.Points.Add(ratingCounts[i]);
                point.AxisLabel = $"{i} ⭐";
                point.Label = ratingCounts[i].ToString();
            }

            chart.Series.Add(series);
            chart.ChartAreas[0].AxisX.Title = "Değerlendirme";
            chart.ChartAreas[0].AxisY.Title = "Sayı";
            chart.Titles.Clear();
            chart.Titles.Add("Memnuniyet Değerlendirme Dağılımı");
        }

        private void ShowGoalCompletionRates()
        {
            var series = new Series("Hedef Tamamlanma Oranları")
            {
                ChartType = SeriesChartType.Bar,
                IsValueShownAsLabel = true,
                LabelFormat = "#.#'%'"
            };

            foreach (var hobby in hobbies)
            {
                var goals = database.GetHobbyGoals(hobby.Id);
                if (goals.Count == 0) continue;

                var completedGoals = goals.Count(g => g.IsCompleted);
                var completionRate = (double)completedGoals / goals.Count * 100;

                var point = series.Points.Add(completionRate);
                point.AxisLabel = hobby.Name;
                point.Label = $"{completionRate:F1}%";
                
                // Renk kodlaması
                if (completionRate >= 80)
                    point.Color = System.Drawing.Color.Green;
                else if (completionRate >= 50)
                    point.Color = System.Drawing.Color.Orange;
                else
                    point.Color = System.Drawing.Color.Red;
            }

            chart.Series.Add(series);
            chart.ChartAreas[0].AxisX.Title = "Hobi";
            chart.ChartAreas[0].AxisY.Title = "Tamamlanma Oranı (%)";
            chart.Titles.Clear();
            chart.Titles.Add("Hedef Tamamlanma Oranları");
        }

        private void ShowCategoryTimeDistribution()
        {
            var series = new Series("Kategori Süreleri")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                LabelFormat = "#.#'%'"
            };

            var categoryTimes = new Dictionary<string, int>();

            foreach (var hobby in hobbies)
            {
                var category = string.IsNullOrEmpty(hobby.Category) ? "Diğer" : hobby.Category;
                if (!categoryTimes.ContainsKey(category))
                    categoryTimes[category] = 0;
                
                categoryTimes[category] += hobby.TotalTimeSpent;
            }

            var totalMinutes = categoryTimes.Values.Sum();
            if (totalMinutes == 0)
            {
                ShowNoDataMessage();
                return;
            }

            foreach (var kvp in categoryTimes)
            {
                var percentage = (double)kvp.Value / totalMinutes * 100;
                var point = series.Points.Add(percentage);
                point.LegendText = $"{kvp.Key} ({kvp.Value / 60.0:F1} saat)";
                point.Label = $"{percentage:F1}%";
            }

            chart.Series.Add(series);
            chart.Titles.Clear();
            chart.Titles.Add("Kategori Bazında Zaman Dağılımı");
        }

        private void ShowNoDataMessage()
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Titles.Add("Görüntülenecek veri bulunamadı");
            
            var textAnnotation = new TextAnnotation
            {
                Text = "Henüz yeterli veri yok.\nHobi ekleyip ilerleme kaydetmeye başlayın!",
                X = 50,
                Y = 50,
                Font = new System.Drawing.Font("Segoe UI", 12),
                ForeColor = System.Drawing.Color.Gray
            };
            chart.Annotations.Add(textAnnotation);
        }

        private void ApplyChartTheme()
        {
            var isDark = ThemeManager.CurrentTheme == "Dark";
            
            // Grafik arka planı
            chart.BackColor = isDark ? ThemeManager.DarkTheme.PanelColor : ThemeManager.LightTheme.PanelColor;
            chart.ChartAreas[0].BackColor = isDark ? ThemeManager.DarkTheme.PanelColor : ThemeManager.LightTheme.PanelColor;
            
            // Yazı renkleri
            var textColor = isDark ? ThemeManager.DarkTheme.TextColor : ThemeManager.LightTheme.TextColor;
            
            foreach (var title in chart.Titles)
            {
                title.ForeColor = textColor;
            }
            
            chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = textColor;
            chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = textColor;
            chart.ChartAreas[0].AxisX.TitleForeColor = textColor;
            chart.ChartAreas[0].AxisY.TitleForeColor = textColor;
            
            // Legend
            if (chart.Legends.Count > 0)
            {
                chart.Legends[0].ForeColor = textColor;
                chart.Legends[0].BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void cmbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowChart();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ShowChart();
            MessageBox.Show("Grafikler yenilendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var saveDialog = new SaveFileDialog
                {
                    Filter = "PNG Dosyası (*.png)|*.png|JPEG Dosyası (*.jpg)|*.jpg",
                    DefaultExt = "png",
                    FileName = $"HobiGrafik_{cmbChartType.Text.Replace(" ", "_")}_{DateTime.Now:yyyyMMdd}.png"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    chart.SaveImage(saveDialog.FileName, ChartImageFormat.Png);
                    MessageBox.Show($"Grafik başarıyla kaydedildi!\n\nDosya: {saveDialog.FileName}", 
                        "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Grafik kaydedilirken hata oluştu: {ex.Message}", "Hata", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this);
        }
    }
}
#endif // Chart kütüphanesi için geçici devre dışı