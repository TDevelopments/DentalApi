using System.ComponentModel.DataAnnotations;

namespace DentalApi.Authentication
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Nombre de usuario requerido")]
        public string Username { get;  set;}

        [EmailAddress]
        [Required(ErrorMessage = "Email requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contraseña requerida")]
        public string Password { get; set;}
    }
}
