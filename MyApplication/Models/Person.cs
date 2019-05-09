namespace Models
{
    public class Person : BaseEntity
    {
        public Person() : base()
        {

        }

        // **********
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        public string FirstName { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        public string LastName { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.StringLength
           (maximumLength: 3)]

        public string Age { get; set; }
        // **********

        // **********
        public bool IsMan { get; set; }

        // **********

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
                string result = FirstName +" " + LastName;

                return result;
            }
        }
    }
}
