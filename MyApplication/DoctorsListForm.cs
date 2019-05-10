using System.Linq;

namespace MyApplication
{
    public partial class DoctorsListForm : Infrastructure.BaseForm
    {
        public DoctorsListForm()
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

                System.Collections.Generic.List<Models.Doctors> doctors = null;

                if (showInformationCheckBox.Checked == true)
                {
                    if (searchTextBox.Text == string.Empty)
                    {
                        doctors =
                            databaseContext.Doctor
                            .OrderBy(current => current.LastName)
                            .ToList();
                    }
                    else
                    {
                        doctors =
                            databaseContext.Doctor
                            .Where(current => current.FirstName.Contains(searchTextBox.Text))
                            .OrderBy(current => current.FirstName)
                            .ToList();
                    }
                }
                else
                {
                    if (searchTextBox.Text == string.Empty)
                    {
                        doctors =
                            databaseContext.Doctor
                            .Where(current => current.IsDelete.ToString().Contains("false"))
                            .OrderBy(current => current.FirstName)
                            .ToList();
                    }
                    else
                    {
                        doctors =
                            databaseContext.Doctor
                            .Where(current => current.FirstName.Contains(searchTextBox.Text))
                            .Where(current => current.IsDelete.ToString().Contains("false"))
                            .OrderBy(current => current.FirstName)
                            .ToList();
                    }
                }
                doctorListListBox.ValueMember = "Id";

                doctorListListBox.DisplayMember = "DisplayName";

                doctorListListBox.DataSource = doctors;
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

        private void doctorListListBox_DoubleClick(object sender, System.EventArgs e)
        {
            Models.Doctors selectedDoctor =
                doctorListListBox.SelectedItem as Models.Doctors;

            if (selectedDoctor != null)
            {
                UpdateDoctorsProfileForm updateProfile = new UpdateDoctorsProfileForm
                {
                    SelectedDoctor = selectedDoctor,
                };

                updateProfile.ShowDialog();

                Search();
            }
        }
        private void searchButton_Click_1(object sender, System.EventArgs e)
        {
            Search();
        }

        private void exitButton_Click_1(object sender, System.EventArgs e)
        {
            Hide();
        }



    }
}

