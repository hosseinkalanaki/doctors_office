using System.Linq;

namespace MyApplication.Admin
{
    public partial class UpdateAllUserProfileForm : Infrastructure.BaseForm
    {
        public UpdateAllUserProfileForm()
        {
            InitializeComponent();
        }

        public Models.User SelectUser { get; set; }

        public void ResetForm()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            marridCheckBox.Checked = false;
            singleCheckBox.Checked = false;
            ageTextBox.Text = string.Empty;
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            isActiveCheckBox.Checked = false;
            isAdminCheckBox.Checked = false;
            deleteCheckBox.Checked = false;
            addressTextBox.Text = string.Empty;
            phoneTextBox.Text = string.Empty;
            mobileTextBox.Text = string.Empty;
            postalCodeTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
        }

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

                if (foundeduser == null)
                {
                    System.Windows.Forms.MessageBox.Show("There Is No Such A User Anymore!");

                    Close();
                }

                userCodeTextBox.Text = SelectUser.Id;
                firstNameTextBox.Text = SelectUser.FirstName;
                lastNameTextBox.Text = foundeduser.LastName;
                if (foundeduser.IsMan == true)
                {
                    maleRadioButton.Checked = true;
                    femaleRadioButton.Checked = false;
                }
                else
                {
                    maleRadioButton.Checked = false;
                    femaleRadioButton.Checked = true;
                }
                if (foundeduser.IsMarried==true)
                {
                    marridCheckBox.Checked = true;
                    singleCheckBox.Checked = false;
                }
                else
                {
                    marridCheckBox.Checked = false;
                    singleCheckBox.Checked = true;
                }
                ageTextBox.Text = foundeduser.Age;
                isAdminCheckBox.Checked = foundeduser.IsAdmin;
                isActiveCheckBox.Checked = foundeduser.IsActive;
                addressTextBox.Text = foundeduser.Address;
                phoneTextBox.Text = foundeduser.Phone;
                mobileTextBox.Text = foundeduser.Mobile;
                postalCodeTextBox.Text = foundeduser.PostalCode;
                descriptionTextBox.Text = foundeduser.Description;
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
            if (deleteCheckBox.Checked == true)
            {
                System.Windows.Forms.MessageBox.Show("با فعال بودن گزینه حذف این کاربر از سامانه حذف می شود.");
            }
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

                if (deleteCheckBox.Checked == true)
                {
                    databaseContext.Users.Remove(foundeduser);
                    databaseContext.SaveChanges();

                    Close();
                }
                else
                {
                    foundeduser.FirstName = firstNameTextBox.Text;
                    foundeduser.LastName = lastNameTextBox.Text;
                    if (maleRadioButton.Checked==true)
                    {
                        foundeduser.IsMan = true;
                    }
                    if (femaleRadioButton.Checked==true)
                    {
                        foundeduser.IsMan = false;
                    }
                    if (marridCheckBox.Checked==true)
                    {
                        foundeduser.IsMarried = true;
                    }
                    if (singleCheckBox.Checked==true)
                    {
                        foundeduser.IsMarried = false;
                    }
                    foundeduser.Age = ageTextBox.Text;
                    foundeduser.IsAdmin = isAdminCheckBox.Checked;
                    foundeduser.IsActive = isActiveCheckBox.Checked;
                    foundeduser.Address = addressTextBox.Text;
                    foundeduser.Phone = phoneTextBox.Text;
                    foundeduser.Mobile = mobileTextBox.Text;
                    foundeduser.PostalCode = postalCodeTextBox.Text;
                    foundeduser.Description = descriptionTextBox.Text;

                    databaseContext.SaveChanges();

                    System.Windows.Forms.MessageBox.Show("Register done!");

                    Close();
                }
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

        private void deleteCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (deleteCheckBox.Checked == true)
            {
                System.Windows.Forms.MessageBox.Show("با فعال کردن این گزینه پس از سیو کردن صفحه این کاربر از سامانه حذف می شود.");
            }
        }

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            ResetForm();
        }
    }
}
