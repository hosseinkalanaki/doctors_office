using System.Linq;

namespace MyApplication
{
    public partial class UpdatePatientProfileForm : Infrastructure.BaseForm
    {
        public UpdatePatientProfileForm()
        {
            InitializeComponent();
        }

        public Models.User Selectedpatient { get; set; }

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

        private void UpdatePatientProfileForm_Load(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;

            //show information user
            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                Models.Patients foundedPatient =
                    databaseContext.Patient
                    .Where(current => current.Id == Selectedpatient.Id)
                    .FirstOrDefault();

                if (foundedPatient == null)
                {
                    System.Windows.Forms.MessageBox.Show("There Is No Such A User Anymore!");

                    Close();
                }

                patientCodeTextBox.Text = Selectedpatient.Id;
                firstNameTextBox.Text = Selectedpatient.FirstName;
                lastNameTextBox.Text = Selectedpatient.LastName;
                if (foundedPatient.IsMan == true)
                {
                    maleRadioButton.Checked = true;
                    femaleRadioButton.Checked = false;
                }
                else
                {
                    maleRadioButton.Checked = false;
                    femaleRadioButton.Checked = true;
                }
                if (foundedPatient.IsMarried == true)
                {
                    marridCheckBox.Checked = true;
                    singleCheckBox.Checked = false;
                }
                else
                {
                    marridCheckBox.Checked = false;
                    singleCheckBox.Checked = true;
                }
                ageTextBox.Text = foundedPatient.Age;
                addressTextBox.Text = foundedPatient.Address;
                phoneTextBox.Text = foundedPatient.Phone;
                mobileTextBox.Text = foundedPatient.Mobile;
                postalCodeTextBox.Text = foundedPatient.PostalCode;
                descriptionTextBox.Text = foundedPatient.Description;
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

        private void registerButton_Click(object sender, System.EventArgs e)
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

                Models.Patients foundedPatient =
                    databaseContext.Patient
                    .Where(current => current.Id == patientCodeTextBox.Text)
                    .FirstOrDefault();

                if (foundedPatient == null)
                {
                    System.Windows.Forms.MessageBox.Show("There Is No Such A User Anymore!");

                    Close();
                }

                if (deleteCheckBox.Checked == true)
                {
                    databaseContext.Patient.Remove(foundedPatient);
                    databaseContext.SaveChanges();

                    Close();
                }
                else
                {
                    foundedPatient.FirstName = firstNameTextBox.Text;
                    foundedPatient.LastName = lastNameTextBox.Text;
                    if (maleRadioButton.Checked == true)
                    {
                        foundedPatient.IsMan = true;
                    }
                    if (femaleRadioButton.Checked == true)
                    {
                        foundedPatient.IsMan = false;
                    }
                    if (marridCheckBox.Checked == true)
                    {
                        foundedPatient.IsMarried = true;
                    }
                    if (singleCheckBox.Checked == true)
                    {
                        foundedPatient.IsMarried = false;
                    }
                    foundedPatient.Age = ageTextBox.Text;
                    foundedPatient.Address = addressTextBox.Text;
                    foundedPatient.Phone = phoneTextBox.Text;
                    foundedPatient.Mobile = mobileTextBox.Text;
                    foundedPatient.PostalCode = postalCodeTextBox.Text;
                    foundedPatient.Description = descriptionTextBox.Text;

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

        private void exitButton_Click_1(object sender, System.EventArgs e)
        {
            Close();
        }

        private void deleteCheckBox_CheckedChanged_1(object sender, System.EventArgs e)
        {
            if (deleteCheckBox.Checked == true)
            {
                System.Windows.Forms.MessageBox.Show("با فعال کردن این گزینه پس از سیو کردن صفحه این کاربر از سامانه حذف می شود.");
            }
        }

        private void resetButton_Click_1(object sender, System.EventArgs e)
        {
            ResetForm();
        }
    }
}
