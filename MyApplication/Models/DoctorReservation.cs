namespace Models
{
    public class DoctorReservation : BaseEntity
    {
        public DoctorReservation()
        {

        }

        // **********
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        public string DateReservation { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]
        public string TimeReservation { get; set; }
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
