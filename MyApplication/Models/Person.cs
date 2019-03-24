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

        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        public string FirstName { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        public string LastName { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.StringLength
           (maximumLength: 3)]

        [System.ComponentModel.DataAnnotations.Required
           (AllowEmptyStrings = false)]

        public int Age  { get; set; }
        // **********

        // **********

    }
}
