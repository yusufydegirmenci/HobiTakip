namespace HobiTakip
{
    partial class AchievementsForm
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
            this.lblTitle = new Label();
            this.lblUserName = new Label();
            this.listAchievements = new ListView();
            this.colIcon = new ColumnHeader();
            this.colName = new ColumnHeader();
            this.colCategory = new ColumnHeader();
            this.colDescription = new ColumnHeader();
            this.colStatus = new ColumnHeader();
            this.colDate = new ColumnHeader();
            this.btnRefresh = new Button();
            this.btnClose = new Button();
            this.panelTop = new Panel();
            this.panelBottom = new Panel();
            this.panelStats = new Panel();
            this.groupStats = new GroupBox();
            this.lblTotalAchievements = new Label();
            this.lblUnlockedAchievements = new Label();
            this.lblPercentage = new Label();
            this.progressBar = new ProgressBar();
            this.lblCategoryStats = new Label();
            this.lblLastAchievement = new Label();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.groupStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(230, 126, 34);
            this.lblTitle.Location = new Point(15, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(130, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🏆 BAŞARILAR";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblUserName.ForeColor = Color.FromArgb(46, 204, 113);
            this.lblUserName.Location = new Point(15, 50);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new Size(200, 21);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "🏆 Kullanıcının Başarıları";
            // 
            // listAchievements
            // 
            this.listAchievements.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.listAchievements.Columns.AddRange(new ColumnHeader[] { colIcon, colName, colCategory, colDescription, colStatus, colDate });
            this.listAchievements.FullRowSelect = true;
            this.listAchievements.GridLines = true;
            this.listAchievements.Location = new Point(15, 200);
            this.listAchievements.Name = "listAchievements";
            this.listAchievements.Size = new Size(870, 300);
            this.listAchievements.TabIndex = 2;
            this.listAchievements.UseCompatibleStateImageBehavior = false;
            this.listAchievements.View = View.Details;
            this.listAchievements.DoubleClick += listAchievements_DoubleClick;
            // 
            // colIcon
            // 
            this.colIcon.Text = "";
            this.colIcon.Width = 50;
            // 
            // colName
            // 
            this.colName.Text = "Rozet Adı";
            this.colName.Width = 150;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Kategori";
            this.colCategory.Width = 100;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Açıklama";
            this.colDescription.Width = 250;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Durum";
            this.colStatus.Width = 120;
            // 
            // colDate
            // 
            this.colDate.Text = "Kazanılma Tarihi";
            this.colDate.Width = 120;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = Color.FromArgb(230, 126, 34);
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.Location = new Point(15, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(120, 40);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "🔄 Yenile";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnClose.BackColor = Color.FromArgb(95, 39, 205);
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.Font = new Font("Segoe UI", 10F);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.Location = new Point(765, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(120, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += btnClose_Click;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = Color.White;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblUserName);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Location = new Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new Size(900, 90);
            this.panelTop.TabIndex = 5;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = Color.White;
            this.panelBottom.Controls.Add(this.btnRefresh);
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Dock = DockStyle.Bottom;
            this.panelBottom.Location = new Point(0, 520);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new Size(900, 70);
            this.panelBottom.TabIndex = 6;
            // 
            // panelStats
            // 
            this.panelStats.BackColor = Color.White;
            this.panelStats.Controls.Add(this.groupStats);
            this.panelStats.Dock = DockStyle.Top;
            this.panelStats.Location = new Point(0, 90);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new Size(900, 90);
            this.panelStats.TabIndex = 7;
            // 
            // groupStats
            // 
            this.groupStats.Controls.Add(this.lblTotalAchievements);
            this.groupStats.Controls.Add(this.lblUnlockedAchievements);
            this.groupStats.Controls.Add(this.lblPercentage);
            this.groupStats.Controls.Add(this.progressBar);
            this.groupStats.Controls.Add(this.lblCategoryStats);
            this.groupStats.Controls.Add(this.lblLastAchievement);
            this.groupStats.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupStats.ForeColor = Color.FromArgb(52, 73, 94);
            this.groupStats.Location = new Point(15, 10);
            this.groupStats.Name = "groupStats";
            this.groupStats.Size = new Size(870, 70);
            this.groupStats.TabIndex = 0;
            this.groupStats.TabStop = false;
            this.groupStats.Text = "İstatistikler";
            // 
            // lblTotalAchievements
            // 
            this.lblTotalAchievements.AutoSize = true;
            this.lblTotalAchievements.Font = new Font("Segoe UI", 10F);
            this.lblTotalAchievements.Location = new Point(15, 25);
            this.lblTotalAchievements.Name = "lblTotalAchievements";
            this.lblTotalAchievements.Size = new Size(100, 19);
            this.lblTotalAchievements.TabIndex = 0;
            this.lblTotalAchievements.Text = "Toplam Rozet: 0";
            // 
            // lblUnlockedAchievements
            // 
            this.lblUnlockedAchievements.AutoSize = true;
            this.lblUnlockedAchievements.Font = new Font("Segoe UI", 10F);
            this.lblUnlockedAchievements.Location = new Point(15, 45);
            this.lblUnlockedAchievements.Name = "lblUnlockedAchievements";
            this.lblUnlockedAchievements.Size = new Size(80, 19);
            this.lblUnlockedAchievements.TabIndex = 1;
            this.lblUnlockedAchievements.Text = "Kazanılan: 0";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblPercentage.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblPercentage.Location = new Point(150, 25);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new Size(110, 19);
            this.lblPercentage.TabIndex = 2;
            this.lblPercentage.Text = "Tamamlanma: %0";
            // 
            // progressBar
            // 
            this.progressBar.Location = new Point(150, 45);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new Size(200, 15);
            this.progressBar.TabIndex = 3;
            // 
            // lblCategoryStats
            // 
            this.lblCategoryStats.Font = new Font("Segoe UI", 9F);
            this.lblCategoryStats.Location = new Point(400, 25);
            this.lblCategoryStats.Name = "lblCategoryStats";
            this.lblCategoryStats.Size = new Size(200, 40);
            this.lblCategoryStats.TabIndex = 4;
            this.lblCategoryStats.Text = "Kategori istatistikleri";
            // 
            // lblLastAchievement
            // 
            this.lblLastAchievement.Font = new Font("Segoe UI", 9F);
            this.lblLastAchievement.Location = new Point(620, 25);
            this.lblLastAchievement.Name = "lblLastAchievement";
            this.lblLastAchievement.Size = new Size(240, 40);
            this.lblLastAchievement.TabIndex = 5;
            this.lblLastAchievement.Text = "Son kazanılan rozet";
            // 
            // AchievementsForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(900, 590);
            this.Controls.Add(this.listAchievements);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new Size(900, 590);
            this.Name = "AchievementsForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Başarılar";
            this.Load += AchievementsForm_Load;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.groupStats.ResumeLayout(false);
            this.groupStats.PerformLayout();
            this.ResumeLayout(false);
        }

        private Label lblTitle;
        private Label lblUserName;
        private ListView listAchievements;
        private ColumnHeader colIcon;
        private ColumnHeader colName;
        private ColumnHeader colCategory;
        private ColumnHeader colDescription;
        private ColumnHeader colStatus;
        private ColumnHeader colDate;
        private Button btnRefresh;
        private Button btnClose;
        private Panel panelTop;
        private Panel panelBottom;
        private Panel panelStats;
        private GroupBox groupStats;
        private Label lblTotalAchievements;
        private Label lblUnlockedAchievements;
        private Label lblPercentage;
        private ProgressBar progressBar;
        private Label lblCategoryStats;
        private Label lblLastAchievement;
    }
}