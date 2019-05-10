using System.Linq;

namespace MyApplication
{
    public partial class UpdateDoctorsProfileForm : Infrastructure.BaseForm
    {
        public UpdateDoctorsProfileForm()
        {
            InitializeComponent();
        }

        public Models.Doctors SelectedDoctor { get; set; }

        public void ResetForm()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            marridCheckBox.Checked = false;
            singleCheckBox.Checked = false;
            ageTextBox.Text = string.Empty;
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            deleteCheckBox.Checked = false;
            addressTextBox.Text = string.Empty;
            phoneTextBox.Text = string.Empty;
            mobileTextBox.Text = string.Empty;
            postalCodeTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
        }

        private void UpdateAllDoctorsProfileForm_Load(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;

            //show information user
            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                Models.Doctors foundedDoctor =
                    databaseContext.Doctor
                    .Where(current => current.Id == SelectedDoctor.Id)
                    .FirstOrDefault();

                if (foundedDoctor == null)
                {
                    System.Windows.Forms.MessageBox.Show("There Is No Such A User Anymore!");

                    Close();
                }

                patientCodeTextBox.Text = foundedDoctor.Id;
                firstNameTextBox.Text = foundedDoctor.FirstName;
                lastNameTextBox.Text = foundedDoctor.LastName;
                if (foundedDoctor.IsMan == true)
                {
                    maleRadioButton.Checked = true;
                    femaleRadioButton.Checked = false;
                }
                else
                {
                    maleRadioButton.Checked = false;
                    femaleRadioButton.Checked = true;
                }
                if (foundedDoctor.IsMarried == true)
                {
                    marridCheckBox.Checked = true;
                    singleCheckBox.Checked = false;
                }
                else
                {
                    marridCheckBox.Checked = false;
                    singleCheckBox.Checked = true;
                }
                ageTextBox.Text = foundedDoctor.Age;
                expertiseTextBox.Text = foundedDoctor.Expertise;
                addressTextBox.Text = foundedDoctor.Address;
                phoneTextBox.Text = foundedDoctor.Phone;
                mobileTextBox.Text = foundedDoctor.Mobile;
                postalCodeTextBox.Text = foundedDoctor.PostalCode;
                descriptionTextBox.Text = foundedDoctor.Description;
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

        private void registerButton_Click_1(object sender, System.EventArgs e)
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

                Models.Doctors foundedDoctor =
                    databaseContext.Doctor
                    .Where(current => current.Id == patientCodeTextBox.Text)
                    .FirstOrDefault();

                if (foundedDoctor == null)
                {
                    System.Windows.Forms.MessageBox.Show("There Is No Such A User Anymore!");

                    Close();
                }

                if (deleteCheckBox.Checked == true)
                {
                    databaseContext.Doctor.Remove(foundedDoctor);
                    databaseContext.SaveChanges();

                    Close();
                }
                else
                {
                    foundedDoctor.FirstName = firstNameTextBox.Text;
                    foundedDoctor.LastName = lastNameTextBox.Text;
                    if (maleRadioButton.Checked == true)
                    {
                        foundedDoctor.IsMan = true;
                    }
                    if (femaleRadioButton.Checked == true)
                    {
                        foundedDoctor.IsMan = false;
                    }
                    if (marridCheckBox.Checked == true)
                    {
                        foundedDoctor.IsMarried = true;
                    }
                    if (singleCheckBox.Checked == true)
                    {
                        foundedDoctor.IsMarried = false;
                    }
                    foundedDoctor.Age = ageTextBox.Text;
                    foundedDoctor.Expertise = expertiseTextBox.Text;
                    foundedDoctor.Address = addressTextBox.Text;
                    foundedDoctor.Phone = phoneTextBox.Text;
                    foundedDoctor.Mobile = mobileTextBox.Text;
                    foundedDoctor.PostalCode = postalCodeTextBox.Text;
                    foundedDoctor.Description = descriptionTextBox.Text;

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
            Hide();
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
