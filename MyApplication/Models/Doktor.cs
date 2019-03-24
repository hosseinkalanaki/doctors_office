namespace Models
{
    public class Doktor : Person
    {
        public Doktor() : base()
        {
            DoctorId = System.Guid.NewGuid();
        }

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        public string Expertise { get; set; }
        // **********

        // **********
        public System.Guid DoctorId { get; set; }
        // **********
    }
}
