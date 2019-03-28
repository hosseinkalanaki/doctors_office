using System.Linq;

namespace MyApplication
{
    public partial class RegisterForm : Infrastructure.BaseForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            ResetForm();
        }

        public void ResetForm()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            ageTextBox.Text = string.Empty;
            marridCheckBox.Checked = false;
            singleCheckBox.Checked = false;
            addressTextBox.Text = string.Empty;
            mobileTextBox.Text = string.Empty;
            phoneTextBox.Text = string.Empty;
            postalCodeTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            confirmPasswordTextBox.Text = string.Empty;

            firstNameTextBox.Focus();

            return;
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            //clear space input 
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text)||
                string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text)||
                string.IsNullOrWhiteSpace(firstNameTextBox.Text)||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text)
                )

            {
                usernameTextBox.Text =
                    usernameTextBox.Text.Replace(" ", string.Empty);

                passwordTextBox.Text =
                    passwordTextBox.Text.Replace(" ", string.Empty);

                confirmPasswordTextBox.Text =
                    confirmPasswordTextBox.Text.Replace(" ", string.Empty);

                firstNameTextBox.Text =
                    firstNameTextBox.Text.Replace(" ", string.Empty);

                lastNameTextBox.Text =
                    lastNameTextBox.Text.Replace(" ", string.Empty);


                //cheking null usernmae textbox
                if (usernameTextBox.Text == string.Empty)
                {
                    usernameTextBox.Focus();
                }

                //cheking null password textbox

                if (passwordTextBox.Text==string.Empty)
                {
                    passwordTextBox.Focus();
                }

                //cheking null confirm password textbox

                if (confirmPasswordTextBox.Text == string.Empty)
                {
                    confirmPasswordTextBox.Focus();
                }

                //cheking null firstname textbox

                if (firstNameTextBox.Text == string.Empty)
                {
                    firstNameTextBox.Focus();
                }

                //cheking null lastname textbox

                if (lastNameTextBox.Text == string.Empty)
                {
                    lastNameTextBox.Focus();
                }


                return;
            }

            //create error messages
            string errorMessages = string.Empty;

            //cheking username textbox lenght
            if (usernameTextBox.Text.Length < 6)
            {
                errorMessages =
                    "Username Lenght Should Be At Least 6 Characters!";
            }

            //cheking passwrod textbox lenght
            if (passwordTextBox.Text.Length < 8)
            {
                if (errorMessages != string.Empty)
                {
                    errorMessages +=
                        System.Environment.NewLine;
                }

                errorMessages +=
                    "Password Lenght Should Be At Least 8 Characters!";
            }

            //cheking password confirm

            if (passwordTextBox.Text!=confirmPasswordTextBox.Text)
            {
                if (errorMessages != string.Empty)
                {
                    errorMessages +=
                        System.Environment.NewLine;
                }

                errorMessages +=
                    "passrod confirm in incorrect!";
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

                Models.User user =
                    databaseContext.Users
                    .Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0).FirstOrDefault();

                if (user != null)
                {
                    System.Windows.Forms.MessageBox.Show
                        ("This username is already exist! Please choose another one...");

                    usernameTextBox.Focus();

                    return;
                }

                user = new Models.User
                {
                    
                    Password = passwordTextBox.Text,
                    Username = usernameTextBox.Text,

                    IsActive = true,
                };

                databaseContext.Users.Add(user);

                databaseContext.SaveChanges();

                System.Windows.Forms.MessageBox.Show("Registration Done!");

                ResetForm();
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

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();

            Infrastructure.Utility.LoginForm.Show();
        }
    }
}
