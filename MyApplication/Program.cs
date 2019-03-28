using System.Linq;

namespace MyApplication
{
	internal static class Program
	{
		static Program()
		{
		}

		[System.STAThread]
		internal static void Main()
		{
			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            // **************************************************

            // **************************************************
            // **************************************************
            // **************************************************

            #region createuserdatabase

            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                bool hasAnyUser =
                    databaseContext.Users
                    .Any();
                // **************************************************

                if (hasAnyUser == false)
                {
                    Models.User adminUser = new Models.User
                    {
                        IsAdmin = true,
                        IsActive = true,

                        Username = "Admin1",
                        Password = "123456789",
                        FirstName = "hossein",
                        LastName="kalanaki",
                    };

                    databaseContext.Users.Add(adminUser);

                    databaseContext.SaveChanges();
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

            #endregion /createuserdatabase

            // **************************************************
            // **************************************************
            // **************************************************

            // **************************************************
            //System.Windows.Forms.Application.Run(new StartupForm());

            //#region Runing Startup Form and then Disposing!
            //StartupForm startupForm = new StartupForm();

            //System.Windows.Forms.Application.Run(startupForm);

            //if (startupForm != null)
            //{
            //    if (startupForm.IsDisposed == false)
            //    {
            //        startupForm.Dispose();
            //    }

            //    startupForm = null;
            //}
            //#endregion /Runing Startup Form and then Disposing!

            // **************************************************

            #region Runing Login Form and then Disposing!
            LoginForm loginForm = new LoginForm();

            System.Windows.Forms.Application.Run(loginForm);

            if (loginForm != null)
            {
                if (loginForm.IsDisposed == false)
                {
                    loginForm.Dispose();
                }

                loginForm = null;
            }
            #endregion /Runing Login Form and then Disposing!

            // **************************************************

            System.Windows.Forms.Application.Run(Infrastructure.Utility.LoginForm);

        }
    }
}
