using System.Linq;

namespace MyApplication
{
    public partial class UpdateProfileForm : Infrastructure.BaseForm
    {
        public UpdateProfileForm()
        {
            InitializeComponent();
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

            firstNameTextBox.Focus();

            return;
        }
        private void UpdateProfileForm_Load(object sender, System.EventArgs e)
        {
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

                firstNameTextBox.Text = currentUser.FirstName;
                lastNameTextBox.Text = currentUser.LastName;
                ageTextBox.Text = currentUser.Age;
                addressTextBox.Text = currentUser.Address;
                phoneTextBox.Text = currentUser.Phone;
                mobileTextBox.Text = currentUser.Mobile;
                postalCodeTextBox.Text = currentUser.PostalCode;
                descriptionTextBox.Text = currentUser.Description;
                if (currentUser.IsMan==true)
                {
                    maleRadioButton.Checked = true;
                }
                else
                {
                    femaleRadioButton.Checked = true;
                }
                if (currentUser.IsMarried==true)
                {
                    marridCheckBox.Checked = true;
                    singleCheckBox.Checked = false;
                }
                else
                {
                    singleCheckBox.Checked = true;
                    marridCheckBox.Checked = false;
                }
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

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
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

                currentUser.FirstName = firstNameTextBox.Text;
                currentUser.LastName = lastNameTextBox.Text;
                currentUser.Age = ageTextBox.Text;
                currentUser.Address = addressTextBox.Text;
                currentUser.Phone = phoneTextBox.Text;
                currentUser.Mobile = mobileTextBox.Text;
                currentUser.PostalCode = postalCodeTextBox.Text;
                currentUser.Description = descriptionTextBox.Text;
                if (maleRadioButton.Checked==true)
                {
                    currentUser.IsMan = true;
                }

                if (femaleRadioButton.Checked==true)
                {
                    currentUser.IsMan = false;
                }

                if (marridCheckBox.Checked==true)
                {
                    currentUser.IsMarried = true;
                }

                if (singleCheckBox.Checked==true)
                {
                    currentUser.IsMarried = false;
                }
                databaseContext.SaveChanges();

                Infrastructure.Utility.AuthenticatedUser = currentUser;

                Infrastructure.Utility.MainForm.InitializeMainForm();

                System.Windows.Forms.MessageBox
                    .Show("Your profile updated successfully...");

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

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            ResetForm();
        }

        private void marridCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (marridCheckBox.Checked==true)
            {
                singleCheckBox.Checked = false;
            }
        }

        private void singleCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (singleCheckBox.Checked==true)
            {
                marridCheckBox.Checked = false;
            }
        }
    }
}
    

