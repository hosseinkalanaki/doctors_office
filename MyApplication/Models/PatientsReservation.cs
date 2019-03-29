namespace Models
{
    public class PatientsReservation : BaseEntity
    {
        public PatientsReservation(): base()
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
            (maximumLength: 500)]

        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]
        public string Description { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 500)]

        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]
        public string Prescription { get; set; }
        // **********


        // **********
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Required
           (AllowEmptyStrings = false)]
        public string PatientsCode { get; set; }
        // **********
    }
}
