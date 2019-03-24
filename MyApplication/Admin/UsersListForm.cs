using System.Linq;

namespace MyApplication
{
    public partial class UsersListForm : Infrastructure.BaseForm
    {
        public UsersListForm()
        {
            InitializeComponent();
        }

        private void ebutton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        private void searchButton_Click(object sender, System.EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            Models.DatabaseContext databaseContext = null;
        // search
            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                fullNameTextBox.Text =
                    fullNameTextBox.Text.Trim();

                while (fullNameTextBox.Text.Contains("  "))
                {
                    fullNameTextBox.Text =
                        fullNameTextBox.Text.Replace("  ", " ");
                }

                System.Collections.Generic.List<Models.User> users = null;

                if (fullNameTextBox.Text==string.Empty)
                {
                    users =
                        databaseContext.Users
                        .OrderBy(current => current.FullName)
                        .ToList();
                }
                else
                {
                    users =
                        databaseContext.Users
                        .Where(current => current.FullName.Contains(fullNameTextBox.Text))
                        .OrderBy(current => current.FullName)
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

            if (selectedUser!=null)
            {
                Admin.UpdateProfileForm updateProfile = new Admin.UpdateProfileForm
                {
                    SelectUser = selectedUser
                };

                updateProfile.ShowDialog();

                Search();
            }
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            if (usersListListBox.SelectedItems.Count==0)
            {
                System.Windows.Forms.MessageBox.Show("You Did Not Select Anu Users For Deleting!");

                return;
            }

            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                foreach (var selectedItem in usersListListBox.SelectedItems)
                {
                    Models.User selectUser = selectedItem as Models.User;

                    if (selectUser!=null)
                    {
                        Models.User foundeduser =
                            databaseContext.Users
                            .Where(current => current.Id == selectUser.Id)
                            .FirstOrDefault();

                        if (foundeduser!=null)
                        {
                            if (foundeduser.IsAdmin==false)
                            {
                                if (string.Compare(foundeduser.Username,
                                    Infrastructure.Utility.AuthenticatedUser.Username,ignoreCase:true)!=0)
                                {
                                    databaseContext.Users.Remove(foundeduser);

                                    databaseContext.SaveChanges();

                                    System.Windows.Forms.MessageBox.Show($"{foundeduser.FullName} Is Deleted");
                                }
                                else
                                {
                                    System.Windows.Forms.MessageBox.Show($"{foundeduser.FullName} Not Found in Database !");
                                }

                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show($"{foundeduser.FullName} User Is Admin And Can Not Deleted!");
                            }
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show($"{foundeduser.FullName} User Befor This Has Deleted!");
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("You Did Not Select Any Users For Deleting!");

                        return;
                    }

                    Search();
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
    }
}
