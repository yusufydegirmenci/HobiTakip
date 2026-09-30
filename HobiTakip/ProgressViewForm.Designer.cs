namespace HobiTakip
{
    partial class ProgressViewForm
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
            this.lblHobbyName = new Label();
            this.listProgress = new ListView();
            this.colDate = new ColumnHeader();
            this.colTime = new ColumnHeader();
            this.colWork = new ColumnHeader();
            this.colRating = new ColumnHeader();
            this.colNotes = new ColumnHeader();
            this.btnClose = new Button();
            this.btnRefresh = new Button();
            this.panelTop = new Panel();
            this.panelBottom = new Panel();
            this.panelStats = new Panel();
            this.lblTotalTime = new Label();
            this.lblAvgRating = new Label();
            this.lblTotalSessions = new Label();
            this.lblLastActivity = new Label();
            this.lblMonthlyStats = new Label();
            this.lblWeeklyStats = new Label();
            this.groupStats = new GroupBox();
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
            this.lblTitle.Size = new Size(240, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "İLERLEME GÖRÜNTÜLE";
            // 
            // lblHobbyName
            // 
            this.lblHobbyName.AutoSize = true;
            this.lblHobbyName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblHobbyName.ForeColor = Color.FromArgb(46, 204, 113);
            this.lblHobbyName.Location = new Point(15, 50);
            this.lblHobbyName.Name = "lblHobbyName";
            this.lblHobbyName.Size = new Size(50, 21);
            this.lblHobbyName.TabIndex = 1;
            this.lblHobbyName.Text = "Hobi:";
            // 
            // listProgress
            // 
            this.listProgress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.listProgress.Columns.AddRange(new ColumnHeader[] { colDate, colTime, colWork, colRating, colNotes });
            this.listProgress.FullRowSelect = true;
            this.listProgress.GridLines = true;
            this.listProgress.Location = new Point(15, 250);
            this.listProgress.Name = "listProgress";
            this.listProgress.Size = new Size(770, 300);
            this.listProgress.TabIndex = 2;
            this.listProgress.UseCompatibleStateImageBehavior = false;
            this.listProgress.View = View.Details;
            this.listProgress.DoubleClick += listProgress_DoubleClick;
            // 
            // colDate
            // 
            this.colDate.Text = "Tarih";
            this.colDate.Width = 100;
            // 
            // colTime
            // 
            this.colTime.Text = "Süre";
            this.colTime.Width = 80;
            // 
            // colWork
            // 
            this.colWork.Text = "Yapılan İş";
            this.colWork.Width = 120;
            // 
            // colRating
            // 
            this.colRating.Text = "Değerlendirme";
            this.colRating.Width = 150;
            // 
            // colNotes
            // 
            this.colNotes.Text = "Notlar";
            this.colNotes.Width = 200;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnClose.BackColor = Color.FromArgb(95, 39, 205);
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.Font = new Font("Segoe UI", 10F);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.Location = new Point(665, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(120, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += btnClose_Click;
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
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += btnRefresh_Click;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = Color.White;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblHobbyName);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Location = new Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new Size(800, 90);
            this.panelTop.TabIndex = 5;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = Color.White;
            this.panelBottom.Controls.Add(this.btnRefresh);
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Dock = DockStyle.Bottom;
            this.panelBottom.Location = new Point(0, 570);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new Size(800, 70);
            this.panelBottom.TabIndex = 6;
            // 
            // panelStats
            // 
            this.panelStats.BackColor = Color.White;
            this.panelStats.Controls.Add(this.groupStats);
            this.panelStats.Dock = DockStyle.Top;
            this.panelStats.Location = new Point(0, 90);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new Size(800, 140);
            this.panelStats.TabIndex = 7;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblTotalTime.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblTotalTime.Location = new Point(15, 25);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new Size(150, 20);
            this.lblTotalTime.TabIndex = 0;
            this.lblTotalTime.Text = "Toplam Süre: 0 saat";
            // 
            // lblAvgRating
            // 
            this.lblAvgRating.AutoSize = true;
            this.lblAvgRating.Font = new Font("Segoe UI", 10F);
            this.lblAvgRating.Location = new Point(15, 55);
            this.lblAvgRating.Name = "lblAvgRating";
            this.lblAvgRating.Size = new Size(180, 19);
            this.lblAvgRating.TabIndex = 1;
            this.lblAvgRating.Text = "Ortalama Değerlendirme: -";
            // 
            // lblTotalSessions
            // 
            this.lblTotalSessions.AutoSize = true;
            this.lblTotalSessions.Font = new Font("Segoe UI", 10F);
            this.lblTotalSessions.Location = new Point(15, 85);
            this.lblTotalSessions.Name = "lblTotalSessions";
            this.lblTotalSessions.Size = new Size(120, 19);
            this.lblTotalSessions.TabIndex = 2;
            this.lblTotalSessions.Text = "Toplam Oturum: 0";
            // 
            // lblLastActivity
            // 
            this.lblLastActivity.AutoSize = true;
            this.lblLastActivity.Font = new Font("Segoe UI", 10F);
            this.lblLastActivity.Location = new Point(280, 25);
            this.lblLastActivity.Name = "lblLastActivity";
            this.lblLastActivity.Size = new Size(100, 19);
            this.lblLastActivity.TabIndex = 3;
            this.lblLastActivity.Text = "Son Aktivite: -";
            // 
            // lblMonthlyStats
            // 
            this.lblMonthlyStats.AutoSize = true;
            this.lblMonthlyStats.Font = new Font("Segoe UI", 10F);
            this.lblMonthlyStats.Location = new Point(280, 55);
            this.lblMonthlyStats.Name = "lblMonthlyStats";
            this.lblMonthlyStats.Size = new Size(120, 19);
            this.lblMonthlyStats.TabIndex = 4;
            this.lblMonthlyStats.Text = "Bu Ay: 0 saat";
            // 
            // lblWeeklyStats
            // 
            this.lblWeeklyStats.AutoSize = true;
            this.lblWeeklyStats.Font = new Font("Segoe UI", 10F);
            this.lblWeeklyStats.Location = new Point(280, 85);
            this.lblWeeklyStats.Name = "lblWeeklyStats";
            this.lblWeeklyStats.Size = new Size(130, 19);
            this.lblWeeklyStats.TabIndex = 5;
            this.lblWeeklyStats.Text = "Bu Hafta: 0 saat";
            // 
            // groupStats
            // 
            this.groupStats.Controls.Add(this.lblTotalTime);
            this.groupStats.Controls.Add(this.lblWeeklyStats);
            this.groupStats.Controls.Add(this.lblAvgRating);
            this.groupStats.Controls.Add(this.lblMonthlyStats);
            this.groupStats.Controls.Add(this.lblTotalSessions);
            this.groupStats.Controls.Add(this.lblLastActivity);
            this.groupStats.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupStats.ForeColor = Color.FromArgb(52, 73, 94);
            this.groupStats.Location = new Point(15, 10);
            this.groupStats.Name = "groupStats";
            this.groupStats.Size = new Size(770, 120);
            this.groupStats.TabIndex = 6;
            this.groupStats.TabStop = false;
            this.groupStats.Text = "İstatistikler";
            // 
            // ProgressViewForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(800, 640);
            this.Controls.Add(this.listProgress);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new Size(800, 640);
            this.Name = "ProgressViewForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "İlerleme Görüntüle";
            this.Load += ProgressViewForm_Load;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.groupStats.ResumeLayout(false);
            this.groupStats.PerformLayout();
            this.ResumeLayout(false);
        }

        private Label lblTitle;
        private Label lblHobbyName;
        private ListView listProgress;
        private ColumnHeader colDate;
        private ColumnHeader colTime;
        private ColumnHeader colWork;
        private ColumnHeader colRating;
        private ColumnHeader colNotes;
        private Button btnClose;
        private Button btnRefresh;
        private Panel panelTop;
        private Panel panelBottom;
        private Panel panelStats;
        private Label lblTotalTime;
        private Label lblAvgRating;
        private Label lblTotalSessions;
        private Label lblLastActivity;
        private Label lblMonthlyStats;
        private Label lblWeeklyStats;
        private GroupBox groupStats;
    }
}