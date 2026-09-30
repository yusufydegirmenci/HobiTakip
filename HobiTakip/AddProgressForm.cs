using HobiTakip.Models;

namespace HobiTakip
{
    public partial class AddProgressForm : Form
    {
        private Database database;
        private Hobby hobby;
        private List<Goal> goals;

        public AddProgressForm(Hobby hobby, Database database)
        {
            InitializeComponent();
            this.hobby = hobby;
            this.database = database;
            LoadGoals();
            SetupForm();
        }

        private void LoadGoals()
        {
            goals = database.GetHobbyGoals(hobby.Id);
        }

        private void SetupForm()
        {
            lblHobbyName.Text = $"Hobi: {hobby.Name}";
            dtpDate.Value = DateTime.Now;
            
            // Hedefleri combobox'a ekle
            cmbGoal.Items.Add("(Hedefe bağlı değil)");
            foreach (var goal in goals.Where(g => !g.IsCompleted))
            {
                cmbGoal.Items.Add($"{goal.Title} ({goal.Unit})");
            }
            cmbGoal.SelectedIndex = 0;

            // Rating için 1-5 seçenekleri
            for (int i = 1; i <= 5; i++)
            {
                cmbRating.Items.Add($"{i} - {GetRatingText(i)}");
            }
            cmbRating.SelectedIndex = 3; // 4 - İyi
        }

        private string GetRatingText(int rating)
        {
            return rating switch
            {
                1 => "Çok Kötü",
                2 => "Kötü",
                3 => "Orta",
                4 => "İyi",
                5 => "Mükemmel",
                _ => "Orta"
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var progress = new Progress
                {
                    HobbyId = hobby.Id,
                    Date = dtpDate.Value,
                    TimeSpent = (int)numTimeSpent.Value,
                    Value = (int)numValue.Value,
                    Unit = txtUnit.Text.Trim(),
                    Notes = txtNotes.Text.Trim(),
                    Rating = cmbRating.SelectedIndex + 1
                };

                // Eğer hedef seçildiyse
                if (cmbGoal.SelectedIndex > 0)
                {
                    progress.GoalId = goals[cmbGoal.SelectedIndex - 1].Id;
                }

                try
                {
                    database.AddProgress(progress);
                    
                    // Başarıları kontrol et
                    database.CheckAndUnlockAchievements(hobby.UserId);
                    
                    MessageBox.Show("İlerleme başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"İlerleme kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            if (numTimeSpent.Value <= 0)
            {
                MessageBox.Show("Geçirilen süre 0'dan büyük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numTimeSpent.Focus();
                return false;
            }

            if (cmbRating.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir değerlendirme seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRating.Focus();
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbGoal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGoal.SelectedIndex > 0)
            {
                var selectedGoal = goals[cmbGoal.SelectedIndex - 1];
                txtUnit.Text = selectedGoal.Unit;
                lblUnitHint.Text = $"Hedef: {selectedGoal.CurrentValue}/{selectedGoal.TargetValue} {selectedGoal.Unit}";
            }
            else
            {
                txtUnit.Text = "";
                lblUnitHint.Text = "";
            }
        }
    }
}