namespace Models
{
    public class Patients : Person
    {
        public Patients()
        {

        }

        public bool IsDelete { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = true)]

        public string Disease { get; set; }

        public string  DisplayInformation
        {
            get
            {
                string result = FirstName + " " + LastName + " [ Mobile Number :" + Mobile + " ] " + " [ Phone Number: " + Phone + "] ";

                return result;
            }
        }
        
    }
}
