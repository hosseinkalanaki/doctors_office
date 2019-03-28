using MyApplication;

namespace Infrastructure
{
	public static class Utility 
	{
		static Utility() 
		{
		}

		public static Models.User AuthenticatedUser { get; set; }

        // **************************************************

        private static MyApplication.MainForm mainForm;

        public static MyApplication.MainForm MainForm
        {
            get
            {
                if (mainForm == null)
                {
                    mainForm = 
                        new MyApplication.MainForm();
                }

                return mainForm;
            }            
        }

        // **************************************************

        private static MyApplication.LoginForm loginForm;

        public static MyApplication.LoginForm LoginForm
        {
            get
            {
                if (loginForm == null)
                {
                    loginForm = 
                        new MyApplication.LoginForm();
                }

                loginForm.ResetForm();

                return loginForm;
            }            
        }

        // **************************************************

        private static MyApplication.RegisterForm registerForm;

        public static MyApplication.RegisterForm RegisterForm
        {
            get
            {
                if (registerForm == null)
                {
                    registerForm = 
                        new MyApplication.RegisterForm();
                }

                registerForm.ResetForm();

                return registerForm;
            }            
        }

        // **************************************************

        public static PersianDate ConvertMiladiToShamsi(System.DateTime time)
        {
            System.Globalization.PersianCalendar
                persianCalendar = new System.Globalization.PersianCalendar();

            int year =
                persianCalendar.GetYear(time);

            int month =
                persianCalendar.GetMonth(time);

            int day =
                persianCalendar.GetDayOfMonth(time);

            PersianDate persianDate =
                new PersianDate(year: year, month: month, day: day);

            return persianDate;
        }

}
}
