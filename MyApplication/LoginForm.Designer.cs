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
            this.loginButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(90, 64);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(87, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "&Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(183, 64);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(87, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click_1);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(276, 64);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(14, 42);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(66, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "&Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(14, 15);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "&Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Location = new System.Drawing.Point(90, 12);
            this.usernameTextBox.MaxLength = 40;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(272, 21);
            this.usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(90, 39);
            this.passwordTextBox.MaxLength = 20;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(272, 21);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(377, 99);
            this.ControlBox = false;
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.loginButton);
            this.MaximumSize = new System.Drawing.Size(931, 138);
            this.MinimumSize = new System.Drawing.Size(393, 138);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private EventHandler resetButton_Click;
    }
}