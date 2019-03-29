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

            if (Infrastructure.Utility.AuthenticatedUser.FirstName == string.Empty)
            {
                welcomeToolStripStatusLabel.Text =
                    $"Welcome { Infrastructure.Utility.AuthenticatedUser.Username }!";
            }
            else
            {
                welcomeToolStripStatusLabel.Text =
                    $"Welcome { Infrastructure.Utility.AuthenticatedUser.FirstName }!";
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

            Infrastructure.Utility.RegisterForm.Show();
        }

        private AttendanceSearch attendanceSearch;
        private void renameDoctorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if ((attendanceSearch == null) || (attendanceSearch.IsDisposed))
            {
                attendanceSearch = new AttendanceSearch();

                attendanceSearch.ShowDialog();
            }

            attendanceSearch.Dispose();

            attendanceSearch = null;
        }

        private void settingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void رزروبیمارToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void وقتدهیهToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        //private NewDoctor newDoctor;
        private void addDoctorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //    if ((newDoctor == null) || (newDoctor.IsDisposed))
            //    {
            //        newDoctor = new NewDoctor();

            //        newDoctor.ShowDialog();
            //    }

            //    newDoctor.Dispose();

            //    newDoctor = null;
        }
    }
}
