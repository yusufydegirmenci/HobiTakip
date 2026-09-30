#if true // Chart kütüphanesi sorunu çıkarırsa false yapın
using System.Windows.Forms.DataVisualization.Charting;

namespace HobiTakip
{
    partial class ChartForm
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
            this.cmbChartType = new ComboBox();
            this.lblChartType = new Label();
            this.chart = new Chart();
            this.btnRefresh = new Button();
            this.btnExport = new Button();
            this.btnClose = new Button();
            this.panelTop = new Panel();
            this.panelBottom = new Panel();
            this.panelControls = new Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(52, 152, 219);
            this.lblTitle.Location = new Point(15, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(190, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📊 GÖRSEL RAPORLAR";
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
            this.lblUserName.Text = "📊 Kullanıcının Raporları";
            // 
            // lblChartType
            // 
            this.lblChartType.AutoSize = true;
            this.lblChartType.Font = new Font("Segoe UI", 10F);
            this.lblChartType.Location = new Point(15, 15);
            this.lblChartType.Name = "lblChartType";
            this.lblChartType.Size = new Size(71, 19);
            this.lblChartType.TabIndex = 2;
            this.lblChartType.Text = "Grafik Türü:";
            // 
            // cmbChartType
            // 
            this.cmbChartType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbChartType.Font = new Font("Segoe UI", 11F);
            this.cmbChartType.FormattingEnabled = true;
            this.cmbChartType.Location = new Point(15, 40);
            this.cmbChartType.Name = "cmbChartType";
            this.cmbChartType.Size = new Size(300, 28);
            this.cmbChartType.TabIndex = 3;
            this.cmbChartType.SelectedIndexChanged += cmbChartType_SelectedIndexChanged;
            // 
            // chart
            // 
            this.chart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.chart.BackColor = Color.White;
            this.chart.BorderlineColor = Color.Gray;
            this.chart.BorderlineDashStyle = ChartDashStyle.Solid;
            this.chart.BorderlineWidth = 1;
            this.chart.Location = new Point(15, 180);
            this.chart.Name = "chart";
            this.chart.Size = new Size(970, 450);
            this.chart.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.Location = new Point(15, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(100, 40);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "🔄 Yenile";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = Color.FromArgb(155, 89, 182);
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = FlatStyle.Flat;
            this.btnExport.Font = new Font("Segoe UI", 10F);
            this.btnExport.ForeColor = Color.White;
            this.btnExport.Location = new Point(125, 15);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new Size(120, 40);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "📤 Grafik Kaydet";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += btnExport_Click;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnClose.BackColor = Color.FromArgb(95, 39, 205);
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.Font = new Font("Segoe UI", 10F);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.Location = new Point(885, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(100, 40);
            this.btnClose.TabIndex = 7;
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
            this.panelTop.Size = new Size(1000, 90);
            this.panelTop.TabIndex = 8;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = Color.White;
            this.panelBottom.Controls.Add(this.btnRefresh);
            this.panelBottom.Controls.Add(this.btnExport);
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Dock = DockStyle.Bottom;
            this.panelBottom.Location = new Point(0, 650);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new Size(1000, 70);
            this.panelBottom.TabIndex = 9;
            // 
            // panelControls
            // 
            this.panelControls.BackColor = Color.White;
            this.panelControls.Controls.Add(this.lblChartType);
            this.panelControls.Controls.Add(this.cmbChartType);
            this.panelControls.Dock = DockStyle.Top;
            this.panelControls.Location = new Point(0, 90);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new Size(1000, 80);
            this.panelControls.TabIndex = 10;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(1000, 720);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new Size(1000, 720);
            this.Name = "ChartForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Görsel Raporlar";
            this.WindowState = FormWindowState.Maximized;
            this.Load += ChartForm_Load;
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);
        }

        private Label lblTitle;
        private Label lblUserName;
        private ComboBox cmbChartType;
        private Label lblChartType;
        private Chart chart;
        private Button btnRefresh;
        private Button btnExport;
        private Button btnClose;
        private Panel panelTop;
        private Panel panelBottom;
        private Panel panelControls;
    }
}
#endif // Chart kütüphanesi için geçici devre dışı