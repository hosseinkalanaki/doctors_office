namespace MyApplication.Admin
{
    partial class UpdateProfileForm
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
            this.fullNmaeLabel = new Hkx.Windows.Form.Label();
            this.fullNmaeTextBox = new Hkx.Windows.Form.TextBox();
            this.descriptionLabel = new Hkx.Windows.Form.Label();
            this.descriptionTextBox = new Hkx.Windows.Form.TextBox();
            this.activeCheckBox = new Hkx.Windows.Form.CheckBox();
            this.adminCheckBox = new Hkx.Windows.Form.CheckBox();
            this.exitButton = new Hkx.Windows.Form.Button();
            this.saveButton = new Hkx.Windows.Form.Button();
            this.SuspendLayout();
            // 
            // fullNmaeLabel
            // 
            this.fullNmaeLabel.AutoSize = true;
            this.fullNmaeLabel.Location = new System.Drawing.Point(12, 15);
            this.fullNmaeLabel.Name = "fullNmaeLabel";
            this.fullNmaeLabel.Size = new System.Drawing.Size(59, 13);
            this.fullNmaeLabel.TabIndex = 0;
            this.fullNmaeLabel.Text = "&FullName";
            // 
            // fullNmaeTextBox
            // 
            this.fullNmaeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNmaeTextBox.Location = new System.Drawing.Point(89, 12);
            this.fullNmaeTextBox.MaxLength = 20;
            this.fullNmaeTextBox.Name = "fullNmaeTextBox";
            this.fullNmaeTextBox.Size = new System.Drawing.Size(230, 21);
            this.fullNmaeTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 42);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(71, 13);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "&Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(89, 39);
            this.descriptionTextBox.MaxLength = 20;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(230, 53);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Location = new System.Drawing.Point(89, 167);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(61, 17);
            this.activeCheckBox.TabIndex = 4;
            this.activeCheckBox.Text = "&Active";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Location = new System.Drawing.Point(89, 190);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(62, 17);
            this.adminCheckBox.TabIndex = 5;
            this.adminCheckBox.Text = "Ad&min";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(244, 172);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(163, 172);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // UpdateProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 223);
            this.ControlBox = false;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.adminCheckBox);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.fullNmaeTextBox);
            this.Controls.Add(this.fullNmaeLabel);
            this.MaximumSize = new System.Drawing.Size(800, 262);
            this.MinimumSize = new System.Drawing.Size(347, 262);
            this.Name = "UpdateProfileForm";
            this.Text = "UpdateProfile";
            this.Load += new System.EventHandler(this.UpdateProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Hkx.Windows.Form.Label fullNmaeLabel;
        private Hkx.Windows.Form.TextBox fullNmaeTextBox;
        private Hkx.Windows.Form.Label descriptionLabel;
        private Hkx.Windows.Form.TextBox descriptionTextBox;
        private Hkx.Windows.Form.CheckBox activeCheckBox;
        private Hkx.Windows.Form.CheckBox adminCheckBox;
        private Hkx.Windows.Form.Button exitButton;
        private Hkx.Windows.Form.Button saveButton;
    }
}