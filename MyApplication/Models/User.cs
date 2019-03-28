namespace Models
{
    public class User : BaseEntity
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

        // **********
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string FirstName { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string LastName { get; set; }
        // **********

        // **********
        public bool IsMan { get; set; }

        // **********

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string Age { get; set; }

        // **********
        public bool IsMarried { get; set; }

        // **********

        // **********

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 500)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string Address { get; set; }

        // **********

        // **********

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 11)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string Phone { get; set; }

        // **********

        // **********

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 11)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string Mobile { get; set; }

        // **********

        // **********

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 10)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string PostalCode { get; set; }

        // **********

        // **********
        public string Description { get; set; }
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
