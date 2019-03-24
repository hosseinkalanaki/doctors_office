namespace MyApplication
{
    partial class ChangePasswrod
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
            this.oldPasswrodTextBox = new System.Windows.Forms.TextBox();
            this.confirmNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswrodTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.confirmNewPasswordLabel = new Hkx.Windows.Form.Label();
            this.newPasswrodLabel = new Hkx.Windows.Form.Label();
            this.oldPasswrodLabel = new Hkx.Windows.Form.Label();
            this.SuspendLayout();
            // 
            // oldPasswrodTextBox
            // 
            this.oldPasswrodTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldPasswrodTextBox.Location = new System.Drawing.Point(124, 6);
            this.oldPasswrodTextBox.MaxLength = 50;
            this.oldPasswrodTextBox.Name = "oldPasswrodTextBox";
            this.oldPasswrodTextBox.Size = new System.Drawing.Size(195, 21);
            this.oldPasswrodTextBox.TabIndex = 1;
            this.oldPasswrodTextBox.UseSystemPasswordChar = true;
            // 
            // confirmNewPasswordTextBox
            // 
            this.confirmNewPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmNewPasswordTextBox.Location = new System.Drawing.Point(124, 60);
            this.confirmNewPasswordTextBox.MaxLength = 50;
            this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            this.confirmNewPasswordTextBox.Size = new System.Drawing.Size(195, 21);
            this.confirmNewPasswordTextBox.TabIndex = 5;
            this.confirmNewPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswrodTextBox
            // 
            this.newPasswrodTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPasswrodTextBox.Location = new System.Drawing.Point(124, 33);
            this.newPasswrodTextBox.MaxLength = 50;
            this.newPasswrodTextBox.Name = "newPasswrodTextBox";
            this.newPasswrodTextBox.Size = new System.Drawing.Size(195, 21);
            this.newPasswrodTextBox.TabIndex = 3;
            this.newPasswrodTextBox.UseSystemPasswordChar = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(124, 87);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(205, 87);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // confirmNewPasswordLabel
            // 
            this.confirmNewPasswordLabel.AutoSize = true;
            this.confirmNewPasswordLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.confirmNewPasswordLabel.Location = new System.Drawing.Point(7, 63);
            this.confirmNewPasswordLabel.Name = "confirmNewPasswordLabel";
            this.confirmNewPasswordLabel.Size = new System.Drawing.Size(111, 13);
            this.confirmNewPasswordLabel.TabIndex = 10;
            this.confirmNewPasswordLabel.Text = "&Confirm Passwrod";
            // 
            // newPasswrodLabel
            // 
            this.newPasswrodLabel.AutoSize = true;
            this.newPasswrodLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.newPasswrodLabel.Location = new System.Drawing.Point(7, 36);
            this.newPasswrodLabel.Name = "newPasswrodLabel";
            this.newPasswrodLabel.Size = new System.Drawing.Size(89, 13);
            this.newPasswrodLabel.TabIndex = 9;
            this.newPasswrodLabel.Text = "&New Passwrod";
            // 
            // oldPasswrodLabel
            // 
            this.oldPasswrodLabel.AutoSize = true;
            this.oldPasswrodLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.oldPasswrodLabel.Location = new System.Drawing.Point(7, 9);
            this.oldPasswrodLabel.Name = "oldPasswrodLabel";
            this.oldPasswrodLabel.Size = new System.Drawing.Size(84, 13);
            this.oldPasswrodLabel.TabIndex = 8;
            this.oldPasswrodLabel.Text = "&Old Passwrod";
            // 
            // ChangePasswrod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 119);
            this.ControlBox = false;
            this.Controls.Add(this.confirmNewPasswordLabel);
            this.Controls.Add(this.newPasswrodLabel);
            this.Controls.Add(this.oldPasswrodLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newPasswrodTextBox);
            this.Controls.Add(this.confirmNewPasswordTextBox);
            this.Controls.Add(this.oldPasswrodTextBox);
            this.MaximumSize = new System.Drawing.Size(800, 158);
            this.MinimumSize = new System.Drawing.Size(347, 158);
            this.Name = "ChangePasswrod";
            this.Text = "ChangePasswrod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox oldPasswrodTextBox;
        private System.Windows.Forms.TextBox confirmNewPasswordTextBox;
        private System.Windows.Forms.TextBox newPasswrodTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private Hkx.Windows.Form.Label oldPasswrodLabel;
        private Hkx.Windows.Form.Label newPasswrodLabel;
        private Hkx.Windows.Form.Label confirmNewPasswordLabel;
    }
}