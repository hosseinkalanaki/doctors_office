namespace MyApplication
{
    partial class ChangePasswrodForm
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
            this.oldPasswrodLabel = new Hkx.Windows.Form.Label();
            this.newPasswrodLabel = new Hkx.Windows.Form.Label();
            this.confirmNewPasswordLabel = new Hkx.Windows.Form.Label();
            this.oldPasswrodTextBox = new Hkx.Windows.Form.TextBox();
            this.newPasswrodTextBox = new Hkx.Windows.Form.TextBox();
            this.confirmNewPasswordTextBox = new Hkx.Windows.Form.TextBox();
            this.exitButton = new Hkx.Windows.Form.Button2();
            this.saveButton = new Hkx.Windows.Form.Button2();
            this.SuspendLayout();
            // 
            // oldPasswrodLabel
            // 
            this.oldPasswrodLabel.AutoSize = true;
            this.oldPasswrodLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.oldPasswrodLabel.Location = new System.Drawing.Point(12, 9);
            this.oldPasswrodLabel.Name = "oldPasswrodLabel";
            this.oldPasswrodLabel.Size = new System.Drawing.Size(72, 27);
            this.oldPasswrodLabel.TabIndex = 1;
            this.oldPasswrodLabel.Text = "پسورد قدیم :";
            // 
            // newPasswrodLabel
            // 
            this.newPasswrodLabel.AutoSize = true;
            this.newPasswrodLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.newPasswrodLabel.Location = new System.Drawing.Point(12, 45);
            this.newPasswrodLabel.Name = "newPasswrodLabel";
            this.newPasswrodLabel.Size = new System.Drawing.Size(70, 27);
            this.newPasswrodLabel.TabIndex = 3;
            this.newPasswrodLabel.Text = "پسورد جدید :";
            // 
            // confirmNewPasswordLabel
            // 
            this.confirmNewPasswordLabel.AutoSize = true;
            this.confirmNewPasswordLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.confirmNewPasswordLabel.Location = new System.Drawing.Point(12, 81);
            this.confirmNewPasswordLabel.Name = "confirmNewPasswordLabel";
            this.confirmNewPasswordLabel.Size = new System.Drawing.Size(94, 27);
            this.confirmNewPasswordLabel.TabIndex = 5;
            this.confirmNewPasswordLabel.Text = "ورود مجدد پسورد :";
            // 
            // oldPasswrodTextBox
            // 
            this.oldPasswrodTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldPasswrodTextBox.Location = new System.Drawing.Point(112, 9);
            this.oldPasswrodTextBox.MaxLength = 20;
            this.oldPasswrodTextBox.Name = "oldPasswrodTextBox";
            this.oldPasswrodTextBox.Size = new System.Drawing.Size(139, 30);
            this.oldPasswrodTextBox.TabIndex = 2;
            this.oldPasswrodTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswrodTextBox
            // 
            this.newPasswrodTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPasswrodTextBox.Location = new System.Drawing.Point(112, 45);
            this.newPasswrodTextBox.MaxLength = 20;
            this.newPasswrodTextBox.Name = "newPasswrodTextBox";
            this.newPasswrodTextBox.Size = new System.Drawing.Size(139, 30);
            this.newPasswrodTextBox.TabIndex = 4;
            this.newPasswrodTextBox.UseSystemPasswordChar = true;
            // 
            // confirmNewPasswordTextBox
            // 
            this.confirmNewPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmNewPasswordTextBox.Location = new System.Drawing.Point(112, 81);
            this.confirmNewPasswordTextBox.MaxLength = 20;
            this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            this.confirmNewPasswordTextBox.Size = new System.Drawing.Size(139, 30);
            this.confirmNewPasswordTextBox.TabIndex = 6;
            this.confirmNewPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.exitButton.Location = new System.Drawing.Point(185, 117);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(66, 39);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "خروج";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.saveButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.saveButton.Location = new System.Drawing.Point(112, 117);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(66, 39);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "ذخیره";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ChangePasswrod
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(267, 166);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.confirmNewPasswordTextBox);
            this.Controls.Add(this.newPasswrodTextBox);
            this.Controls.Add(this.oldPasswrodTextBox);
            this.Controls.Add(this.confirmNewPasswordLabel);
            this.Controls.Add(this.newPasswrodLabel);
            this.Controls.Add(this.oldPasswrodLabel);
            this.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.MaximumSize = new System.Drawing.Size(1024, 240);
            this.Name = "ChangePasswrod";
            this.Text = "تغییر کلمه عبور";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Hkx.Windows.Form.Label oldPasswrodLabel;
        private Hkx.Windows.Form.Label newPasswrodLabel;
        private Hkx.Windows.Form.Label confirmNewPasswordLabel;
        private Hkx.Windows.Form.TextBox oldPasswrodTextBox;
        private Hkx.Windows.Form.TextBox newPasswrodTextBox;
        private Hkx.Windows.Form.TextBox confirmNewPasswordTextBox;
        private Hkx.Windows.Form.Button2 exitButton;
        private Hkx.Windows.Form.Button2 saveButton;
    }
}