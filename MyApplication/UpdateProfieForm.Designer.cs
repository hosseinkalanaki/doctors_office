namespace MyApplication
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
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new Hkx.Windows.Form.Button();
            this.exitButton = new Hkx.Windows.Form.Button();
            this.fullNameLabel = new Hkx.Windows.Form.Label();
            this.fullNameTextBox = new Hkx.Windows.Form.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(88, 55);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.descriptionTextBox.Size = new System.Drawing.Size(367, 209);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(263, 270);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(344, 270);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(12, 15);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(59, 13);
            this.fullNameLabel.TabIndex = 8;
            this.fullNameLabel.Text = "&FullName";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(88, 12);
            this.fullNameTextBox.MaxLength = 20;
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(367, 21);
            this.fullNameTextBox.TabIndex = 9;
            // 
            // UpdateProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(469, 326);
            this.ControlBox = false;
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(800, 365);
            this.MinimumSize = new System.Drawing.Size(485, 365);
            this.Name = "UpdateProfileForm";
            this.Text = "Update Profie";
            this.Load += new System.EventHandler(this.UpdateProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private Hkx.Windows.Form.Button saveButton;
        private Hkx.Windows.Form.Button exitButton;
        private Hkx.Windows.Form.Label fullNameLabel;
        private Hkx.Windows.Form.TextBox fullNameTextBox;
    }
}