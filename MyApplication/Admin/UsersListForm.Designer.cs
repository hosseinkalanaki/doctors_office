namespace MyApplication
{
    partial class UsersListForm
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
            this.usersListListBox = new Hkx.Windows.Form.ListBox();
            this.searchTextBox = new Hkx.Windows.Form.TextBox();
            this.searchButton = new Hkx.Windows.Form.Button2();
            this.exitButton = new Hkx.Windows.Form.Button2();
            this.showInformationCheckBox = new Hkx.Windows.Form.CheckBox();
            this.SuspendLayout();
            // 
            // usersListListBox
            // 
            this.usersListListBox.FormattingEnabled = true;
            this.usersListListBox.ItemHeight = 22;
            this.usersListListBox.Location = new System.Drawing.Point(12, 55);
            this.usersListListBox.Name = "usersListListBox";
            this.usersListListBox.Size = new System.Drawing.Size(444, 268);
            this.usersListListBox.TabIndex = 0;
            this.usersListListBox.SelectedIndexChanged += new System.EventHandler(this.usersListListBox_SelectedIndexChanged);
            this.usersListListBox.DoubleClick += new System.EventHandler(this.usersListListBox_DoubleClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(156, 12);
            this.searchTextBox.MaxLength = 20;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(300, 30);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.searchButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.searchButton.Location = new System.Drawing.Point(84, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(66, 39);
            this.searchButton.TabIndex = 65;
            this.searchButton.Text = "جستجو";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("B Kamran", 14F);
            this.exitButton.Location = new System.Drawing.Point(12, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(66, 39);
            this.exitButton.TabIndex = 66;
            this.exitButton.Text = "خروج";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // showInformationCheckBox
            // 
            this.showInformationCheckBox.AutoSize = true;
            this.showInformationCheckBox.Location = new System.Drawing.Point(405, 306);
            this.showInformationCheckBox.Name = "showInformationCheckBox";
            this.showInformationCheckBox.Size = new System.Drawing.Size(67, 26);
            this.showInformationCheckBox.TabIndex = 67;
            this.showInformationCheckBox.Text = "Show";
            this.showInformationCheckBox.UseVisualStyleBackColor = true;
            // 
            // UsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 335);
            this.Controls.Add(this.showInformationCheckBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.usersListListBox);
            this.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.MaximumSize = new System.Drawing.Size(1024, 1327);
            this.MinimumSize = new System.Drawing.Size(442, 335);
            this.Name = "UsersListForm";
            this.Text = "لیست کاربران";
            this.Load += new System.EventHandler(this.UsersListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private Hkx.Windows.Form.ListBox usersListListBox;
        private Hkx.Windows.Form.TextBox searchTextBox;
        private Hkx.Windows.Form.Button2 searchButton;
        private Hkx.Windows.Form.Button2 exitButton;
        private Hkx.Windows.Form.CheckBox showInformationCheckBox;
    }
}