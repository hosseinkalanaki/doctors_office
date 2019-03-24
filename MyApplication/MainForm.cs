namespace MyApplication
{
    public partial class MainForm : Infrastructure.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private ChangePasswrod changePasswrod;
        private void changePasswordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if ((changePasswrod==null)||(changePasswrod.IsDisposed))
            {
                changePasswrod = new ChangePasswrod
                {
                    MdiParent = this
                };

                changePasswrod.Show();
            }
        }

        private void toolStripStatusLabel1_Click(object sender, System.EventArgs e)
        {

        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }

        public void InitializeMainForm()
        {
            adminToolStripMenuItem.Visible =
                Infrastructure.Utility.AuthenticatedUser.IsAdmin;

            if (Infrastructure.Utility.AuthenticatedUser.FullName == string.Empty)
            {
                welcomeToolStripStatusLabel.Text =
                    $"Welcome { Infrastructure.Utility.AuthenticatedUser.Username }!";
            }
            else
            {
                welcomeToolStripStatusLabel.Text =
                    $"Welcome { Infrastructure.Utility.AuthenticatedUser.FullName }!";
            }
        }

        private UpdateProfileForm updateProfileForm;
        private void UpdateToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if ((updateProfileForm == null) || (updateProfileForm.IsDisposed))
            {
                updateProfileForm = new UpdateProfileForm
                {
                    MdiParent = this
                };

                updateProfileForm.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Hide();

            Infrastructure.Utility.LoginForm.ResetForm();

            Infrastructure.Utility.AuthenticatedUser = null;

            Infrastructure.Utility.LoginForm.Show();
        }

        private UsersListForm usersList;
        private void usersListToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if ((usersList==null)||(usersList.IsDisposed))
            {
                usersList = new UsersListForm();

                usersList.ShowDialog();
            }
        }

        private void registeryUserToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Hide();

            Infrastructure.Utility.RegisterForm.Show();
        }
    }
}
