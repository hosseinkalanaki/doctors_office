using System.Linq;

namespace MyApplication
{
    public partial class UsersListForm : Infrastructure.BaseForm
    {
        public UsersListForm()
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

                System.Collections.Generic.List<Models.User> users = null;

                if (searchTextBox.Text == string.Empty)
                {
                    users =
                        databaseContext.Users
                        .OrderBy(current => current.LastName)
                        .ToList();
                }
                else
                {
                    users =
                        databaseContext.Users
                        .Where(current => current.FirstName.Contains(searchTextBox.Text))
                        .OrderBy(current => current.FirstName)
                        .ToList();
                }

                usersListListBox.ValueMember = "Id";

                usersListListBox.DisplayMember = "DisplayName";

                usersListListBox.DataSource = users;
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
            Models.User selectedUser =
                usersListListBox.SelectedItem as Models.User;

            if (selectedUser != null)
            {
                Admin.UpdateAllUserProfileForm updateProfile = new Admin.UpdateAllUserProfileForm
                {
                    SelectUser = selectedUser
                };

                updateProfile.ShowDialog();

                Search();
            }
        }

        private void UsersListForm_Load(object sender, System.EventArgs e)
        {

        }
        private void searchButton_Click(object sender, System.EventArgs e)
        {
            Search();
        }

        private void usersListListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
