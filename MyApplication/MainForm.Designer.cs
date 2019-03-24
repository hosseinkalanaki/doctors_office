namespace MyApplication
{
    partial class MainForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registeryUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.welcomeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.doctorToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(356, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripMenuItem1,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingToolStripMenuItem.Text = "&Settings";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.updateToolStripMenuItem.Text = "&Update Profile";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "&Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logOutToolStripMenuItem.Text = "&Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersListToolStripMenuItem,
            this.registeryUserToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "&Admin";
            // 
            // usersListToolStripMenuItem
            // 
            this.usersListToolStripMenuItem.Name = "usersListToolStripMenuItem";
            this.usersListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usersListToolStripMenuItem.Text = "&Users List";
            this.usersListToolStripMenuItem.Click += new System.EventHandler(this.usersListToolStripMenuItem_Click);
            // 
            // registeryUserToolStripMenuItem
            // 
            this.registeryUserToolStripMenuItem.Name = "registeryUserToolStripMenuItem";
            this.registeryUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registeryUserToolStripMenuItem.Text = "&Register User";
            this.registeryUserToolStripMenuItem.Click += new System.EventHandler(this.registeryUserToolStripMenuItem_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 246);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.mainStatusStrip.Size = new System.Drawing.Size(356, 22);
            this.mainStatusStrip.TabIndex = 2;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // welcomeToolStripStatusLabel
            // 
            this.welcomeToolStripStatusLabel.Name = "welcomeToolStripStatusLabel";
            this.welcomeToolStripStatusLabel.Size = new System.Drawing.Size(27, 17);
            this.welcomeToolStripStatusLabel.Text = "----";
            this.welcomeToolStripStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDoctorToolStripMenuItem,
            this.renameDoctorToolStripMenuItem});
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.doctorToolStripMenuItem.Text = "&Doctor";
            // 
            // addDoctorToolStripMenuItem
            // 
            this.addDoctorToolStripMenuItem.Name = "addDoctorToolStripMenuItem";
            this.addDoctorToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.addDoctorToolStripMenuItem.Text = "&Add new doctor";
            // 
            // renameDoctorToolStripMenuItem
            // 
            this.renameDoctorToolStripMenuItem.Name = "renameDoctorToolStripMenuItem";
            this.renameDoctorToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.renameDoctorToolStripMenuItem.Text = "Date or &Time of Attendance";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 268);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "UserManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel welcomeToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem usersListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registeryUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameDoctorToolStripMenuItem;
    }
}