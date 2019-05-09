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
                        Id = "1",

                        IsAdmin = true,
                        IsActive = true,

                        Username = "hosseinkalanaki",
                        Password = "123456789",
                        FirstName = "hossein",
                        LastName = "kalanaki",
                    };

                    databaseContext.Users.Add(adminUser);

                    databaseContext.SaveChanges();
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    System.Windows.Forms.MessageBox.Show($"Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        System.Windows.Forms.MessageBox.Show($"- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName);
                    }
                }
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

            #region Comment code

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

            #endregion /Comment code

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
