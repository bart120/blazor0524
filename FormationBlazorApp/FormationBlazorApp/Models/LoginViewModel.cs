using FormationBlazorApp.Validators;
using System.ComponentModel.DataAnnotations;

namespace FormationBlazorApp.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Login obligatoire")]
        [Email(ErrorMessage = "Format du mail incorrect")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Mot de passe obligatoire")]
        public string? Password { get; set; }
    }
}
