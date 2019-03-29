﻿namespace Models
{
    public class Doctors : Person
    {
        public Doctors() : base()
        {
        }

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50)]

        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        public string Expertise { get; set; }

    }
}