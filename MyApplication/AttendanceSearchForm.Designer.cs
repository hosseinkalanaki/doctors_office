namespace MyApplication
{
    partial class AttendanceSearchForm
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
            this.searchLabel = new Hkx.Windows.Form.Label();
            this.searchTextBox = new Hkx.Windows.Form.TextBox();
            this.searchButton = new Hkx.Windows.Form.Button2();
            this.exitButton = new Hkx.Windows.Form.Button2();
            this.doctorListBox = new Hkx.Windows.Form.ListBox();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("B Kamran", 14F);
            this.searchLabel.Location = new System.Drawing.Point(15, 18);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(80, 27);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "نام یا کد دکتر :";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(103, 18);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.MaxLength = 20;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(271, 30);
            this.searchTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.searchButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.searchButton.Location = new System.Drawing.Point(381, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(66, 39);
            this.searchButton.TabIndex = 64;
            this.searchButton.Text = "جستجو";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.exitButton.Location = new System.Drawing.Point(12, 284);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(66, 39);
            this.exitButton.TabIndex = 65;
            this.exitButton.Text = "خروج";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // doctorListBox
            // 
            this.doctorListBox.FormattingEnabled = true;
            this.doctorListBox.ItemHeight = 22;
            this.doctorListBox.Location = new System.Drawing.Point(20, 56);
            this.doctorListBox.Name = "doctorListBox";
            this.doctorListBox.Size = new System.Drawing.Size(427, 224);
            this.doctorListBox.TabIndex = 66;
            this.doctorListBox.SelectedIndexChanged += new System.EventHandler(this.doctorListBox_SelectedIndexChanged);
            this.doctorListBox.DoubleClick += new System.EventHandler(this.doctorListBox_DoubleClick);
            // 
            // AttendanceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 335);
            this.Controls.Add(this.doctorListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Name = "AttendanceSearch";
            this.Text = "جستجو دکتر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Hkx.Windows.Form.Label searchLabel;
        private Hkx.Windows.Form.TextBox searchTextBox;
        private Hkx.Windows.Form.Button2 searchButton;
        private Hkx.Windows.Form.Button2 exitButton;
        private Hkx.Windows.Form.ListBox doctorListBox;
    }
}