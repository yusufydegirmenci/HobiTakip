namespace HobiTakip
{
    public partial class RegisterForm : Form
    {
        private Database database;

        public RegisterForm(Database db)
        {
            InitializeComponent();
            database = db;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Alanları kontrol et
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Kullanıcı adı boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Şifre boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPasswordConfirm.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Ad soyad boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (txtPassword.Text.Length < 4)
            {
                MessageBox.Show("Şifre en az 4 karakter olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Kullanıcı kaydet
            bool success = database.RegisterUser(txtUsername.Text, txtPassword.Text, txtFullName.Text, txtEmail.Text);
            
            if (success)
            {
                MessageBox.Show("Kayıt başarılı! Şimdi giriş yapabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kayıt başarısız! Bu kullanıcı adı zaten kullanımda olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}