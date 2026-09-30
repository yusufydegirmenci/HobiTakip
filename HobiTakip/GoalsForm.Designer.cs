namespace HobiTakip
{
    partial class GoalsForm
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
            this.listGoals = new ListView();
            this.colTitle = new ColumnHeader();
            this.colTargetDate = new ColumnHeader();
            this.colProgress = new ColumnHeader();
            this.colPercentage = new ColumnHeader();
            this.colStatus = new ColumnHeader();
            this.btnAddGoal = new Button();
            this.btnClose = new Button();
            this.lblStats = new Label();
            this.panelTop = new Panel();
            this.panelBottom = new Panel();
            this.lblLegend = new Label();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(155, 89, 182);
            this.lblTitle.Location = new Point(15, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(110, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HEDEFLER";
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
            // listGoals
            // 
            this.listGoals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.listGoals.Columns.AddRange(new ColumnHeader[] { colTitle, colTargetDate, colProgress, colPercentage, colStatus });
            this.listGoals.FullRowSelect = true;
            this.listGoals.GridLines = true;
            this.listGoals.Location = new Point(15, 110);
            this.listGoals.Name = "listGoals";
            this.listGoals.Size = new Size(770, 350);
            this.listGoals.TabIndex = 2;
            this.listGoals.UseCompatibleStateImageBehavior = false;
            this.listGoals.View = View.Details;
            this.listGoals.DoubleClick += listGoals_DoubleClick;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Hedef Başlığı";
            this.colTitle.Width = 200;
            // 
            // colTargetDate
            // 
            this.colTargetDate.Text = "Hedef Tarihi";
            this.colTargetDate.Width = 100;
            // 
            // colProgress
            // 
            this.colProgress.Text = "İlerleme";
            this.colProgress.Width = 150;
            // 
            // colPercentage
            // 
            this.colPercentage.Text = "Yüzde";
            this.colPercentage.Width = 80;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Durum";
            this.colStatus.Width = 120;
            // 
            // btnAddGoal
            // 
            this.btnAddGoal.BackColor = Color.FromArgb(155, 89, 182);
            this.btnAddGoal.FlatAppearance.BorderSize = 0;
            this.btnAddGoal.FlatStyle = FlatStyle.Flat;
            this.btnAddGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnAddGoal.ForeColor = Color.White;
            this.btnAddGoal.Location = new Point(15, 15);
            this.btnAddGoal.Name = "btnAddGoal";
            this.btnAddGoal.Size = new Size(120, 40);
            this.btnAddGoal.TabIndex = 3;
            this.btnAddGoal.Text = "Yeni Hedef";
            this.btnAddGoal.UseVisualStyleBackColor = false;
            this.btnAddGoal.Click += btnAddGoal_Click;
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
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += btnClose_Click;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblStats.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblStats.Location = new Point(155, 25);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new Size(200, 19);
            this.lblStats.TabIndex = 5;
            this.lblStats.Text = "Toplam: 0 | Tamamlanan: 0";
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
            this.panelTop.TabIndex = 6;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = Color.White;
            this.panelBottom.Controls.Add(this.btnAddGoal);
            this.panelBottom.Controls.Add(this.lblStats);
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Dock = DockStyle.Bottom;
            this.panelBottom.Location = new Point(0, 480);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new Size(800, 70);
            this.panelBottom.TabIndex = 7;
            // 
            // lblLegend
            // 
            this.lblLegend.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.lblLegend.AutoSize = true;
            this.lblLegend.Font = new Font("Segoe UI", 8F);
            this.lblLegend.ForeColor = Color.Gray;
            this.lblLegend.Location = new Point(15, 465);
            this.lblLegend.Name = "lblLegend";
            this.lblLegend.Size = new Size(400, 13);
            this.lblLegend.TabIndex = 8;
            this.lblLegend.Text = "Renk Kodları: Yeşil=Tamamlandı, Kırmızı=Süresi Geçti, Mavi=Hedefe Yakın";
            // 
            // GoalsForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(800, 550);
            this.Controls.Add(this.lblLegend);
            this.Controls.Add(this.listGoals);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new Size(800, 550);
            this.Name = "GoalsForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Hedefler";
            this.Load += GoalsForm_Load;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitle;
        private Label lblHobbyName;
        private ListView listGoals;
        private ColumnHeader colTitle;
        private ColumnHeader colTargetDate;
        private ColumnHeader colProgress;
        private ColumnHeader colPercentage;
        private ColumnHeader colStatus;
        private Button btnAddGoal;
        private Button btnClose;
        private Label lblStats;
        private Panel panelTop;
        private Panel panelBottom;
        private Label lblLegend;
    }
}