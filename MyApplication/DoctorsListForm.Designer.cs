namespace MyApplication
{
    partial class DoctorsListForm
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
            this.showInformationCheckBox = new Hkx.Windows.Form.CheckBox();
            this.exitButton = new Hkx.Windows.Form.Button2();
            this.searchButton = new Hkx.Windows.Form.Button2();
            this.searchTextBox = new Hkx.Windows.Form.TextBox();
            this.doctorListListBox = new Hkx.Windows.Form.ListBox();
            this.SuspendLayout();
            // 
            // showInformationCheckBox
            // 
            this.showInformationCheckBox.AutoSize = true;
            this.showInformationCheckBox.Location = new System.Drawing.Point(405, 311);
            this.showInformationCheckBox.Name = "showInformationCheckBox";
            this.showInformationCheckBox.Size = new System.Drawing.Size(67, 26);
            this.showInformationCheckBox.TabIndex = 77;
            this.showInformationCheckBox.Text = "Show";
            this.showInformationCheckBox.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.exitButton.Location = new System.Drawing.Point(12, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(66, 39);
            this.exitButton.TabIndex = 76;
            this.exitButton.Text = "خروج";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // searchButton
            // 
            this.searchButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.searchButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.searchButton.Location = new System.Drawing.Point(84, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(66, 39);
            this.searchButton.TabIndex = 75;
            this.searchButton.Text = "جستجو";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(156, 17);
            this.searchTextBox.MaxLength = 20;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(300, 30);
            this.searchTextBox.TabIndex = 74;
            // 
            // doctorListListBox
            // 
            this.doctorListListBox.FormattingEnabled = true;
            this.doctorListListBox.ItemHeight = 22;
            this.doctorListListBox.Location = new System.Drawing.Point(12, 60);
            this.doctorListListBox.Name = "doctorListListBox";
            this.doctorListListBox.Size = new System.Drawing.Size(444, 268);
            this.doctorListListBox.TabIndex = 73;
            this.doctorListListBox.DoubleClick += new System.EventHandler(this.doctorListListBox_DoubleClick);
            // 
            // DoctorsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 339);
            this.Controls.Add(this.showInformationCheckBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.doctorListListBox);
            this.Name = "DoctorsListForm";
            this.Text = "DoctorsListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Hkx.Windows.Form.CheckBox showInformationCheckBox;
        private Hkx.Windows.Form.Button2 exitButton;
        private Hkx.Windows.Form.Button2 searchButton;
        private Hkx.Windows.Form.TextBox searchTextBox;
        private Hkx.Windows.Form.ListBox doctorListListBox;
    }
}