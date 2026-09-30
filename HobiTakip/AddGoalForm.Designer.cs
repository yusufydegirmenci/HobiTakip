namespace HobiTakip
{
    partial class AddGoalForm
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
            this.lblGoalTitle = new Label();
            this.txtTitle = new TextBox();
            this.lblDescription = new Label();
            this.txtDescription = new TextBox();
            this.lblTargetValue = new Label();
            this.numTargetValue = new NumericUpDown();
            this.lblUnit = new Label();
            this.cmbUnit = new ComboBox();
            this.lblTargetDate = new Label();
            this.dtpTargetDate = new DateTimePicker();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.panelMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetValue)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(155, 89, 182);
            this.lblTitle.Location = new Point(120, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(160, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "YENİ HEDEF";
            // 
            // lblHobbyName
            // 
            this.lblHobbyName.AutoSize = true;
            this.lblHobbyName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblHobbyName.ForeColor = Color.FromArgb(46, 204, 113);
            this.lblHobbyName.Location = new Point(30, 65);
            this.lblHobbyName.Name = "lblHobbyName";
            this.lblHobbyName.Size = new Size(50, 21);
            this.lblHobbyName.TabIndex = 1;
            this.lblHobbyName.Text = "Hobi:";
            // 
            // lblGoalTitle
            // 
            this.lblGoalTitle.AutoSize = true;
            this.lblGoalTitle.Font = new Font("Segoe UI", 10F);
            this.lblGoalTitle.Location = new Point(30, 105);
            this.lblGoalTitle.Name = "lblGoalTitle";
            this.lblGoalTitle.Size = new Size(86, 19);
            this.lblGoalTitle.TabIndex = 2;
            this.lblGoalTitle.Text = "Hedef Başlığı:";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new Font("Segoe UI", 11F);
            this.txtTitle.Location = new Point(30, 130);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new Size(340, 27);
            this.txtTitle.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new Font("Segoe UI", 10F);
            this.lblDescription.Location = new Point(30, 170);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new Size(69, 19);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Açıklama:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new Font("Segoe UI", 10F);
            this.txtDescription.Location = new Point(30, 195);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new Size(340, 60);
            this.txtDescription.TabIndex = 5;
            // 
            // lblTargetValue
            // 
            this.lblTargetValue.AutoSize = true;
            this.lblTargetValue.Font = new Font("Segoe UI", 10F);
            this.lblTargetValue.Location = new Point(30, 275);
            this.lblTargetValue.Name = "lblTargetValue";
            this.lblTargetValue.Size = new Size(84, 19);
            this.lblTargetValue.TabIndex = 6;
            this.lblTargetValue.Text = "Hedef Değer:";
            // 
            // numTargetValue
            // 
            this.numTargetValue.Font = new Font("Segoe UI", 11F);
            this.numTargetValue.Location = new Point(30, 300);
            this.numTargetValue.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numTargetValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numTargetValue.Name = "numTargetValue";
            this.numTargetValue.Size = new Size(120, 27);
            this.numTargetValue.TabIndex = 7;
            this.numTargetValue.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new Font("Segoe UI", 10F);
            this.lblUnit.Location = new Point(180, 275);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new Size(40, 19);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "Birim:";
            // 
            // cmbUnit
            // 
            this.cmbUnit.Font = new Font("Segoe UI", 11F);
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new Point(180, 300);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new Size(190, 28);
            this.cmbUnit.TabIndex = 9;
            // 
            // lblTargetDate
            // 
            this.lblTargetDate.AutoSize = true;
            this.lblTargetDate.Font = new Font("Segoe UI", 10F);
            this.lblTargetDate.Location = new Point(30, 345);
            this.lblTargetDate.Name = "lblTargetDate";
            this.lblTargetDate.Size = new Size(82, 19);
            this.lblTargetDate.TabIndex = 10;
            this.lblTargetDate.Text = "Hedef Tarihi:";
            // 
            // dtpTargetDate
            // 
            this.dtpTargetDate.Font = new Font("Segoe UI", 11F);
            this.dtpTargetDate.Format = DateTimePickerFormat.Short;
            this.dtpTargetDate.Location = new Point(30, 370);
            this.dtpTargetDate.Name = "dtpTargetDate";
            this.dtpTargetDate.Size = new Size(150, 27);
            this.dtpTargetDate.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = Color.FromArgb(155, 89, 182);
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
            this.panelMain.Controls.Add(this.lblHobbyName);
            this.panelMain.Controls.Add(this.btnSave);
            this.panelMain.Controls.Add(this.lblGoalTitle);
            this.panelMain.Controls.Add(this.dtpTargetDate);
            this.panelMain.Controls.Add(this.txtTitle);
            this.panelMain.Controls.Add(this.lblTargetDate);
            this.panelMain.Controls.Add(this.lblDescription);
            this.panelMain.Controls.Add(this.cmbUnit);
            this.panelMain.Controls.Add(this.txtDescription);
            this.panelMain.Controls.Add(this.lblUnit);
            this.panelMain.Controls.Add(this.lblTargetValue);
            this.panelMain.Controls.Add(this.numTargetValue);
            this.panelMain.Location = new Point(30, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new Size(400, 480);
            this.panelMain.TabIndex = 14;
            // 
            // AddGoalForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(460, 540);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGoalForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Yeni Hedef Ekle";
            this.Load += AddGoalForm_Load;
            ((System.ComponentModel.ISupportInitialize)(this.numTargetValue)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }

        private Label lblTitle;
        private Label lblHobbyName;
        private Label lblGoalTitle;
        private TextBox txtTitle;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblTargetValue;
        private NumericUpDown numTargetValue;
        private Label lblUnit;
        private ComboBox cmbUnit;
        private Label lblTargetDate;
        private DateTimePicker dtpTargetDate;
        private Button btnSave;
        private Button btnCancel;
        private Panel panelMain;
    }
}