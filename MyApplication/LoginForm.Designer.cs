using System;

namespace MyApplication
{
    partial class LoginForm
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
            this.label1 = new Hkx.Windows.Form.Label();
            this.label2 = new Hkx.Windows.Form.Label();
            this.usernameTextBox = new Hkx.Windows.Form.TextBox();
            this.exitButton = new Hkx.Windows.Form.Button2();
            this.resetButton = new Hkx.Windows.Form.Button2();
            this.loginButton = new Hkx.Windows.Form.Button2();
            this.passwordTextBox = new Hkx.Windows.Form.PasswordTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Kamran", 14F);
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Kamran", 14F);
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "کلمه عبور :";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Location = new System.Drawing.Point(84, 12);
            this.usernameTextBox.MaxLength = 20;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(210, 30);
            this.usernameTextBox.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.exitButton.Location = new System.Drawing.Point(228, 84);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(66, 39);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "خروج";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.resetButton.Location = new System.Drawing.Point(156, 84);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(66, 39);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "ورود مجدد";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click_1);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.loginButton.Location = new System.Drawing.Point(84, 84);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(66, 39);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "ورود";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(84, 48);
            this.passwordTextBox.MaxLength = 40;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(210, 30);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(308, 129);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.MaximumSize = new System.Drawing.Size(800, 168);
            this.MinimumSize = new System.Drawing.Size(324, 168);
            this.Name = "LoginForm";
            this.Text = "ورود";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EventHandler resetButton_Click;
        private Hkx.Windows.Form.Label label1;
        private Hkx.Windows.Form.Label label2;
        private Hkx.Windows.Form.TextBox usernameTextBox;
        private Hkx.Windows.Form.Button2 exitButton;
        private Hkx.Windows.Form.Button2 resetButton;
        private Hkx.Windows.Form.Button2 loginButton;
        private Hkx.Windows.Form.PasswordTextBox passwordTextBox;
    }
}