namespace HobiTakip
{
    partial class NotificationWindow
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
            this.lblMessage = new Label();
            this.panelMain = new Panel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblTitle.Location = new Point(15, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(150, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bildirim Başlığı";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new Font("Segoe UI", 10F);
            this.lblMessage.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblMessage.Location = new Point(15, 35);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new Size(310, 60);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Bildirim mesajı buraya gelecek...";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = Color.White;
            this.panelMain.BorderStyle = BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.lblMessage);
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Location = new Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new Size(350, 120);
            this.panelMain.TabIndex = 2;
            this.panelMain.Click += NotificationWindow_Click;
            // 
            // NotificationWindow
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(350, 120);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "NotificationWindow";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Click += NotificationWindow_Click;
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }

        private Label lblTitle;
        private Label lblMessage;
        private Panel panelMain;
    }
}