namespace Models
{
    public class DoctorsReservation : BaseEntity
    {
        public DoctorsReservation()
        {

        }

        // **********
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        public string WorkingHour { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]
        public string WorkingDate { get; set; }
        // **********


        // **********
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Required
           (AllowEmptyStrings = false)]
        public string DoctorId { get; set; }
        // **********
    }
}
