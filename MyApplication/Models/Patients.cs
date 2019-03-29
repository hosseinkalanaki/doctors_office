namespace Models
{
    public class Patients : Person
    {
        public Patients()
        {

        }

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        public string Disease { get; set; }
    }
}
