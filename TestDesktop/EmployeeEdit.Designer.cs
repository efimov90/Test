namespace TestDesktop
{
    partial class EmployeeEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstName = new System.Windows.Forms.Label();
            this.TBFirstName = new System.Windows.Forms.TextBox();
            this.TBLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.TBMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.TBDapartment = new System.Windows.Forms.TextBox();
            this.lblDapartment = new System.Windows.Forms.Label();
            this.TBAbout = new System.Windows.Forms.TextBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.GBAddress = new System.Windows.Forms.GroupBox();
            this.TBPostalCode = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.TBStreetAddress = new System.Windows.Forms.TextBox();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.TBRegion = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.TBCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.GBAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 9);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Имя";
            // 
            // TBFirstName
            // 
            this.TBFirstName.Location = new System.Drawing.Point(108, 6);
            this.TBFirstName.Name = "TBFirstName";
            this.TBFirstName.Size = new System.Drawing.Size(280, 20);
            this.TBFirstName.TabIndex = 1;
            // 
            // TBLastName
            // 
            this.TBLastName.Location = new System.Drawing.Point(108, 32);
            this.TBLastName.Name = "TBLastName";
            this.TBLastName.Size = new System.Drawing.Size(280, 20);
            this.TBLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 35);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Фамилия";
            // 
            // TBMiddleName
            // 
            this.TBMiddleName.Location = new System.Drawing.Point(108, 58);
            this.TBMiddleName.Name = "TBMiddleName";
            this.TBMiddleName.Size = new System.Drawing.Size(280, 20);
            this.TBMiddleName.TabIndex = 5;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(12, 61);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(54, 13);
            this.lblMiddleName.TabIndex = 4;
            this.lblMiddleName.Text = "Отчество";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(12, 93);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(86, 13);
            this.lblDateOfBirth.TabIndex = 6;
            this.lblDateOfBirth.Text = "Дата рождения";
            // 
            // TBDapartment
            // 
            this.TBDapartment.Location = new System.Drawing.Point(108, 263);
            this.TBDapartment.Name = "TBDapartment";
            this.TBDapartment.Size = new System.Drawing.Size(280, 20);
            this.TBDapartment.TabIndex = 9;
            // 
            // lblDapartment
            // 
            this.lblDapartment.AutoSize = true;
            this.lblDapartment.Location = new System.Drawing.Point(12, 266);
            this.lblDapartment.Name = "lblDapartment";
            this.lblDapartment.Size = new System.Drawing.Size(38, 13);
            this.lblDapartment.TabIndex = 8;
            this.lblDapartment.Text = "Отдел";
            // 
            // TBAbout
            // 
            this.TBAbout.Location = new System.Drawing.Point(108, 289);
            this.TBAbout.Name = "TBAbout";
            this.TBAbout.Size = new System.Drawing.Size(280, 20);
            this.TBAbout.TabIndex = 11;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(12, 292);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(42, 13);
            this.lblAbout.TabIndex = 10;
            this.lblAbout.Text = "О себе";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(108, 87);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(280, 20);
            this.dtpDateOfBirth.TabIndex = 12;
            // 
            // GBAddress
            // 
            this.GBAddress.Controls.Add(this.TBPostalCode);
            this.GBAddress.Controls.Add(this.lblPostalCode);
            this.GBAddress.Controls.Add(this.TBStreetAddress);
            this.GBAddress.Controls.Add(this.lblStreetAddress);
            this.GBAddress.Controls.Add(this.TBCity);
            this.GBAddress.Controls.Add(this.lblCity);
            this.GBAddress.Controls.Add(this.TBRegion);
            this.GBAddress.Controls.Add(this.lblRegion);
            this.GBAddress.Controls.Add(this.TBCountry);
            this.GBAddress.Controls.Add(this.lblCountry);
            this.GBAddress.Location = new System.Drawing.Point(12, 113);
            this.GBAddress.Name = "GBAddress";
            this.GBAddress.Size = new System.Drawing.Size(376, 142);
            this.GBAddress.TabIndex = 13;
            this.GBAddress.TabStop = false;
            this.GBAddress.Text = "Адрес проживания";
            // 
            // TBPostalCode
            // 
            this.TBPostalCode.Location = new System.Drawing.Point(90, 116);
            this.TBPostalCode.Name = "TBPostalCode";
            this.TBPostalCode.Size = new System.Drawing.Size(280, 20);
            this.TBPostalCode.TabIndex = 21;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(6, 119);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(45, 13);
            this.lblPostalCode.TabIndex = 20;
            this.lblPostalCode.Text = "Индекс";
            // 
            // TBStreetAddress
            // 
            this.TBStreetAddress.Location = new System.Drawing.Point(90, 91);
            this.TBStreetAddress.Name = "TBStreetAddress";
            this.TBStreetAddress.Size = new System.Drawing.Size(280, 20);
            this.TBStreetAddress.TabIndex = 19;
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(6, 94);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(38, 13);
            this.lblStreetAddress.TabIndex = 18;
            this.lblStreetAddress.Text = "Адрес";
            // 
            // TBCity
            // 
            this.TBCity.Location = new System.Drawing.Point(90, 65);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(280, 20);
            this.TBCity.TabIndex = 17;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 68);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(37, 13);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "Город";
            // 
            // TBRegion
            // 
            this.TBRegion.Location = new System.Drawing.Point(90, 39);
            this.TBRegion.Name = "TBRegion";
            this.TBRegion.Size = new System.Drawing.Size(280, 20);
            this.TBRegion.TabIndex = 15;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(6, 42);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(43, 13);
            this.lblRegion.TabIndex = 14;
            this.lblRegion.Text = "Регион";
            // 
            // TBCountry
            // 
            this.TBCountry.Location = new System.Drawing.Point(90, 13);
            this.TBCountry.Name = "TBCountry";
            this.TBCountry.Size = new System.Drawing.Size(280, 20);
            this.TBCountry.TabIndex = 13;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(6, 16);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 12;
            this.lblCountry.Text = "Страна";
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Location = new System.Drawing.Point(307, 415);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Сохранить";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(226, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // EmployeeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.GBAddress);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.TBAbout);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.TBDapartment);
            this.Controls.Add(this.lblDapartment);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.TBMiddleName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.TBLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.TBFirstName);
            this.Controls.Add(this.lblFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EmployeeEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создать сотрудника";
            this.GBAddress.ResumeLayout(false);
            this.GBAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox TBFirstName;
        private System.Windows.Forms.TextBox TBLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox TBMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox TBDapartment;
        private System.Windows.Forms.Label lblDapartment;
        private System.Windows.Forms.TextBox TBAbout;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.GroupBox GBAddress;
        private System.Windows.Forms.TextBox TBPostalCode;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox TBStreetAddress;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox TBRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox TBCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}