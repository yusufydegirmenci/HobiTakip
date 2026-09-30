namespace HobiTakip
{
    partial class AddHobbyForm
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
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblDescription = new Label();
            this.txtDescription = new TextBox();
            this.lblCategory = new Label();
            this.cmbCategory = new ComboBox();
            this.lblDifficulty = new Label();
            this.cmbDifficulty = new ComboBox();
            this.lblStartDate = new Label();
            this.dtpStartDate = new DateTimePicker();
            this.chkIsActive = new CheckBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.panelMain = new Panel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblTitle.Location = new Point(140, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(120, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "YENİ HOBİ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new Font("Segoe UI", 10F);
            this.lblName.Location = new Point(30, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new Size(61, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Hobi Adı:";
            // 
            // txtName
            // 
            this.txtName.Font = new Font("Segoe UI", 11F);
            this.txtName.Location = new Point(30, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(340, 27);
            this.txtName.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new Font("Segoe UI", 10F);
            this.lblDescription.Location = new Point(30, 135);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new Size(69, 19);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Açıklama:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new Font("Segoe UI", 10F);
            this.txtDescription.Location = new Point(30, 160);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new Size(340, 60);
            this.txtDescription.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new Font("Segoe UI", 10F);
            this.lblCategory.Location = new Point(30, 235);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new Size(63, 19);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Kategori:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new Font("Segoe UI", 11F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new Point(30, 260);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new Size(340, 28);
            this.cmbCategory.TabIndex = 6;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new Font("Segoe UI", 10F);
            this.lblDifficulty.Location = new Point(30, 305);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new Size(102, 19);
            this.lblDifficulty.TabIndex = 7;
            this.lblDifficulty.Text = "Zorluk Seviyesi:";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDifficulty.Font = new Font("Segoe UI", 11F);
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Location = new Point(30, 330);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new Size(160, 28);
            this.cmbDifficulty.TabIndex = 8;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new Font("Segoe UI", 10F);
            this.lblStartDate.Location = new Point(210, 305);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new Size(103, 19);
            this.lblStartDate.TabIndex = 9;
            this.lblStartDate.Text = "Başlangıç Tarihi:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new Font("Segoe UI", 11F);
            this.dtpStartDate.Format = DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new Point(210, 330);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new Size(160, 27);
            this.dtpStartDate.TabIndex = 10;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = CheckState.Checked;
            this.chkIsActive.Font = new Font("Segoe UI", 10F);
            this.chkIsActive.Location = new Point(30, 380);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new Size(116, 23);
            this.chkIsActive.TabIndex = 11;
            this.chkIsActive.Text = "Aktif Hobi";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = Color.FromArgb(46, 204, 113);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.Location = new Point(30, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(160, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new Font("Segoe UI", 11F);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.Location = new Point(210, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(160, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "İPTAL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += btnCancel_Click;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = Color.White;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.btnCancel);
            this.panelMain.Controls.Add(this.lblName);
            this.panelMain.Controls.Add(this.btnSave);
            this.panelMain.Controls.Add(this.txtName);
            this.panelMain.Controls.Add(this.chkIsActive);
            this.panelMain.Controls.Add(this.lblDescription);
            this.panelMain.Controls.Add(this.dtpStartDate);
            this.panelMain.Controls.Add(this.txtDescription);
            this.panelMain.Controls.Add(this.lblStartDate);
            this.panelMain.Controls.Add(this.lblCategory);
            this.panelMain.Controls.Add(this.cmbDifficulty);
            this.panelMain.Controls.Add(this.cmbCategory);
            this.panelMain.Controls.Add(this.lblDifficulty);
            this.panelMain.Location = new Point(30, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new Size(400, 480);
            this.panelMain.TabIndex = 14;
            // 
            // AddHobbyForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(460, 540);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddHobbyForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Yeni Hobi Ekle";
            this.Load += AddHobbyForm_Load;
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }

        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblDifficulty;
        private ComboBox cmbDifficulty;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private CheckBox chkIsActive;
        private Button btnSave;
        private Button btnCancel;
        private Panel panelMain;
    }
}