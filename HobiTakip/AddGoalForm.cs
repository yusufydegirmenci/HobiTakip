using HobiTakip.Models;

namespace HobiTakip
{
    public partial class AddGoalForm : Form
    {
        private Database database;
        private Hobby hobby;

        public AddGoalForm(Hobby hobby, Database database)
        {
            InitializeComponent();
            this.hobby = hobby;
            this.database = database;
            SetupForm();
        }

        private void SetupForm()
        {
            lblHobbyName.Text = $"Hobi: {hobby.Name}";
            dtpTargetDate.Value = DateTime.Now.AddDays(30); // 30 gün sonrası varsayılan
            
            // Yaygın birim örnekleri
            cmbUnit.Items.AddRange(new string[]
            {
                "saat",
                "sayfa",
                "bölüm",
                "dakika",
                "kilometre",
                "adet",
                "proje",
                "seviye",
                "ders",
                "kelime"
            });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var goal = new Goal
                {
                    HobbyId = hobby.Id,
                    Title = txtTitle.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    TargetDate = dtpTargetDate.Value,
                    TargetValue = (int)numTargetValue.Value,
                    Unit = cmbUnit.Text.Trim()
                };

                try
                {
                    database.AddGoal(goal);
                    
                    // Başarıları kontrol et (hobi sahibini bul)
                    // Hobi bilgisini zaten hobby değişkeninde saklamıştık
                    database.CheckAndUnlockAchievements(hobby.UserId);
                    
                    MessageBox.Show("Hedef başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hedef eklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Hedef başlığı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }

            if (numTargetValue.Value <= 0)
            {
                MessageBox.Show("Hedef değer 0'dan büyük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numTargetValue.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbUnit.Text))
            {
                MessageBox.Show("Birim boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbUnit.Focus();
                return false;
            }

            if (dtpTargetDate.Value <= DateTime.Now)
            {
                MessageBox.Show("Hedef tarihi gelecekte olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpTargetDate.Focus();
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddGoalForm_Load(object sender, EventArgs e)
        {
            txtTitle.Focus();
        }
    }
}