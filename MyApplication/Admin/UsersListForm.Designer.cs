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
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.usersListListBox = new System.Windows.Forms.ListBox();
            this.searchButton = new Hkx.Windows.Form.Button();
            this.ebutton = new Hkx.Windows.Form.Button();
            this.deleteButton = new Hkx.Windows.Form.Button();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(12, 17);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(63, 13);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "&Full Name";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(13, 41);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(62, 13);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "&Users List";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(81, 14);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(157, 21);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // usersListListBox
            // 
            this.usersListListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersListListBox.FormattingEnabled = true;
            this.usersListListBox.Location = new System.Drawing.Point(81, 41);
            this.usersListListBox.MultiColumn = true;
            this.usersListListBox.Name = "usersListListBox";
            this.usersListListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.usersListListBox.Size = new System.Drawing.Size(238, 95);
            this.usersListListBox.TabIndex = 4;
            this.usersListListBox.DoubleClick += new System.EventHandler(this.usersListListBox_DoubleClick);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(245, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ebutton
            // 
            this.ebutton.Location = new System.Drawing.Point(244, 142);
            this.ebutton.Name = "ebutton";
            this.ebutton.Size = new System.Drawing.Size(75, 23);
            this.ebutton.TabIndex = 6;
            this.ebutton.Text = "E&xit";
            this.ebutton.UseVisualStyleBackColor = true;
            this.ebutton.Click += new System.EventHandler(this.ebutton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(163, 142);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // UsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 198);
            this.ControlBox = false;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.ebutton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.usersListListBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.fullNameLabel);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(347, 214);
            this.Name = "UsersListForm";
            this.Text = "UsersListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.ListBox usersListListBox;
        private Hkx.Windows.Form.Button searchButton;
        private Hkx.Windows.Form.Button ebutton;
        private Hkx.Windows.Form.Button deleteButton;
    }
}