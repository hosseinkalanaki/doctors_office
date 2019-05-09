namespace MyApplication
{
    partial class RegisterUserForm
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
            this.usernameTextBox = new Hkx.Windows.Form.TextBox();
            this.usernameLabel = new Hkx.Windows.Form.Label();
            this.passwordLabel = new Hkx.Windows.Form.Label();
            this.confirmPasswordLabel = new Hkx.Windows.Form.Label();
            this.firstNameTextBox = new Hkx.Windows.Form.TextBox();
            this.firtNameLabel = new Hkx.Windows.Form.Label();
            this.lastNameTextBox = new Hkx.Windows.Form.TextBox();
            this.lastNameLabel = new Hkx.Windows.Form.Label();
            this.ageTextBox = new Hkx.Windows.Form.TextBox();
            this.ageLabel = new Hkx.Windows.Form.Label();
            this.genderLabel = new Hkx.Windows.Form.Label();
            this.maleRadioButton = new Hkx.Windows.Form.RadioButton();
            this.femaleRadioButton = new Hkx.Windows.Form.RadioButton();
            this.maritalStatusLabel = new Hkx.Windows.Form.Label();
            this.addressTextBox = new Hkx.Windows.Form.TextBox();
            this.addressLabel = new Hkx.Windows.Form.Label();
            this.phoneTextBox = new Hkx.Windows.Form.TextBox();
            this.PhoneLabel = new Hkx.Windows.Form.Label();
            this.mobileTextBox = new Hkx.Windows.Form.TextBox();
            this.mobileLabel = new Hkx.Windows.Form.Label();
            this.postalCodeTextBox = new Hkx.Windows.Form.TextBox();
            this.postalCodeLabel = new Hkx.Windows.Form.Label();
            this.descriptionTextBox = new Hkx.Windows.Form.TextBox();
            this.descriptionLabel = new Hkx.Windows.Form.Label();
            this.personGroupBox = new Hkx.Windows.Form.GroupBox();
            this.userCodeTextBox = new Hkx.Windows.Form.TextBox();
            this.userCodeLabel = new Hkx.Windows.Form.Label();
            this.singleCheckBox = new Hkx.Windows.Form.CheckBox();
            this.marridCheckBox = new Hkx.Windows.Form.CheckBox();
            this.usersGroupBox = new Hkx.Windows.Form.GroupBox();
            this.passwordTextBox = new Hkx.Windows.Form.PasswordTextBox();
            this.confirmPasswordTextBox = new Hkx.Windows.Form.PasswordTextBox();
            this.completedGroupBox = new Hkx.Windows.Form.GroupBox();
            this.exitButton = new Hkx.Windows.Form.Button2();
            this.registerButton = new Hkx.Windows.Form.Button2();
            this.resetButton = new Hkx.Windows.Form.Button2();
            this.personGroupBox.SuspendLayout();
            this.usersGroupBox.SuspendLayout();
            this.completedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(578, 29);
            this.usernameTextBox.MaxLength = 20;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(181, 30);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.usernameLabel.Location = new System.Drawing.Point(765, 29);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(68, 27);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "نام کاربری :";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.passwordLabel.Location = new System.Drawing.Point(503, 29);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(45, 27);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "پسورد :";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.confirmPasswordLabel.Location = new System.Drawing.Point(201, 29);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(94, 27);
            this.confirmPasswordLabel.TabIndex = 4;
            this.confirmPasswordLabel.Text = "ورود مجدد پسورد :";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(6, 73);
            this.firstNameTextBox.MaxLength = 20;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firtNameLabel
            // 
            this.firtNameLabel.AutoSize = true;
            this.firtNameLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.firtNameLabel.Location = new System.Drawing.Point(272, 76);
            this.firtNameLabel.Name = "firtNameLabel";
            this.firtNameLabel.Size = new System.Drawing.Size(34, 27);
            this.firtNameLabel.TabIndex = 0;
            this.firtNameLabel.Text = "نام :";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(6, 113);
            this.lastNameTextBox.MaxLength = 20;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.lastNameLabel.Location = new System.Drawing.Point(231, 116);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(75, 27);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "نام خانوادگی :";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(6, 199);
            this.ageTextBox.MaxLength = 20;
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(200, 34);
            this.ageTextBox.TabIndex = 8;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.ageLabel.Location = new System.Drawing.Point(267, 202);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(39, 27);
            this.ageLabel.TabIndex = 7;
            this.ageLabel.Text = "سن :";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.genderLabel.Location = new System.Drawing.Point(252, 164);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(54, 27);
            this.genderLabel.TabIndex = 4;
            this.genderLabel.Text = "جنسیت :";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.maleRadioButton.Location = new System.Drawing.Point(161, 162);
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
            this.femaleRadioButton.Location = new System.Drawing.Point(110, 162);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(45, 31);
            this.femaleRadioButton.TabIndex = 6;
            this.femaleRadioButton.Text = "زن";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maritalStatusLabel
            // 
            this.maritalStatusLabel.AutoSize = true;
            this.maritalStatusLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.maritalStatusLabel.Location = new System.Drawing.Point(221, 242);
            this.maritalStatusLabel.Name = "maritalStatusLabel";
            this.maritalStatusLabel.Size = new System.Drawing.Size(85, 27);
            this.maritalStatusLabel.TabIndex = 9;
            this.maritalStatusLabel.Text = "وضعیت تاهل :";
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
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(215, 106);
            this.phoneTextBox.MaxLength = 20;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 30);
            this.phoneTextBox.TabIndex = 3;
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
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(215, 142);
            this.mobileTextBox.MaxLength = 20;
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(200, 30);
            this.mobileTextBox.TabIndex = 5;
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
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(215, 178);
            this.postalCodeTextBox.MaxLength = 20;
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(200, 30);
            this.postalCodeTextBox.TabIndex = 7;
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
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(6, 214);
            this.descriptionTextBox.MaxLength = 20;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(409, 94);
            this.descriptionTextBox.TabIndex = 9;
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
            // personGroupBox
            // 
            this.personGroupBox.Controls.Add(this.userCodeTextBox);
            this.personGroupBox.Controls.Add(this.userCodeLabel);
            this.personGroupBox.Controls.Add(this.singleCheckBox);
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
            this.personGroupBox.TabIndex = 0;
            this.personGroupBox.TabStop = false;
            this.personGroupBox.Text = "مشخصات فردی";
            // 
            // userCodeTextBox
            // 
            this.userCodeTextBox.Enabled = false;
            this.userCodeTextBox.Location = new System.Drawing.Point(6, 33);
            this.userCodeTextBox.MaxLength = 20;
            this.userCodeTextBox.Name = "userCodeTextBox";
            this.userCodeTextBox.Size = new System.Drawing.Size(200, 34);
            this.userCodeTextBox.TabIndex = 13;
            // 
            // userCodeLabel
            // 
            this.userCodeLabel.AutoSize = true;
            this.userCodeLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.userCodeLabel.Location = new System.Drawing.Point(257, 36);
            this.userCodeLabel.Name = "userCodeLabel";
            this.userCodeLabel.Size = new System.Drawing.Size(47, 27);
            this.userCodeLabel.TabIndex = 12;
            this.userCodeLabel.Text = "کد کاربر:";
            // 
            // singleCheckBox
            // 
            this.singleCheckBox.AutoSize = true;
            this.singleCheckBox.Location = new System.Drawing.Point(90, 241);
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
            this.marridCheckBox.Location = new System.Drawing.Point(146, 241);
            this.marridCheckBox.Name = "marridCheckBox";
            this.marridCheckBox.Size = new System.Drawing.Size(60, 31);
            this.marridCheckBox.TabIndex = 10;
            this.marridCheckBox.Text = "متاهل";
            this.marridCheckBox.UseVisualStyleBackColor = true;
            this.marridCheckBox.CheckedChanged += new System.EventHandler(this.marridCheckBox_CheckedChanged);
            // 
            // usersGroupBox
            // 
            this.usersGroupBox.Controls.Add(this.passwordTextBox);
            this.usersGroupBox.Controls.Add(this.confirmPasswordTextBox);
            this.usersGroupBox.Controls.Add(this.usernameLabel);
            this.usersGroupBox.Controls.Add(this.passwordLabel);
            this.usersGroupBox.Controls.Add(this.confirmPasswordLabel);
            this.usersGroupBox.Controls.Add(this.usernameTextBox);
            this.usersGroupBox.Location = new System.Drawing.Point(12, 332);
            this.usersGroupBox.Name = "usersGroupBox";
            this.usersGroupBox.Size = new System.Drawing.Size(839, 84);
            this.usersGroupBox.TabIndex = 1;
            this.usersGroupBox.TabStop = false;
            this.usersGroupBox.Text = "اطلاعات کاربری";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(316, 29);
            this.passwordTextBox.MaxLength = 40;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(181, 30);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(6, 29);
            this.confirmPasswordTextBox.MaxLength = 40;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(189, 30);
            this.confirmPasswordTextBox.TabIndex = 5;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            this.confirmPasswordTextBox.Enter += new System.EventHandler(this.confirmPasswordTextBox_Enter);
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
            this.completedGroupBox.TabIndex = 2;
            this.completedGroupBox.TabStop = false;
            this.completedGroupBox.Text = "اطاعات تکمیلی";
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.exitButton.Location = new System.Drawing.Point(489, 422);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(66, 39);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "خروج";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.registerButton.Location = new System.Drawing.Point(282, 422);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(66, 39);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "ذخیره";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.resetButton.Location = new System.Drawing.Point(383, 422);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(66, 39);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "ورود مجدد";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // RegisterUserForm
            // 
            this.AcceptButton = this.registerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(867, 476);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.completedGroupBox);
            this.Controls.Add(this.usersGroupBox);
            this.Controls.Add(this.personGroupBox);
            this.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.MaximumSize = new System.Drawing.Size(883, 515);
            this.MinimumSize = new System.Drawing.Size(883, 473);
            this.Name = "RegisterUserForm";
            this.Text = "ثبت اطلاعات کاربران ";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.personGroupBox.ResumeLayout(false);
            this.personGroupBox.PerformLayout();
            this.usersGroupBox.ResumeLayout(false);
            this.usersGroupBox.PerformLayout();
            this.completedGroupBox.ResumeLayout(false);
            this.completedGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Hkx.Windows.Form.TextBox usernameTextBox;
        private Hkx.Windows.Form.Label usernameLabel;
        private Hkx.Windows.Form.Label passwordLabel;
        private Hkx.Windows.Form.Label confirmPasswordLabel;
        private Hkx.Windows.Form.TextBox firstNameTextBox;
        private Hkx.Windows.Form.Label firtNameLabel;
        private Hkx.Windows.Form.TextBox lastNameTextBox;
        private Hkx.Windows.Form.Label lastNameLabel;
        private Hkx.Windows.Form.TextBox ageTextBox;
        private Hkx.Windows.Form.Label ageLabel;
        private Hkx.Windows.Form.Label genderLabel;
        private Hkx.Windows.Form.RadioButton maleRadioButton;
        private Hkx.Windows.Form.RadioButton femaleRadioButton;
        private Hkx.Windows.Form.Label maritalStatusLabel;
        private Hkx.Windows.Form.TextBox addressTextBox;
        private Hkx.Windows.Form.Label addressLabel;
        private Hkx.Windows.Form.TextBox phoneTextBox;
        private Hkx.Windows.Form.Label PhoneLabel;
        private Hkx.Windows.Form.TextBox mobileTextBox;
        private Hkx.Windows.Form.Label mobileLabel;
        private Hkx.Windows.Form.TextBox postalCodeTextBox;
        private Hkx.Windows.Form.Label postalCodeLabel;
        private Hkx.Windows.Form.TextBox descriptionTextBox;
        private Hkx.Windows.Form.Label descriptionLabel;
        private Hkx.Windows.Form.GroupBox personGroupBox;
        private Hkx.Windows.Form.GroupBox usersGroupBox;
        private Hkx.Windows.Form.GroupBox completedGroupBox;
        private Hkx.Windows.Form.Button2 exitButton;
        private Hkx.Windows.Form.Button2 registerButton;
        private Hkx.Windows.Form.Button2 resetButton;
        private Hkx.Windows.Form.PasswordTextBox passwordTextBox;
        private Hkx.Windows.Form.PasswordTextBox confirmPasswordTextBox;
        private Hkx.Windows.Form.CheckBox marridCheckBox;
        private Hkx.Windows.Form.CheckBox singleCheckBox;
        private Hkx.Windows.Form.TextBox userCodeTextBox;
        private Hkx.Windows.Form.Label userCodeLabel;
    }
}