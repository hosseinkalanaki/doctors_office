using System.Linq;

namespace MyApplication
{
    public partial class ChangePasswrodForm : Infrastructure.BaseForm
    {
        public ChangePasswrodForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            //clear space input 
            if (string.IsNullOrWhiteSpace(oldPasswrodTextBox.Text) ||
                string.IsNullOrWhiteSpace(newPasswrodTextBox.Text)||
                string.IsNullOrWhiteSpace(confirmNewPasswordLabel.Text))

            {
                oldPasswrodTextBox.Text =
                    oldPasswrodTextBox.Text.Replace(" ", string.Empty);

                newPasswrodTextBox.Text =
                    newPasswrodTextBox.Text.Replace(" ", string.Empty);

                confirmNewPasswordTextBox.Text =
                    confirmNewPasswordTextBox.Text.Replace(" ", string.Empty);

                //cheking null usernmae textbox
                if (oldPasswrodTextBox.Text == string.Empty)
                {
                    oldPasswrodTextBox.Focus();
                }

                else
                {
                    if (newPasswrodTextBox.Text==string.Empty)
                    {
                        newPasswrodTextBox.Focus();
                    }
                    else
                    {
                        confirmNewPasswordTextBox.Focus();
                    }
                }

                return;
            }

            //create error messages
            string errorMessages = string.Empty;

            //cheking passwrod textbox lenght
            if (newPasswrodTextBox.Text.Length < 8)
            {
                if (errorMessages != string.Empty)
                {
                    errorMessages +=
                        System.Environment.NewLine;
                }

                errorMessages +=
                    "Password Lenght Should Be At Least 8 Characters!";
            }

            if (string.Compare(newPasswrodTextBox.Text, confirmNewPasswordTextBox.Text, true) != 0)
            {
                if (errorMessages != string.Empty)
                {
                    errorMessages +=
                        System.Environment.NewLine;
                }

                errorMessages +=
                    "The Passwrod Is Not Confirm!";
            }

            if (errorMessages != string.Empty)
            {
                System.Windows.Forms.MessageBox.Show(errorMessages);

                return;
            }
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                Models.User currentUser =
                    databaseContext.Users
                    .Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
                    .FirstOrDefault();

                if (currentUser == null)
                {
                    System.Windows.Forms.Application.Exit();
                }

                if (string.Compare(Infrastructure.Utility.AuthenticatedUser.Password,oldPasswrodTextBox.Text,true)!=0)
                {
                    System.Windows.Forms.MessageBox.Show("Old Passwrod Is Not Ok!");

                    oldPasswrodTextBox.Focus();

                    return;
                }

                currentUser.Password = newPasswrodTextBox.Text;

                databaseContext.SaveChanges();

                Infrastructure.Utility.AuthenticatedUser = currentUser;

                Infrastructure.Utility.MainForm.InitializeMainForm();

                System.Windows.Forms.MessageBox
                    .Show("Your Password has updated successfully...");

                Close();
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
    }
}
