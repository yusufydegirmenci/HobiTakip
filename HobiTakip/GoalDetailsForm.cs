using HobiTakip.Models;

namespace HobiTakip
{
    public partial class GoalDetailsForm : Form
    {
        private Database database;
        private Goal goal;

        public GoalDetailsForm(Goal goal, Database database)
        {
            InitializeComponent();
            this.goal = goal;
            this.database = database;
            LoadGoalDetails();
        }

        private void LoadGoalDetails()
        {
            lblTitle.Text = goal.Title;
            lblDescription.Text = string.IsNullOrEmpty(goal.Description) ? "Açıklama yok" : goal.Description;
            lblTargetValue.Text = $"Hedef: {goal.TargetValue} {goal.Unit}";
            lblCurrentValue.Text = $"Mevcut: {goal.CurrentValue} {goal.Unit}";
            lblTargetDate.Text = $"Hedef Tarihi: {goal.TargetDate:dd.MM.yyyy}";
            lblCreatedDate.Text = $"Oluşturulma: {goal.CreatedDate:dd.MM.yyyy}";
            
            var remainingDays = (goal.TargetDate - DateTime.Now).Days;
            if (remainingDays > 0)
            {
                lblRemainingTime.Text = $"Kalan Süre: {remainingDays} gün";
                lblRemainingTime.ForeColor = Color.FromArgb(52, 152, 219);
            }
            else if (remainingDays == 0)
            {
                lblRemainingTime.Text = "Bugün son gün!";
                lblRemainingTime.ForeColor = Color.FromArgb(230, 126, 34);
            }
            else
            {
                lblRemainingTime.Text = $"Süre {Math.Abs(remainingDays)} gün önce doldu";
                lblRemainingTime.ForeColor = Color.FromArgb(231, 76, 60);
            }

            // İlerleme çubuğu
            progressBar.Maximum = goal.TargetValue;
            progressBar.Value = Math.Min(goal.CurrentValue, goal.TargetValue);
            lblProgress.Text = $"{goal.ProgressPercentage:F1}% Tamamlandı";

            // Durum
            if (goal.IsCompleted)
            {
                lblStatus.Text = "✓ TAMAMLANDI";
                lblStatus.ForeColor = Color.FromArgb(46, 204, 113);
                lblCompletedDate.Text = $"Tamamlanma: {goal.CompletedDate:dd.MM.yyyy}";
                lblCompletedDate.Visible = true;
                btnMarkCompleted.Visible = false;
            }
            else
            {
                lblStatus.Text = "DEVAM EDİYOR";
                lblStatus.ForeColor = Color.FromArgb(52, 152, 219);
                lblCompletedDate.Visible = false;
                btnMarkCompleted.Visible = true;
            }
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bu hedefi tamamlandı olarak işaretlemek istediğinizden emin misiniz?", 
                "Hedef Tamamlandı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Hedefi tamamlandı olarak işaretle
                    using var connection = new Microsoft.Data.Sqlite.SqliteConnection(database.GetConnectionString());
                    connection.Open();
                    
                    var sql = @"UPDATE Goals SET IsCompleted = 1, CompletedDate = CURRENT_TIMESTAMP, 
                               CurrentValue = TargetValue WHERE Id = @id";
                    using var command = new Microsoft.Data.Sqlite.SqliteCommand(sql, connection);
                    command.Parameters.AddWithValue("@id", goal.Id);
                    command.ExecuteNonQuery();
                    
                    MessageBox.Show("Tebrikler! Hedef tamamlandı olarak işaretlendi.", "Başarılı", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hedef güncellenirken hata oluştu: {ex.Message}", "Hata", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GoalDetailsForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Hedef Detayı - {goal.Title}";
        }
    }
}