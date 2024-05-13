using System.ComponentModel.DataAnnotations;

namespace FormationBlazorApp.Models
{
    public class LoginViewModel
    {
        [Required (ErrorMessage ="Login obligatoire")]
        [EmailAddress (ErrorMessage = "Ce n'est pas une adresse email")]
        public string? Email { get; set; }

        public string? Password { get; set; }
    }
}
