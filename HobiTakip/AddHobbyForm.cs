using HobiTakip.Models;

namespace HobiTakip
{
    public partial class AddHobbyForm : Form
    {
        private Database database;
        private int userId;

        public AddHobbyForm(int userId, Database db)
        {
            InitializeComponent();
            this.userId = userId;
            database = db;
            SetupForm();
        }

        private void SetupForm()
        {
            // Kategori örnekleri
            cmbCategory.Items.AddRange(new string[]
            {
                "Sanat ve El Sanatları",
                "Spor ve Fitness",
                "Müzik",
                "Okuma ve Yazma",
                "Teknoloji",
                "Yemek Pişirme",
                "Bahçıvanlık",
                "Oyunlar",
                "Koleksiyon",
                "Fotoğrafçılık",
                "Seyahat",
                "Dil Öğrenme",
                "Diğer"
            });

            // Zorluk seviyeleri
            cmbDifficulty.Items.AddRange(new string[] { "Kolay", "Orta", "Zor" });

            // Varsayılan değerler
            dtpStartDate.Value = DateTime.Now;
            cmbDifficulty.SelectedIndex = 1; // Orta
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var hobby = new Hobby
                {
                    UserId = userId,
                    Name = txtName.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Category = cmbCategory.Text,
                    StartDate = dtpStartDate.Value,
                    DifficultyLevel = cmbDifficulty.Text,
                    IsActive = chkIsActive.Checked
                };

                try
                {
                    database.AddHobby(hobby);
                    
                    // Başarıları kontrol et
                    database.CheckAndUnlockAchievements(userId);
                    
                    MessageBox.Show("Hobi başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hobi eklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Hobi adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("Lütfen bir kategori seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbDifficulty.Text))
            {
                MessageBox.Show("Lütfen zorluk seviyesi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDifficulty.Focus();
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddHobbyForm_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}