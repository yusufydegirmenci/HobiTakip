namespace HobiTakip
{
    partial class GoalDetailsForm
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
            this.lblDescription = new Label();
            this.lblTargetValue = new Label();
            this.lblCurrentValue = new Label();
            this.lblTargetDate = new Label();
            this.lblCreatedDate = new Label();
            this.lblRemainingTime = new Label();
            this.progressBar = new ProgressBar();
            this.lblProgress = new Label();
            this.lblStatus = new Label();
            this.lblCompletedDate = new Label();
            this.btnMarkCompleted = new Button();
            this.btnClose = new Button();
            this.panelMain = new Panel();
            this.groupProgress = new GroupBox();
            this.groupInfo = new GroupBox();
            this.panelMain.SuspendLayout();
            this.groupProgress.SuspendLayout();
            this.groupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(155, 89, 182);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(460, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hedef Başlığı";
            this.lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new Font("Segoe UI", 10F);
            this.lblDescription.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblDescription.Location = new Point(15, 25);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new Size(420, 40);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Hedef açıklaması";
            // 
            // lblTargetValue
            // 
            this.lblTargetValue.AutoSize = true;
            this.lblTargetValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblTargetValue.Location = new Point(15, 75);
            this.lblTargetValue.Name = "lblTargetValue";
            this.lblTargetValue.Size = new Size(100, 20);
            this.lblTargetValue.TabIndex = 2;
            this.lblTargetValue.Text = "Hedef: 100 sayfa";
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.AutoSize = true;
            this.lblCurrentValue.Font = new Font("Segoe UI", 11F);
            this.lblCurrentValue.Location = new Point(15, 105);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new Size(110, 20);
            this.lblCurrentValue.TabIndex = 3;
            this.lblCurrentValue.Text = "Mevcut: 50 sayfa";
            // 
            // lblTargetDate
            // 
            this.lblTargetDate.AutoSize = true;
            this.lblTargetDate.Font = new Font("Segoe UI", 10F);
            this.lblTargetDate.Location = new Point(15, 135);
            this.lblTargetDate.Name = "lblTargetDate";
            this.lblTargetDate.Size = new Size(130, 19);
            this.lblTargetDate.TabIndex = 4;
            this.lblTargetDate.Text = "Hedef Tarihi: 01.01.2025";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new Font("Segoe UI", 10F);
            this.lblCreatedDate.Location = new Point(15, 160);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new Size(140, 19);
            this.lblCreatedDate.TabIndex = 5;
            this.lblCreatedDate.Text = "Oluşturulma: 01.12.2024";
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblRemainingTime.Location = new Point(250, 135);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new Size(120, 20);
            this.lblRemainingTime.TabIndex = 6;
            this.lblRemainingTime.Text = "Kalan Süre: 30 gün";
            // 
            // progressBar
            // 
            this.progressBar.Location = new Point(15, 30);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new Size(420, 25);
            this.progressBar.TabIndex = 7;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblProgress.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblProgress.Location = new Point(15, 65);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new Size(120, 20);
            this.lblProgress.TabIndex = 8;
            this.lblProgress.Text = "50% Tamamlandı";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblStatus.Location = new Point(300, 65);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(150, 25);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "DEVAM EDİYOR";
            // 
            // lblCompletedDate
            // 
            this.lblCompletedDate.AutoSize = true;
            this.lblCompletedDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblCompletedDate.ForeColor = Color.FromArgb(46, 204, 113);
            this.lblCompletedDate.Location = new Point(250, 160);
            this.lblCompletedDate.Name = "lblCompletedDate";
            this.lblCompletedDate.Size = new Size(150, 19);
            this.lblCompletedDate.TabIndex = 10;
            this.lblCompletedDate.Text = "Tamamlanma: 15.01.2025";
            this.lblCompletedDate.Visible = false;
            // 
            // btnMarkCompleted
            // 
            this.btnMarkCompleted.BackColor = Color.FromArgb(46, 204, 113);
            this.btnMarkCompleted.FlatAppearance.BorderSize = 0;
            this.btnMarkCompleted.FlatStyle = FlatStyle.Flat;
            this.btnMarkCompleted.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnMarkCompleted.ForeColor = Color.White;
            this.btnMarkCompleted.Location = new Point(30, 450);
            this.btnMarkCompleted.Name = "btnMarkCompleted";
            this.btnMarkCompleted.Size = new Size(180, 40);
            this.btnMarkCompleted.TabIndex = 11;
            this.btnMarkCompleted.Text = "TAMAMLANDI OLARAK İŞARETLE";
            this.btnMarkCompleted.UseVisualStyleBackColor = false;
            this.btnMarkCompleted.Click += btnMarkCompleted_Click;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = Color.FromArgb(95, 39, 205);
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.Font = new Font("Segoe UI", 11F);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.Location = new Point(290, 450);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(160, 40);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "KAPAT";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += btnClose_Click;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = Color.White;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.btnClose);
            this.panelMain.Controls.Add(this.groupInfo);
            this.panelMain.Controls.Add(this.btnMarkCompleted);
            this.panelMain.Controls.Add(this.groupProgress);
            this.panelMain.Location = new Point(20, 20);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new Size(480, 510);
            this.panelMain.TabIndex = 13;
            // 
            // groupProgress
            // 
            this.groupProgress.Controls.Add(this.progressBar);
            this.groupProgress.Controls.Add(this.lblProgress);
            this.groupProgress.Controls.Add(this.lblStatus);
            this.groupProgress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupProgress.ForeColor = Color.FromArgb(52, 73, 94);
            this.groupProgress.Location = new Point(20, 320);
            this.groupProgress.Name = "groupProgress";
            this.groupProgress.Size = new Size(450, 100);
            this.groupProgress.TabIndex = 14;
            this.groupProgress.TabStop = false;
            this.groupProgress.Text = "İlerleme Durumu";
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.lblDescription);
            this.groupInfo.Controls.Add(this.lblTargetValue);
            this.groupInfo.Controls.Add(this.lblCompletedDate);
            this.groupInfo.Controls.Add(this.lblCurrentValue);
            this.groupInfo.Controls.Add(this.lblRemainingTime);
            this.groupInfo.Controls.Add(this.lblTargetDate);
            this.groupInfo.Controls.Add(this.lblCreatedDate);
            this.groupInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupInfo.ForeColor = Color.FromArgb(52, 73, 94);
            this.groupInfo.Location = new Point(20, 90);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new Size(450, 210);
            this.groupInfo.TabIndex = 15;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Hedef Bilgileri";
            // 
            // GoalDetailsForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(520, 550);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoalDetailsForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Hedef Detayı";
            this.Load += GoalDetailsForm_Load;
            this.panelMain.ResumeLayout(false);
            this.groupProgress.ResumeLayout(false);
            this.groupProgress.PerformLayout();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.ResumeLayout(false);
        }

        private Label lblTitle;
        private Label lblDescription;
        private Label lblTargetValue;
        private Label lblCurrentValue;
        private Label lblTargetDate;
        private Label lblCreatedDate;
        private Label lblRemainingTime;
        private ProgressBar progressBar;
        private Label lblProgress;
        private Label lblStatus;
        private Label lblCompletedDate;
        private Button btnMarkCompleted;
        private Button btnClose;
        private Panel panelMain;
        private GroupBox groupProgress;
        private GroupBox groupInfo;
    }
}