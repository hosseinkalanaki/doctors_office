namespace Models
{
    public class User : Person
    {
        public User() : base()
        {
        }

        // **********
        public bool IsActive { get; set; }
        // **********

        // **********
        public bool IsAdmin { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 20, MinimumLength = 6)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = true)]
        public string Username { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 40, MinimumLength = 8)]
        public string Password { get; set; }
        // **********

        public string DisplayName
        {
            get
            {
                string result = FirstName + LastName;

                if (IsActive)
                {
                    result += "[Enabled]";
                }

                else
                {
                    result += "[Disabled]";
                }

                if (IsAdmin)
                {
                    result += "[Admin]";
                }

                else
                {
                    result += "[User]";
                }

                return result;
            }
        }

    }
}
