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
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بیمارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.وروداطلاعاتبیمارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رزروبیمارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشاطلاعاتبیمارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.مشاهدهوقتبیمارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.وقتدهیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.welcomeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Font = new System.Drawing.Font("B Kamran", 14F);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.بیمارToolStripMenuItem,
            this.وقتدهیToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mainMenuStrip.Size = new System.Drawing.Size(458, 37);
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
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(59, 31);
            this.settingToolStripMenuItem.Text = "پروفایل";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(173, 32);
            this.updateToolStripMenuItem.Text = "به روز رسانی";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(173, 32);
            this.changePasswordToolStripMenuItem.Text = "تغییر پسورد";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(173, 32);
            this.logOutToolStripMenuItem.Text = "خروج از نام کاربری";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 32);
            this.exitToolStripMenuItem.Text = "خروج";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersListToolStripMenuItem,
            this.registeryUserToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(51, 31);
            this.adminToolStripMenuItem.Text = "ادمین";
            // 
            // usersListToolStripMenuItem
            // 
            this.usersListToolStripMenuItem.Name = "usersListToolStripMenuItem";
            this.usersListToolStripMenuItem.Size = new System.Drawing.Size(150, 32);
            this.usersListToolStripMenuItem.Text = "لیست کاربران";
            this.usersListToolStripMenuItem.Click += new System.EventHandler(this.usersListToolStripMenuItem_Click);
            // 
            // registeryUserToolStripMenuItem
            // 
            this.registeryUserToolStripMenuItem.Name = "registeryUserToolStripMenuItem";
            this.registeryUserToolStripMenuItem.Size = new System.Drawing.Size(150, 32);
            this.registeryUserToolStripMenuItem.Text = "ایجاد کاربر جدید";
            this.registeryUserToolStripMenuItem.Click += new System.EventHandler(this.registeryUserToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDoctorToolStripMenuItem,
            this.renameDoctorToolStripMenuItem});
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(45, 31);
            this.doctorToolStripMenuItem.Text = "دکتر ";
            // 
            // addDoctorToolStripMenuItem
            // 
            this.addDoctorToolStripMenuItem.Name = "addDoctorToolStripMenuItem";
            this.addDoctorToolStripMenuItem.Size = new System.Drawing.Size(235, 32);
            this.addDoctorToolStripMenuItem.Text = "ورود مشخصات دکتر جدید";
            this.addDoctorToolStripMenuItem.Click += new System.EventHandler(this.addDoctorToolStripMenuItem_Click);
            // 
            // renameDoctorToolStripMenuItem
            // 
            this.renameDoctorToolStripMenuItem.Name = "renameDoctorToolStripMenuItem";
            this.renameDoctorToolStripMenuItem.Size = new System.Drawing.Size(235, 32);
            this.renameDoctorToolStripMenuItem.Text = "ورود ساعات حضور دکتر در مطب";
            this.renameDoctorToolStripMenuItem.Click += new System.EventHandler(this.renameDoctorToolStripMenuItem_Click);
            // 
            // بیمارToolStripMenuItem
            // 
            this.بیمارToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.وروداطلاعاتبیمارToolStripMenuItem,
            this.رزروبیمارToolStripMenuItem,
            this.ویرایشاطلاعاتبیمارToolStripMenuItem,
            this.toolStripMenuItem2,
            this.مشاهدهوقتبیمارToolStripMenuItem});
            this.بیمارToolStripMenuItem.Name = "بیمارToolStripMenuItem";
            this.بیمارToolStripMenuItem.Size = new System.Drawing.Size(44, 31);
            this.بیمارToolStripMenuItem.Text = "بیمار";
            // 
            // وروداطلاعاتبیمارToolStripMenuItem
            // 
            this.وروداطلاعاتبیمارToolStripMenuItem.Name = "وروداطلاعاتبیمارToolStripMenuItem";
            this.وروداطلاعاتبیمارToolStripMenuItem.Size = new System.Drawing.Size(189, 32);
            this.وروداطلاعاتبیمارToolStripMenuItem.Text = "ورود اطلاعات بیمار";
            // 
            // رزروبیمارToolStripMenuItem
            // 
            this.رزروبیمارToolStripMenuItem.Name = "رزروبیمارToolStripMenuItem";
            this.رزروبیمارToolStripMenuItem.Size = new System.Drawing.Size(189, 32);
            this.رزروبیمارToolStripMenuItem.Text = "مشاهده اطلاعات بیمار";
            this.رزروبیمارToolStripMenuItem.Click += new System.EventHandler(this.رزروبیمارToolStripMenuItem_Click);
            // 
            // ویرایشاطلاعاتبیمارToolStripMenuItem
            // 
            this.ویرایشاطلاعاتبیمارToolStripMenuItem.Name = "ویرایشاطلاعاتبیمارToolStripMenuItem";
            this.ویرایشاطلاعاتبیمارToolStripMenuItem.Size = new System.Drawing.Size(189, 32);
            this.ویرایشاطلاعاتبیمارToolStripMenuItem.Text = "ویرایش اطلاعات بیمار";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(186, 6);
            // 
            // مشاهدهوقتبیمارToolStripMenuItem
            // 
            this.مشاهدهوقتبیمارToolStripMenuItem.Name = "مشاهدهوقتبیمارToolStripMenuItem";
            this.مشاهدهوقتبیمارToolStripMenuItem.Size = new System.Drawing.Size(189, 32);
            this.مشاهدهوقتبیمارToolStripMenuItem.Text = "مشاهده وقت بیمار ";
            // 
            // وقتدهیToolStripMenuItem
            // 
            this.وقتدهیToolStripMenuItem.Name = "وقتدهیToolStripMenuItem";
            this.وقتدهیToolStripMenuItem.Size = new System.Drawing.Size(75, 31);
            this.وقتدهیToolStripMenuItem.Text = "وقت دهی";
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 432);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.mainStatusStrip.Size = new System.Drawing.Size(458, 22);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 454);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
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
        private System.Windows.Forms.ToolStripMenuItem بیمارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem وروداطلاعاتبیمارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem رزروبیمارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ویرایشاطلاعاتبیمارToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهوقتبیمارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem وقتدهیToolStripMenuItem;
    }
}