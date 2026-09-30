using HobiTakip.Models;

namespace HobiTakip
{
    public partial class LoginForm : Form
    {
        private Database database;

        public LoginForm()
        {
            InitializeComponent();
            database = new Database();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = database.LoginUser(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                // Ana forma geç
                var mainForm = new MainForm(user, database);
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm(database);
            registerForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde odak kullanıcı adı alanına
            txtUsername.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Enter tuşuna basıldığında giriş yap
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Enter tuşuna basıldığında şifre alanına geç
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPassword.Focus();
            }
        }
    }
}