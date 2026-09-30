namespace HobiTakip
{
    partial class AddProgressForm
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
            this.lblDate = new Label();
            this.dtpDate = new DateTimePicker();
            this.lblTimeSpent = new Label();
            this.numTimeSpent = new NumericUpDown();
            this.lblMinutes = new Label();
            this.lblGoal = new Label();
            this.cmbGoal = new ComboBox();
            this.lblValue = new Label();
            this.numValue = new NumericUpDown();
            this.lblUnit = new Label();
            this.txtUnit = new TextBox();
            this.lblUnitHint = new Label();
            this.lblNotes = new Label();
            this.txtNotes = new TextBox();
            this.lblRating = new Label();
            this.cmbRating = new ComboBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.panelMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeSpent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(41, 128, 185);
            this.lblTitle.Location = new Point(120, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(160, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "İLERLEME EKLE";
            // 
            // lblHobbyName
            // 
            this.lblHobbyName.AutoSize = true;
            this.lblHobbyName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblHobbyName.ForeColor = Color.FromArgb(46, 204, 113);
            this.lblHobbyName.Location = new Point(30, 55);
            this.lblHobbyName.Name = "lblHobbyName";
            this.lblHobbyName.Size = new Size(50, 21);
            this.lblHobbyName.TabIndex = 1;
            this.lblHobbyName.Text = "Hobi:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new Font("Segoe UI", 10F);
            this.lblDate.Location = new Point(30, 90);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new Size(38, 19);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Tarih:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new Font("Segoe UI", 10F);
            this.dtpDate.Format = DateTimePickerFormat.Short;
            this.dtpDate.Location = new Point(30, 115);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new Size(150, 25);
            this.dtpDate.TabIndex = 3;
            // 
            // lblTimeSpent
            // 
            this.lblTimeSpent.AutoSize = true;
            this.lblTimeSpent.Font = new Font("Segoe UI", 10F);
            this.lblTimeSpent.Location = new Point(220, 90);
            this.lblTimeSpent.Name = "lblTimeSpent";
            this.lblTimeSpent.Size = new Size(93, 19);
            this.lblTimeSpent.TabIndex = 4;
            this.lblTimeSpent.Text = "Geçirilen Süre:";
            // 
            // numTimeSpent
            // 
            this.numTimeSpent.Font = new Font("Segoe UI", 10F);
            this.numTimeSpent.Location = new Point(220, 115);
            this.numTimeSpent.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            this.numTimeSpent.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numTimeSpent.Name = "numTimeSpent";
            this.numTimeSpent.Size = new Size(80, 25);
            this.numTimeSpent.TabIndex = 5;
            this.numTimeSpent.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new Font("Segoe UI", 10F);
            this.lblMinutes.Location = new Point(310, 117);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new Size(48, 19);
            this.lblMinutes.TabIndex = 6;
            this.lblMinutes.Text = "dakika";
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Font = new Font("Segoe UI", 10F);
            this.lblGoal.Location = new Point(30, 160);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new Size(44, 19);
            this.lblGoal.TabIndex = 7;
            this.lblGoal.Text = "Hedef:";
            // 
            // cmbGoal
            // 
            this.cmbGoal.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbGoal.Font = new Font("Segoe UI", 10F);
            this.cmbGoal.FormattingEnabled = true;
            this.cmbGoal.Location = new Point(30, 185);
            this.cmbGoal.Name = "cmbGoal";
            this.cmbGoal.Size = new Size(340, 25);
            this.cmbGoal.TabIndex = 8;
            this.cmbGoal.SelectedIndexChanged += cmbGoal_SelectedIndexChanged;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new Font("Segoe UI", 10F);
            this.lblValue.Location = new Point(30, 230);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new Size(73, 19);
            this.lblValue.TabIndex = 9;
            this.lblValue.Text = "Yapılan İş:";
            // 
            // numValue
            // 
            this.numValue.Font = new Font("Segoe UI", 10F);
            this.numValue.Location = new Point(30, 255);
            this.numValue.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numValue.Name = "numValue";
            this.numValue.Size = new Size(100, 25);
            this.numValue.TabIndex = 10;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new Font("Segoe UI", 10F);
            this.lblUnit.Location = new Point(160, 230);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new Size(40, 19);
            this.lblUnit.TabIndex = 11;
            this.lblUnit.Text = "Birim:";
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new Font("Segoe UI", 10F);
            this.txtUnit.Location = new Point(160, 255);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new Size(100, 25);
            this.txtUnit.TabIndex = 12;
            // 
            // lblUnitHint
            // 
            this.lblUnitHint.AutoSize = true;
            this.lblUnitHint.Font = new Font("Segoe UI", 8F);
            this.lblUnitHint.ForeColor = Color.Gray;
            this.lblUnitHint.Location = new Point(280, 260);
            this.lblUnitHint.Name = "lblUnitHint";
            this.lblUnitHint.Size = new Size(0, 13);
            this.lblUnitHint.TabIndex = 13;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new Font("Segoe UI", 10F);
            this.lblNotes.Location = new Point(30, 300);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new Size(51, 19);
            this.lblNotes.TabIndex = 14;
            this.lblNotes.Text = "Notlar:";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new Font("Segoe UI", 10F);
            this.txtNotes.Location = new Point(30, 325);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new Size(340, 60);
            this.txtNotes.TabIndex = 15;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new Font("Segoe UI", 10F);
            this.lblRating.Location = new Point(30, 400);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new Size(90, 19);
            this.lblRating.TabIndex = 16;
            this.lblRating.Text = "Değerlendirme:";
            // 
            // cmbRating
            // 
            this.cmbRating.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRating.Font = new Font("Segoe UI", 10F);
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Location = new Point(30, 425);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new Size(200, 25);
            this.cmbRating.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = Color.FromArgb(46, 204, 113);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.Location = new Point(30, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(160, 40);
            this.btnSave.TabIndex = 18;
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
            this.btnCancel.Location = new Point(210, 470);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(160, 40);
            this.btnCancel.TabIndex = 19;
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
            this.panelMain.Controls.Add(this.lblDate);
            this.panelMain.Controls.Add(this.cmbRating);
            this.panelMain.Controls.Add(this.dtpDate);
            this.panelMain.Controls.Add(this.lblRating);
            this.panelMain.Controls.Add(this.lblTimeSpent);
            this.panelMain.Controls.Add(this.txtNotes);
            this.panelMain.Controls.Add(this.numTimeSpent);
            this.panelMain.Controls.Add(this.lblNotes);
            this.panelMain.Controls.Add(this.lblMinutes);
            this.panelMain.Controls.Add(this.lblUnitHint);
            this.panelMain.Controls.Add(this.lblGoal);
            this.panelMain.Controls.Add(this.txtUnit);
            this.panelMain.Controls.Add(this.cmbGoal);
            this.panelMain.Controls.Add(this.lblUnit);
            this.panelMain.Controls.Add(this.lblValue);
            this.panelMain.Controls.Add(this.numValue);
            this.panelMain.Location = new Point(30, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new Size(400, 530);
            this.panelMain.TabIndex = 20;
            // 
            // AddProgressForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(460, 590);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProgressForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "İlerleme Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.numTimeSpent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }

        private Label lblTitle;
        private Label lblHobbyName;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblTimeSpent;
        private NumericUpDown numTimeSpent;
        private Label lblMinutes;
        private Label lblGoal;
        private ComboBox cmbGoal;
        private Label lblValue;
        private NumericUpDown numValue;
        private Label lblUnit;
        private TextBox txtUnit;
        private Label lblUnitHint;
        private Label lblNotes;
        private TextBox txtNotes;
        private Label lblRating;
        private ComboBox cmbRating;
        private Button btnSave;
        private Button btnCancel;
        private Panel panelMain;
    }
}