using System.Linq;

namespace MyApplication
{
    public partial class NewDoctor : Infrastructure.BaseForm
    {
        public NewDoctor()
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
            expertiseTextBox.Text = string.Empty;
            rightToVisitTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
            phoneTextBox.Text = string.Empty;
            mobileTextBox.Text = string.Empty;
            postalCodeTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;

            firstNameTextBox.Focus();

        }

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            ResetForm();
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                bool hasAnyUser =
                    databaseContext.Doktor
                    .Any();
                // **************************************************
                Models.Doktor Doktors = new Models.Doktor
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Age = System.Convert.ToInt32(ageTextBox.Text),
                    DoctorId = doctorCodeTextBox.Text,


                };

                databaseContext.Users.Add(Doktors);

                databaseContext.SaveChanges();

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
