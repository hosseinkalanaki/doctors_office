using System.Linq;

namespace MyApplication
{
    public partial class PatientsListForm : Infrastructure.BaseForm
    {
        public PatientsListForm()
        {
            InitializeComponent();
        }

        private void Search()
        {
            Models.DatabaseContext databaseContext = null;
            // search
            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                searchTextBox.Text =
                    searchTextBox.Text.Trim();

                while (searchTextBox.Text.Contains("  "))
                {
                    searchTextBox.Text =
                        searchTextBox.Text.Replace("  ", " ");
                }

                System.Collections.Generic.List<Models.Patients> patients = null;

                if (showInformationCheckBox.Checked == true)
                {
                    if (searchTextBox.Text == string.Empty)
                    {
                        patients =
                            databaseContext.Patient
                            .OrderBy(current => current.LastName)
                            .ToList();
                    }
                    else
                    {
                        patients =
                            databaseContext.Patient
                            .Where(current => current.FirstName.Contains(searchTextBox.Text))
                            .OrderBy(current => current.FirstName)
                            .ToList();
                    }
                }
                else
                {
                    if (searchTextBox.Text == string.Empty)
                    {
                        patients =
                            databaseContext.Patient
                            .Where(current => current.IsDelete.ToString().Contains("false"))
                            .OrderBy(current => current.FirstName)
                            .ToList();
                    }
                    else
                    {
                        patients =
                            databaseContext.Patient
                            .Where(current => current.FirstName.Contains(searchTextBox.Text))
                            .Where(current => current.IsDelete.ToString().Contains("false"))
                            .OrderBy(current => current.FirstName)
                            .ToList();
                    }
                }
                usersListListBox.ValueMember = "Id";

                usersListListBox.DisplayMember = "DisplayName";

                usersListListBox.DataSource = patients;
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

        private void usersListListBox_DoubleClick(object sender, System.EventArgs e)
        {
            Models.Patients selectedpatient =
                usersListListBox.SelectedItem as Models.Patients;

            if (selectedpatient != null)
            {
                UpdatePatientProfileForm updateProfile = new UpdatePatientProfileForm
                {
                    Selectedpatient = selectedpatient,
                };

                updateProfile.ShowDialog();

                Search();
            }
        }
        private void searchButton_Click(object sender, System.EventArgs e)
        {
            Search();
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            Hide();
        }
    }
}
