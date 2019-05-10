namespace MyApplication
{
    public partial class MainForm : Infrastructure.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private ChangePasswrodForm changePasswrod;
        private void changePasswordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if ((changePasswrod == null) || (changePasswrod.IsDisposed))
            {
                changePasswrod = new ChangePasswrodForm
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
                if (Infrastructure.Utility.AuthenticatedUser.LastName == string.Empty)
                {
                    welcomeToolStripStatusLabel.Text =
                     $"خوش آمدید { Infrastructure.Utility.AuthenticatedUser.Username }!";
                }

                else
                {
                    welcomeToolStripStatusLabel.Text =
                        $"خوش آمدید { Infrastructure.Utility.AuthenticatedUser.FirstName }!";
                }
            }
            else
            {
                welcomeToolStripStatusLabel.Text =
                    $"خوش آمدید { Infrastructure.Utility.AuthenticatedUser.FirstName } {Infrastructure.Utility.AuthenticatedUser.LastName}!";
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
            if ((usersList == null) || (usersList.IsDisposed))
            {
                usersList = new UsersListForm();

                usersList.Show();
            }
        }

        private void registeryUserToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            Infrastructure.Utility.RegisterForm.Show();
        }

        private void renameDoctorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            Infrastructure.Utility.AttendanceSearch.Show();
        }

        private void settingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void رزروبیمارToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if ((patientList == null) || (patientList.IsDisposed))
            {
                patientList = new PatientsListForm();
            }

            patientList.Show();
        }

        private void وقتدهیهToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void addDoctorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {


            Infrastructure.Utility.RegisterDoctorForm.ResetForm();

            Infrastructure.Utility.RegisterDoctorForm.Show();
        }

        private void وروداطلاعاتبیمارToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Infrastructure.Utility.RegisterPatientForm.ResetForm();

            Infrastructure.Utility.RegisterPatientForm.Show();
        }

        private void exitHideButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private PatientsListForm patientList;

        private void بیمارانToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if ((patientList == null) || (patientList.IsDisposed))
            {
                patientList = new PatientsListForm();
            }

            patientList.Show();
        }

        private DoctorsListForm doctorList;
        private void پزشکانToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if ((doctorList == null) || (doctorList.IsDisposed))
            {
                doctorList = new DoctorsListForm();
            }
            doctorList.Show();
        }
    }
}
