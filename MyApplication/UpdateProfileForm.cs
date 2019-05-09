using System.Linq;

namespace MyApplication
{
    public partial class UpdateProfileForm : Infrastructure.BaseForm
    {
        public UpdateProfileForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        public void ResetForm()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            marridCheckBox.Checked = false;
            singleCheckBox.Checked = false;
            ageTextBox.Text = string.Empty;
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            addressTextBox.Text = string.Empty;
            phoneTextBox.Text = string.Empty;
            mobileTextBox.Text = string.Empty;
            postalCodeTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
        }

        private void UpdateProfileForm_Load(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();

                Models.User currentUser =
                   databaseContext.Users
                   .Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
                   .FirstOrDefault();

                if (currentUser == null)
                {
                    System.Windows.Forms.Application.Exit();
                }

                userCodeTextBox.Text = currentUser.Id;
                firstNameTextBox.Text = currentUser.FirstName;
                lastNameTextBox.Text = currentUser.LastName;
                if (currentUser.IsMan == true)
                {
                    maleRadioButton.Checked = true;
                    femaleRadioButton.Checked = false;
                }
                else
                {
                    maleRadioButton.Checked = false;
                    femaleRadioButton.Checked = true;
                }
                if (currentUser.IsMarried == true)
                {
                    marridCheckBox.Checked = true;
                    singleCheckBox.Checked = false;
                }
                else
                {
                    marridCheckBox.Checked = false;
                    singleCheckBox.Checked = true;
                }
                ageTextBox.Text = currentUser.Age;
                addressTextBox.Text = currentUser.Address;
                phoneTextBox.Text = currentUser.Phone;
                mobileTextBox.Text = currentUser.Mobile;
                postalCodeTextBox.Text = currentUser.PostalCode;
                descriptionTextBox.Text = currentUser.Description;
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

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            ResetForm();
        }

        private void registerButton_Click(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                Models.User foundeduser =
                    databaseContext.Users
                    .Where(current => current.Id == userCodeTextBox.Text)
                    .FirstOrDefault();

                if (foundeduser == null)
                {
                    System.Windows.Forms.MessageBox.Show("There Is No Such A User Anymore!");

                    Close();
                }
                foundeduser.FirstName = firstNameTextBox.Text;
                foundeduser.LastName = lastNameTextBox.Text;
                if (maleRadioButton.Checked == true)
                {
                    foundeduser.IsMan = true;
                }
                if (femaleRadioButton.Checked == true)
                {
                    foundeduser.IsMan = false;
                }
                if (marridCheckBox.Checked == true)
                {
                    foundeduser.IsMarried = true;
                }
                if (singleCheckBox.Checked == true)
                {
                    foundeduser.IsMarried = true;
                }
                foundeduser.Age = ageTextBox.Text;
                foundeduser.Address = addressTextBox.Text;
                foundeduser.Phone = phoneTextBox.Text;
                foundeduser.Mobile = mobileTextBox.Text;
                foundeduser.PostalCode = postalCodeTextBox.Text;
                foundeduser.Description = descriptionTextBox.Text;

                databaseContext.SaveChanges();

                System.Windows.Forms.MessageBox.Show("Register done!");

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
    }
}
