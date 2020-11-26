using System.ComponentModel.DataAnnotations;

namespace DentalApi.Authentication
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Nombre de usuario requerido")]
        public string Username { get; set;}

        [Required(ErrorMessage = "Contraseña requerida")]
        public string Password { get; set;}
    }
}
