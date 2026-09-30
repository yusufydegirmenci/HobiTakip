namespace HobiTakip
{
    partial class PomodoroTimerForm
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
            this.lblTimer = new Label();
            this.lblSessionType = new Label();
            this.lblSessionInfo = new Label();
            this.progressBar = new ProgressBar();
            this.cmbHobby = new ComboBox();
            this.lblHobby = new Label();
            this.btnStart = new Button();
            this.btnPause = new Button();
            this.btnReset = new Button();
            this.btnSettings = new Button();
            this.btnClose = new Button();
            this.groupTimer = new GroupBox();
            this.groupControls = new GroupBox();
            this.groupSettings = new GroupBox();
            this.lblWorkMinutes = new Label();
            this.numWorkMinutes = new NumericUpDown();
            this.lblBreakMinutes = new Label();
            this.numBreakMinutes = new NumericUpDown();
            this.chkSound = new CheckBox();
            this.groupStats = new GroupBox();
            this.lblTotalSessions = new Label();
            this.lblLastSession = new Label();
            this.panelMain = new Panel();
            this.groupTimer.SuspendLayout();
            this.groupControls.SuspendLayout();
            this.groupSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakMinutes)).BeginInit();
            this.groupStats.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(231, 76, 60);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(200, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🍅 POMODORO";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new Font("Segoe UI", 12F);
            this.lblUserName.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblUserName.Location = new Point(20, 60);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new Size(150, 21);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Merhaba, Kullanıcı!";
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            this.lblTimer.ForeColor = Color.FromArgb(231, 76, 60);
            this.lblTimer.Location = new Point(20, 30);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new Size(300, 80);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "25:00";
            this.lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSessionType
            // 
            this.lblSessionType.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblSessionType.ForeColor = Color.FromArgb(231, 76, 60);
            this.lblSessionType.Location = new Point(20, 120);
            this.lblSessionType.Name = "lblSessionType";
            this.lblSessionType.Size = new Size(300, 30);
            this.lblSessionType.TabIndex = 1;
            this.lblSessionType.Text = "🍅 ÇALIŞMA SEANSİ";
            this.lblSessionType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSessionInfo
            // 
            this.lblSessionInfo.Font = new Font("Segoe UI", 10F);
            this.lblSessionInfo.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblSessionInfo.Location = new Point(20, 160);
            this.lblSessionInfo.Name = "lblSessionInfo";
            this.lblSessionInfo.Size = new Size(300, 40);
            this.lblSessionInfo.TabIndex = 2;
            this.lblSessionInfo.Text = "Odaklanma zamanı! 25 dakika boyunca seçili hobinizle ilgilenin.";
            this.lblSessionInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Location = new Point(20, 210);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new Size(300, 20);
            this.progressBar.TabIndex = 3;
            // 
            // cmbHobby
            // 
            this.cmbHobby.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbHobby.Font = new Font("Segoe UI", 11F);
            this.cmbHobby.FormattingEnabled = true;
            this.cmbHobby.Location = new Point(15, 45);
            this.cmbHobby.Name = "cmbHobby";
            this.cmbHobby.Size = new Size(200, 28);
            this.cmbHobby.TabIndex = 1;
            // 
            // lblHobby
            // 
            this.lblHobby.AutoSize = true;
            this.lblHobby.Font = new Font("Segoe UI", 10F);
            this.lblHobby.Location = new Point(15, 25);
            this.lblHobby.Name = "lblHobby";
            this.lblHobby.Size = new Size(76, 19);
            this.lblHobby.TabIndex = 0;
            this.lblHobby.Text = "Hobi Seçin:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = Color.FromArgb(46, 204, 113);
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = FlatStyle.Flat;
            this.btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnStart.ForeColor = Color.White;
            this.btnStart.Location = new Point(15, 25);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new Size(100, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "▶️ Başla";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += btnStart_Click;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = Color.FromArgb(230, 126, 34);
            this.btnPause.Enabled = false;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = FlatStyle.Flat;
            this.btnPause.Font = new Font("Segoe UI", 11F);
            this.btnPause.ForeColor = Color.White;
            this.btnPause.Location = new Point(125, 25);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new Size(100, 40);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "⏸️ Duraklat";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += btnPause_Click;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = Color.FromArgb(231, 76, 60);
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = FlatStyle.Flat;
            this.btnReset.Font = new Font("Segoe UI", 11F);
            this.btnReset.ForeColor = Color.White;
            this.btnReset.Location = new Point(235, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new Size(100, 40);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "🔄 Sıfırla";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += btnReset_Click;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = Color.FromArgb(52, 152, 219);
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = FlatStyle.Flat;
            this.btnSettings.Font = new Font("Segoe UI", 10F);
            this.btnSettings.ForeColor = Color.White;
            this.btnSettings.Location = new Point(380, 20);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new Size(100, 35);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "⚙️ Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += btnSettings_Click;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = Color.FromArgb(95, 39, 205);
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.Font = new Font("Segoe UI", 10F);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.Location = new Point(490, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(80, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += btnClose_Click;
            // 
            // groupTimer
            // 
            this.groupTimer.Controls.Add(this.lblTimer);
            this.groupTimer.Controls.Add(this.lblSessionType);
            this.groupTimer.Controls.Add(this.lblSessionInfo);
            this.groupTimer.Controls.Add(this.progressBar);
            this.groupTimer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupTimer.ForeColor = Color.FromArgb(52, 73, 94);
            this.groupTimer.Location = new Point(20, 100);
            this.groupTimer.Name = "groupTimer";
            this.groupTimer.Size = new Size(340, 250);
            this.groupTimer.TabIndex = 4;
            this.groupTimer.TabStop = false;
            this.groupTimer.Text = "Timer";
            // 
            // groupControls
            // 
            this.groupControls.Controls.Add(this.lblHobby);
            this.groupControls.Controls.Add(this.cmbHobby);
            this.groupControls.Controls.Add(this.btnStart);
            this.groupControls.Controls.Add(this.btnPause);
            this.groupControls.Controls.Add(this.btnReset);
            this.groupControls.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupControls.ForeColor = Color.FromArgb(52, 73, 94);
            this.groupControls.Location = new Point(20, 370);
            this.groupControls.Name = "groupControls";
            this.groupControls.Size = new Size(350, 85);
            this.groupControls.TabIndex = 5;
            this.groupControls.TabStop = false;
            this.groupControls.Text = "Kontroller";
            // 
            // groupSettings
            // 
            this.groupSettings.Controls.Add(this.lblWorkMinutes);
            this.groupSettings.Controls.Add(this.numWorkMinutes);
            this.groupSettings.Controls.Add(this.lblBreakMinutes);
            this.groupSettings.Controls.Add(this.numBreakMinutes);
            this.groupSettings.Controls.Add(this.chkSound);
            this.groupSettings.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupSettings.ForeColor = Color.FromArgb(52, 73, 94);
            this.groupSettings.Location = new Point(380, 100);
            this.groupSettings.Name = "groupSettings";
            this.groupSettings.Size = new Size(190, 150);
            this.groupSettings.TabIndex = 6;
            this.groupSettings.TabStop = false;
            this.groupSettings.Text = "Hızlı Ayarlar";
            // 
            // lblWorkMinutes
            // 
            this.lblWorkMinutes.AutoSize = true;
            this.lblWorkMinutes.Font = new Font("Segoe UI", 9F);
            this.lblWorkMinutes.Location = new Point(15, 25);
            this.lblWorkMinutes.Name = "lblWorkMinutes";
            this.lblWorkMinutes.Size = new Size(90, 15);
            this.lblWorkMinutes.TabIndex = 0;
            this.lblWorkMinutes.Text = "Çalışma (dakika):";
            // 
            // numWorkMinutes
            // 
            this.numWorkMinutes.Font = new Font("Segoe UI", 10F);
            this.numWorkMinutes.Location = new Point(15, 45);
            this.numWorkMinutes.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            this.numWorkMinutes.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            this.numWorkMinutes.Name = "numWorkMinutes";
            this.numWorkMinutes.Size = new Size(60, 25);
            this.numWorkMinutes.TabIndex = 1;
            this.numWorkMinutes.Value = new decimal(new int[] { 25, 0, 0, 0 });
            this.numWorkMinutes.ValueChanged += numWorkMinutes_ValueChanged;
            // 
            // lblBreakMinutes
            // 
            this.lblBreakMinutes.AutoSize = true;
            this.lblBreakMinutes.Font = new Font("Segoe UI", 9F);
            this.lblBreakMinutes.Location = new Point(100, 25);
            this.lblBreakMinutes.Name = "lblBreakMinutes";
            this.lblBreakMinutes.Size = new Size(78, 15);
            this.lblBreakMinutes.TabIndex = 2;
            this.lblBreakMinutes.Text = "Mola (dakika):";
            // 
            // numBreakMinutes
            // 
            this.numBreakMinutes.Font = new Font("Segoe UI", 10F);
            this.numBreakMinutes.Location = new Point(100, 45);
            this.numBreakMinutes.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            this.numBreakMinutes.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            this.numBreakMinutes.Name = "numBreakMinutes";
            this.numBreakMinutes.Size = new Size(60, 25);
            this.numBreakMinutes.TabIndex = 3;
            this.numBreakMinutes.Value = new decimal(new int[] { 5, 0, 0, 0 });
            this.numBreakMinutes.ValueChanged += numBreakMinutes_ValueChanged;
            // 
            // chkSound
            // 
            this.chkSound.AutoSize = true;
            this.chkSound.Checked = true;
            this.chkSound.CheckState = CheckState.Checked;
            this.chkSound.Font = new Font("Segoe UI", 9F);
            this.chkSound.Location = new Point(15, 85);
            this.chkSound.Name = "chkSound";
            this.chkSound.Size = new Size(108, 19);
            this.chkSound.TabIndex = 4;
            this.chkSound.Text = "🔊 Ses bildirimi";
            this.chkSound.UseVisualStyleBackColor = true;
            // 
            // groupStats
            // 
            this.groupStats.Controls.Add(this.lblTotalSessions);
            this.groupStats.Controls.Add(this.lblLastSession);
            this.groupStats.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupStats.ForeColor = Color.FromArgb(52, 73, 94);
            this.groupStats.Location = new Point(380, 270);
            this.groupStats.Name = "groupStats";
            this.groupStats.Size = new Size(190, 80);
            this.groupStats.TabIndex = 7;
            this.groupStats.TabStop = false;
            this.groupStats.Text = "İstatistikler";
            // 
            // lblTotalSessions
            // 
            this.lblTotalSessions.AutoSize = true;
            this.lblTotalSessions.Font = new Font("Segoe UI", 9F);
            this.lblTotalSessions.Location = new Point(15, 25);
            this.lblTotalSessions.Name = "lblTotalSessions";
            this.lblTotalSessions.Size = new Size(80, 15);
            this.lblTotalSessions.TabIndex = 0;
            this.lblTotalSessions.Text = "Bugün: 0 seans";
            // 
            // lblLastSession
            // 
            this.lblLastSession.Font = new Font("Segoe UI", 8F);
            this.lblLastSession.Location = new Point(15, 45);
            this.lblLastSession.Name = "lblLastSession";
            this.lblLastSession.Size = new Size(170, 30);
            this.lblLastSession.TabIndex = 1;
            this.lblLastSession.Text = "Son seans: -";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = Color.White;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.lblUserName);
            this.panelMain.Controls.Add(this.btnSettings);
            this.panelMain.Controls.Add(this.btnClose);
            this.panelMain.Controls.Add(this.groupTimer);
            this.panelMain.Controls.Add(this.groupControls);
            this.panelMain.Controls.Add(this.groupSettings);
            this.panelMain.Controls.Add(this.groupStats);
            this.panelMain.Location = new Point(15, 15);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new Size(590, 470);
            this.panelMain.TabIndex = 8;
            // 
            // PomodoroTimerForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(253, 245, 243);
            this.ClientSize = new Size(620, 500);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PomodoroTimerForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "🍅 Pomodoro Timer";
            this.FormClosing += PomodoroTimerForm_FormClosing;
            this.Load += PomodoroTimerForm_Load;
            this.groupTimer.ResumeLayout(false);
            this.groupControls.ResumeLayout(false);
            this.groupControls.PerformLayout();
            this.groupSettings.ResumeLayout(false);
            this.groupSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakMinutes)).EndInit();
            this.groupStats.ResumeLayout(false);
            this.groupStats.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }

        private Label lblTitle;
        private Label lblUserName;
        private Label lblTimer;
        private Label lblSessionType;
        private Label lblSessionInfo;
        private ProgressBar progressBar;
        private ComboBox cmbHobby;
        private Label lblHobby;
        private Button btnStart;
        private Button btnPause;
        private Button btnReset;
        private Button btnSettings;
        private Button btnClose;
        private GroupBox groupTimer;
        private GroupBox groupControls;
        private GroupBox groupSettings;
        private Label lblWorkMinutes;
        private NumericUpDown numWorkMinutes;
        private Label lblBreakMinutes;
        private NumericUpDown numBreakMinutes;
        private CheckBox chkSound;
        private GroupBox groupStats;
        private Label lblTotalSessions;
        private Label lblLastSession;
        private Panel panelMain;
    }
}