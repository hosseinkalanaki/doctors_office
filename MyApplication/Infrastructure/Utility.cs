using MyApplication;

namespace Infrastructure
{
	public static class Utility 
	{
		static Utility() 
		{
		}

		public static Models.User AuthenticatedUser { get; set; }

        public static string EndUserId { get; set; }

        public static string EndAttendanceId { get; set; }

        public static string EndPatientId { get; set; }

        public static Models.Doctors  SelectDoctor { get; set; }

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

        private static MyApplication.RegisterUserForm registerForm;

        public static MyApplication.RegisterUserForm RegisterForm
        {
            get
            {
                if (registerForm == null)
                {
                    registerForm = 
                        new MyApplication.RegisterUserForm();
                }

                registerForm.ResetForm();

                return registerForm;
            }            
        }

        // **************************************************

        // **************************************************

        private static MyApplication.RegisterDoctorForm registerDoctorForm;

        public static MyApplication.RegisterDoctorForm RegisterDoctorForm
        {
            get
            {
                if (registerDoctorForm == null)
                {
                    registerDoctorForm =
                        new MyApplication.RegisterDoctorForm();
                }

                registerDoctorForm.ResetForm();

                return registerDoctorForm;
            }
        }

        // **************************************************

        // **************************************************

        private static MyApplication.AttendanceForm attendance;

        public static MyApplication.AttendanceForm Attendance
        {
            get
            {
                if (attendance == null)
                {
                    attendance =
                        new MyApplication.AttendanceForm();
                }

                return attendance;
            }
        }

        // **************************************************

        // **************************************************

        private static MyApplication.AttendanceSearchForm attendanceSearch;

        public static MyApplication.AttendanceSearchForm AttendanceSearch
        {
            get
            {
                if (attendanceSearch == null)
                {
                    attendanceSearch =
                        new MyApplication.AttendanceSearchForm();
                }

                attendanceSearch.Search();

                return attendanceSearch;
            }
        }

        // **************************************************

        // **************************************************

        private static MyApplication.RegisterPatientForm registerPatientForm;

        public static MyApplication.RegisterPatientForm RegisterPatientForm
        {
            get
            {
                if (registerPatientForm == null)
                {
                    registerPatientForm =
                        new MyApplication.RegisterPatientForm();
                }

                registerPatientForm.ResetForm();

                return registerPatientForm;
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
