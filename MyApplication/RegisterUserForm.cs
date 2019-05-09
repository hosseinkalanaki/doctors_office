using System.Linq;

namespace MyApplication
{
    public partial class RegisterUserForm : Infrastructure.BaseForm
    {
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        public void InitializeUserId()
        {

        }

        private System.Drawing.Color TextBoxBackColor;

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
            Hide();
        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            //clear space input 
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text) ||
                string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text)
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

                    usernameTextBox.BackColor = System.Drawing.Color.Red;
                }

                //cheking null password textbox

                if (passwordTextBox.Text == string.Empty)
                {
                    passwordTextBox.Focus();

                    passwordTextBox.BackColor = System.Drawing.Color.Red;
                }

                //cheking null confirm password textbox

                if (confirmPasswordTextBox.Text == string.Empty)
                {
                    confirmPasswordTextBox.Focus();

                    confirmPasswordTextBox.BackColor = System.Drawing.Color.Red;
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

            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
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

                    usernameTextBox.BackColor = System.Drawing.Color.Red;

                    return;
                }

                bool isMarried = marridCheckBox.Checked;

                bool isMan = maleRadioButton.Checked;

                user = new Models.User
                {
                    Id = userCodeTextBox.Text,
                    Password = passwordTextBox.Text,
                    Username = usernameTextBox.Text,
                    IsActive = false,

                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Age = ageTextBox.Text,
                    Address = addressTextBox.Text,
                    Mobile = mobileTextBox.Text,
                    Phone = phoneTextBox.Text,
                    PostalCode = postalCodeTextBox.Text,
                    IsMarried = isMarried,
                    IsMan = isMan,
                    Description = descriptionTextBox.Text,
                };

                databaseContext.Users.Add(user);

                databaseContext.SaveChanges();

                System.Windows.Forms.MessageBox.Show("Registration Done!");

                Infrastructure.Utility.EndUserId = userCodeTextBox.Text;

                int userNumber = System.Convert.ToInt32(userCodeTextBox.Text);

                userNumber++;

                userCodeTextBox.Text = userNumber.ToString();

                ResetForm();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    System.Windows.Forms.MessageBox.Show($"Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        System.Windows.Forms.MessageBox.Show($"- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName);
                    }
                }
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

        private void usernameTextBox_Enter(object sender, System.EventArgs e)
        {
            usernameTextBox.BackColor = TextBoxBackColor;
        }

        private void RegisterForm_Load(object sender, System.EventArgs e)
        {
            int newUserNumber;

            #region first open 
            if (Infrastructure.Utility.EndUserId == string.Empty || Infrastructure.Utility.EndUserId == null)
            {
                Models.DatabaseContext databaseContext = null;
                try
                {
                    databaseContext = new Models.DatabaseContext();

                    System.Collections.Generic.List<Models.User> endUser = null;

                    endUser =
                        databaseContext.Users
                        .OrderBy(current => current.Id)
                        .ToList();

                    newUserNumber = endUser.Count();


                    Infrastructure.Utility.EndUserId = newUserNumber.ToString();

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

            #endregion/first open

            #region next open
            else
            {
                newUserNumber = System.Convert.ToInt32(Infrastructure.Utility.EndUserId);
            }

            #endregion/next open

            newUserNumber++;

            userCodeTextBox.Text = newUserNumber.ToString();

            TextBoxBackColor = usernameTextBox.BackColor;
        }

        private void passwordTextBox_Enter(object sender, System.EventArgs e)
        {

            passwordTextBox.BackColor = TextBoxBackColor;
        }

        private void confirmPasswordTextBox_Enter(object sender, System.EventArgs e)
        {
            confirmPasswordTextBox.BackColor = TextBoxBackColor;
        }

        private void marridCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (marridCheckBox.Checked == true)
            {
                singleCheckBox.Checked = false;
            }
        }

        private void singleCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (singleCheckBox.Checked == true)
            {
                marridCheckBox.Checked = false;
            }
        }
    }
}
