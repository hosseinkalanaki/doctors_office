namespace MyApplication
{
    partial class RegisterPatientForm
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
            this.typeOfDiseaseLabel = new Hkx.Windows.Form.Label();
            this.typeOfDiseaseTextBox = new Hkx.Windows.Form.TextBox();
            this.registerButton = new Hkx.Windows.Form.Button2();
            this.resetButton = new Hkx.Windows.Form.Button2();
            this.exitButton = new Hkx.Windows.Form.Button2();
            this.completedGroupBox = new Hkx.Windows.Form.GroupBox();
            this.addressLabel = new Hkx.Windows.Form.Label();
            this.PhoneLabel = new Hkx.Windows.Form.Label();
            this.mobileLabel = new Hkx.Windows.Form.Label();
            this.descriptionTextBox = new Hkx.Windows.Form.TextBox();
            this.postalCodeLabel = new Hkx.Windows.Form.Label();
            this.postalCodeTextBox = new Hkx.Windows.Form.TextBox();
            this.descriptionLabel = new Hkx.Windows.Form.Label();
            this.mobileTextBox = new Hkx.Windows.Form.TextBox();
            this.addressTextBox = new Hkx.Windows.Form.TextBox();
            this.phoneTextBox = new Hkx.Windows.Form.TextBox();
            this.personGroupBox = new Hkx.Windows.Form.GroupBox();
            this.singleCheckBox = new Hkx.Windows.Form.CheckBox();
            this.marridCheckBox = new Hkx.Windows.Form.CheckBox();
            this.firstNameTextBox = new Hkx.Windows.Form.TextBox();
            this.firtNameLabel = new Hkx.Windows.Form.Label();
            this.lastNameLabel = new Hkx.Windows.Form.Label();
            this.lastNameTextBox = new Hkx.Windows.Form.TextBox();
            this.genderLabel = new Hkx.Windows.Form.Label();
            this.ageLabel = new Hkx.Windows.Form.Label();
            this.maritalStatusLabel = new Hkx.Windows.Form.Label();
            this.ageTextBox = new Hkx.Windows.Form.TextBox();
            this.maleRadioButton = new Hkx.Windows.Form.RadioButton();
            this.femaleRadioButton = new Hkx.Windows.Form.RadioButton();
            this.codePatientTextBox = new Hkx.Windows.Form.TextBox();
            this.codePatientLabel = new Hkx.Windows.Form.Label();
            this.completedGroupBox.SuspendLayout();
            this.personGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeOfDiseaseLabel
            // 
            this.typeOfDiseaseLabel.AutoSize = true;
            this.typeOfDiseaseLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.typeOfDiseaseLabel.Location = new System.Drawing.Point(235, 277);
            this.typeOfDiseaseLabel.Name = "typeOfDiseaseLabel";
            this.typeOfDiseaseLabel.Size = new System.Drawing.Size(71, 27);
            this.typeOfDiseaseLabel.TabIndex = 0;
            this.typeOfDiseaseLabel.Text = "نوع بیماری :";
            // 
            // typeOfDiseaseTextBox
            // 
            this.typeOfDiseaseTextBox.Location = new System.Drawing.Point(6, 274);
            this.typeOfDiseaseTextBox.MaxLength = 20;
            this.typeOfDiseaseTextBox.Name = "typeOfDiseaseTextBox";
            this.typeOfDiseaseTextBox.Size = new System.Drawing.Size(200, 34);
            this.typeOfDiseaseTextBox.TabIndex = 1;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.registerButton.Location = new System.Drawing.Point(283, 332);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(66, 39);
            this.registerButton.TabIndex = 9;
            this.registerButton.Text = "ذخیره";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.resetButton.Location = new System.Drawing.Point(355, 332);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(66, 39);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "ورود مجدد";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.exitButton.Location = new System.Drawing.Point(427, 332);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(66, 39);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "خروج";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // completedGroupBox
            // 
            this.completedGroupBox.Controls.Add(this.addressLabel);
            this.completedGroupBox.Controls.Add(this.PhoneLabel);
            this.completedGroupBox.Controls.Add(this.mobileLabel);
            this.completedGroupBox.Controls.Add(this.descriptionTextBox);
            this.completedGroupBox.Controls.Add(this.postalCodeLabel);
            this.completedGroupBox.Controls.Add(this.postalCodeTextBox);
            this.completedGroupBox.Controls.Add(this.descriptionLabel);
            this.completedGroupBox.Controls.Add(this.mobileTextBox);
            this.completedGroupBox.Controls.Add(this.addressTextBox);
            this.completedGroupBox.Controls.Add(this.phoneTextBox);
            this.completedGroupBox.Location = new System.Drawing.Point(330, 12);
            this.completedGroupBox.Name = "completedGroupBox";
            this.completedGroupBox.Size = new System.Drawing.Size(521, 314);
            this.completedGroupBox.TabIndex = 8;
            this.completedGroupBox.TabStop = false;
            this.completedGroupBox.Text = "اطاعات تکمیلی";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.addressLabel.Location = new System.Drawing.Point(448, 29);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(51, 27);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "آدرس :";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.PhoneLabel.Location = new System.Drawing.Point(450, 106);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(49, 27);
            this.PhoneLabel.TabIndex = 2;
            this.PhoneLabel.Text = "تلفن  :";
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.mobileLabel.Location = new System.Drawing.Point(421, 142);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(81, 27);
            this.mobileLabel.TabIndex = 4;
            this.mobileLabel.Text = "تلفن همراه  :";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(6, 214);
            this.descriptionTextBox.MaxLength = 20;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(409, 94);
            this.descriptionTextBox.TabIndex = 9;
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.postalCodeLabel.Location = new System.Drawing.Point(437, 178);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(62, 27);
            this.postalCodeLabel.TabIndex = 6;
            this.postalCodeLabel.Text = "کد پستی  :";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(215, 178);
            this.postalCodeTextBox.MaxLength = 20;
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(200, 30);
            this.postalCodeTextBox.TabIndex = 7;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.descriptionLabel.Location = new System.Drawing.Point(434, 214);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(65, 27);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "توضیحات  :";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(215, 142);
            this.mobileTextBox.MaxLength = 20;
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(200, 30);
            this.mobileTextBox.TabIndex = 5;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(6, 29);
            this.addressTextBox.MaxLength = 20;
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(409, 71);
            this.addressTextBox.TabIndex = 1;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(215, 106);
            this.phoneTextBox.MaxLength = 20;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 30);
            this.phoneTextBox.TabIndex = 3;
            // 
            // personGroupBox
            // 
            this.personGroupBox.Controls.Add(this.codePatientTextBox);
            this.personGroupBox.Controls.Add(this.codePatientLabel);
            this.personGroupBox.Controls.Add(this.typeOfDiseaseLabel);
            this.personGroupBox.Controls.Add(this.singleCheckBox);
            this.personGroupBox.Controls.Add(this.typeOfDiseaseTextBox);
            this.personGroupBox.Controls.Add(this.marridCheckBox);
            this.personGroupBox.Controls.Add(this.firstNameTextBox);
            this.personGroupBox.Controls.Add(this.firtNameLabel);
            this.personGroupBox.Controls.Add(this.lastNameLabel);
            this.personGroupBox.Controls.Add(this.lastNameTextBox);
            this.personGroupBox.Controls.Add(this.genderLabel);
            this.personGroupBox.Controls.Add(this.ageLabel);
            this.personGroupBox.Controls.Add(this.maritalStatusLabel);
            this.personGroupBox.Controls.Add(this.ageTextBox);
            this.personGroupBox.Controls.Add(this.maleRadioButton);
            this.personGroupBox.Controls.Add(this.femaleRadioButton);
            this.personGroupBox.Font = new System.Drawing.Font("B Kamran", 14F);
            this.personGroupBox.Location = new System.Drawing.Point(12, 12);
            this.personGroupBox.Name = "personGroupBox";
            this.personGroupBox.Size = new System.Drawing.Size(312, 314);
            this.personGroupBox.TabIndex = 6;
            this.personGroupBox.TabStop = false;
            this.personGroupBox.Text = "مشخصات فردی";
            // 
            // singleCheckBox
            // 
            this.singleCheckBox.AutoSize = true;
            this.singleCheckBox.Location = new System.Drawing.Point(90, 237);
            this.singleCheckBox.Name = "singleCheckBox";
            this.singleCheckBox.Size = new System.Drawing.Size(50, 31);
            this.singleCheckBox.TabIndex = 11;
            this.singleCheckBox.Text = "مجرد";
            this.singleCheckBox.UseVisualStyleBackColor = true;
            this.singleCheckBox.CheckedChanged += new System.EventHandler(this.singleCheckBox_CheckedChanged);
            // 
            // marridCheckBox
            // 
            this.marridCheckBox.AutoSize = true;
            this.marridCheckBox.Location = new System.Drawing.Point(146, 237);
            this.marridCheckBox.Name = "marridCheckBox";
            this.marridCheckBox.Size = new System.Drawing.Size(60, 31);
            this.marridCheckBox.TabIndex = 10;
            this.marridCheckBox.Text = "متاهل";
            this.marridCheckBox.UseVisualStyleBackColor = true;
            this.marridCheckBox.CheckedChanged += new System.EventHandler(this.marridCheckBox_CheckedChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(6, 69);
            this.firstNameTextBox.MaxLength = 20;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.Enter += new System.EventHandler(this.firstNameTextBox_Enter);
            // 
            // firtNameLabel
            // 
            this.firtNameLabel.AutoSize = true;
            this.firtNameLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.firtNameLabel.Location = new System.Drawing.Point(272, 72);
            this.firtNameLabel.Name = "firtNameLabel";
            this.firtNameLabel.Size = new System.Drawing.Size(34, 27);
            this.firtNameLabel.TabIndex = 0;
            this.firtNameLabel.Text = "نام :";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.lastNameLabel.Location = new System.Drawing.Point(231, 112);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(75, 27);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "نام خانوادگی :";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(6, 109);
            this.lastNameTextBox.MaxLength = 20;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.lastNameTextBox.TabIndex = 3;
            this.lastNameTextBox.Enter += new System.EventHandler(this.lastNameTextBox_Enter);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.genderLabel.Location = new System.Drawing.Point(252, 160);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(54, 27);
            this.genderLabel.TabIndex = 4;
            this.genderLabel.Text = "جنسیت :";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.ageLabel.Location = new System.Drawing.Point(267, 198);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(39, 27);
            this.ageLabel.TabIndex = 7;
            this.ageLabel.Text = "سن :";
            // 
            // maritalStatusLabel
            // 
            this.maritalStatusLabel.AutoSize = true;
            this.maritalStatusLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.maritalStatusLabel.Location = new System.Drawing.Point(221, 238);
            this.maritalStatusLabel.Name = "maritalStatusLabel";
            this.maritalStatusLabel.Size = new System.Drawing.Size(85, 27);
            this.maritalStatusLabel.TabIndex = 9;
            this.maritalStatusLabel.Text = "وضعیت تاهل :";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(6, 195);
            this.ageTextBox.MaxLength = 20;
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(200, 34);
            this.ageTextBox.TabIndex = 8;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.maleRadioButton.Location = new System.Drawing.Point(161, 158);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(45, 31);
            this.maleRadioButton.TabIndex = 5;
            this.maleRadioButton.Text = "مرد";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.femaleRadioButton.Location = new System.Drawing.Point(110, 158);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(45, 31);
            this.femaleRadioButton.TabIndex = 6;
            this.femaleRadioButton.Text = "زن";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // codePatientTextBox
            // 
            this.codePatientTextBox.Enabled = false;
            this.codePatientTextBox.Location = new System.Drawing.Point(6, 29);
            this.codePatientTextBox.MaxLength = 20;
            this.codePatientTextBox.Name = "codePatientTextBox";
            this.codePatientTextBox.Size = new System.Drawing.Size(200, 34);
            this.codePatientTextBox.TabIndex = 13;
            // 
            // codePatientLabel
            // 
            this.codePatientLabel.AutoSize = true;
            this.codePatientLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.codePatientLabel.Location = new System.Drawing.Point(277, 32);
            this.codePatientLabel.Name = "codePatientLabel";
            this.codePatientLabel.Size = new System.Drawing.Size(29, 27);
            this.codePatientLabel.TabIndex = 12;
            this.codePatientLabel.Text = "کد :";
            // 
            // RegisterPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 382);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.completedGroupBox);
            this.Controls.Add(this.personGroupBox);
            this.MaximumSize = new System.Drawing.Size(881, 421);
            this.MinimumSize = new System.Drawing.Size(881, 421);
            this.Name = "RegisterPatientForm";
            this.Text = "ورود اطلاعات بیمار";
            this.Load += new System.EventHandler(this.RegisterPatientForm_Load);
            this.completedGroupBox.ResumeLayout(false);
            this.completedGroupBox.PerformLayout();
            this.personGroupBox.ResumeLayout(false);
            this.personGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Hkx.Windows.Form.Label typeOfDiseaseLabel;
        private Hkx.Windows.Form.TextBox typeOfDiseaseTextBox;
        private Hkx.Windows.Form.Button2 registerButton;
        private Hkx.Windows.Form.Button2 resetButton;
        private Hkx.Windows.Form.Button2 exitButton;
        private Hkx.Windows.Form.GroupBox completedGroupBox;
        private Hkx.Windows.Form.Label addressLabel;
        private Hkx.Windows.Form.Label PhoneLabel;
        private Hkx.Windows.Form.Label mobileLabel;
        private Hkx.Windows.Form.TextBox descriptionTextBox;
        private Hkx.Windows.Form.Label postalCodeLabel;
        private Hkx.Windows.Form.TextBox postalCodeTextBox;
        private Hkx.Windows.Form.Label descriptionLabel;
        private Hkx.Windows.Form.TextBox mobileTextBox;
        private Hkx.Windows.Form.TextBox addressTextBox;
        private Hkx.Windows.Form.TextBox phoneTextBox;
        private Hkx.Windows.Form.GroupBox personGroupBox;
        private Hkx.Windows.Form.CheckBox singleCheckBox;
        private Hkx.Windows.Form.CheckBox marridCheckBox;
        private Hkx.Windows.Form.TextBox firstNameTextBox;
        private Hkx.Windows.Form.Label firtNameLabel;
        private Hkx.Windows.Form.Label lastNameLabel;
        private Hkx.Windows.Form.TextBox lastNameTextBox;
        private Hkx.Windows.Form.Label genderLabel;
        private Hkx.Windows.Form.Label ageLabel;
        private Hkx.Windows.Form.Label maritalStatusLabel;
        private Hkx.Windows.Form.TextBox ageTextBox;
        private Hkx.Windows.Form.RadioButton maleRadioButton;
        private Hkx.Windows.Form.RadioButton femaleRadioButton;
        private Hkx.Windows.Form.TextBox codePatientTextBox;
        private Hkx.Windows.Form.Label codePatientLabel;
    }
}