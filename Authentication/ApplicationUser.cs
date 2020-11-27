using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace DentalApi.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public enum GenderType
        {
            Male,
            Female,
            Other
        }

        public enum IdentityType
        {
            DNI,
            Passport,
        }
        
        [Required(ErrorMessage = "El nombre es requerido")]
        public string FirstName { get; set;}

        [Required(ErrorMessage = "El apellido es requerido")]
        public string LastName { get; set;}

        public GenderType Gender { get; set;}

        [Column(TypeName="Date")]
        public DateTime BirthDate { get; set; }

        public IdentityType Identity { get; set;}

        public int IdentityNumber { get; set; }

        public int PhoneNumber1 { get; set;}

        public int PhoneNumber2 { get; set;}
    }

}
