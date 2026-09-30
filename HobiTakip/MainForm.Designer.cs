namespace HobiTakip
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new Label();
            this.listHobbies = new ListView();
            this.colName = new ColumnHeader();
            this.colCategory = new ColumnHeader();
            this.colDifficulty = new ColumnHeader();
            this.colTimeSpent = new ColumnHeader();
            this.colStatus = new ColumnHeader();
            this.btnAddHobby = new Button();
            this.btnAddProgress = new Button();
            this.btnViewGoals = new Button();
            this.btnViewProgress = new Button();
            this.btnCharts = new Button();
            this.btnAchievements = new Button();
            this.btnPomodoro = new Button();
            this.btnSettings = new Button();
            this.btnLogout = new Button();
            this.panelTop = new Panel();
            this.lblHobbyCount = new Label();
            this.lblActiveHobbies = new Label();
            this.panelButtons = new Panel();
            this.panelStats = new Panel();
            this.panelTop.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblWelcome.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblWelcome.Location = new Point(20, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new Size(200, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Hoş geldin!";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnLogout.BackColor = Color.FromArgb(231, 76, 60);
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.Font = new Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = Color.White;
            this.btnLogout.Location = new Point(680, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new Size(80, 30);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Çıkış";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += btnLogout_Click;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = Color.White;
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Location = new Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new Size(800, 60);
            this.panelTop.TabIndex = 2;
            // 
            // panelStats
            // 
            this.panelStats.BackColor = Color.FromArgb(52, 152, 219);
            this.panelStats.Controls.Add(this.lblHobbyCount);
            this.panelStats.Controls.Add(this.lblActiveHobbies);
            this.panelStats.Dock = DockStyle.Top;
            this.panelStats.Location = new Point(0, 60);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new Size(800, 50);
            this.panelStats.TabIndex = 3;
            // 
            // lblHobbyCount
            // 
            this.lblHobbyCount.AutoSize = true;
            this.lblHobbyCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblHobbyCount.ForeColor = Color.White;
            this.lblHobbyCount.Location = new Point(20, 15);
            this.lblHobbyCount.Name = "lblHobbyCount";
            this.lblHobbyCount.Size = new Size(120, 21);
            this.lblHobbyCount.TabIndex = 0;
            this.lblHobbyCount.Text = "Toplam 0 hobi";
            // 
            // lblActiveHobbies
            // 
            this.lblActiveHobbies.AutoSize = true;
            this.lblActiveHobbies.Font = new Font("Segoe UI", 10F);
            this.lblActiveHobbies.ForeColor = Color.White;
            this.lblActiveHobbies.Location = new Point(200, 17);
            this.lblActiveHobbies.Name = "lblActiveHobbies";
            this.lblActiveHobbies.Size = new Size(82, 19);
            this.lblActiveHobbies.TabIndex = 1;
            this.lblActiveHobbies.Text = "0 aktif hobi";
            // 
            // listHobbies
            // 
            this.listHobbies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.listHobbies.Columns.AddRange(new ColumnHeader[] { colName, colCategory, colDifficulty, colTimeSpent, colStatus });
            this.listHobbies.FullRowSelect = true;
            this.listHobbies.GridLines = true;
            this.listHobbies.Location = new Point(20, 130);
            this.listHobbies.Name = "listHobbies";
            this.listHobbies.Size = new Size(760, 350);
            this.listHobbies.TabIndex = 4;
            this.listHobbies.UseCompatibleStateImageBehavior = false;
            this.listHobbies.View = View.Details;
            this.listHobbies.SelectedIndexChanged += listHobbies_SelectedIndexChanged;
            // 
            // colName
            // 
            this.colName.Text = "Hobi Adı";
            this.colName.Width = 200;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Kategori";
            this.colCategory.Width = 150;
            // 
            // colDifficulty
            // 
            this.colDifficulty.Text = "Zorluk";
            this.colDifficulty.Width = 100;
            // 
            // colTimeSpent
            // 
            this.colTimeSpent.Text = "Toplam Süre";
            this.colTimeSpent.Width = 120;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Durum";
            this.colStatus.Width = 100;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = Color.White;
            this.panelButtons.Controls.Add(this.btnAddHobby);
            this.panelButtons.Controls.Add(this.btnAddProgress);
            this.panelButtons.Controls.Add(this.btnViewGoals);
            this.panelButtons.Controls.Add(this.btnViewProgress);
            this.panelButtons.Controls.Add(this.btnCharts);
            this.panelButtons.Controls.Add(this.btnAchievements);
            this.panelButtons.Controls.Add(this.btnPomodoro);
            this.panelButtons.Controls.Add(this.btnSettings);
            this.panelButtons.Dock = DockStyle.Bottom;
            this.panelButtons.Location = new Point(0, 500);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new Size(800, 120);
            this.panelButtons.TabIndex = 5;
            // 
            // btnAddHobby
            // 
            this.btnAddHobby.BackColor = Color.FromArgb(46, 204, 113);
            this.btnAddHobby.FlatAppearance.BorderSize = 0;
            this.btnAddHobby.FlatStyle = FlatStyle.Flat;
            this.btnAddHobby.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnAddHobby.ForeColor = Color.White;
            this.btnAddHobby.Location = new Point(20, 15);
            this.btnAddHobby.Name = "btnAddHobby";
            this.btnAddHobby.Size = new Size(120, 40);
            this.btnAddHobby.TabIndex = 0;
            this.btnAddHobby.Text = "Hobi Ekle";
            this.btnAddHobby.UseVisualStyleBackColor = false;
            this.btnAddHobby.Click += btnAddHobby_Click;
            // 
            // btnAddProgress
            // 
            this.btnAddProgress.BackColor = Color.FromArgb(41, 128, 185);
            this.btnAddProgress.Enabled = false;
            this.btnAddProgress.FlatAppearance.BorderSize = 0;
            this.btnAddProgress.FlatStyle = FlatStyle.Flat;
            this.btnAddProgress.Font = new Font("Segoe UI", 10F);
            this.btnAddProgress.ForeColor = Color.White;
            this.btnAddProgress.Location = new Point(160, 15);
            this.btnAddProgress.Name = "btnAddProgress";
            this.btnAddProgress.Size = new Size(120, 40);
            this.btnAddProgress.TabIndex = 1;
            this.btnAddProgress.Text = "İlerleme Ekle";
            this.btnAddProgress.UseVisualStyleBackColor = false;
            this.btnAddProgress.Click += btnAddProgress_Click;
            // 
            // btnViewGoals
            // 
            this.btnViewGoals.BackColor = Color.FromArgb(155, 89, 182);
            this.btnViewGoals.Enabled = false;
            this.btnViewGoals.FlatAppearance.BorderSize = 0;
            this.btnViewGoals.FlatStyle = FlatStyle.Flat;
            this.btnViewGoals.Font = new Font("Segoe UI", 10F);
            this.btnViewGoals.ForeColor = Color.White;
            this.btnViewGoals.Location = new Point(300, 15);
            this.btnViewGoals.Name = "btnViewGoals";
            this.btnViewGoals.Size = new Size(120, 40);
            this.btnViewGoals.TabIndex = 2;
            this.btnViewGoals.Text = "Hedefler";
            this.btnViewGoals.UseVisualStyleBackColor = false;
            this.btnViewGoals.Click += btnViewGoals_Click;
            // 
            // btnViewProgress
            // 
            this.btnViewProgress.BackColor = Color.FromArgb(230, 126, 34);
            this.btnViewProgress.Enabled = false;
            this.btnViewProgress.FlatAppearance.BorderSize = 0;
            this.btnViewProgress.FlatStyle = FlatStyle.Flat;
            this.btnViewProgress.Font = new Font("Segoe UI", 10F);
            this.btnViewProgress.ForeColor = Color.White;
            this.btnViewProgress.Location = new Point(440, 15);
            this.btnViewProgress.Name = "btnViewProgress";
            this.btnViewProgress.Size = new Size(120, 40);
            this.btnViewProgress.TabIndex = 3;
            this.btnViewProgress.Text = "İlerleme Görüntüle";
            this.btnViewProgress.UseVisualStyleBackColor = false;
            this.btnViewProgress.Click += btnViewProgress_Click;
            // 
            // btnCharts
            // 
            this.btnCharts.BackColor = Color.FromArgb(52, 152, 219);
            this.btnCharts.FlatAppearance.BorderSize = 0;
            this.btnCharts.FlatStyle = FlatStyle.Flat;
            this.btnCharts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCharts.ForeColor = Color.White;
            this.btnCharts.Location = new Point(580, 15);
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Size = new Size(120, 40);
            this.btnCharts.TabIndex = 4;
            this.btnCharts.Text = "📊 Grafikler";
            this.btnCharts.UseVisualStyleBackColor = false;
            this.btnCharts.Click += btnCharts_Click;
            // 
            // btnAchievements
            // 
            this.btnAchievements.BackColor = Color.FromArgb(230, 126, 34);
            this.btnAchievements.FlatAppearance.BorderSize = 0;
            this.btnAchievements.FlatStyle = FlatStyle.Flat;
            this.btnAchievements.Font = new Font("Segoe UI", 10F);
            this.btnAchievements.ForeColor = Color.White;
            this.btnAchievements.Location = new Point(15, 65);
            this.btnAchievements.Name = "btnAchievements";
            this.btnAchievements.Size = new Size(120, 40);
            this.btnAchievements.TabIndex = 5;
            this.btnAchievements.Text = "🏆 Başarılar";
            this.btnAchievements.UseVisualStyleBackColor = false;
            this.btnAchievements.Click += btnAchievements_Click;
            // 
            // btnPomodoro
            // 
            this.btnPomodoro.BackColor = Color.FromArgb(231, 76, 60);
            this.btnPomodoro.FlatAppearance.BorderSize = 0;
            this.btnPomodoro.FlatStyle = FlatStyle.Flat;
            this.btnPomodoro.Font = new Font("Segoe UI", 10F);
            this.btnPomodoro.ForeColor = Color.White;
            this.btnPomodoro.Location = new Point(155, 65);
            this.btnPomodoro.Name = "btnPomodoro";
            this.btnPomodoro.Size = new Size(120, 40);
            this.btnPomodoro.TabIndex = 6;
            this.btnPomodoro.Text = "🍅 Pomodoro";
            this.btnPomodoro.UseVisualStyleBackColor = false;
            this.btnPomodoro.Click += btnPomodoro_Click;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = Color.FromArgb(95, 39, 205);
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = FlatStyle.Flat;
            this.btnSettings.Font = new Font("Segoe UI", 10F);
            this.btnSettings.ForeColor = Color.White;
            this.btnSettings.Location = new Point(295, 65);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new Size(120, 40);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "⚙️ Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += btnSettings_Click;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(800, 620);
            this.Controls.Add(this.listHobbies);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new Size(800, 650);
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Hobi Takip - Ana Sayfa";
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += MainForm_FormClosing;
            this.Load += MainForm_Load;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.ResumeLayout(false);
        }

        private Label lblWelcome;
        private ListView listHobbies;
        private ColumnHeader colName;
        private ColumnHeader colCategory;
        private ColumnHeader colDifficulty;
        private ColumnHeader colTimeSpent;
        private ColumnHeader colStatus;
        private Button btnAddHobby;
        private Button btnAddProgress;
        private Button btnViewGoals;
        private Button btnViewProgress;
        private Button btnCharts;
        private Button btnAchievements;
        private Button btnPomodoro;
        private Button btnSettings;
        private Button btnLogout;
        private Panel panelTop;
        private Panel panelButtons;
        private Panel panelStats;
        private Label lblHobbyCount;
        private Label lblActiveHobbies;
    }
}