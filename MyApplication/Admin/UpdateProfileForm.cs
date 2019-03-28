using System.Linq;

namespace MyApplication.Admin
{
    public partial class UpdateProfileForm : Infrastructure.BaseForm
    {
        public UpdateProfileForm()
        {
            InitializeComponent();
        }

        public Models.User SelectUser { get; set; }

        private void UpdateProfileForm_Load(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;

            //show information user
            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                Models.User foundeduser =
                    databaseContext.Users
                    .Where(current => current.Id == SelectUser.Id)
                    .FirstOrDefault();

                if (foundeduser==null)
                {
                    System.Windows.Forms.MessageBox.Show("There Is No Such A User Anymore!");

                    Close();
                }

                //fullNmaeTextBox.Text = foundeduser.FullName;

                descriptionTextBox.Text = foundeduser.Description;

                adminCheckBox.Checked = foundeduser.IsAdmin;

                activeCheckBox.Checked = foundeduser.IsActive;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

                return;
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();

                    databaseContext = null;
                }
            }

        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                Models.User foundeduser =
                    databaseContext.Users
                    .Where(current => current.Id == SelectUser.Id)
                    .FirstOrDefault();

                if (foundeduser==null)
                {
                    System.Windows.Forms.MessageBox.Show("There Is No Such A User Anymore!");

                    Close();
                }

                foundeduser.FirstName = fullNmaeTextBox.Text;

                foundeduser.Description = descriptionTextBox.Text;

                foundeduser.IsActive = activeCheckBox.Checked;

                foundeduser.IsAdmin = adminCheckBox.Checked;

                databaseContext.SaveChanges();

                Close();
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

                return;
            }

            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();

                    databaseContext = null;
                }
            }

        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
