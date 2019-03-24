using System.Linq;

namespace MyApplication
{
    public partial class LoginForm : Infrastructure.BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //**************************************************

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //**************************************************

        private void ResetButton_Click_1(object sender, System.EventArgs e)
        {
            ResetForm();
        }        
        public void ResetForm()
        {
            Infrastructure.Utility.AuthenticatedUser = null;

            passwordTextBox.Text = string.Empty;
            usernameTextBox.Text = string.Empty;

            usernameTextBox.Focus();            
        }

        //**************************************************

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();

                Models.User foundedUser =
                    databaseContext.Users
                    .Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
                    .FirstOrDefault();

                if (foundedUser == null)
                {
                    System.Windows.Forms.MessageBox.Show("Username and/or Password is not correct!");

                    usernameTextBox.Focus();

                    return;
                }

                if (string.Compare(foundedUser.Password, passwordTextBox.Text, ignoreCase: false) != 0)
                {
                    System.Windows.Forms.MessageBox.Show("Username and/or Password is not correct!");

                    usernameTextBox.Focus();

                    return;
                }

                if (foundedUser.IsActive == false)
                {
                    System.Windows.Forms.MessageBox
                        .Show("You can not login to this application!Please contact to support team.");

                    usernameTextBox.Focus();

                    return;
                }

                if (foundedUser.IsActive == false)
                {
                    System.Windows.Forms.MessageBox
                        .Show("You can not login to this application! Please contact support team.");

                    usernameTextBox.Focus();

                    return;
                }

                //System.Windows.Forms.MessageBox.Show("Welcome!");

                Infrastructure.Utility.AuthenticatedUser = foundedUser;

                Hide();

                Infrastructure.Utility.MainForm.InitializeMainForm();

                Infrastructure.Utility.MainForm.Show();


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
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

        private void LoginForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
